using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace WinFormsApp3
{
    public partial class main : Form
    {


        public main()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = true;
            panel1.Controls.Add(picDrawingSurface);
            globals.drawing = false;
            globals.currentPen = new Pen(Color.Black);
            globals.histotyColor = globals.currentPen.Color;
            l_XY.Text = "";
            trackBar1.Value = 5;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            globals.currentPen.Width = trackBar1.Value;  
            globals.History = new List<Image>(); 
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel); 

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
            globals.History.Clear();
            globals.historyCounter = 1;
            Bitmap pic = new Bitmap(621, 362);
            picDrawingSurface.Image = pic;
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|BitmapImage|*.bmp|GIFImage|*.gif|PNGImage|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; 
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "") 
            {
                FileStream fs =(FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void picDrawingSurface_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|BitmapImage|*.bmp|GIFImage|*.gif|PNGImage|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; 
            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;

        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Для начала работы необходимо создать новый документ!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                globals.drawing = true;
                globals.oldLocation = e.Location;
                globals.currentPath = new GraphicsPath();
            }
            if (e.Button == MouseButtons.Right)
            {
                globals.drawing = true;
                globals.histotyColor = globals.currentPen.Color;
                globals.currentPen.Color = Color.White;
                globals.oldLocation = e.Location;
                globals.currentPath = new GraphicsPath();
            }

        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (globals.History.Count - globals.historyCounter - 1 -(globals.historyCounter + 1) >0) globals.History.RemoveRange(globals.historyCounter + 1, globals.History.Count - globals.historyCounter - 1);
            globals.History.Add(new Bitmap(picDrawingSurface.Image));
            if (globals.historyCounter + 1 < 10) globals.historyCounter++;
            if (globals.History.Count - 1 == 10) globals.History.RemoveAt(0);

            globals.drawing = false;
            globals.currentPen.Color = globals.histotyColor;
            try
            {
                globals.currentPath.Dispose();
            }
            catch { };

        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (globals.drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                globals.currentPath.AddLine(globals.oldLocation, e.Location);
                g.DrawPath(globals.currentPen, globals.currentPath);
                globals.oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
            l_XY.Text = e.X + ", " + e.Y;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            globals.currentPen.Width = trackBar1.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globals.History.Count != 0 && globals.historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(globals.History[--globals.historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void renoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globals.historyCounter < globals.History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(globals.History[++globals.historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;

        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorsForm f = new ColorsForm(globals.currentPen.Color);
            f.Show();
            globals.currentPen.Color = Color.FromArgb(Data.Value);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {//по анологии с  open
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")
            {
                FileStream fs =
                (FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }
        // ссылаемся на панель инструментов
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            styleToolStripMenuItem_Click(sender,e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Разработчик: Руслан Бардин");
        }
    }
    class globals//класс глобальных переменных
    {
        public static bool drawing;
        public static GraphicsPath currentPath;
        public static Point oldLocation;
        public static Pen currentPen;
        public static Color histotyColor;
        public static int historyCounter=1;
        public static List<Image> History; 
    }
}
