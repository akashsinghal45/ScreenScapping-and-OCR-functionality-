namespace TestApplication
{
    partial class Form2
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
            this.bttCaptureScreen = new System.Windows.Forms.Button();
            this.bttCaptureArea = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // bttCaptureScreen
            // 
            this.bttCaptureScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttCaptureScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureScreen.Location = new System.Drawing.Point(2, 15);
            this.bttCaptureScreen.Name = "bttCaptureScreen";
            this.bttCaptureScreen.Size = new System.Drawing.Size(90, 32);
            this.bttCaptureScreen.TabIndex = 0;
            this.bttCaptureScreen.TabStop = false;
            this.bttCaptureScreen.Text = "Capture Screen";
            this.bttCaptureScreen.UseVisualStyleBackColor = false;
            this.bttCaptureScreen.Click += new System.EventHandler(this.bttCaptureScreen_Click);
            this.bttCaptureScreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bttCaptureScreen_KeyUp);
            // 
            // bttCaptureArea
            // 
            this.bttCaptureArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttCaptureArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureArea.Location = new System.Drawing.Point(2, 57);
            this.bttCaptureArea.Name = "bttCaptureArea";
            this.bttCaptureArea.Size = new System.Drawing.Size(90, 32);
            this.bttCaptureArea.TabIndex = 2;
            this.bttCaptureArea.TabStop = false;
            this.bttCaptureArea.Text = "Capture Area";
            this.bttCaptureArea.UseVisualStyleBackColor = false;
            this.bttCaptureArea.Click += new System.EventHandler(this.bttCaptureArea_Click);
            this.bttCaptureArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bttCaptureArea_KeyUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 122);
            this.Controls.Add(this.bttCaptureScreen);
            this.Controls.Add(this.bttCaptureArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "ScreenScraping";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttCaptureScreen;
        private System.Windows.Forms.Button bttCaptureArea;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}