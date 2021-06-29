using Dashboard.handler;
using Dashboard.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form2 : Form
    {
        OracleHandler ora;
        MemberAdapter adapter;
        
        public Form2()
        {
            InitializeComponent();
            ora = new OracleHandler();
            adapter = new MemberAdapter(ora);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new Form3(adapter).ShowDialog();
            
                adapter.addReceiptDb();
         
              



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            Search.star_id = textBox1.Text;
            Info.name = textBox1.Text;
            Form1.name = textBox1.Text;
                string password = textBox2.Text;
                adapter.logindb(id,password);
           
            
                
            
            
        }
    }
}
