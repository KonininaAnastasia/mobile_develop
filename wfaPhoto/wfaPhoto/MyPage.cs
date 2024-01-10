using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace wfaPhoto
{
    internal class MyPage
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Color BackgroundColor { get; set; }
        public Panel PanelWork { get; set; }
        public Panel PanelSave { get; set; }
        public PictureBox picture { get; set; }
        public PictureBox pictureSave { get; set; }

        public int count_lvSave = 1;
        private Point mouseOffset;
        private bool isDragging;

        private TextBox widthTextBox;
        private TextBox heightTextBox;
        private TextBox colorTextBox;

        public MyPage(int width, int height, Color backgroundColor)
        {
            Width = width;
            Height = height;
            BackgroundColor = backgroundColor;
        }

        internal void CreatNewPage(Panel panel, TextBox width, TextBox height, TextBox color)
        {
            PanelWork = new Panel
            {
                Width = Width,
                Height = Height,
                BackColor = BackgroundColor,
            };

            panel.Controls.Add(PanelWork);

            PanelWork.MouseWheel += PanelWork_MouseWheel;
            PanelWork.MouseDown += PanelWork_MouseDown;
            PanelWork.MouseMove += PanelWork_MouseMove;
            PanelWork.MouseUp += PanelWork_MouseUp;

            Parametrs(width, height, color, PanelWork);
        }

        private void PanelWork_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                // Отпускание колесика мыши и остановка перемещения
                isDragging = false;
            }
        }

        private void PanelWork_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Перемещение Panel при перетаскивании мыши
                PanelWork.Left = e.X + PanelWork.Left - mouseOffset.X;
                PanelWork.Top = e.Y + PanelWork.Top - mouseOffset.Y;
            }
        }

        private void PanelWork_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                // Захват смещения мыши при нажатии колесика
                mouseOffset = e.Location;
                isDragging = true;
            }
        }

        private void PanelWork_MouseWheel(object? sender, MouseEventArgs e)
        {
            double scaleFactor = e.Delta > 0 ? 1.1f : 0.9f;

            if (sender is PictureBox)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Width = (int)(pictureBox.Width * scaleFactor);
                pictureBox.Height = (int)(pictureBox.Height * scaleFactor);
            }
            else if (sender is Panel)
            {
                Panel panel = (Panel)sender;
                panel.Width = (int)(panel.Width * scaleFactor);
                panel.Height = (int)(panel.Height * scaleFactor);

            }

            Parametrs(widthTextBox, heightTextBox, colorTextBox, PanelWork);
        }


        internal void Parametrs(TextBox width, TextBox height, TextBox color, Panel p)
        {
            width.Text = p.Width.ToString();
            height.Text = p.Height.ToString();
            color.Text = p.BackColor.Name;
        }

        internal void ChangeParametrs(TextBox width, TextBox height, TextBox color)
        {
            PanelWork.Width = int.Parse(width.Text);
            PanelWork.Height = int.Parse(height.Text);
            PanelWork.BackColor = Color.FromName(color.Text);
        }

        internal void Save(TreeView treeView)
        {

            TreeNode selectedNode = treeView.SelectedNode;

            if (selectedNode != null && selectedNode.Tag is Panel savedPanel)
            {
                // Обновление параметров для выбранного узла
                savedPanel.BackColor = PanelWork.BackColor;
                savedPanel.Width = PanelWork.Width;
                savedPanel.Height = PanelWork.Height;


                foreach (Control control in PanelWork.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureSave = new PictureBox
                        {
                            Image = picture.Image,
                            Location = picture.Location,
                            Size = picture.Size,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };

                        savedPanel.Controls.Add(pictureSave);
                    }
                }

                PanelSave = savedPanel;


            }
            else
            {
                PanelSave = new Panel();

                string itemText = "Страница №" + count_lvSave;
                TreeNode newItem = new TreeNode(itemText);

                foreach (Control control in PanelWork.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureSave = new PictureBox
                        {
                            Image = picture.Image,
                            Location = picture.Location,
                            Size = picture.Size,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };

                        PanelWork.Controls.Add(pictureSave);
                    }
                }

                newItem.Tag = PanelWork;
                treeView.Nodes.Add(newItem);

                count_lvSave++;

            }

            PanelSave.Controls.Clear();

        }

        internal void OpenLvSave(TreeView treeView, Panel panel)
        {
            TreeNode selectedNode = treeView.SelectedNode;

            // Проверка, что выбран элемент и у него есть сохраненный Panel
            if (selectedNode != null && selectedNode.Tag is Panel savedPanel)
            {
                panel.Controls.Clear();

                PanelWork = new Panel
                {
                    BackColor = savedPanel.BackColor,
                    Width = savedPanel.Width,
                    Height = savedPanel.Height,
                };


                foreach (Control control in savedPanel.Controls)
                {
                    if (control is PictureBox)
                    {
                        picture = new PictureBox
                        {
                            Image = pictureSave.Image,
                            Location = pictureSave.Location,
                            Size = pictureSave.Size,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };

                        PanelWork.Controls.Add(picture);

                    }
                }

                panel.Controls.Add(PanelWork);
            }

            PanelWork.MouseWheel += PanelWork_MouseWheel;
            PanelWork.MouseDown += PanelWork_MouseDown;
            PanelWork.MouseMove += PanelWork_MouseMove;
            PanelWork.MouseUp += PanelWork_MouseUp;

        }

        internal void DeleteFromTreeView(TreeView treeView)
        {
            TreeNode selectedNode = treeView.SelectedNode;

            // Проверка, что выбран элемент в дереве
            if (selectedNode != null)
            {
                // Проверка, что выбранный узел является родителем
                if (selectedNode.Parent != null)
                {
                    // Удаление выбранного узла из родительского узла
                    selectedNode.Parent.Nodes.Remove(selectedNode);
                }
                else
                {
                    // Удаление выбранного корневого узла
                    treeView.Nodes.Remove(selectedNode);
                }
            }
        }

        internal void Sent_parametrs(TextBox width, TextBox height, TextBox color)
        {
            widthTextBox = width;
            heightTextBox = height;
            colorTextBox = color;
        }

        internal void Insert_Photo()
        {

            picture = new PictureBox();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                string selectedImagePath = openFileDialog.FileName;
                picture.Image = Image.FromFile(selectedImagePath);

                picture.SizeMode = PictureBoxSizeMode.Zoom;

                PanelWork.Controls.Add(picture);
            }

            picture.MouseDown += Picture_MouseDown;
            picture.MouseMove += Picture_MouseMove;
            picture.MouseUp += Picture_MouseUp;
            picture.MouseWheel += PanelWork_MouseWheel;

        }

        private void Picture_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Отпускание колесика мыши и остановка перемещения
                isDragging = false;
            }
        }

        private void Picture_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Перемещение picture при перетаскивании мыши
                picture.Left = e.X + picture.Left - mouseOffset.X;
                picture.Top = e.Y + picture.Top - mouseOffset.Y;
            }
        }

        private void Picture_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Захват смещения мыши при нажатии колесика
                mouseOffset = e.Location;
                isDragging = true;
            }
        }


    }
}