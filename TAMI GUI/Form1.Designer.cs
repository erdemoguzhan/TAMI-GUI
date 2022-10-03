
namespace TAMI_GUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange4 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange5 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange6 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange7 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange8 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange9 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.InternalPressure = new System.Windows.Forms.Label();
            this.InternalTemperature = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.InternalPressure_Text = new System.Windows.Forms.TextBox();
            this.InternalTemperature_Text = new System.Windows.Forms.TextBox();
            this.Humidity_Text = new System.Windows.Forms.TextBox();
            this.Yaw_Angle = new System.Windows.Forms.Label();
            this.Roll_Angle = new System.Windows.Forms.Label();
            this.Pitch_Angle = new System.Windows.Forms.Label();
            this.Yaw_Angle_Text = new System.Windows.Forms.TextBox();
            this.Roll_Angle_Text = new System.Windows.Forms.TextBox();
            this.Pitch_Angle_Text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Depth_Text = new System.Windows.Forms.TextBox();
            this.ExternalTemperature_Text = new System.Windows.Forms.TextBox();
            this.ExternalPressure_Text = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.Label();
            this.ExternalTemperature = new System.Windows.Forms.Label();
            this.ExternalPressure = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Horizontal_Left_Motor = new System.Windows.Forms.TrackBar();
            this.Horizontal_Right_Motor = new System.Windows.Forms.TrackBar();
            this.Vertical_Back_Motor = new System.Windows.Forms.TrackBar();
            this.Vertical_Front_Motor = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IP_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.PORT_Text = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.HorizontalFullThrustR = new System.Windows.Forms.Button();
            this.HorizontalFullThrust = new System.Windows.Forms.Button();
            this.VerticalFullThrustR = new System.Windows.Forms.Button();
            this.VerticalFullThrust = new System.Windows.Forms.Button();
            this.HorizontalMidThrust = new System.Windows.Forms.Button();
            this.HorizontalMidThrustR = new System.Windows.Forms.Button();
            this.VerticalMidThrustR = new System.Windows.Forms.Button();
            this.VerticalMidThrust = new System.Windows.Forms.Button();
            this.VBM1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.VBM = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.VFM1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.VFM = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.HLM1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.HLM = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.HRM1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.HRM = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.button1 = new System.Windows.Forms.Button();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.Roll = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.Yaw = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge3 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.Pitch = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.Camera_PictureBox = new System.Windows.Forms.PictureBox();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal_Left_Motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal_Right_Motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_Back_Motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_Front_Motor)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VFM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HLM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camera_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // InternalPressure
            // 
            this.InternalPressure.AutoSize = true;
            this.InternalPressure.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InternalPressure.Location = new System.Drawing.Point(9, 31);
            this.InternalPressure.Name = "InternalPressure";
            this.InternalPressure.Size = new System.Drawing.Size(55, 21);
            this.InternalPressure.TabIndex = 0;
            this.InternalPressure.Text = "Basınç";
            // 
            // InternalTemperature
            // 
            this.InternalTemperature.AutoSize = true;
            this.InternalTemperature.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InternalTemperature.Location = new System.Drawing.Point(7, 69);
            this.InternalTemperature.Name = "InternalTemperature";
            this.InternalTemperature.Size = new System.Drawing.Size(61, 21);
            this.InternalTemperature.TabIndex = 1;
            this.InternalTemperature.Text = "Sıcaklık";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Humidity.Location = new System.Drawing.Point(9, 110);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(52, 21);
            this.Humidity.TabIndex = 2;
            this.Humidity.Text = "Sızıntı";
            // 
            // InternalPressure_Text
            // 
            this.InternalPressure_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalPressure_Text.Location = new System.Drawing.Point(101, 25);
            this.InternalPressure_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InternalPressure_Text.Name = "InternalPressure_Text";
            this.InternalPressure_Text.Size = new System.Drawing.Size(123, 32);
            this.InternalPressure_Text.TabIndex = 3;
            this.InternalPressure_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InternalTemperature_Text
            // 
            this.InternalTemperature_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InternalTemperature_Text.Location = new System.Drawing.Point(101, 63);
            this.InternalTemperature_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InternalTemperature_Text.Name = "InternalTemperature_Text";
            this.InternalTemperature_Text.Size = new System.Drawing.Size(123, 32);
            this.InternalTemperature_Text.TabIndex = 4;
            this.InternalTemperature_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Humidity_Text
            // 
            this.Humidity_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Humidity_Text.Location = new System.Drawing.Point(101, 103);
            this.Humidity_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Humidity_Text.Name = "Humidity_Text";
            this.Humidity_Text.Size = new System.Drawing.Size(123, 32);
            this.Humidity_Text.TabIndex = 5;
            this.Humidity_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // Yaw_Angle
            // 
            this.Yaw_Angle.AutoSize = true;
            this.Yaw_Angle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yaw_Angle.Location = new System.Drawing.Point(5, 30);
            this.Yaw_Angle.Name = "Yaw_Angle";
            this.Yaw_Angle.Size = new System.Drawing.Size(93, 21);
            this.Yaw_Angle.TabIndex = 6;
            this.Yaw_Angle.Text = "Sapma Açısı";
            // 
            // Roll_Angle
            // 
            this.Roll_Angle.AutoSize = true;
            this.Roll_Angle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Roll_Angle.Location = new System.Drawing.Point(5, 69);
            this.Roll_Angle.Name = "Roll_Angle";
            this.Roll_Angle.Size = new System.Drawing.Size(83, 21);
            this.Roll_Angle.TabIndex = 7;
            this.Roll_Angle.Text = "Yalpa Açısı";
            // 
            // Pitch_Angle
            // 
            this.Pitch_Angle.AutoSize = true;
            this.Pitch_Angle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pitch_Angle.Location = new System.Drawing.Point(5, 108);
            this.Pitch_Angle.Name = "Pitch_Angle";
            this.Pitch_Angle.Size = new System.Drawing.Size(122, 21);
            this.Pitch_Angle.TabIndex = 8;
            this.Pitch_Angle.Text = "Yunuslama Açısı";
            // 
            // Yaw_Angle_Text
            // 
            this.Yaw_Angle_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yaw_Angle_Text.Location = new System.Drawing.Point(156, 23);
            this.Yaw_Angle_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yaw_Angle_Text.Name = "Yaw_Angle_Text";
            this.Yaw_Angle_Text.Size = new System.Drawing.Size(123, 32);
            this.Yaw_Angle_Text.TabIndex = 9;
            this.Yaw_Angle_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Roll_Angle_Text
            // 
            this.Roll_Angle_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Roll_Angle_Text.Location = new System.Drawing.Point(156, 63);
            this.Roll_Angle_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Roll_Angle_Text.Name = "Roll_Angle_Text";
            this.Roll_Angle_Text.Size = new System.Drawing.Size(123, 32);
            this.Roll_Angle_Text.TabIndex = 10;
            this.Roll_Angle_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pitch_Angle_Text
            // 
            this.Pitch_Angle_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pitch_Angle_Text.Location = new System.Drawing.Point(156, 102);
            this.Pitch_Angle_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pitch_Angle_Text.Name = "Pitch_Angle_Text";
            this.Pitch_Angle_Text.Size = new System.Drawing.Size(123, 32);
            this.Pitch_Angle_Text.TabIndex = 11;
            this.Pitch_Angle_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.InternalPressure);
            this.groupBox1.Controls.Add(this.InternalTemperature);
            this.groupBox1.Controls.Add(this.Humidity);
            this.groupBox1.Controls.Add(this.InternalPressure_Text);
            this.groupBox1.Controls.Add(this.InternalTemperature_Text);
            this.groupBox1.Controls.Add(this.Humidity_Text);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(319, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basınçlı Kap";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.Depth_Text);
            this.groupBox2.Controls.Add(this.ExternalTemperature_Text);
            this.groupBox2.Controls.Add(this.ExternalPressure_Text);
            this.groupBox2.Controls.Add(this.Depth);
            this.groupBox2.Controls.Add(this.ExternalTemperature);
            this.groupBox2.Controls.Add(this.ExternalPressure);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(319, 140);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensörler";
            // 
            // Depth_Text
            // 
            this.Depth_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Depth_Text.Location = new System.Drawing.Point(101, 100);
            this.Depth_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Depth_Text.Name = "Depth_Text";
            this.Depth_Text.Size = new System.Drawing.Size(123, 32);
            this.Depth_Text.TabIndex = 9;
            this.Depth_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExternalTemperature_Text
            // 
            this.ExternalTemperature_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExternalTemperature_Text.Location = new System.Drawing.Point(101, 60);
            this.ExternalTemperature_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExternalTemperature_Text.Name = "ExternalTemperature_Text";
            this.ExternalTemperature_Text.Size = new System.Drawing.Size(123, 32);
            this.ExternalTemperature_Text.TabIndex = 8;
            this.ExternalTemperature_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExternalPressure_Text
            // 
            this.ExternalPressure_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExternalPressure_Text.Location = new System.Drawing.Point(101, 22);
            this.ExternalPressure_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExternalPressure_Text.Name = "ExternalPressure_Text";
            this.ExternalPressure_Text.Size = new System.Drawing.Size(123, 32);
            this.ExternalPressure_Text.TabIndex = 6;
            this.ExternalPressure_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Depth
            // 
            this.Depth.AutoSize = true;
            this.Depth.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Depth.Location = new System.Drawing.Point(11, 106);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(65, 21);
            this.Depth.TabIndex = 7;
            this.Depth.Text = "Derinlik";
            // 
            // ExternalTemperature
            // 
            this.ExternalTemperature.AutoSize = true;
            this.ExternalTemperature.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExternalTemperature.Location = new System.Drawing.Point(8, 66);
            this.ExternalTemperature.Name = "ExternalTemperature";
            this.ExternalTemperature.Size = new System.Drawing.Size(61, 21);
            this.ExternalTemperature.TabIndex = 6;
            this.ExternalTemperature.Text = "Sıcaklık";
            // 
            // ExternalPressure
            // 
            this.ExternalPressure.AutoSize = true;
            this.ExternalPressure.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExternalPressure.Location = new System.Drawing.Point(11, 28);
            this.ExternalPressure.Name = "ExternalPressure";
            this.ExternalPressure.Size = new System.Drawing.Size(55, 21);
            this.ExternalPressure.TabIndex = 6;
            this.ExternalPressure.Text = "Basınç";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.Yaw_Angle);
            this.groupBox3.Controls.Add(this.Roll_Angle);
            this.groupBox3.Controls.Add(this.Pitch_Angle);
            this.groupBox3.Controls.Add(this.Pitch_Angle_Text);
            this.groupBox3.Controls.Add(this.Yaw_Angle_Text);
            this.groupBox3.Controls.Add(this.Roll_Angle_Text);
            this.groupBox3.Location = new System.Drawing.Point(11, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(319, 140);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oryantasyon";
            // 
            // Horizontal_Left_Motor
            // 
            this.Horizontal_Left_Motor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Horizontal_Left_Motor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Horizontal_Left_Motor.Location = new System.Drawing.Point(199, 21);
            this.Horizontal_Left_Motor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Horizontal_Left_Motor.Maximum = 5;
            this.Horizontal_Left_Motor.Minimum = -5;
            this.Horizontal_Left_Motor.Name = "Horizontal_Left_Motor";
            this.Horizontal_Left_Motor.Size = new System.Drawing.Size(275, 56);
            this.Horizontal_Left_Motor.TabIndex = 16;
            // 
            // Horizontal_Right_Motor
            // 
            this.Horizontal_Right_Motor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Horizontal_Right_Motor.Location = new System.Drawing.Point(199, 269);
            this.Horizontal_Right_Motor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Horizontal_Right_Motor.Maximum = 5;
            this.Horizontal_Right_Motor.Minimum = -5;
            this.Horizontal_Right_Motor.Name = "Horizontal_Right_Motor";
            this.Horizontal_Right_Motor.Size = new System.Drawing.Size(275, 56);
            this.Horizontal_Right_Motor.TabIndex = 17;
            // 
            // Vertical_Back_Motor
            // 
            this.Vertical_Back_Motor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vertical_Back_Motor.Location = new System.Drawing.Point(104, 54);
            this.Vertical_Back_Motor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vertical_Back_Motor.Maximum = 5;
            this.Vertical_Back_Motor.Minimum = -5;
            this.Vertical_Back_Motor.Name = "Vertical_Back_Motor";
            this.Vertical_Back_Motor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Vertical_Back_Motor.Size = new System.Drawing.Size(56, 254);
            this.Vertical_Back_Motor.TabIndex = 18;
            // 
            // Vertical_Front_Motor
            // 
            this.Vertical_Front_Motor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vertical_Front_Motor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Vertical_Front_Motor.Location = new System.Drawing.Point(511, 54);
            this.Vertical_Front_Motor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vertical_Front_Motor.Maximum = 5;
            this.Vertical_Front_Motor.Minimum = -5;
            this.Vertical_Front_Motor.Name = "Vertical_Front_Motor";
            this.Vertical_Front_Motor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Vertical_Front_Motor.Size = new System.Drawing.Size(56, 254);
            this.Vertical_Front_Motor.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yatay Sol M.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(383, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yatay Sağ M.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dikey Arka M.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(549, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dikey Ön M.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "IP Adresi";
            // 
            // IP_Text
            // 
            this.IP_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IP_Text.Location = new System.Drawing.Point(178, 26);
            this.IP_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IP_Text.Name = "IP_Text";
            this.IP_Text.Size = new System.Drawing.Size(123, 32);
            this.IP_Text.TabIndex = 12;
            this.IP_Text.Text = "192.168.0.10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Port Numarası";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Connect_Button.Location = new System.Drawing.Point(29, 115);
            this.Connect_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(98, 34);
            this.Connect_Button.TabIndex = 24;
            this.Connect_Button.Text = "Bağlan";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // PORT_Text
            // 
            this.PORT_Text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PORT_Text.Location = new System.Drawing.Point(178, 62);
            this.PORT_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PORT_Text.Name = "PORT_Text";
            this.PORT_Text.Size = new System.Drawing.Size(123, 32);
            this.PORT_Text.TabIndex = 25;
            this.PORT_Text.Text = "23000";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox4.Controls.Add(this.Disconnect_Button);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.PORT_Text);
            this.groupBox4.Controls.Add(this.IP_Text);
            this.groupBox4.Controls.Add(this.Connect_Button);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(11, 446);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(318, 166);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Disconnect_Button.Location = new System.Drawing.Point(133, 115);
            this.Disconnect_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(168, 34);
            this.Disconnect_Button.TabIndex = 26;
            this.Disconnect_Button.Text = "Bağlantıyı Kes";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(6, 968);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(949, 121);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.HorizontalFullThrustR);
            this.groupBox5.Controls.Add(this.HorizontalFullThrust);
            this.groupBox5.Controls.Add(this.VerticalFullThrustR);
            this.groupBox5.Controls.Add(this.VerticalFullThrust);
            this.groupBox5.Controls.Add(this.HorizontalMidThrust);
            this.groupBox5.Controls.Add(this.HorizontalMidThrustR);
            this.groupBox5.Controls.Add(this.VerticalMidThrustR);
            this.groupBox5.Controls.Add(this.VerticalMidThrust);
            this.groupBox5.Controls.Add(this.VBM1);
            this.groupBox5.Controls.Add(this.VFM1);
            this.groupBox5.Controls.Add(this.HLM1);
            this.groupBox5.Controls.Add(this.HRM1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.Horizontal_Left_Motor);
            this.groupBox5.Controls.Add(this.Horizontal_Right_Motor);
            this.groupBox5.Controls.Add(this.Vertical_Back_Motor);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.Vertical_Front_Motor);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(337, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(700, 597);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor Güçleri";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton7);
            this.panel4.Controls.Add(this.rb4);
            this.panel4.Location = new System.Drawing.Point(529, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 48);
            this.panel4.TabIndex = 42;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(66, 12);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(59, 20);
            this.radioButton7.TabIndex = 41;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Tersi";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(3, 3);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(59, 36);
            this.rb4.TabIndex = 41;
            this.rb4.Text = "Saat\r\nYönü";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.rb3);
            this.panel3.Location = new System.Drawing.Point(22, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 48);
            this.panel3.TabIndex = 42;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(66, 12);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 20);
            this.radioButton5.TabIndex = 41;
            this.radioButton5.Text = "Tersi";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Checked = true;
            this.rb3.Location = new System.Drawing.Point(3, 3);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(59, 36);
            this.rb3.TabIndex = 41;
            this.rb3.TabStop = true;
            this.rb3.Text = "Saat \r\nYönü";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.rb2);
            this.panel2.Location = new System.Drawing.Point(362, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 48);
            this.panel2.TabIndex = 42;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(66, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 20);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.Text = "Tersi";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Location = new System.Drawing.Point(3, 4);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(59, 36);
            this.rb2.TabIndex = 41;
            this.rb2.TabStop = true;
            this.rb2.Text = "Saat\r\nYönü";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Location = new System.Drawing.Point(187, 428);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(130, 48);
            this.panel1.TabIndex = 42;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 20);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tersi";
            this.radioButton2.UseVisualStyleBackColor = true;
           
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(3, 3);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(59, 36);
            this.rb1.TabIndex = 41;
            this.rb1.Text = "Saat \r\nYönü";
            this.rb1.UseVisualStyleBackColor = true;
           
            // 
            // HorizontalFullThrustR
            // 
            this.HorizontalFullThrustR.BackColor = System.Drawing.Color.Blue;
            this.HorizontalFullThrustR.Location = new System.Drawing.Point(542, 539);
            this.HorizontalFullThrustR.Name = "HorizontalFullThrustR";
            this.HorizontalFullThrustR.Size = new System.Drawing.Size(132, 53);
            this.HorizontalFullThrustR.TabIndex = 40;
            this.HorizontalFullThrustR.Text = "Yatay Max İtki (Ters)";
            this.HorizontalFullThrustR.UseVisualStyleBackColor = false;
            this.HorizontalFullThrustR.Click += new System.EventHandler(this.HorizontalFullThrustR_Click);
            // 
            // HorizontalFullThrust
            // 
            this.HorizontalFullThrust.BackColor = System.Drawing.Color.Green;
            this.HorizontalFullThrust.Location = new System.Drawing.Point(404, 538);
            this.HorizontalFullThrust.Name = "HorizontalFullThrust";
            this.HorizontalFullThrust.Size = new System.Drawing.Size(132, 54);
            this.HorizontalFullThrust.TabIndex = 39;
            this.HorizontalFullThrust.Text = "Yatay Max İtki";
            this.HorizontalFullThrust.UseVisualStyleBackColor = false;
            this.HorizontalFullThrust.Click += new System.EventHandler(this.HorizontalFullThrust_Click);
            // 
            // VerticalFullThrustR
            // 
            this.VerticalFullThrustR.BackColor = System.Drawing.Color.Blue;
            this.VerticalFullThrustR.Location = new System.Drawing.Point(148, 539);
            this.VerticalFullThrustR.Name = "VerticalFullThrustR";
            this.VerticalFullThrustR.Size = new System.Drawing.Size(132, 54);
            this.VerticalFullThrustR.TabIndex = 38;
            this.VerticalFullThrustR.Text = "Dikey Max İtki (Ters)";
            this.VerticalFullThrustR.UseVisualStyleBackColor = false;
            this.VerticalFullThrustR.Click += new System.EventHandler(this.VerticalFullThrustR_Click);
            // 
            // VerticalFullThrust
            // 
            this.VerticalFullThrust.BackColor = System.Drawing.Color.Green;
            this.VerticalFullThrust.Location = new System.Drawing.Point(10, 540);
            this.VerticalFullThrust.Name = "VerticalFullThrust";
            this.VerticalFullThrust.Size = new System.Drawing.Size(132, 53);
            this.VerticalFullThrust.TabIndex = 37;
            this.VerticalFullThrust.Text = "Dikey Max İrki";
            this.VerticalFullThrust.UseVisualStyleBackColor = false;
            this.VerticalFullThrust.Click += new System.EventHandler(this.VerticalFullThrust_Click);
            // 
            // HorizontalMidThrust
            // 
            this.HorizontalMidThrust.BackColor = System.Drawing.Color.Green;
            this.HorizontalMidThrust.Location = new System.Drawing.Point(404, 481);
            this.HorizontalMidThrust.Name = "HorizontalMidThrust";
            this.HorizontalMidThrust.Size = new System.Drawing.Size(132, 54);
            this.HorizontalMidThrust.TabIndex = 36;
            this.HorizontalMidThrust.Text = "Yatay Nominal İtki";
            this.HorizontalMidThrust.UseVisualStyleBackColor = false;
            this.HorizontalMidThrust.Click += new System.EventHandler(this.HorizontalMidThrust_Click);
            // 
            // HorizontalMidThrustR
            // 
            this.HorizontalMidThrustR.BackColor = System.Drawing.Color.Blue;
            this.HorizontalMidThrustR.Location = new System.Drawing.Point(542, 481);
            this.HorizontalMidThrustR.Name = "HorizontalMidThrustR";
            this.HorizontalMidThrustR.Size = new System.Drawing.Size(132, 53);
            this.HorizontalMidThrustR.TabIndex = 35;
            this.HorizontalMidThrustR.Text = "Yatay Nominal İtki (Ters)";
            this.HorizontalMidThrustR.UseVisualStyleBackColor = false;
            this.HorizontalMidThrustR.Click += new System.EventHandler(this.HorizontalMidThrustR_Click);
            // 
            // VerticalMidThrustR
            // 
            this.VerticalMidThrustR.BackColor = System.Drawing.Color.Blue;
            this.VerticalMidThrustR.Location = new System.Drawing.Point(148, 481);
            this.VerticalMidThrustR.Name = "VerticalMidThrustR";
            this.VerticalMidThrustR.Size = new System.Drawing.Size(132, 54);
            this.VerticalMidThrustR.TabIndex = 34;
            this.VerticalMidThrustR.Text = "Dikey Nominal İtki (Ters)";
            this.VerticalMidThrustR.UseVisualStyleBackColor = false;
            this.VerticalMidThrustR.Click += new System.EventHandler(this.VerticalMidThrustR_Click);
            // 
            // VerticalMidThrust
            // 
            this.VerticalMidThrust.BackColor = System.Drawing.Color.Green;
            this.VerticalMidThrust.Location = new System.Drawing.Point(10, 481);
            this.VerticalMidThrust.Name = "VerticalMidThrust";
            this.VerticalMidThrust.Size = new System.Drawing.Size(132, 53);
            this.VerticalMidThrust.TabIndex = 33;
            this.VerticalMidThrust.Text = "Dikey Nominal İtki";
            this.VerticalMidThrust.UseVisualStyleBackColor = false;
            this.VerticalMidThrust.Click += new System.EventHandler(this.VerticalMidThrust_Click);
            // 
            // VBM1
            // 
            this.VBM1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.VBM});
            this.VBM1.Location = new System.Drawing.Point(36, 366);
            this.VBM1.Name = "VBM1";
            this.VBM1.Size = new System.Drawing.Size(106, 56);
            this.VBM1.TabIndex = 32;
            // 
            // VBM
            // 
            this.VBM.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0A151A");
            this.VBM.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#289FB8");
            this.VBM.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.VBM.Bounds = new System.Drawing.Rectangle(6, 6, 94, 44);
            this.VBM.DigitCount = 5;
            this.VBM.Name = "VBM";
            this.VBM.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.AcceptOrder = -1000;
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style21;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // VFM1
            // 
            this.VFM1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.VFM});
            this.VFM1.Location = new System.Drawing.Point(542, 366);
            this.VFM1.Name = "VFM1";
            this.VFM1.Size = new System.Drawing.Size(106, 56);
            this.VFM1.TabIndex = 32;
            // 
            // VFM
            // 
            this.VFM.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0A151A");
            this.VFM.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#289FB8");
            this.VFM.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent4});
            this.VFM.Bounds = new System.Drawing.Rectangle(6, 6, 94, 44);
            this.VFM.DigitCount = 5;
            this.VFM.Name = "VFM";
            this.VFM.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            // 
            // digitalBackgroundLayerComponent4
            // 
            this.digitalBackgroundLayerComponent4.AcceptOrder = -1000;
            this.digitalBackgroundLayerComponent4.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent4.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style21;
            this.digitalBackgroundLayerComponent4.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // HLM1
            // 
            this.HLM1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.HLM});
            this.HLM1.Location = new System.Drawing.Point(199, 366);
            this.HLM1.Name = "HLM1";
            this.HLM1.Size = new System.Drawing.Size(106, 56);
            this.HLM1.TabIndex = 31;
            // 
            // HLM
            // 
            this.HLM.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0A151A");
            this.HLM.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#289FB8");
            this.HLM.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent2});
            this.HLM.Bounds = new System.Drawing.Rectangle(6, 6, 94, 44);
            this.HLM.DigitCount = 5;
            this.HLM.Name = "HLM";
            this.HLM.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.AcceptOrder = -1000;
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style21;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // HRM1
            // 
            this.HRM1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.HRM});
            this.HRM1.Location = new System.Drawing.Point(377, 365);
            this.HRM1.Name = "HRM1";
            this.HRM1.Size = new System.Drawing.Size(106, 56);
            this.HRM1.TabIndex = 31;
            // 
            // HRM
            // 
            this.HRM.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0A151A");
            this.HRM.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#289FB8");
            this.HRM.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent3});
            this.HRM.Bounds = new System.Drawing.Rectangle(6, 6, 94, 44);
            this.HRM.DigitCount = 5;
            this.HRM.Name = "HRM";
            this.HRM.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            // 
            // digitalBackgroundLayerComponent3
            // 
            this.digitalBackgroundLayerComponent3.AcceptOrder = -1000;
            this.digitalBackgroundLayerComponent3.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style21;
            this.digitalBackgroundLayerComponent3.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(286, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 29;
            this.button1.Text = "Motor Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl2.Location = new System.Drawing.Point(348, 21);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(308, 258);
            this.gaugeControl2.TabIndex = 31;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent2});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 296, 246);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent2});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.Roll});
            this.circularGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent2});
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.AcceptOrder = -1000;
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.Roll;
            this.arcScaleBackgroundLayerComponent2.Name = "bg";
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style25;
            this.arcScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // Roll
            // 
            this.Roll.AcceptOrder = 0;
            this.Roll.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Roll.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Roll.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Roll.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Roll.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Roll.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Roll.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.Roll.EndAngle = 60F;
            this.Roll.MajorTickCount = 20;
            this.Roll.MajorTickmark.FormatString = "{0:F0}";
            this.Roll.MajorTickmark.ShapeOffset = -6F;
            this.Roll.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_1;
            this.Roll.MajorTickmark.TextOffset = -20F;
            this.Roll.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.Roll.MaxValue = 90F;
            this.Roll.MinorTickCount = 4;
            this.Roll.MinorTickmark.ShapeOffset = -2F;
            this.Roll.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_2;
            this.Roll.MinValue = -90F;
            this.Roll.Name = "scale1";
            this.Roll.RadiusX = 95F;
            this.Roll.RadiusY = 95F;
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange1.EndThickness = 2F;
            arcScaleRange1.EndValue = 33F;
            arcScaleRange1.Name = "Range0";
            arcScaleRange1.ShapeOffset = 11.5F;
            arcScaleRange1.StartThickness = 2F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFDA80");
            arcScaleRange2.EndThickness = 2F;
            arcScaleRange2.EndValue = 66F;
            arcScaleRange2.Name = "Range1";
            arcScaleRange2.ShapeOffset = 11.5F;
            arcScaleRange2.StartThickness = 2F;
            arcScaleRange2.StartValue = 33F;
            arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E99D9D");
            arcScaleRange3.EndThickness = 2F;
            arcScaleRange3.EndValue = 100F;
            arcScaleRange3.Name = "Range2";
            arcScaleRange3.ShapeOffset = 11.5F;
            arcScaleRange3.StartThickness = 2F;
            arcScaleRange3.StartValue = 66F;
            this.Roll.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3});
            this.Roll.StartAngle = -240F;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.AcceptOrder = 50;
            this.arcScaleNeedleComponent2.ArcScale = this.Roll;
            this.arcScaleNeedleComponent2.EndOffset = -8F;
            this.arcScaleNeedleComponent2.Name = "needle";
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style3;
            this.arcScaleNeedleComponent2.StartOffset = -21F;
            this.arcScaleNeedleComponent2.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent2
            // 
            this.arcScaleSpindleCapComponent2.AcceptOrder = 100;
            this.arcScaleSpindleCapComponent2.ArcScale = this.Roll;
            this.arcScaleSpindleCapComponent2.Name = "circularGauge11_SpindleCap1";
            this.arcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style25;
            this.arcScaleSpindleCapComponent2.Size = new System.Drawing.SizeF(15F, 15F);
            this.arcScaleSpindleCapComponent2.ZOrder = -100;
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.AutoLayout = false;
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge2});
            this.gaugeControl3.Location = new System.Drawing.Point(703, 21);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(309, 258);
            this.gaugeControl3.TabIndex = 31;
            // 
            // circularGauge2
            // 
            this.circularGauge2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent3});
            this.circularGauge2.Bounds = new System.Drawing.Rectangle(7, 7, 295, 246);
            this.circularGauge2.Name = "circularGauge2";
            this.circularGauge2.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent3});
            this.circularGauge2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.Yaw});
            this.circularGauge2.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent3});
            // 
            // arcScaleBackgroundLayerComponent3
            // 
            this.arcScaleBackgroundLayerComponent3.AcceptOrder = -1000;
            this.arcScaleBackgroundLayerComponent3.ArcScale = this.Yaw;
            this.arcScaleBackgroundLayerComponent3.Name = "bg";
            this.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style25;
            this.arcScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // Yaw
            // 
            this.Yaw.AcceptOrder = 0;
            this.Yaw.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Yaw.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Yaw.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Yaw.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Yaw.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Yaw.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Yaw.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.Yaw.EndAngle = 60F;
            this.Yaw.MajorTickCount = 20;
            this.Yaw.MajorTickmark.FormatString = "{0:F0}";
            this.Yaw.MajorTickmark.ShapeOffset = -6F;
            this.Yaw.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_1;
            this.Yaw.MajorTickmark.TextOffset = -20F;
            this.Yaw.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.Yaw.MaxValue = 90F;
            this.Yaw.MinorTickCount = 4;
            this.Yaw.MinorTickmark.ShapeOffset = -2F;
            this.Yaw.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_2;
            this.Yaw.MinValue = -90F;
            this.Yaw.Name = "scale1";
            this.Yaw.RadiusX = 95F;
            this.Yaw.RadiusY = 95F;
            arcScaleRange4.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange4.EndThickness = 2F;
            arcScaleRange4.EndValue = 33F;
            arcScaleRange4.Name = "Range0";
            arcScaleRange4.ShapeOffset = 11.5F;
            arcScaleRange4.StartThickness = 2F;
            arcScaleRange5.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFDA80");
            arcScaleRange5.EndThickness = 2F;
            arcScaleRange5.EndValue = 66F;
            arcScaleRange5.Name = "Range1";
            arcScaleRange5.ShapeOffset = 11.5F;
            arcScaleRange5.StartThickness = 2F;
            arcScaleRange5.StartValue = 33F;
            arcScaleRange6.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E99D9D");
            arcScaleRange6.EndThickness = 2F;
            arcScaleRange6.EndValue = 100F;
            arcScaleRange6.Name = "Range2";
            arcScaleRange6.ShapeOffset = 11.5F;
            arcScaleRange6.StartThickness = 2F;
            arcScaleRange6.StartValue = 66F;
            this.Yaw.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange4,
            arcScaleRange5,
            arcScaleRange6});
            this.Yaw.StartAngle = -240F;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.AcceptOrder = 50;
            this.arcScaleNeedleComponent3.ArcScale = this.Yaw;
            this.arcScaleNeedleComponent3.EndOffset = -8F;
            this.arcScaleNeedleComponent3.Name = "needle";
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style3;
            this.arcScaleNeedleComponent3.StartOffset = -21F;
            this.arcScaleNeedleComponent3.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent3
            // 
            this.arcScaleSpindleCapComponent3.AcceptOrder = 100;
            this.arcScaleSpindleCapComponent3.ArcScale = this.Yaw;
            this.arcScaleSpindleCapComponent3.Name = "circularGauge11_SpindleCap1";
            this.arcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style25;
            this.arcScaleSpindleCapComponent3.Size = new System.Drawing.SizeF(15F, 15F);
            this.arcScaleSpindleCapComponent3.ZOrder = -100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(819, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sapma Açısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(461, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Yalpa Açısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(77, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Yunuslama Açısı";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.gaugeControl1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.gaugeControl2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.gaugeControl3);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(11, 619);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1027, 344);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Oryantasyon";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge3});
            this.gaugeControl1.Location = new System.Drawing.Point(9, 21);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(288, 258);
            this.gaugeControl1.TabIndex = 32;
            // 
            // circularGauge3
            // 
            this.circularGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge3.Bounds = new System.Drawing.Rectangle(6, 6, 273, 244);
            this.circularGauge3.Name = "circularGauge3";
            this.circularGauge3.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent4});
            this.circularGauge3.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.Pitch});
            this.circularGauge3.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.AcceptOrder = -1000;
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.Pitch;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style25;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // Pitch
            // 
            this.Pitch.AcceptOrder = 0;
            this.Pitch.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Pitch.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Pitch.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Pitch.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Pitch.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Pitch.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.Pitch.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.Pitch.EndAngle = 60F;
            this.Pitch.MajorTickCount = 20;
            this.Pitch.MajorTickmark.FormatString = "{0:F0}";
            this.Pitch.MajorTickmark.ShapeOffset = -6F;
            this.Pitch.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_1;
            this.Pitch.MajorTickmark.TextOffset = -20F;
            this.Pitch.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.Pitch.MaxValue = 90F;
            this.Pitch.MinorTickCount = 4;
            this.Pitch.MinorTickmark.ShapeOffset = -2F;
            this.Pitch.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style25_2;
            this.Pitch.MinValue = -90F;
            this.Pitch.Name = "scale1";
            this.Pitch.RadiusX = 95F;
            this.Pitch.RadiusY = 95F;
            arcScaleRange7.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange7.EndThickness = 2F;
            arcScaleRange7.EndValue = 33F;
            arcScaleRange7.Name = "Range0";
            arcScaleRange7.ShapeOffset = 11.5F;
            arcScaleRange7.StartThickness = 2F;
            arcScaleRange8.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFDA80");
            arcScaleRange8.EndThickness = 2F;
            arcScaleRange8.EndValue = 66F;
            arcScaleRange8.Name = "Range1";
            arcScaleRange8.ShapeOffset = 11.5F;
            arcScaleRange8.StartThickness = 2F;
            arcScaleRange8.StartValue = 33F;
            arcScaleRange9.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E99D9D");
            arcScaleRange9.EndThickness = 2F;
            arcScaleRange9.EndValue = 100F;
            arcScaleRange9.Name = "Range2";
            arcScaleRange9.ShapeOffset = 11.5F;
            arcScaleRange9.StartThickness = 2F;
            arcScaleRange9.StartValue = 66F;
            this.Pitch.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange7,
            arcScaleRange8,
            arcScaleRange9});
            this.Pitch.StartAngle = -240F;
            // 
            // arcScaleNeedleComponent4
            // 
            this.arcScaleNeedleComponent4.AcceptOrder = 50;
            this.arcScaleNeedleComponent4.ArcScale = this.Pitch;
            this.arcScaleNeedleComponent4.EndOffset = -8F;
            this.arcScaleNeedleComponent4.Name = "needle";
            this.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style3;
            this.arcScaleNeedleComponent4.StartOffset = -21F;
            this.arcScaleNeedleComponent4.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.AcceptOrder = 100;
            this.arcScaleSpindleCapComponent1.ArcScale = this.Pitch;
            this.arcScaleSpindleCapComponent1.Name = "circularGauge11_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style25;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(15F, 15F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // Camera_PictureBox
            // 
            this.Camera_PictureBox.Location = new System.Drawing.Point(1054, 15);
            this.Camera_PictureBox.Name = "Camera_PictureBox";
            this.Camera_PictureBox.Size = new System.Drawing.Size(835, 597);
            this.Camera_PictureBox.TabIndex = 33;
            this.Camera_PictureBox.TabStop = false;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.AcceptOrder = 50;
            this.arcScaleNeedleComponent1.EndOffset = -8F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style25;
            this.arcScaleNeedleComponent1.StartOffset = -21F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Camera_PictureBox);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAMİ GUİ";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal_Left_Motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal_Right_Motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_Back_Motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_Front_Motor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VFM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HLM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camera_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InternalPressure;
        private System.Windows.Forms.Label InternalTemperature;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.TextBox InternalPressure_Text;
        private System.Windows.Forms.TextBox InternalTemperature_Text;
        private System.Windows.Forms.TextBox Humidity_Text;
        private System.Windows.Forms.Label Yaw_Angle;
        private System.Windows.Forms.Label Roll_Angle;
        private System.Windows.Forms.Label Pitch_Angle;
        private System.Windows.Forms.TextBox Yaw_Angle_Text;
        private System.Windows.Forms.TextBox Roll_Angle_Text;
        private System.Windows.Forms.TextBox Pitch_Angle_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Depth_Text;
        private System.Windows.Forms.TextBox ExternalTemperature_Text;
        private System.Windows.Forms.TextBox ExternalPressure_Text;
        private System.Windows.Forms.Label Depth;
        private System.Windows.Forms.Label ExternalTemperature;
        private System.Windows.Forms.Label ExternalPressure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar Horizontal_Left_Motor;
        private System.Windows.Forms.TrackBar Horizontal_Right_Motor;
        private System.Windows.Forms.TrackBar Vertical_Back_Motor;
        private System.Windows.Forms.TrackBar Vertical_Front_Motor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IP_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.TextBox PORT_Text;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Disconnect_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent Roll;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent Yaw;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGauges.Win.GaugeControl VBM1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge VBM;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl VFM1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge VFM;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent4;
        private DevExpress.XtraGauges.Win.GaugeControl HLM1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge HLM;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.GaugeControl HRM1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge HRM;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button HorizontalMidThrust;
        private System.Windows.Forms.Button HorizontalMidThrustR;
        private System.Windows.Forms.Button VerticalMidThrustR;
        private System.Windows.Forms.Button VerticalMidThrust;
        private System.Windows.Forms.Button HorizontalFullThrustR;
        private System.Windows.Forms.Button HorizontalFullThrust;
        private System.Windows.Forms.Button VerticalFullThrustR;
        private System.Windows.Forms.Button VerticalFullThrust;
        private System.Windows.Forms.PictureBox Camera_PictureBox;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent Pitch;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb1;
    }
}

