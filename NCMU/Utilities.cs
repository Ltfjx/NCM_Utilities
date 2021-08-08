using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NCM_Utilities
{
    class Utilities
    {
        public static string GetPostReturn(string url)
        {
            

            byte[] data = Encoding.UTF8.GetBytes("");//参数

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0"; //添加头
            myRequest.Method = "POST";//请求类型 Get,Post....
            myRequest.ContentType = "application/xml;charset=UTF-8";//内容格式



            myRequest.ContentLength = data.Length;

            Stream newStream = myRequest.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();


            HttpWebResponse myResponse = myRequest.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            return content;
        }


        public static bool IfStringIsNum(string String)
        {
            try
            {
                int var1 = Convert.ToInt32(String);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public byte[] GetBytesFromUrl(string url)
        {
            byte[] b;
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(url);
            WebResponse myResp = myReq.GetResponse();

            Stream stream = myResp.GetResponseStream();
            //int i;
            using (BinaryReader br = new BinaryReader(stream))
            {
                //i = (int)(stream.Length);
                b = br.ReadBytes(500000);
                br.Close();
            }
            myResp.Close();
            return b;

        }

        static public void WriteBytesToFile(string fileName, byte[] content)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);
            try
            {
                w.Write(content);
            }
            finally
            {
                fs.Close();
                w.Close();
            }

        }



    }
}
