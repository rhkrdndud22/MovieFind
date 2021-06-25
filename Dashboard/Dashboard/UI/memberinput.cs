using Dashboard.handler;
using Dashboard.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
     partial class Form3 : Form
    { MemberAdapter adapter;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(MemberAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = memID.Text;
            string password = memP.Text;
            string name = memN.Text;
            string telF = memTF.SelectedText;
            string telB = memTB.Text;
            string birthY = memY.SelectedText;
            string birthM = memM.SelectedText;
            string birthD = memD.SelectedText;
            string Mgenre = memMgenre.Text;
            string Hgenre = memHgenre.Text;

            string[] arrData = new string[] { id, password, name, telF, telB, birthY,birthM,birthD, Mgenre, Hgenre };
            object[] arrObj = new object[] { memID, memP,memN,memTF,memTB,memY,memM,memD,memMgenre,memHgenre };
            string[] arrS = new string[] { "아이디 안적음", "비밀번호 안적음", "이름 안적음", "전화번호 앞자리 없음", "전화번호 뒷자리 없음", "생년 안적음", "월 안적음", "일 안적음", " 선호하는 장르선택안함", "싫어하는 장르 선택안함" };
           
            Dictionary<object, string> dicinput = new Dictionary<object, string>();
            for (int i = 0; i < arrData.Length; i++)
            {
                dicinput.Add(arrObj[i], arrData[i]);
            }
          
             int cnt = 0;
            foreach(KeyValuePair<object,string> item in dicinput)
                {
                if(item.Value.Equals("")|| item.Value.Equals("선택"))
                {
                    MessageBox.Show(arrS[cnt]);
                    ActiveControl = item.Key as Control;
                    ActiveControl.Focus();
                    return;
                }

                cnt++;
            }
           //이름 제한걸기
            string chkName = Regex.Replace(name, @"[^가-힣]", "");

            if (chkName.Length != name.Length)
            {
                MessageBox.Show("잘못된 이름 형식");
                return;
            }
            //아이디 제한걸기
            string chkID = Regex.Replace(id,@"^[0-9a-zA-Z]{1,100}$","");
            if (chkID.Length == id.Length)
            {
                MessageBox.Show("잘못된 아이디 형식");
                return;
            }

            //전화번호 제한 걸기
            string telALL = telF+ telB;
            if (telALL.Length == 10 || telALL.Length == 11)
            {
                Regex regex0 = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
                Match a = regex0.Match(telALL);
                if (a.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호입니다");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 자리수를 입력하세요");
                ActiveControl = memTB;
                ActiveControl.Focus();
                return;
            }

           
                adapter.addMember(new Member(id, password, name, telF + telB, (birthY + birthM + birthD), Mgenre, Hgenre));
               
            
          
             
            
            MessageBox.Show("회원가입이 완료 되었습니다");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter.selectdb();
        }
    }
}
