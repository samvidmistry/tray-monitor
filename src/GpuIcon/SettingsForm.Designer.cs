namespace GpuIcon
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gpuInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gpuBorderText = new System.Windows.Forms.TextBox();
            this.gpuBorderButton = new System.Windows.Forms.Button();
            this.gpuBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.gpuBackgroundText = new System.Windows.Forms.TextBox();
            this.gpuBackgroundButton = new System.Windows.Forms.Button();
            this.gpuBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.gpuForegroundText = new System.Windows.Forms.TextBox();
            this.gpuForegroundButton = new System.Windows.Forms.Button();
            this.gpuForegroundOpacity = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gpuInterval)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuBorderOpacity)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuBackgroundOpacity)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuForegroundOpacity)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(522, 211);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(156, 44);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(358, 211);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(156, 44);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Update interval";
            // 
            // gpuInterval
            // 
            this.gpuInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.gpuInterval.Location = new System.Drawing.Point(147, 4);
            this.gpuInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.gpuInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.gpuInterval.Name = "gpuInterval";
            this.gpuInterval.Size = new System.Drawing.Size(98, 31);
            this.gpuInterval.TabIndex = 59;
            this.gpuInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "ms";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.gpuBorderText);
            this.panel9.Controls.Add(this.gpuBorderButton);
            this.panel9.Controls.Add(this.gpuBorderOpacity);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(3, 105);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(675, 48);
            this.panel9.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Border";
            // 
            // gpuBorderText
            // 
            this.gpuBorderText.Location = new System.Drawing.Point(147, 6);
            this.gpuBorderText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuBorderText.Name = "gpuBorderText";
            this.gpuBorderText.Size = new System.Drawing.Size(139, 31);
            this.gpuBorderText.TabIndex = 61;
            // 
            // gpuBorderButton
            // 
            this.gpuBorderButton.Location = new System.Drawing.Point(302, 4);
            this.gpuBorderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuBorderButton.Name = "gpuBorderButton";
            this.gpuBorderButton.Size = new System.Drawing.Size(74, 38);
            this.gpuBorderButton.TabIndex = 63;
            this.gpuBorderButton.Text = "Color";
            this.gpuBorderButton.UseVisualStyleBackColor = true;
            this.gpuBorderButton.Click += new System.EventHandler(this.gpuBorderButton_Click);
            // 
            // gpuBorderOpacity
            // 
            this.gpuBorderOpacity.AutoSize = false;
            this.gpuBorderOpacity.Location = new System.Drawing.Point(472, 9);
            this.gpuBorderOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuBorderOpacity.Maximum = 255;
            this.gpuBorderOpacity.Name = "gpuBorderOpacity";
            this.gpuBorderOpacity.Size = new System.Drawing.Size(198, 27);
            this.gpuBorderOpacity.TabIndex = 64;
            this.gpuBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gpuBorderOpacity.Scroll += new System.EventHandler(this.gpuBorderOpacity_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Opacity";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.gpuBackgroundText);
            this.panel8.Controls.Add(this.gpuBackgroundButton);
            this.panel8.Controls.Add(this.gpuBackgroundOpacity);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(3, 57);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(675, 48);
            this.panel8.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Background";
            // 
            // gpuBackgroundText
            // 
            this.gpuBackgroundText.Location = new System.Drawing.Point(147, 6);
            this.gpuBackgroundText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuBackgroundText.Name = "gpuBackgroundText";
            this.gpuBackgroundText.Size = new System.Drawing.Size(139, 31);
            this.gpuBackgroundText.TabIndex = 51;
            // 
            // gpuBackgroundButton
            // 
            this.gpuBackgroundButton.Location = new System.Drawing.Point(302, 4);
            this.gpuBackgroundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuBackgroundButton.Name = "gpuBackgroundButton";
            this.gpuBackgroundButton.Size = new System.Drawing.Size(74, 38);
            this.gpuBackgroundButton.TabIndex = 54;
            this.gpuBackgroundButton.Text = "Color";
            this.gpuBackgroundButton.UseVisualStyleBackColor = true;
            this.gpuBackgroundButton.Click += new System.EventHandler(this.gpuBackgroundButton_Click);
            // 
            // gpuBackgroundOpacity
            // 
            this.gpuBackgroundOpacity.AutoSize = false;
            this.gpuBackgroundOpacity.Location = new System.Drawing.Point(472, 9);
            this.gpuBackgroundOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuBackgroundOpacity.Maximum = 255;
            this.gpuBackgroundOpacity.Name = "gpuBackgroundOpacity";
            this.gpuBackgroundOpacity.Size = new System.Drawing.Size(198, 27);
            this.gpuBackgroundOpacity.TabIndex = 56;
            this.gpuBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gpuBackgroundOpacity.Scroll += new System.EventHandler(this.gpuBackgroundOpacity_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Opacity";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.gpuForegroundText);
            this.panel7.Controls.Add(this.gpuForegroundButton);
            this.panel7.Controls.Add(this.gpuForegroundOpacity);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(3, 9);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(675, 48);
            this.panel7.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Foreground";
            // 
            // gpuForegroundText
            // 
            this.gpuForegroundText.Location = new System.Drawing.Point(147, 6);
            this.gpuForegroundText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuForegroundText.Name = "gpuForegroundText";
            this.gpuForegroundText.Size = new System.Drawing.Size(139, 31);
            this.gpuForegroundText.TabIndex = 49;
            // 
            // gpuForegroundButton
            // 
            this.gpuForegroundButton.Location = new System.Drawing.Point(302, 4);
            this.gpuForegroundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuForegroundButton.Name = "gpuForegroundButton";
            this.gpuForegroundButton.Size = new System.Drawing.Size(74, 38);
            this.gpuForegroundButton.TabIndex = 53;
            this.gpuForegroundButton.Text = "Color";
            this.gpuForegroundButton.UseVisualStyleBackColor = true;
            this.gpuForegroundButton.Click += new System.EventHandler(this.gpuForegroundButton_Click);
            // 
            // gpuForegroundOpacity
            // 
            this.gpuForegroundOpacity.AutoSize = false;
            this.gpuForegroundOpacity.Location = new System.Drawing.Point(472, 9);
            this.gpuForegroundOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpuForegroundOpacity.Maximum = 255;
            this.gpuForegroundOpacity.Name = "gpuForegroundOpacity";
            this.gpuForegroundOpacity.Size = new System.Drawing.Size(198, 27);
            this.gpuForegroundOpacity.TabIndex = 55;
            this.gpuForegroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gpuForegroundOpacity.Scroll += new System.EventHandler(this.gpuForegroundOpacity_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Opacity";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.gpuInterval);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(3, 153);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(675, 48);
            this.panel10.TabIndex = 80;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(682, 261);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "GpuIcon Settings";
            ((System.ComponentModel.ISupportInitialize)(this.gpuInterval)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuBorderOpacity)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuBackgroundOpacity)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuForegroundOpacity)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown gpuInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gpuBorderText;
        private System.Windows.Forms.Button gpuBorderButton;
        private System.Windows.Forms.TrackBar gpuBorderOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gpuBackgroundText;
        private System.Windows.Forms.Button gpuBackgroundButton;
        private System.Windows.Forms.TrackBar gpuBackgroundOpacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gpuForegroundText;
        private System.Windows.Forms.Button gpuForegroundButton;
        private System.Windows.Forms.TrackBar gpuForegroundOpacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
    }
}
