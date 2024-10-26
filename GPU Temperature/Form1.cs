using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPU_Temperature
{
    public partial class Form1 : Form
    {
        bool isShortcutExist = false;
        public Form1()
        {
            InitializeComponent();
            thermometer.Visible = true;

            if (File.Exists(save + timeWithSecond.Name) && decimal.TryParse(File.ReadAllText(save + timeWithSecond.Name), out decimal result1))
                timeWithSecond.Value = result1;

            if (File.Exists(save + temperatureWarning.Name) && decimal.TryParse(File.ReadAllText(save + temperatureWarning.Name), out decimal result2))
                temperatureWarning.Value = result2;

            Read_Click(null, null);
        }

        readonly string save = Microsoft.VisualBasic.FileIO.SpecialDirectories.AllUsersApplicationData.Replace(Application.ProductVersion, "");

        private void Understood_Click(object sender, EventArgs e)
        {
            if (!isShortcutExist)
            {
                try { CreateStartupShortcut(); }
                catch { }
                isShortcutExist = true;
            }
            Hide();
        }

        static Computer computer = null;
        static ISensor Sensor = null;
        static IHardware Hardware = null;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Sensor == null)
            {
                try
                {
                    computer = new Computer
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
                                    Hardware = hardware;
                                    Sensor = sensor;

                                    if (Sensor.Value < 48)
                                        degree.ForeColor = Color.Blue;
                                    else if (Sensor.Value >= 85)
                                        degree.ForeColor = Color.Red;
                                    else if (Sensor.Value > 75)
                                        degree.ForeColor = Color.OrangeRed;
                                    else
                                        degree.ForeColor = Color.Green;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    degree.Text = "Err";
                    degree.ForeColor = Color.Red;
                }
                finally
                {
                    //computer?.Close();
                    //computer = null;
                }
            }
            else
            {
                try
                {
                    Hardware.Update();
                    degree.Text = Sensor.Value.ToString();
                    if (Sensor.Value < 48)
                        degree.ForeColor = Color.Blue;
                    else if (Sensor.Value >= 85)
                        degree.ForeColor = Color.Red;
                    else if (Sensor.Value > 75)
                        degree.ForeColor = Color.OrangeRed;
                    else
                        degree.ForeColor = Color.Green;

                    if (Sensor.Value >= (float)temperatureWarning.Value)
                    {
                        if (!Visible)
                        {
                            // https://stackoverflow.com/questions/5282588/how-can-i-bring-my-application-window-to-the-front
                            Show();
                            TopMost = true;
                            Focus();
                            BringToFront();
                            TopMost = false;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            computer?.Close();
            computer = null;
            DeleteStartupShortcut();
            Close();
        }

        private void Thermometer_Click(object sender, EventArgs e)
        {
            Read_Click(null, null);

            // https://stackoverflow.com/questions/5282588/how-can-i-bring-my-application-window-to-the-front
            Show();
            TopMost = true;
            Focus();
            BringToFront();
            TopMost = false;
        }

        private void TimeWithSecond_ValueChanged(object sender, EventArgs e)
        {
            File.WriteAllText(save + timeWithSecond.Name, timeWithSecond.Value.ToString());
            timer1.Stop();
            timer1.Interval = (int)(timeWithSecond.Value * 1000);
            timer1.Start();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer1_Tick(null, null);
            timer1.Start();
        }

        private void TemperatureWarning_ValueChanged(object sender, EventArgs e)
        {
            File.WriteAllText(save + temperatureWarning.Name, temperatureWarning.Value.ToString());
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timeWithSecond.Value = 25;
            temperatureWarning.Value = 80;
        }

        private void CreateStartupShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupPath, $"{Application.ProductName} - Shortcut.lnk");

            if (File.Exists(shortcutPath)) return;

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);

            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.WindowStyle = 1;
            shortcut.Description = $"Shortcut to {Application.ProductName} Application";
            shortcut.IconLocation = Application.ExecutablePath;

            shortcut.Save();
        }

        public void DeleteStartupShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupPath, $"{Application.ProductName} - Shortcut.lnk");

            if (File.Exists(shortcutPath))
                File.Delete(shortcutPath);
        }
    }
}
