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

        private Image imgZoom;
        private Image imgOrig;
        private int Xold = 0, Yold = 0;
        private int Xnew = 0, Ynew = 0;
        private bool _ZoomOnOff;

        private event System.EventHandler ZoomOnOffHandler; // определение события для 
        private bool ZoomOnOff
        {
            get
            {
                return _ZoomOnOff;
            }

            set
            {
                _ZoomOnOff = value;
                ZoomOnOffHandler?.Invoke(this, EventArgs.Empty); // вызов события
                // ? - проверка на ZoomOnOffHandler != null
            }
        }

        // При загрузке формы
        private void FormMain_Load(object sender, EventArgs e)
        {
            ZoomOnOffHandler += ZoomOnOff_Changed;
            ZoomOnOff = false;
        }

        // кнопка Вращать ПРОТИВ часовой стрелки
        private void btnRotateCounterClockWise_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff) return;
            pictureBox.Image = PictureManager.RotateCounterClockWise(pictureBox.Image);
        }

        // кнопка Вращать ПО часовой стрелки
        private void btnRotateClockWise_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff) return;
            pictureBox.Image = PictureManager.RotateClockWise(pictureBox.Image);
        }

        // кнопка Отобразить по горизонтали
        private void btnFlipHorizontally_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff) return;
            pictureBox.Image = PictureManager.FlipHorizontally(pictureBox.Image);
        }

        // кнопка Отобразить по вертикали
        private void btnFlipVertically_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff) return;
            pictureBox.Image = PictureManager.FlipVertically(pictureBox.Image);
        }

        // кнопка Включить возможность увеличивать уменьшать
        private void btnZoomOnOff_Click(object sender, EventArgs e)
        {
            ZoomOnOff = !ZoomOnOff;
        }

        // кнопка Отобразить фото по размеру окна
        private void btnZoom100_Click(object sender, EventArgs e)
        {
            if (!ZoomOnOff) return;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // кнопка Увеличить
        private void btnZoomIn_Click(object sender, EventArgs e)
        {

        }

        // кнопка Уменьшить
        private void btnZoomOut_Click(object sender, EventArgs e)
        {

        }

        // событие при изменении значения переменной ZoomOnOff
        private void ZoomOnOff_Changed(object sender, EventArgs e)
        {
            if(ZoomOnOff) // если включили изменение размера
            {
                btnZoomOnOff.Text = "Вкл.\noom";
                btnRotateCounterClockWise.Cursor = Cursors.No;
                btnRotateClockWise.Cursor = Cursors.No;
                btnFlipHorizontally.Cursor = Cursors.No;
                btnFlipVertically.Cursor = Cursors.No;
                btnZoom100.Cursor = Cursors.Hand;
                btnZoomIn.Cursor = Cursors.Hand;
                btnZoomOut.Cursor = Cursors.Hand;
            }
            else
            {
                btnZoomOnOff.Text = "Вкл.\nZoom";
                btnRotateCounterClockWise.Cursor = Cursors.Hand;
                btnRotateClockWise.Cursor = Cursors.Hand;
                btnFlipHorizontally.Cursor = Cursors.Hand;
                btnFlipVertically.Cursor = Cursors.Hand;
                btnZoom100.Cursor = Cursors.No;
                btnZoomIn.Cursor = Cursors.No;
                btnZoomOut.Cursor = Cursors.No;
            }
        }

        // обработчик отрисовки картинки в режиме изменения размера
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (ZoomOnOff == true && imgZoom != null)
                e.Graphics.DrawImage(imgZoom, Xnew, Ynew);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Обработка нажатия мыши по pictureBox
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Xold = e.X;
            Yold = e.Y;
        }

        // Обработка перемещения картинки по pictureBox
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (ZoomOnOff == true && e.Button == MouseButtons.Left)
            {
                int dx = e.X - Xold;
                int dy = e.Y - Yold;
                Xnew += dx;
                Ynew += dy;
                Xold = e.X;
                Yold = e.Y;
                pictureBox.Invalidate();
            }
        }
    }
}
