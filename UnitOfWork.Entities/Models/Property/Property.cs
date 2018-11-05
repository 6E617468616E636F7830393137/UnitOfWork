using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Entities.Models.Property
{
    public class Property
    {
        public int RequestId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string MemberNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Nickname { get; set; }
        public string Sequence { get; set; }
    }
}
