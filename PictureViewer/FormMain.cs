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
        private int isMouseLeftButton = 1; // 1 Left, 0 Right

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
            // добавили слушатель к изменению переключателя
            ZoomOnOffHandler += ZoomOnOff_Changed;
            ZoomOnOff = false;
            RefreshListBoxImages();
        }

        // Обновление списка файлов справа
        private void RefreshListBoxImages()
        {
            btnSaveImageChange.Visible = false;
            ZoomOnOff = false;
            pictureBox.Image = null;
            listBoxImages.Items.Clear();
            try
            {
                string response = "";
                int countFiles = 0;
                string code = DataManager.SendRequestAndGetResponce(DataManager.CreateGetListRequest(), out response);
                if (code == "200")
                {
                    string[] fileNames;
                    string error = "";
                    countFiles = DataManager.ParseResponseGetList(response, out fileNames, out error);
                    if (countFiles < 0)
                        MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else if (countFiles == 0)
                        MessageBox.Show("На сервере пока нет ни одной картинки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                    {
                        foreach (string item in fileNames)
                            listBoxImages.Items.Add(item);

                        //if (listBoxImages.Items.Count > 0)
                        //    listBoxImages.SelectedIndex = 0;
                    }
                }
                else
                {
                    response = DataManager.ParseResponseMessageeAndError(response);
                    string text = "Код ошибки: " + code + Environment.NewLine + "Текст ошибки: " + Environment.NewLine + response;
                    MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // кнопка Вращать ПРОТИВ часовой стрелки
        private void btnRotateCounterClockWise_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff || pictureBox.Image == null) return;
            pictureBox.Image = PictureManager.RotateCounterClockWise(pictureBox.Image);
            btnSaveImageChange.Visible = true;
        }

        // кнопка Вращать ПО часовой стрелки
        private void btnRotateClockWise_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff || pictureBox.Image == null) return;
            pictureBox.Image = PictureManager.RotateClockWise(pictureBox.Image);
            btnSaveImageChange.Visible = true;
        }

        // кнопка Отобразить по горизонтали
        private void btnFlipHorizontally_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff || pictureBox.Image == null) return;
            pictureBox.Image = PictureManager.FlipHorizontally(pictureBox.Image);
            btnSaveImageChange.Visible = true;
        }

        // кнопка Отобразить по вертикали
        private void btnFlipVertically_Click(object sender, EventArgs e)
        {
            if (ZoomOnOff || pictureBox.Image == null) return;
            pictureBox.Image = PictureManager.FlipVertically(pictureBox.Image);
            btnSaveImageChange.Visible = true;
        }

        // кнопка Включить возможность увеличивать уменьшать
        private void btnZoomOnOff_Click(object sender, EventArgs e)
        {
            if (!ZoomOnOff && pictureBox.Image == null) return;
            ZoomOnOff = !ZoomOnOff;
        }

        // кнопка Увеличить
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (!ZoomOnOff || imgZoom == null) return;
            imgZoom = PictureManager.ZoomIn(imgZoom);
            pictureBox.Invalidate();
        }

        // кнопка Уменьшить
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (!ZoomOnOff || imgZoom == null) return;
            imgZoom = PictureManager.ZoomOut(imgZoom);
            pictureBox.Invalidate();
        }

        // событие при изменении значения переменной ZoomOnOff
        private void ZoomOnOff_Changed(object sender, EventArgs e)
        {
            if(ZoomOnOff) // если включено изменение масштаба (Zoom)
            {
                btnZoomOnOff.Text = "Выключить режим масштаба"+ Environment.NewLine+"------->";
                btnRotateCounterClockWise.Cursor = Cursors.No;
                btnRotateClockWise.Cursor = Cursors.No;
                btnFlipHorizontally.Cursor = Cursors.No;
                btnFlipVertically.Cursor = Cursors.No;
                btnZoomIn.Cursor = Cursors.Hand;
                btnZoomOut.Cursor = Cursors.Hand;
                btnAddNewImage.Enabled = false;
                btnRefreshList.Enabled = false;
                listBoxImages.Enabled = false;
                MenuImageSaveLocal.Enabled = false;
                btnSaveImageChange.Visible = false;
                // отрисовка в pictureBox изображения
                Xold = 0; Yold = 0;
                Xnew = 0; Ynew = 0;
                pictureBox.Image = null;
                imgZoom = imgOrig;
                pictureBox.Invalidate();
            }
            else
            {
                btnZoomOnOff.Text = "Включить режим масштаба" + Environment.NewLine + "------->";
                btnRotateCounterClockWise.Cursor = Cursors.Hand;
                btnRotateClockWise.Cursor = Cursors.Hand;
                btnFlipHorizontally.Cursor = Cursors.Hand;
                btnFlipVertically.Cursor = Cursors.Hand;
                btnZoomIn.Cursor = Cursors.No;
                btnZoomOut.Cursor = Cursors.No;
                btnAddNewImage.Enabled = true;
                btnRefreshList.Enabled = true;
                listBoxImages.Enabled = true;
                MenuImageSaveLocal.Enabled = true;
                btnSaveImageChange.Visible = false;
                // обратно возвращаем в pictureBox исходное изображение
                pictureBox.Image = imgOrig;
                imgZoom = null;
            }
        }

        // обработчик отрисовки картинки в режиме изменения размера
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (ZoomOnOff == true && imgZoom != null)
                e.Graphics.DrawImage(imgZoom, Xnew, Ynew);
        }

        // Вывод информации об авторах
        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Студенты группы ПМИМ-01:" + Environment.NewLine + "Наи Сора" + Environment.NewLine + "Орлов Михаил";
            MessageBox.Show(text, "Разработчики", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        // кнопка Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // кнопка Обновить список
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshListBoxImages();
        }

        // Выбор изображения из списка - отображение в PictureBox
        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.Items.Count > 0 && listBoxImages.SelectedIndex >= 0 && isMouseLeftButton == 1)
            {
                listBoxImages.Cursor = Cursors.WaitCursor;
                pictureBox.Cursor = Cursors.WaitCursor;

                string name = listBoxImages.SelectedItem.ToString();
                pictureBox.Image = null;

                try
                {
                    string response = "";
                    bool result = false;
                    Image img;
                    string code = DataManager.SendRequestAndGetResponce(DataManager.CreateGetImageRequest(name), out response);
                    if (code == "200")
                    {
                        string[] fileNames;
                        string error = "";
                        result = DataManager.ParseResponseGetImage(response, out img, out error);
                        if (result == false)
                            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        else
                        {
                            pictureBox.Image = img;
                            imgOrig = img;
                        }
                    }
                    else
                    {
                        response = DataManager.ParseResponseMessageeAndError(response);
                        string text = "Код ошибки: " + code + Environment.NewLine + "Текст ошибки: " + Environment.NewLine + response;
                        MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            listBoxImages.Cursor = Cursors.Arrow;
            pictureBox.Cursor = Cursors.Arrow;
        }

        // ПКМ Сохранить изображение локально
        private void MenuImageSaveLocal_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Выберите место для сохранения изображения";
                sfd.InitialDirectory = Application.StartupPath;
                sfd.FileName = "pic.gif";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {

                    Utility.ImageObjectSave(pictureBox.Image, sfd.FileName);
                    MessageBox.Show("Изображение сохранено по пути:" + Environment.NewLine + sfd.FileName, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        // кнопка ПЛЮС (добавить картинку на сервер)
        private void btnAddNewImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(*.png; *.jpeg; *.jpg; *.bmp)|*.png;*.jpeg;*.jpg;*.bmp|All files(*.*)|*.*";
            ofd.Title = "Выберите изображение для загрузки на сервер";
            ofd.InitialDirectory = Application.StartupPath;

            if(ofd.ShowDialog(this) == DialogResult.OK)
            {
                string name = ofd.FileName; // полный путь
                name = name.Substring(name.LastIndexOf("\\") + 1); // оставили только имя

                listBoxImages.Cursor = Cursors.WaitCursor;
                pictureBox.Cursor = Cursors.WaitCursor;

                try
                {
                    string response = "";
                    Image img = Image.FromFile(ofd.FileName);
                    string code = DataManager.SendRequestAndGetResponce(DataManager.CreatePostNewRequest(name, img), out response);
                    if (code == "200")
                    {
                        response = DataManager.ParseResponseMessageeAndError(response);

                        // после успешной загрузки на сервер обновить список файлов 
                        btnRefreshList_Click(null, null);

                        MessageBox.Show(response, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        response = DataManager.ParseResponseMessageeAndError(response);
                        string text = "Код ошибки: " + code + Environment.NewLine + "Текст ошибки: " + Environment.NewLine + response;
                        MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                listBoxImages.Cursor = Cursors.Arrow;
                pictureBox.Cursor = Cursors.Arrow;
            }
        }

        // кнопка Сохранить изменения на сервер
        private void btnSaveImageChange_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            listBoxImages.Cursor = Cursors.WaitCursor;
            pictureBox.Cursor = Cursors.WaitCursor;

            try
            {
                string name = listBoxImages.SelectedItem.ToString();
                string response = "";
                string code = DataManager.SendRequestAndGetResponce(DataManager.CreatePutEditRequest(name, pictureBox.Image), out response);
                if (code == "200")
                {
                    response = DataManager.ParseResponseMessageeAndError(response);
                    MessageBox.Show(response, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    imgOrig = pictureBox.Image;
                    btnSaveImageChange.Visible = false;
                }
                else
                {
                    response = DataManager.ParseResponseMessageeAndError(response);
                    string text = "Код ошибки: " + code + Environment.NewLine + "Текст ошибки: " + Environment.NewLine + response;
                    MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            listBoxImages.Cursor = Cursors.Arrow;
            pictureBox.Cursor = Cursors.Arrow;
        }

        // нажатие мышью по ListBox для определения кнопки нажатой
        private void listBoxImages_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseLeftButton = 1;
            else if (e.Button == MouseButtons.Right)
            {
                isMouseLeftButton = 0;
                listBoxImages.SelectedIndex = listBoxImages.IndexFromPoint(e.Location);
            }
            else
                isMouseLeftButton = -1;
        }

        // Контекстная кнопка Удалить с сервера
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBoxImages.Items.Count > 0 && listBoxImages.SelectedIndex >= 0 && isMouseLeftButton == 0)
            {
                string name = listBoxImages.SelectedItem.ToString();

                listBoxImages.Cursor = Cursors.WaitCursor;
                pictureBox.Cursor = Cursors.WaitCursor;

                try
                {
                    string response = "";
                    string code = DataManager.SendRequestAndGetResponce(DataManager.CreatePutDeleteRequest(name), out response);
                    if (code == "200")
                    {
                        response = DataManager.ParseResponseMessageeAndError(response);

                        // после успешного удаления с сервера обновить список файлов 
                        btnRefreshList_Click(null, null);

                        MessageBox.Show(response, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        response = DataManager.ParseResponseMessageeAndError(response);
                        string text = "Код ошибки: " + code + Environment.NewLine + "Текст ошибки: " + Environment.NewLine + response;
                        MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                listBoxImages.Cursor = Cursors.Arrow;
                pictureBox.Cursor = Cursors.Arrow;
            }
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
