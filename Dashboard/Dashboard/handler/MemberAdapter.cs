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

        public void addMember(Member member)
        {
            memberList.Add(member);
        }
        public void viewMember(Member member)
        {
            
        }
    }
}
