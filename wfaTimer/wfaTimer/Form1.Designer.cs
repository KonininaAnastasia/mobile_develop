namespace wfaTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buUp = new Button();
            buUpPause = new Button();
            pbUpSec = new ProgressBar();
            pbUpMs = new ProgressBar();
            SuspendLayout();
            // 
            // button1
            // 
            buUp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buUp.Location = new Point(12, 12);
            buUp.Name = "button1";
            buUp.Size = new Size(241, 74);
            buUp.TabIndex = 0;
            buUp.Text = "00:00:00.000";
            buUp.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            buUpPause.Location = new Point(259, 14);
            buUpPause.Name = "button2";
            buUpPause.Size = new Size(94, 72);
            buUpPause.TabIndex = 1;
            buUpPause.Text = "▌▐";
            buUpPause.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            pbUpSec.Location = new Point(359, 14);
            pbUpSec.Name = "progressBar1";
            pbUpSec.Size = new Size(378, 33);
            pbUpSec.TabIndex = 2;
            // 
            // progressBar2
            // 
            pbUpMs.Location = new Point(359, 53);
            pbUpMs.Name = "progressBar2";
            pbUpMs.Size = new Size(378, 33);
            pbUpMs.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 168);
            Controls.Add(pbUpMs);
            Controls.Add(pbUpSec);
            Controls.Add(buUpPause);
            Controls.Add(buUp);
            Name = "Form1";
            Text = "wfaTimer";
            ResumeLayout(false);
        }

        #endregion

        private Button buUp;
        private Button buUpPause;
        private ProgressBar pbUpSec;
        private ProgressBar pbUpMs;
    }
}