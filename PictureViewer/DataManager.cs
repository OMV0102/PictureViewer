using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PictureViewer
{
    public class DataManager
    {
        DataManager() { }

        DataManager(string ip, int port)
        {
            this.ipServer = ip;
            this.portServer = port;

        }

        public TcpClient client;
        private string ipServer = "127.0.0.1";
        private int portServer = 3333;

        // Соединение
        public bool Connect()
        {
            this.client = new TcpClient(this.ipServer, this.portServer);
            return client.Connected; ;
        }

        // Отправка запроса и получение ответа
        public static string SendRequestAndGetResponce(string message, out string response)
        {
            response = "";
            DataManager dm = null;
            try
            {
                dm = new DataManager();
                dm.Connect();

                // Отправка сообщения
                message += "\r\n\r\n";
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                dm.client.GetStream().Write(bytes, 0, bytes.Length);

                Thread.Sleep(1000);

                // Получение ответа

                // Объявим строку, в которой будет хранится запрос клиента
                string Responce = "";
                // Буфер для хранения принятых от клиента данных
                byte[] Buffer = new byte[4096];
                // Переменная для хранения количества байт, принятых от клиента
                int Count;
                // Читаем из потока клиента до тех пор, пока от него поступают данные
                while ((Count = dm.client.GetStream().Read(Buffer, 0, Buffer.Length)) > 0)
                {
                    // Преобразуем эти данные в строку и добавим ее к переменной Request
                    Responce += Encoding.UTF8.GetString(Buffer, 0, Count);
                    // Запрос должен заканчиваться последовательностью \r\n\r\n
                    if (Responce.IndexOf("\r\n\r\n") >= 0/* || Request.Length > 4096*/)
                    {
                        break;
                    }
                }
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                dm.client.Close();
            }

            return response;
        }

        // запрос // Получить картинку по имени
        public static string CreateGetImageRequest(string name)
        {
            string request = "GET IMAGE " + Utility.Base64EncodeString(name);
            return request;
        }

        // запрос // Получить список имен файлов и их количество
        public static string CreateGetListRequest(string name)
        {
            string request = "GET LIST";
            return request;
        }

        // запрос // Сохранить изменную картинку по имени
        public static string CreatePutEditRequest(string name, Image img)
        {
            string ext = name.Substring(name.LastIndexOf("."));
            name = Utility.Base64EncodeString(name);
            string request = "PUT EDIT " + name + " ";
            request += Utility.Base64EncodeBytes(Utility.ImageObjectToBytes(img, ext));
            return request;
        }

        // запрос // Удалить картинку по имени
        public static string CreatePutDeleteRequest(string name)
        {
            string request = "PUT DELETE " + Utility.Base64EncodeString(name);
            return request;
        }

        // запрос // Загрузить на сервер новую картинку
        public static string CreatePostNewRequest(string path)
        {
            string name = path.Substring(path.LastIndexOf("\\")); // имя картинки
            name = Utility.Base64EncodeString(name); // имя картинки вBase64
            string imgBase64 = Utility.Base64EncodeBytes(Utility.ImageFileToBytes(path));

            string request = "POST NEW " + name + " " + imgBase64;
            return request;
        }
    }
}
