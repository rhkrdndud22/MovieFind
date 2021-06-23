using Dashboard.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.handler
{
    class ReceiptAdapter
    {
        private List<member> receiptList = new List<member>();

        public void addMember(Member member)
        {
            receiptList.Add(member);
        }
        public void viewMember(Member member)
        {
            Console.WriteLine("고객 이름 :" + receipt.Login.Id);
            Console.WriteLine("고객 전화번호 :" + receipt.Login.Password);
            Console.WriteLine("고객 생년월일: " + receipt.Member.Name);
            Console.WriteLine("차 번호 : " + receipt.Member.Tel);
            Console.WriteLine("차 배기량 :" + receipt.Member.Birth);
            Console.WriteLine("차 연식 :" + receipt.Genre.Mgenre);
            Console.WriteLine("차 모델명 :" + receipt.Genre.Hgenre);
            
        }
    }
}
