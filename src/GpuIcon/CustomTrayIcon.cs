using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using TrayIconLibrary;

namespace GpuIcon
{
    class CustomTrayIcon: TrayIcon
    {
        private CustomSettings settings;
        List<PerformanceCounter> gpuCounters = new List<PerformanceCounter>();
        List<float> measurements = new List<float>();

        public CustomTrayIcon()
        {
            settings = CustomSettings.Instance;

            SetUpdateInterval(settings.updateInterval);
            EnableIcon();
        }

        private void RefreshGpuCounters()
        {
            HashSet<string> existingInstances = new HashSet<string>();
            
            foreach (var counter in gpuCounters)
            {
                existingInstances.Add(counter.InstanceName);
            }

            try
            {
                PerformanceCounterCategory category = new PerformanceCounterCategory("GPU Engine");
                string[] instanceNames = category.GetInstanceNames();
                HashSet<string> currentInstances = new HashSet<string>();
                
                foreach (string instanceName in instanceNames)
                {
                    if (instanceName.Contains("engtype_3D"))
                    {
                        currentInstances.Add(instanceName);
                        
                        if (!existingInstances.Contains(instanceName))
                        {
                            try
                            {
                                PerformanceCounter counter = new PerformanceCounter("GPU Engine", "Utilization Percentage", instanceName);
                                counter.NextValue();
                                gpuCounters.Add(counter);
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                
                for (int i = gpuCounters.Count - 1; i >= 0; i--)
                {
                    if (!currentInstances.Contains(gpuCounters[i].InstanceName))
                    {
                        gpuCounters[i].Dispose();
                        gpuCounters.RemoveAt(i);
                    }
                }
            }
            catch
            {
            }
        }

        public override void ContextMenuSettings(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            SetUpdateInterval(settings.updateInterval);
            UpdateIconTick();
        }

        public float GetGpuUsage()
        {
            if (gpuCounters.Count == 0)
                return 0;

            float totalLoad = 0;
            
            foreach (var counter in gpuCounters)
            {
                try
                {
                    float value = counter.NextValue();
                    totalLoad += value;
                }
                catch
                {
                }
            }
            
            return Math.Min(totalLoad, 100);
        }

        public override void UpdateIconTick(object sender = null, EventArgs e = null)
        {
            RefreshGpuCounters();

            Color foregroundColor = settings.foregroundColor;
            Color backgroundColor = settings.backgroundColor;
            Color borderColor = settings.borderColor;

            int pointWidth = WidthSingleMeasurement();

            float newValue = GetGpuUsage();

            int iconSize = GetTrayIconsSize();
            using (Bitmap bitmap = new Bitmap(iconSize, iconSize))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(backgroundColor);

                    measurements.Add(newValue);
                    if (measurements.Count > (bitmap.Width / pointWidth))
                    {
                        measurements.RemoveAt(0);
                    }

                    for (int i = measurements.Count - 1; i >= 0; i--)
                    {
                        float value = measurements[i];
                        var pos = bitmap.Width - (measurements.Count - 1 - i) * pointWidth;

                        graphics.DrawLine(new Pen(foregroundColor, pointWidth), pos, bitmap.Height, pos, bitmap.Height - bitmap.Height * value / 100);
                    }

                    int borderWidth = 1;
                    graphics.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, (int)bitmap.Width - borderWidth, (int)bitmap.Height - borderWidth);

                    graphics.Save();
                    string tooltip = String.Format("GPU: {0:F0}%\nAvg: {1:F0}%", newValue, measurements.Count > 0 ? measurements.Average() : 0);
                    ChangeIcon(bitmap, tooltip);
                }
            }
        }

        public override void IconHovered()
        {
        }

        public override void IconMouseDoubleClickAction()
        {
            Task.Run(() => Utils.StartProgram("taskmgr.exe"));
        }

        public override void IconMouseClickAction()
        {
        }
    }
}
