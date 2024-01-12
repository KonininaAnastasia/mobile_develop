namespace wfaSnakeGame
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            gameTimer = new System.Windows.Forms.Timer(components);
            lb_Right = new Label();
            lb_Up = new Label();
            lb_Down = new Label();
            lb_Left = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 276);
            panel1.TabIndex = 0;
            // 
            // lb_Right
            // 
            lb_Right.Anchor = AnchorStyles.Bottom;
            lb_Right.AutoSize = true;
            lb_Right.BorderStyle = BorderStyle.FixedSingle;
            lb_Right.Location = new Point(227, 317);
            lb_Right.MinimumSize = new Size(103, 42);
            lb_Right.Name = "lb_Right";
            lb_Right.Size = new Size(103, 42);
            lb_Right.TabIndex = 5;
            lb_Right.Text = "▶";
            lb_Right.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Up
            // 
            lb_Up.Anchor = AnchorStyles.Bottom;
            lb_Up.AutoSize = true;
            lb_Up.BorderStyle = BorderStyle.FixedSingle;
            lb_Up.Location = new Point(118, 294);
            lb_Up.MinimumSize = new Size(103, 42);
            lb_Up.Name = "lb_Up";
            lb_Up.Size = new Size(103, 42);
            lb_Up.TabIndex = 6;
            lb_Up.Text = "▲";
            lb_Up.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Down
            // 
            lb_Down.Anchor = AnchorStyles.Bottom;
            lb_Down.AutoSize = true;
            lb_Down.BorderStyle = BorderStyle.FixedSingle;
            lb_Down.Location = new Point(118, 340);
            lb_Down.MinimumSize = new Size(103, 42);
            lb_Down.Name = "lb_Down";
            lb_Down.Size = new Size(103, 42);
            lb_Down.TabIndex = 7;
            lb_Down.Text = "▼";
            lb_Down.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Left
            // 
            lb_Left.Anchor = AnchorStyles.Bottom;
            lb_Left.AutoSize = true;
            lb_Left.BorderStyle = BorderStyle.FixedSingle;
            lb_Left.Location = new Point(9, 317);
            lb_Left.MinimumSize = new Size(103, 42);
            lb_Left.Name = "lb_Left";
            lb_Left.Size = new Size(103, 42);
            lb_Left.TabIndex = 8;
            lb_Left.Text = "◀";
            lb_Left.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 389);
            Controls.Add(lb_Left);
            Controls.Add(lb_Down);
            Controls.Add(lb_Up);
            Controls.Add(lb_Right);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(516, 586);
            MinimumSize = new Size(365, 436);
            Name = "Form1";
            Text = "SnakeGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bu_Right;
        private System.Windows.Forms.Timer gameTimer;
        private Label lb_Right;
        private Label lb_Up;
        private Label lb_Down;
        private Label lb_Left;
    }
}
