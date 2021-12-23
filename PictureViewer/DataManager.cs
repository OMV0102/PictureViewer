using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        //public string ipServer = "192.168.0.2";
        public string ipServer = "127.0.0.1";
        public int portServer = 3333;

        // Соединение
        public bool Connect()
        {
            // создание клиента и подключение
            this.client = new TcpClient(this.ipServer, this.portServer);
            return client.Connected; ;
        }

        // Отправка запроса и получение ответа
        public static string SendRequestAndGetResponce(string request, out string Responce)
        {
            // Объявим строку, в которой будет хранится запрос клиента
            Responce = "";
            DataManager dm = null;
            string code = "";
            try
            {
                dm = new DataManager();
                if (dm.Connect() == false)
                    throw new Exception("Не удалось установить соединение с " + dm.ipServer + ":" + dm.portServer);

                // Отправка сообщения
                request += " \r\n\r\n";
                byte[] bytes = Encoding.UTF8.GetBytes(request); // сообщений в байты
                dm.client.GetStream().Write(bytes, 0, bytes.Length); // послали

                Thread.Sleep(1000);

                // Получение ответа
                // Буфер для хранения принятых от клиента данных
                byte[] Buffer = new byte[10000000];
                // Переменная для хранения количества байт, принятых от клиента
                int Count;
                Stopwatch stopWatch = new Stopwatch(); // замер времени
                stopWatch.Start();
                // Читаем из потока клиента до тех пор, пока от него поступают данные
                while ((Count = dm.client.GetStream().Read(Buffer, 0, Buffer.Length)) > 0)
                {
                    // Преобразуем эти данные в строку и добавим ее к переменной Request
                    Responce += Encoding.UTF8.GetString(Buffer, 0, Count);
                    // Запрос должен заканчиваться последовательностью \r\n\r\n
                    // DataAvailable указывает, имеются ли в потоке данные, доступные для чтения.
                    if (Responce.IndexOf("\r\n\r\n") >= 0 || !dm.client.GetStream().DataAvailable)
                    {
                        break;
                    }
                    stopWatch.Stop();
                    //if (stopWatch.Elapsed.TotalSeconds > 15.0)
                    //{
                    //    throw new Exception("Превышен таймаут ожидания ответа!");
                    //}
                    stopWatch.Start();
                }

                string[] words = Responce.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                code = words[0];

                Responce = "";
                for (int i = 1; i < words.Length; i++)
                    Responce += words[i] + " ";

            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                if(dm.client != null)
                    dm.client.Close();
            }

            return code;
        }

        // запрос // Получить картинку по имени
        public static string CreateGetImageRequest(string name)
        {
            string request = "GET IMAGE " + Utility.Base64EncodeString(name);
            return request;
        }

        // ответ (парсинг) // Получить картинку по имени
        public static bool ParseResponseGetImage(string response, out Image img, out string error)
        {
            // вид ответа response: Base64_данные
            img = null;
            error = "";
            try
            {
                byte[] bytes = Utility.Base64DecodeBytes(response);
                img = Utility.BytesToImageObject(bytes);
            }
            catch(Exception err)
            {
                error = "Произошла ошибка при парсинге изображения из формата Base64!";
                return false;
            }

            return true;
        }

        // запрос // Получить список имен файлов и их количество
        public static string CreateGetListRequest()
        {
            string request = "GET LIST";
            return request;
        }

        // ответ (парсинг) // Получить картинку по имени
        public static int ParseResponseGetList(string response, out string[] fileNames, out string error)
        {
            // вид ответа response: количество_файлов разделитель_списка_имен Base64_список
            fileNames = new string[0] { };
            int count = -1;
            error = "";
            try
            {
                // распарсили запрос по пробелу
                string[] words = response.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                count = Int32.Parse(words[0]); // смотрим количество файлов
                if (count <= 0) 
                    return count;
                else if (count > 0)
                {
                    // переводим из Base64 в обычную строку список
                    string fileNamesString = Utility.Base64DecodeString(words[2]);
                    // парсим список файлов по указанному разделителю (на сервере = используется)
                    fileNames = fileNamesString.Split(new string[1] { words[1] }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            catch (Exception err)
            {
                error = "Произошла ошибка при парсинге списка имен файлов из формата Base64!";
                return -1;
            }

            return count;
        }

        // ответ (парсинг) // для трех запросов EDIT DELETE NEW, т.к. в ответе только передается сообщение в Base64
        public static string ParseResponseMessageeAndError(string response)
        {
            // вид ответа response: Сообщение_Base64
            try
            {
                response = Utility.Base64DecodeString(response);
            }
            catch (Exception err)
            {
                return "Произошла ошибка при парсинге сообщения из формата Base64!";
            }

            return response;
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
        public static string CreatePostNewRequest(string name, Image img)
        {
            string ext = name.Substring(name.LastIndexOf("."));
            name = Utility.Base64EncodeString(name);

            string request = "POST NEW " + name + " ";
            request += Utility.Base64EncodeBytes(Utility.ImageObjectToBytes(img, ext));
            return request;
        }
    }
}
