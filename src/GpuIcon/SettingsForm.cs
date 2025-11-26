using TrayIconLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GpuIcon
{
    public partial class SettingsForm : Form
    {
        CustomSettings settings;

        public SettingsForm()
        {
            InitializeComponent();

            settings = CustomSettings.Instance;
            gpuForegroundText.Text = Utils.ColorToString(settings.foregroundColor);
            gpuForegroundOpacity.Value = settings.foregroundColor.A;
            gpuBackgroundText.Text = Utils.ColorToString(settings.backgroundColor);
            gpuBackgroundOpacity.Value = settings.backgroundColor.A;
            gpuBorderText.Text = Utils.ColorToString(settings.borderColor);
            gpuBorderOpacity.Value = settings.borderColor.A;
            gpuInterval.Value = settings.updateInterval;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            settings.foregroundColor = Utils.ColorFromString(gpuForegroundText.Text);
            settings.backgroundColor = Utils.ColorFromString(gpuBackgroundText.Text);
            settings.borderColor = Utils.ColorFromString(gpuBorderText.Text);
            settings.updateInterval = (int)gpuInterval.Value;

            Close();
        }

        private void gpuForegroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(gpuForegroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(gpuForegroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            gpuForegroundText.Text = Utils.ColorToString(color);
        }

        private void gpuBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(gpuBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(gpuBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            gpuBackgroundText.Text = Utils.ColorToString(color);
        }

        private void gpuBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(gpuBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(gpuBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            gpuBorderText.Text = Utils.ColorToString(color);
        }

        private void gpuForegroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(gpuForegroundText.Text);
            Color color2 = Color.FromArgb(gpuForegroundOpacity.Value, color.R, color.G, color.B);
            gpuForegroundText.Text = Utils.ColorToString(color2);
        }

        private void gpuBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(gpuBackgroundText.Text);
            Color color2 = Color.FromArgb(gpuBackgroundOpacity.Value, color.R, color.G, color.B);
            gpuBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void gpuBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(gpuBorderText.Text);
            Color color2 = Color.FromArgb(gpuBorderOpacity.Value, color.R, color.G, color.B);
            gpuBorderText.Text = Utils.ColorToString(color2);
        }
    }
}
