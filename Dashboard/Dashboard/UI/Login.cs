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
    public partial class LoginForm : Form
    {
        OracleHandler ora;
        MemberAdapter adapter;
        
        public LoginForm()
        {
            InitializeComponent();
            ora = new OracleHandler();
            adapter = new MemberAdapter(ora);
        }

       

       

        

        private void Login_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            Search.star_id = textBox1.Text;
            Info.name = textBox1.Text;
            Form1.name = textBox1.Text;
            string password = textBox2.Text;
            adapter.logindb(id, password);
        }

        private void newID_Click(object sender, EventArgs e)
        {
            new Form3(adapter).ShowDialog();

            adapter.addReceiptDb();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
