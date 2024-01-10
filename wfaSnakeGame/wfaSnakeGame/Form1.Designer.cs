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
            bu_Up = new Button();
            bu_Down = new Button();
            bu_Left = new Button();
            bu_Right = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 426);
            panel1.TabIndex = 0;
            // 
            // bu_Up
            // 
            bu_Up.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bu_Up.Location = new Point(188, 444);
            bu_Up.Name = "bu_Up";
            bu_Up.Size = new Size(103, 42);
            bu_Up.TabIndex = 1;
            bu_Up.Text = "▲";
            bu_Up.UseVisualStyleBackColor = true;
            // 
            // bu_Down
            // 
            bu_Down.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bu_Down.Location = new Point(188, 492);
            bu_Down.Name = "bu_Down";
            bu_Down.Size = new Size(103, 42);
            bu_Down.TabIndex = 2;
            bu_Down.Text = "▼";
            bu_Down.UseVisualStyleBackColor = true;
            // 
            // bu_Left
            // 
            bu_Left.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bu_Left.Location = new Point(79, 466);
            bu_Left.Name = "bu_Left";
            bu_Left.Size = new Size(103, 42);
            bu_Left.TabIndex = 3;
            bu_Left.Text = "◀";
            bu_Left.UseVisualStyleBackColor = true;
            // 
            // bu_Right
            // 
            bu_Right.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bu_Right.Location = new Point(297, 466);
            bu_Right.Name = "bu_Right";
            bu_Right.Size = new Size(103, 42);
            bu_Right.TabIndex = 4;
            bu_Right.Text = "▶";
            bu_Right.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 539);
            Controls.Add(bu_Right);
            Controls.Add(bu_Left);
            Controls.Add(bu_Down);
            Controls.Add(bu_Up);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(516, 586);
            MinimumSize = new Size(516, 586);
            Name = "Form1";
            Text = "SnakeGame";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bu_Up;
        private Button bu_Down;
        private Button bu_Left;
        private Button bu_Right;
        private System.Windows.Forms.Timer gameTimer;
    }
}
