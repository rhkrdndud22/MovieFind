using Dashboard.handler;
using Dashboard.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.UI
{
     partial class Info : Form
    {   public static string name;
        public static string na;
        public static string gen;
        public static string sp;
        handler.MemberAdapter adapter;
        public Info()
        {
            InitializeComponent();
            
        }

        public Info(MemberAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Info_Load(object sender, EventArgs e)
        {   string st = name;
            
             adapter.selectdbn(name);
            nameL.Text = na;
            adapter.selectgen(name);
            genL.Text = gen;
            adapter.selectstar(name);
            starP.Text = sp;

            DataTable dt=adapter.selectmovie();
            Movieview.DataSource = dt;

            DataTable da = adapter.selectpoint(name);
            StarpointView.DataSource = da;
            
        }
        
    }
}
