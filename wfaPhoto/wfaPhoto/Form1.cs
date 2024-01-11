using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfaPhoto
{
    public partial class Form1 : Form
    {
        MyPage page = new(800, 600, Color.White);

        public Form1()
        {
            InitializeComponent();

            this.Text += " : (Колесо мыши - маштабирование; зажатое колесо мыши - перемещение)";

            //MyPage page = new(800, 600, Color.White);
            //bu_newPage.Click += (s, e) => page.CreatNewPage(panel1);

            page.Sent_parametrs(tb_width_mean, tb_height_mean, tb_color_mean);

            bu_newPage.Click += Bu_newPage_Click;
            bu_parametrs.Click += (s, e) => page.ChangeParametrs(tb_width_mean, tb_height_mean, tb_color_mean);
            bu_save.Click += (s, e) => page.Save(treeView1);
            //bu_delete.Click += (s, e) => panel1.Controls.Clear();
            bu_delete.Click += Bu_delete_Click;
            bu_clear.Click += Bu_newPage_Click;

            treeView1.DoubleClick += (s, e) => page.OpenPanelSave(treeView1, panel1);

            bu_Photo.Click += Bu_Photo_Click;
        }

        private void Bu_Photo_Click(object? sender, EventArgs e)
        {
            page.Insert_Photo();
        }

        private void Bu_delete_Click(object? sender, EventArgs e)
        {
            panel1.Controls.Clear();
            page.DeleteFromTreeView(treeView1);
        }

        private void Bu_newPage_Click(object? sender, EventArgs e)
        {
            //MyPage page = new(800, 600, Color.White);
            panel1.Controls.Clear();
            page.CreatNewPage(panel1, tb_width_mean, tb_height_mean, tb_color_mean);
            //page.Parametrs(tb_width_mean, tb_height_mean, tb_color_mean);
            
        }

    }
}
