namespace wfaDrawPlayBoard
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
            tb_width = new TextBox();
            tb_hieght = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bu_parametrs = new Button();
            radio_1 = new RadioButton();
            radio_2 = new RadioButton();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // tb_width
            // 
            tb_width.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tb_width.Location = new Point(13, 345);
            tb_width.Name = "tb_width";
            tb_width.Size = new Size(125, 27);
            tb_width.TabIndex = 3;
            // 
            // tb_hieght
            // 
            tb_hieght.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tb_hieght.Location = new Point(13, 400);
            tb_hieght.Name = "tb_hieght";
            tb_hieght.Size = new Size(125, 27);
            tb_hieght.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(13, 322);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Ширина";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(14, 375);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 6;
            label2.Text = "Высота";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(13, 292);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 7;
            label3.Text = "Параметры поля:";
            // 
            // bu_parametrs
            // 
            bu_parametrs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bu_parametrs.Location = new Point(13, 435);
            bu_parametrs.Name = "bu_parametrs";
            bu_parametrs.Size = new Size(190, 29);
            bu_parametrs.TabIndex = 8;
            bu_parametrs.Text = "Применить";
            bu_parametrs.UseVisualStyleBackColor = true;
            // 
            // radio_1
            // 
            radio_1.AutoSize = true;
            radio_1.Location = new Point(12, 18);
            radio_1.Name = "radio_1";
            radio_1.Size = new Size(95, 24);
            radio_1.TabIndex = 13;
            radio_1.TabStop = true;
            radio_1.Text = "Шахматы";
            radio_1.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            radio_2.AutoSize = true;
            radio_2.Location = new Point(12, 49);
            radio_2.Name = "radio_2";
            radio_2.Size = new Size(124, 24);
            radio_2.TabIndex = 14;
            radio_2.TabStop = true;
            radio_2.Text = "Морской бой";
            radio_2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(214, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 452);
            panel1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 477);
            Controls.Add(panel1);
            Controls.Add(radio_2);
            Controls.Add(radio_1);
            Controls.Add(bu_parametrs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_hieght);
            Controls.Add(tb_width);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_width;
        private TextBox tb_hieght;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bu_parametrs;
        private RadioButton radio_1;
        private RadioButton radio_2;
        private Panel panel1;
    }
}
