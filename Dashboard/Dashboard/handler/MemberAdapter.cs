using Dashboard.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.handler
{
    class MemberAdapter
    {
        private List<Member> memberList = new List<Member>();
        private OracleHandler ora;

        public MemberAdapter(OracleHandler ora)
        {
            this.ora = ora;
        }
        public void addMember(Member member)
        {
            memberList.Add(member);
        }
        public void viewMember(Member member)
        {
            
        }
        public void addReceiptDb()
        {
            for (int i = 0; i < memberList.Count; i++)
            {
                ora.insertdb(memberList[i]);
            }
            memberList.Clear();

        }
        public void selectdb()
        {
            for (int i = 0; i < memberList.Count; i++)
            {
                ora.selectid(memberList[i]);
            }
            memberList.Clear();
        }
    }
}
