using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureViewer
{
    public class PictureManager
    {
        // Поворот изображанеи ПО часовой стрелке
        public static Image RotateClockWise(Image imgOld)
        {
            Image imgNew = new Bitmap(imgOld.Height, imgOld.Width);
            using (Graphics g = Graphics.FromImage(imgNew))
            {
                g.TranslateTransform((float)imgOld.Height / 2, (float)imgOld.Width / 2);
                g.RotateTransform(90.0f); // поворот на 90 градусов (вправо)
                g.TranslateTransform(-(float)(imgOld.Width / 2), -(float)(imgOld.Height / 2));
                //устанавливаем InterpolationMode на HighQualityBicubic, чтобы обеспечить высокое
                //качество изображения после преобразования до указанного размера 
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgOld, 0, 0);
            }
            return imgNew;
        }

        // Поворот изображанеи ПРОТИВ часовой стрелке
        public static Image RotateCounterClockWise(Image imgOld)
        {
            Image imgNew = new Bitmap(imgOld.Height, imgOld.Width);
            using (Graphics g = Graphics.FromImage(imgNew))
            {
                g.TranslateTransform((float)imgOld.Height / 2, (float)imgOld.Width / 2);
                g.RotateTransform(-90.0f); // поворот на 90 градусов (влево)
                g.TranslateTransform(-(float)(imgOld.Width / 2), -(float)(imgOld.Height / 2));
                //устанавливаем InterpolationMode на HighQualityBicubic, чтобы обеспечить высокое
                //качество изображения после преобразования до указанного размера 
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgOld, 0, 0);
            }
            return imgNew;
        }

        public static Image FlipHorizontally(Image img)
        {
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return img;
        }

        public static Image FlipVertically(Image img)
        {
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return img;
        }
    }
}
