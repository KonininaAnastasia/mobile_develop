namespace wfaPhoto
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
            bu_save = new Button();
            bu_clear = new Button();
            bu_delete = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            lb_width_text = new Label();
            lb_hight_text = new Label();
            lb_color_text = new Label();
            tb_width_mean = new TextBox();
            tb_height_mean = new TextBox();
            tb_color_mean = new TextBox();
            bu_newPage = new Button();
            treeView1 = new TreeView();
            panel1 = new Panel();
            bu_parametrs = new Button();
            bu_Photo = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bu_save
            // 
            bu_save.Location = new Point(12, 193);
            bu_save.Name = "bu_save";
            bu_save.Size = new Size(252, 29);
            bu_save.TabIndex = 2;
            bu_save.Text = "Сохранить";
            bu_save.UseVisualStyleBackColor = true;
            // 
            // bu_clear
            // 
            bu_clear.Location = new Point(12, 228);
            bu_clear.Name = "bu_clear";
            bu_clear.Size = new Size(252, 29);
            bu_clear.TabIndex = 3;
            bu_clear.Text = "Очистить ";
            bu_clear.UseVisualStyleBackColor = true;
            // 
            // bu_delete
            // 
            bu_delete.Location = new Point(12, 263);
            bu_delete.Name = "bu_delete";
            bu_delete.Size = new Size(252, 29);
            bu_delete.TabIndex = 4;
            bu_delete.Text = "Удалить ";
            bu_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 414);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 5;
            label1.Text = "Параметры страницы:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(lb_width_text, 0, 1);
            tableLayoutPanel1.Controls.Add(lb_hight_text, 0, 2);
            tableLayoutPanel1.Controls.Add(lb_color_text, 0, 3);
            tableLayoutPanel1.Controls.Add(tb_width_mean, 1, 1);
            tableLayoutPanel1.Controls.Add(tb_height_mean, 1, 2);
            tableLayoutPanel1.Controls.Add(tb_color_mean, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 437);
            tableLayoutPanel1.MaximumSize = new Size(250, 254);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(250, 140);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(4, 1);
            label2.Name = "label2";
            label2.Size = new Size(117, 33);
            label2.TabIndex = 0;
            label2.Text = "Название";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(128, 1);
            label3.Name = "label3";
            label3.Size = new Size(118, 33);
            label3.TabIndex = 1;
            label3.Text = "Значение";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_width_text
            // 
            lb_width_text.AutoSize = true;
            lb_width_text.Dock = DockStyle.Fill;
            lb_width_text.Location = new Point(4, 35);
            lb_width_text.Name = "lb_width_text";
            lb_width_text.Size = new Size(117, 33);
            lb_width_text.TabIndex = 2;
            lb_width_text.Text = "Ширина";
            lb_width_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_hight_text
            // 
            lb_hight_text.AutoSize = true;
            lb_hight_text.Dock = DockStyle.Fill;
            lb_hight_text.Location = new Point(4, 69);
            lb_hight_text.Name = "lb_hight_text";
            lb_hight_text.Size = new Size(117, 33);
            lb_hight_text.TabIndex = 4;
            lb_hight_text.Text = "Высота";
            lb_hight_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_color_text
            // 
            lb_color_text.AutoSize = true;
            lb_color_text.Dock = DockStyle.Fill;
            lb_color_text.Location = new Point(4, 103);
            lb_color_text.Name = "lb_color_text";
            lb_color_text.Size = new Size(117, 36);
            lb_color_text.TabIndex = 6;
            lb_color_text.Text = "Цвет";
            lb_color_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_width_mean
            // 
            tb_width_mean.Dock = DockStyle.Fill;
            tb_width_mean.Location = new Point(128, 38);
            tb_width_mean.Name = "tb_width_mean";
            tb_width_mean.Size = new Size(118, 27);
            tb_width_mean.TabIndex = 7;
            // 
            // tb_height_mean
            // 
            tb_height_mean.Dock = DockStyle.Fill;
            tb_height_mean.Location = new Point(128, 72);
            tb_height_mean.Name = "tb_height_mean";
            tb_height_mean.Size = new Size(118, 27);
            tb_height_mean.TabIndex = 8;
            // 
            // tb_color_mean
            // 
            tb_color_mean.Dock = DockStyle.Fill;
            tb_color_mean.Location = new Point(128, 106);
            tb_color_mean.Name = "tb_color_mean";
            tb_color_mean.Size = new Size(118, 27);
            tb_color_mean.TabIndex = 9;
            // 
            // bu_newPage
            // 
            bu_newPage.Location = new Point(12, 159);
            bu_newPage.Name = "bu_newPage";
            bu_newPage.Size = new Size(252, 29);
            bu_newPage.TabIndex = 8;
            bu_newPage.Text = "Создать новую";
            bu_newPage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(251, 141);
            treeView1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(269, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 600);
            panel1.TabIndex = 11;
            // 
            // bu_parametrs
            // 
            bu_parametrs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bu_parametrs.Location = new Point(12, 583);
            bu_parametrs.Name = "bu_parametrs";
            bu_parametrs.Size = new Size(251, 29);
            bu_parametrs.TabIndex = 12;
            bu_parametrs.Text = "Применить";
            bu_parametrs.UseVisualStyleBackColor = true;
            // 
            // bu_Photo
            // 
            bu_Photo.Location = new Point(74, 327);
            bu_Photo.Name = "bu_Photo";
            bu_Photo.Size = new Size(124, 46);
            bu_Photo.TabIndex = 13;
            bu_Photo.Text = "+ фото";
            bu_Photo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 624);
            Controls.Add(bu_Photo);
            Controls.Add(bu_parametrs);
            Controls.Add(panel1);
            Controls.Add(treeView1);
            Controls.Add(bu_newPage);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(bu_delete);
            Controls.Add(bu_clear);
            Controls.Add(bu_save);
            MinimumSize = new Size(1099, 671);
            Name = "Form1";
            Text = "Фотоальбом";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bu_save;
        private Button bu_clear;
        private Button bu_delete;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label lb_width_text;
        private Label lb_hight_text;
        private Label lb_color_text;
        private Button bu_newPage;
        private TreeView treeView1;
        private Panel panel1;
        private Button bu_parametrs;
        private Label label3;
        private TextBox tb_width_mean;
        private TextBox tb_height_mean;
        private TextBox tb_color_mean;
        private Button bu_Photo;
    }
}
