﻿using Dashboard.handler;
using Dashboard.model;
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

     partial class Myinfochild1 : Form
    {
        public static string star_id;
        MemberAdapter adapter;
        /* Bitmap noimage = new Bitmap("./noimage.png");*/

        public Myinfochild1()
        {
            InitializeComponent();
        }

        public Myinfochild1(MemberAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (moviesearch.Text == "")
            {
                MessageBox.Show("검색어를 입력해주세요!");
            }
            else
            {
                string query = "https://openapi.naver.com/v1/search/movie.xml?query=" + moviesearch.Text ;

                string client_id = "X2_dnHMYL3zNMJNaj1Mq";
                string client_secret = "icRzvX9KSX";
                string your_client_id = client_id;
                string your_client_secret = client_secret;

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
                OracleHandler.movie_id = movietitle.Text;
                subtitle.Text = listView1.SelectedItems[0].SubItems[3].Text;
                open.Text = listView1.SelectedItems[0].SubItems[4].Text;
                director.Text = listView1.SelectedItems[0].SubItems[5].Text;
                actor.Text = actor.Text = listView1.SelectedItems[0].SubItems[6].Text;
                string act;
                string dir;
                if (director.Text =="")
                {
                    director.Text = listView1.SelectedItems[0].SubItems[5].Text;
                    dir= listView1.SelectedItems[0].SubItems[5].Text;

                }
                else
                {
                    director.Text = listView1.SelectedItems[0].SubItems[5].Text.Substring(0, 3);
                     dir= listView1.SelectedItems[0].SubItems[5].Text.Substring(0, 3);
                }
               
                
                if (actor.Text =="")
                {
                    actor.Text = listView1.SelectedItems[0].SubItems[6].Text;
                    act= listView1.SelectedItems[0].SubItems[6].Text;

                }
             
                
                else {
                    actor.Text = listView1.SelectedItems[0].SubItems[6].Text.Substring(0, 3);
                    act= listView1.SelectedItems[0].SubItems[6].Text.Substring(0, 3);
                }
                starpoint.Text = listView1.SelectedItems[0].SubItems[7].Text;
                string image_path = listView1.SelectedItems[0].SubItems[2].Text;
                string stars = starpoint.Text;/*string.Join("",starpoint.Text.Split('"'));*/
                string title = movietitle.Text;
                
               

                adapter.addmovie(new Movie(title, stars, dir, act));
               
                adapter.addmoviedb();


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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string title = movietitle.Text;
            string evol = evoT.Text;
            if (title != "")
            {


                if (evol != "")
                {
                    if (starPBox1.SelectedText != "")
                    {

                        double point = Convert.ToDouble(starPBox1.SelectedText);

                        string id = star_id;
                        adapter.addstar(new Star(id, title, point, evol));
                        adapter.addstardb();
                    }
                    else
                    {
                        MessageBox.Show("별점 선택해주세요");
                    }

                }
                else
                {
                    MessageBox.Show("한줄평을 적어주세요");
                }
            }
            else
            {
                MessageBox.Show("영화를 선택해주세요");
            }
        }
    }
}