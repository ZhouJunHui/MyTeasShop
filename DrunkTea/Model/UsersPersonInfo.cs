using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class UsersPersonInfo
    {
        public int Uid { get; set; }
        public string LoginName { get; set; }
        public string Pwd { get; set; }
        public int PerId { get; set; }
        public string Uname { get; set; } 
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string ImgPath { get; set; }

    }
}
