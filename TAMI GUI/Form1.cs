using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using AForge.Video;
using MySql.Data.MySqlClient;


namespace TAMI_GUI
{
    
    public partial class Form1 : Form
    {
        Socket client = null;
        MJPEGStream stream;

        public Form1()
        {
            InitializeComponent();
        }

        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var bmp = new Bitmap(eventArgs.Frame, 640, 480);
            Camera_PictureBox.Image = bmp;
        }

        private void cameraThread()
        {
            Camera_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            stream = new MJPEGStream($"http://{IP_Text.Text}:8000/stream.mjpg");
            stream.NewFrame += new NewFrameEventHandler(Stream_NewFrame);
            stream.Start();
        }
        private void Connect_Button_Click(object sender, EventArgs e)
        {

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddr = null;
            Thread trd = new Thread(new ThreadStart(this.cameraThread));
            trd.IsBackground = true;

            try
            {
                     
                string strIPAddress = IP_Text.Text;
                string strPortInput = PORT_Text.Text;
                int nPortInput = 0;

                if (!IPAddress.TryParse(strIPAddress, out ipaddr))
                {
                  richTextBox1.Text=("Invalid server IP supplied.");
                    return;
                }
                if (!int.TryParse(strPortInput.Trim(), out nPortInput))
                {
                    richTextBox1.Text = ("Invalid port number supplied, return.");
                    return;
                }

                if (nPortInput <= 0 || nPortInput > 65535)
                {
                    richTextBox1.Text = ("Port number must be between 0 and 65535.");
                    return;
                }
               

                client.Connect(ipaddr, nPortInput);
                richTextBox1.Text="Connected to the server...";
                trd.Start();
                timer1.Start();


            }
            catch (Exception excp)
            {
                richTextBox1.Text=(excp.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            CommunicationData data = null; ;
            VFM.Text = (Vertical_Front_Motor.Value * 20).ToString();
            VBM.Text = (Vertical_Back_Motor.Value * 20).ToString();
            HLM.Text = (Horizontal_Left_Motor.Value * 20).ToString();
            HRM.Text = (Horizontal_Right_Motor.Value * 20).ToString();

            var waitUntil = BeginInvoke(new MethodInvoker(() =>
            {
                data = new CommunicationData
                {
                    Horizantal_Left_Motor = Horizontal_Left_Motor.Value * (rb1.Checked ? 1 : -1),
                    Horizantal_Right_Motor = Horizontal_Right_Motor.Value * (rb2.Checked ? 1 : -1),
                    Vertical_Back_Motor = Vertical_Back_Motor.Value * (rb3.Checked ? 1 : -1),
                    Vertical_Front_Motor = Vertical_Front_Motor.Value * (rb4.Checked ? 1 : -1),
                };


                var dataToSend = JsonConvert.SerializeObject(data);

                byte[] buffSend = Encoding.ASCII.GetBytes(dataToSend);
                client.Send(buffSend);
                byte[] buffRecv = new byte[1024];
                int numberOfReceivedBytes = 0;

                numberOfReceivedBytes = client.Receive(buffRecv);
                string receivedText = Encoding.ASCII.GetString(buffRecv, 0, numberOfReceivedBytes);

                try
                {
                    receivedText = receivedText.Replace("\"}", "}");
                    SensorData sensorData=JsonConvert.DeserializeObject<SensorData>(receivedText);
                    InternalPressure_Text.Text=(sensorData.Pressure).ToString();
                    InternalTemperature_Text.Text= (sensorData.Temperature).ToString();
                    if (sensorData.Humidity <= 550)
                    {
                        Humidity_Text.Text = ("Sızıntı Tespit Edildi !!!");
                        Humidity_Text.BackColor = Color.Red;
                        
                    }
                    else
                    {
                        Humidity_Text.Text = ("Güvenli");
                        Humidity_Text.BackColor = Color.Green;
                    }


                    Humidity_Text.Text = (sensorData.Humidity).ToString();
                    Yaw_Angle_Text.Text= (sensorData.Yaw).ToString();
                    Roll_Angle_Text.Text = (sensorData.Roll).ToString();
                    Pitch_Angle_Text.Text = (sensorData.Pitch).ToString();
                    ExternalPressure_Text.Text= (sensorData.ExternalPressure).ToString();
                    ExternalTemperature_Text.Text= (sensorData.ExternalTemperature).ToString();
                    Depth_Text.Text= (sensorData.Depth).ToString();
                    Pitch.Value = (sensorData.Pitch);
                    Yaw.Value = (sensorData.Yaw);
                    Roll.Value = (sensorData.Roll);

                }
                catch(Exception ex)
                {
                    richTextBox1.Text += $"{DateTime.Now.ToString("HH:mm:ss")} => {ex.Message}\n\n";
                }

                
            }));

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horizontal_Left_Motor.Value = 0;
            Horizontal_Right_Motor.Value = 0;
            Vertical_Back_Motor.Value = 0;
            Vertical_Front_Motor.Value = 0;
            
        }

        private void VerticalMidThrust_Click(object sender, EventArgs e)
        {
            Vertical_Back_Motor.Value = 2;
            Vertical_Front_Motor.Value = 2;
        }

        private void VerticalFullThrust_Click(object sender, EventArgs e)
        {
            Vertical_Back_Motor.Value = 5;
            Vertical_Front_Motor.Value = 5;
        }

        private void VerticalMidThrustR_Click(object sender, EventArgs e)
        {
            Vertical_Back_Motor.Value = -2;
            Vertical_Front_Motor.Value = -2;
        }

        private void VerticalFullThrustR_Click(object sender, EventArgs e)
        {
            Vertical_Back_Motor.Value = -5;
            Vertical_Front_Motor.Value = -5;
        }

        private void HorizontalMidThrust_Click(object sender, EventArgs e)
        {
            Horizontal_Left_Motor.Value = 2;
            Horizontal_Right_Motor.Value = 2;
        }

        private void HorizontalFullThrust_Click(object sender, EventArgs e)
        {
            Horizontal_Left_Motor.Value = 5;
            Horizontal_Right_Motor.Value = 5;
        }

        private void HorizontalMidThrustR_Click(object sender, EventArgs e)
        {
            Horizontal_Left_Motor.Value = -2;
            Horizontal_Right_Motor.Value = -2;
        }

        private void HorizontalFullThrustR_Click(object sender, EventArgs e)
        {
            Horizontal_Left_Motor.Value = -5;
            Horizontal_Right_Motor.Value = -5;
        }


    }
}
