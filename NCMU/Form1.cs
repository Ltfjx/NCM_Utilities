using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NCM_Utilities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Rootobject SongJson;
        public void GetInfo(object sender, EventArgs e) //按钮：获取
        {
            string SongID;
            string SongInfoInput = SongInfoInputBox.Text;
            if (SongInfoInput.Contains("?"))
            {
                string[] temp1 = SongInfoInput.Split('&');
                string[] temp2 = temp1[0].Split('=');
                SongID = temp2[1];
                SingleSongData.Rows.Add("ID", SongID);
            }
            else
            {
                if (Utilities.IfStringIsNum(SongInfoInput))
                {
                    SongID = SongInfoInput;
                    SingleSongData.Rows.Add("ID", SongInfoInput);
                }
                else
                {
                    MessageBox.Show("地址/ID输入不合法！");
                    return;
                }
            }
            string url = "https://music.163.com/api/song/detail/?id=" + SongID + "&ids=%5B" + SongID + "%5D&csrf_token=";
            string jsonText = Utilities.GetPostReturn(url);
            SongJson = (Rootobject)JsonConvert.DeserializeObject(jsonText, typeof(Rootobject));

            SingleSongData.Rows.Add("曲名", SongJson.songs[0].name);

            string transname = "";
            for (int i = 0; i < SongJson.songs[0].transNames.Length; i++)
            {
                if (i != 0) { transname += " / "; }
                transname += SongJson.songs[0].transNames[i];
            }
            SingleSongData.Rows.Add("译名", transname);

            string alias = "";
            for (int i = 0; i < SongJson.songs[0].alias.Length; i++)
            {
                if (i != 0) { alias += " / "; }
                alias += SongJson.songs[0].alias[i];
            }
            SingleSongData.Rows.Add("描述", alias);

            string artist = "";
            for (int i = 0; i < SongJson.songs[0].artists.Length; i++)
            {
                if (i != 0) { artist += " / "; }
                artist += SongJson.songs[0].artists[i].name;
            }
            SingleSongData.Rows.Add("歌手", artist);

            SingleSongData.Rows.Add("专辑", SongJson.songs[0].album.name);

            SingleSongData.Rows.Add("来源", SongJson.songs[0].album.company);

            //获取图片
            PicBox_SongCover.Image = Image.FromStream(WebRequest.Create(SongJson.songs[0].album.picUrl).GetResponse().GetResponseStream());



        }

        private void button_SavePic_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = SongJson.songs[0].name;
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "*.jpg|*.jpg";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Utilities.WriteBytesToFile(saveFileDialog1.FileName, Utilities.GetBytesFromUrl(SongJson.songs[0].album.picUrl));
            }
            
        }
    }


}
