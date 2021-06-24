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
using System.Xml;

namespace Dashboard.UI
{

    public partial class Myinfochild1 : Form
    {
       /* Bitmap noimage = new Bitmap("./noimage.png");*/

        public Myinfochild1()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (moviesearch.Text == "")
            {
                MessageBox.Show("검색어를 입력해주세요!");
            }
            else
            {
                string query = "https://openapi.naver.com/v1/search/movie.xml?query=" + moviesearch.Text;
                string your_client_id = ClientId.Text;
                string your_client_secret = Clientpassword.Text;

                WebRequest wr = WebRequest.Create(query);
                wr.Method = "GET";
                //X-Naver-Client-Id
                //X-Naver-Client-Secret
                wr.Headers.Add("X-Naver-Client-Id", your_client_id);
                wr.Headers.Add("X-Naver-Client-Secret", your_client_secret);

                WebResponse wrs = wr.GetResponse();
                Stream s = wrs.GetResponseStream();
                StreamReader sr = new StreamReader(s);

                string response = sr.ReadToEnd();

                //richTextBox1.Text = response;

                XmlDocument xd = new XmlDocument();
                xd.LoadXml(response);

                //rss/채널/
                XmlNode xn = xd["rss"]["channel"];

                //0, 3
                

                //원래 리스트뷰에 있던걸 삭제한다!
                listView1.Items.Clear();

                for (int i = 7; i < xn.ChildNodes.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = xn.ChildNodes[i]["title"].InnerText.Replace("<b>", "").Replace("</b>", "");

                    lvi.SubItems.Add(xn.ChildNodes[i]["link"].InnerText);
                    lvi.SubItems.Add(xn.ChildNodes[i]["image"].InnerText);
                    lvi.SubItems.Add(xn.ChildNodes[i]["subtitle"].InnerText);
                    lvi.SubItems.Add(xn.ChildNodes[i]["pubDate"].InnerText);
                    lvi.SubItems.Add(xn.ChildNodes[i]["director"].InnerText);
                    lvi.SubItems.Add(xn.ChildNodes[i]["actor"].InnerText);
                    lvi.SubItems.Add(xn.ChildNodes[i]["userRating"].InnerText);

                    listView1.Items.Add(lvi);
                    //richTextBox1.Text += xn.ChildNodes[i]["title"].InnerText.Replace("<b>", "").Replace("</b>", "") + "\n";
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                //영화제목
                movietitle.Text = listView1.SelectedItems[0].SubItems[0].Text;
                subtitle.Text = listView1.SelectedItems[0].SubItems[3].Text;
                open.Text = listView1.SelectedItems[0].SubItems[4].Text;
                director.Text = listView1.SelectedItems[0].SubItems[5].Text;
                actor.Text = listView1.SelectedItems[0].SubItems[6].Text;
                starpoint.Text = listView1.SelectedItems[0].SubItems[7].Text;
                string image_path = listView1.SelectedItems[0].SubItems[2].Text;
                if (image_path != "")
                {
                    pictureBox1.Load(image_path);
                }
                else
                {
                   /* pictureBox1.Image = noimage;*/
                }
            }
        }
    }
}