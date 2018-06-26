namespace PiSense
{
    partial class PiS
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
            this.TemperatureBox = new System.Windows.Forms.TextBox();
            this.HumidityBox = new System.Windows.Forms.TextBox();
            this.PiSenseLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.BackColor = System.Drawing.Color.Aqua;
            this.TemperatureBox.Location = new System.Drawing.Point(0, 46);
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.ReadOnly = true;
            this.TemperatureBox.Size = new System.Drawing.Size(233, 20);
            this.TemperatureBox.TabIndex = 0;
            this.TemperatureBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HumidityBox
            // 
            this.HumidityBox.BackColor = System.Drawing.Color.GreenYellow;
            this.HumidityBox.Location = new System.Drawing.Point(0, 72);
            this.HumidityBox.Name = "HumidityBox";
            this.HumidityBox.ReadOnly = true;
            this.HumidityBox.Size = new System.Drawing.Size(233, 20);
            this.HumidityBox.TabIndex = 1;
            this.HumidityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PiSenseLabel
            // 
            this.PiSenseLabel.AutoSize = true;
            this.PiSenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiSenseLabel.Location = new System.Drawing.Point(36, 9);
            this.PiSenseLabel.Margin = new System.Windows.Forms.Padding(100, 0, 3, 500);
            this.PiSenseLabel.Name = "PiSenseLabel";
            this.PiSenseLabel.Size = new System.Drawing.Size(160, 31);
            this.PiSenseLabel.TabIndex = 2;
            this.PiSenseLabel.Text = "PiSense 1.0";
            this.PiSenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(13, 108);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(208, 113);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // PiS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 233);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PiSenseLabel);
            this.Controls.Add(this.HumidityBox);
            this.Controls.Add(this.TemperatureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PiS";
            this.Text = "PiSense";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TemperatureBox;
        private System.Windows.Forms.TextBox HumidityBox;
        private System.Windows.Forms.Label PiSenseLabel;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

