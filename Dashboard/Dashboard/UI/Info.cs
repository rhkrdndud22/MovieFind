using Dashboard.handler;
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
             
            
            adapter.selectdbn(st);
        }
    }
}
