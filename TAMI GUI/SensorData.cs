using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMI_GUI
{
    public class SensorData
    {

        public int Roll { get; set; }
        public int Pitch { get; set; }
        public int Yaw { get; set; }
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int Depth { get; set; }
        public int ExternalTemperature { get; set; }
        public int ExternalPressure { get; set; }

    }
}