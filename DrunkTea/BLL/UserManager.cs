using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class UserManager
    {
        UserService dal = new UserService();
        //用户注册
        public bool User_Add(UsersPersonInfo model)
        {
            return dal.User_Add(model);
        }

        //查询用户信息根据登陆账号
        public UsersPersonInfo User_GetListByLoginName(string LoginName)
        {
            return dal.User_GetListByLoginName(LoginName);
        }
        //通过id查询用户信息
        public UsersPersonInfo Users_PersonInfo_GetListByUid(string Uid)
        {
            return dal.Users_PersonInfo_GetListByUid(Uid);
        }
        //修改密码
        public bool UpdatePwd(string Uid, string PwdNew)
        {
            return dal.UpdatePwd(Uid, PwdNew);
        }  //根据uid查询出对应信息
        public UsersPersonInfo GetList_ByUid(string Uid)
        {
            return dal.GetList_ByUid(Uid);
        }
     }
}
