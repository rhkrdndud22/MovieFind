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
    public partial class Conditionsearch : Form
    {
       /* Bitmap noimage = new Bitmap("./noimage.png");*/
        public Conditionsearch()
        {
            InitializeComponent();
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {




            if (movieS.Text == "")
            {
                MessageBox.Show("검색어를 입력해주세요!");
            }
            else
            {
                /*try
                {*/
                    string query1 = "https://openapi.naver.com/v1/search/movie.xml?query=" + movieS.Text + "&display=100&start=1&genre=" 
                    + genreBox.SelectedText + "&country=" + CountryBox.SelectedText.Substring(0, 2) + "&yearfrom=" + yearFBox.Text + "&yearto=" + yearABox.Text;

                    

                    string client_id = "X2_dnHMYL3zNMJNaj1Mq";
                    string client_secret = "icRzvX9KSX";
                    string your_client_id = client_id;
                    string your_client_secret = client_secret;

                    WebRequest wrq = WebRequest.Create(query1);
                    wrq.Method = "GET";
                    //X-Naver-Client-Id
                    //X-Naver-Client-Secret
                    wrq.Headers.Add("X-Naver-Client-Id", your_client_id);
                    wrq.Headers.Add("X-Naver-Client-Secret", your_client_secret);

                    WebResponse wrs = wrq.GetResponse();
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
                    searchview.Items.Clear();

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

                        searchview.Items.Add(lvi);
                        //richTextBox1.Text += xn.ChildNodes[i]["title"].InnerText.Replace("<b>", "").Replace("</b>", "") + "\n";
                    }
            /*    }*/
               /* catch
                {
                    MessageBox.Show("연도를 제대로 입력해주세요");
                }*/
}
            
        }

        private void searchview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchview.SelectedItems.Count == 1)
            {
                string image_path = searchview.SelectedItems[0].SubItems[2].Text;
                if (image_path != "")
                {
                    movieimage.Load(image_path);
                }
                else
                {
                    movieimage.Image = null;
                }
                image_path = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
