using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Image img;
        int lx = 0, ly = 0;
        int cx = 0, cy = 0;

        // При загрузке формы
        private void FormMain_Load(object sender, EventArgs e)
        {
            img = pictureBox.Image;
        }

        // ВРЕМЕННАЯ КНОПКА
        private void button2_Click(object sender, EventArgs e)
        {
            Image imgNew = PictureManager.RotateClockWise(pictureBox.Image);
            pictureBox.Image = imgNew;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if(img != null)
                e.Graphics.DrawImage(img, cx, cy);
            //pictureBox.size
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lx = e.X;
            ly = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - lx;
                int dy = e.Y - ly;
                cx += dx;
                cy += dy;
                lx = e.X;
                ly = e.Y;
                pictureBox.Invalidate();
            }
        }
    }
}
