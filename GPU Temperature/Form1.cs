using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPU_Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thermometer.Visible = true;
            Timer1_Tick(null, null);
        }
        

        private void Understood_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Computer computer = new Computer
            {
                IsGpuEnabled = true // تفعيل مراقبة وحدة المعالجة الرسومية
            };

            computer.Open();

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            degree.Text = sensor.Value.ToString();
                            if (sensor.Value >= (float)temperatureWarning.Value)
                                Show();
                        }
                    }
                }
            }

            computer.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Thermometer_Click(object sender, EventArgs e)
        {
            //Timer1_Tick(null, null);
            Show();
        }

        private void TimeWithSecond_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)(timeWithSecond.Value * 1000);
        }

        private void Read_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer1_Tick(null, null);
            timer1.Start();
        }
    }
}
