using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public class PersonalInfoManager
    {
        PersonalInfoService dal = new PersonalInfoService();
        //修改个人信息
        public bool Update(UsersPersonInfo Info)
        {
            return dal.Update(Info);
        }
    }
}
