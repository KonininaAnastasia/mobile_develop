namespace wfaGameTrainerAccount
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
            tableLayoutPanel1 = new TableLayoutPanel();
            laWrong = new Label();
            laCorrect = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buNo = new Button();
            buYes = new Button();
            laCode = new Label();
            label4 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(laWrong, 1, 0);
            tableLayoutPanel1.Controls.Add(laCorrect, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(464, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // laWrong
            // 
            laWrong.AutoSize = true;
            laWrong.BackColor = Color.FromArgb(255, 192, 192);
            laWrong.Dock = DockStyle.Fill;
            laWrong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            laWrong.Location = new Point(235, 0);
            laWrong.Name = "laWrong";
            laWrong.Size = new Size(226, 90);
            laWrong.TabIndex = 1;
            laWrong.Text = "Неверно = 0";
            laWrong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            laCorrect.AutoSize = true;
            laCorrect.BackColor = Color.FromArgb(192, 255, 192);
            laCorrect.Dock = DockStyle.Fill;
            laCorrect.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            laCorrect.Location = new Point(3, 0);
            laCorrect.Name = "laCorrect";
            laCorrect.Size = new Size(226, 90);
            laCorrect.TabIndex = 0;
            laCorrect.Text = "Верно = 0";
            laCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Controls.Add(buNo, 1, 0);
            tableLayoutPanel2.Controls.Add(buYes, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 443);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(464, 125);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buNo
            // 
            buNo.Dock = DockStyle.Fill;
            buNo.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            buNo.ForeColor = Color.LightSeaGreen;
            buNo.Location = new Point(159, 3);
            buNo.Name = "buNo";
            buNo.Size = new Size(150, 119);
            buNo.TabIndex = 1;
            buNo.Text = "Пропуск";
            buNo.UseVisualStyleBackColor = true;
            // 
            // buYes
            // 
            buYes.Dock = DockStyle.Fill;
            buYes.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            buYes.ForeColor = Color.Green;
            buYes.Location = new Point(3, 3);
            buYes.Name = "buYes";
            buYes.Size = new Size(150, 119);
            buYes.TabIndex = 0;
            buYes.Text = "Да";
            buYes.UseVisualStyleBackColor = true;
            // 
            // laCode
            // 
            laCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            laCode.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            laCode.Location = new Point(12, 105);
            laCode.Name = "laCode";
            laCode.Size = new Size(464, 286);
            laCode.TabIndex = 2;
            laCode.Text = "10+11=21";
            laCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 391);
            label4.Name = "label4";
            label4.Size = new Size(464, 49);
            label4.TabIndex = 3;
            label4.Text = "Верно?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(315, 3);
            button1.Name = "button1";
            button1.Size = new Size(146, 119);
            button1.TabIndex = 2;
            button1.Text = "Нет";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 580);
            Controls.Add(label4);
            Controls.Add(laCode);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(506, 549);
            Name = "Form1";
            Text = "wfaGameTrainerAccount";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label laCorrect;
        private Label laWrong;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buNo;
        private Button buYes;
        private Label laCode;
        private Label label4;
        private Button button1;
    }
}