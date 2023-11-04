namespace wfaFileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            buBack = new ToolStripButton();
            buForward = new ToolStripButton();
            buUp = new ToolStripButton();
            edDir = new ToolStripTextBox();
            buDirSelect = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            miVievLargeIcon = new ToolStripMenuItem();
            miVievSmalIcon = new ToolStripMenuItem();
            miVievList = new ToolStripMenuItem();
            miVievDetails = new ToolStripMenuItem();
            miVievTile = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            laStatus = new ToolStripStatusLabel();
            panel1 = new Panel();
            lv = new ListView();
            ilLarge = new ImageList(components);
            ilSmal = new ImageList(components);
            splitter1 = new Splitter();
            treeView1 = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buBack, buForward, buUp, edDir, buDirSelect, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1011, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // buBack
            // 
            buBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buBack.Image = (Image)resources.GetObject("buBack.Image");
            buBack.ImageTransparentColor = Color.Magenta;
            buBack.Name = "buBack";
            buBack.Size = new Size(29, 24);
            buBack.Text = "🡐";
            // 
            // buForward
            // 
            buForward.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buForward.Image = (Image)resources.GetObject("buForward.Image");
            buForward.ImageTransparentColor = Color.Magenta;
            buForward.Name = "buForward";
            buForward.Size = new Size(29, 24);
            buForward.Text = "🡒";
            // 
            // buUp
            // 
            buUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buUp.Image = (Image)resources.GetObject("buUp.Image");
            buUp.ImageTransparentColor = Color.Magenta;
            buUp.Name = "buUp";
            buUp.Size = new Size(29, 24);
            buUp.Text = "🡑";
            // 
            // edDir
            // 
            edDir.Name = "edDir";
            edDir.Size = new Size(400, 27);
            // 
            // buDirSelect
            // 
            buDirSelect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buDirSelect.Image = (Image)resources.GetObject("buDirSelect.Image");
            buDirSelect.ImageTransparentColor = Color.Magenta;
            buDirSelect.Name = "buDirSelect";
            buDirSelect.Size = new Size(29, 24);
            buDirSelect.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { miVievLargeIcon, miVievSmalIcon, miVievList, miVievDetails, miVievTile });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(49, 24);
            toolStripDropDownButton1.Text = "Вид";
            // 
            // miVievLargeIcon
            // 
            miVievLargeIcon.Name = "miVievLargeIcon";
            miVievLargeIcon.Size = new Size(206, 26);
            miVievLargeIcon.Text = "Крупные значки";
            // 
            // miVievSmalIcon
            // 
            miVievSmalIcon.Name = "miVievSmalIcon";
            miVievSmalIcon.Size = new Size(206, 26);
            miVievSmalIcon.Text = "Мелкие значки";
            // 
            // miVievList
            // 
            miVievList.Name = "miVievList";
            miVievList.Size = new Size(206, 26);
            miVievList.Text = "Список";
            // 
            // miVievDetails
            // 
            miVievDetails.Name = "miVievDetails";
            miVievDetails.Size = new Size(206, 26);
            miVievDetails.Text = "Таблица";
            // 
            // miVievTile
            // 
            miVievTile.Name = "miVievTile";
            miVievTile.Size = new Size(206, 26);
            miVievTile.Text = "Плитки";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { laStatus });
            statusStrip1.Location = new Point(0, 492);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1011, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // laStatus
            // 
            laStatus.Name = "laStatus";
            laStatus.Size = new Size(151, 20);
            laStatus.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(lv);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(treeView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 465);
            panel1.TabIndex = 5;
            // 
            // lv
            // 
            lv.Dock = DockStyle.Fill;
            lv.LargeImageList = ilLarge;
            lv.Location = new Point(235, 0);
            lv.Name = "lv";
            lv.Size = new Size(776, 465);
            lv.SmallImageList = ilSmal;
            lv.TabIndex = 4;
            lv.UseCompatibleStateImageBehavior = false;
            // 
            // ilLarge
            // 
            ilLarge.ColorDepth = ColorDepth.Depth32Bit;
            ilLarge.ImageStream = (ImageListStreamer)resources.GetObject("ilLarge.ImageStream");
            ilLarge.TransparentColor = Color.Transparent;
            ilLarge.Images.SetKeyName(0, "path.png");
            ilLarge.Images.SetKeyName(1, "file.png");
            // 
            // ilSmal
            // 
            ilSmal.ColorDepth = ColorDepth.Depth32Bit;
            ilSmal.ImageStream = (ImageListStreamer)resources.GetObject("ilSmal.ImageStream");
            ilSmal.TransparentColor = Color.Transparent;
            ilSmal.Images.SetKeyName(0, "path.png");
            ilSmal.Images.SetKeyName(1, "file.png");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(231, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 465);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = ilSmal;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(231, 465);
            treeView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 100);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 24);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(211, 24);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(211, 24);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(211, 24);
            toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 518);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "wfaFileExplorer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton buBack;
        private ToolStripButton buForward;
        private ToolStripButton buUp;
        private ToolStripTextBox edDir;
        private ToolStripButton buDirSelect;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private ListView lv;
        private Splitter splitter1;
        private TreeView treeView1;
        private ImageList ilLarge;
        private ImageList ilSmal;
        private ToolStripStatusLabel laStatus;
        private ToolStripMenuItem miVievLargeIcon;
        private ToolStripMenuItem miVievSmalIcon;
        private ToolStripMenuItem miVievList;
        private ToolStripMenuItem miVievDetails;
        private ToolStripMenuItem miVievTile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}