using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DBUtility;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class UserService
    {
        //用户注册
         public bool User_Add(UsersPersonInfo model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@Phone",model.Phone),
               new SqlParameter("@Pwd",model.Pwd),
               new SqlParameter("@LoginName",model.LoginName)
            };
            return SqlHelper.ExecuteNonQuery("Users_Add", param);
        }
        //查询用户信息根据登陆账号
        public UsersPersonInfo User_GetListByLoginName(string LoginName)
        {
            UsersPersonInfo  model= null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginName",LoginName)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("Users_GetListByLoginName", param))
            {
                if (dr.Read())
                {
                    model = new UsersPersonInfo();
                    model.LoginName = dr["LoginName"].ToString();
                    model.Uid = Convert.ToInt32(dr["Uid"]);
                    model.Pwd = dr["Pwd"].ToString();
                }
            }
            return model;
        }
        //通过id查询用户信息
        public UsersPersonInfo Users_PersonInfo_GetListByUid(string Uid)
        {
            UsersPersonInfo model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            using (SqlDataReader dr = SqlHelper.ExecuteReader("Users_PersonInfo_GetListByUid", param))
            {
                if (dr.Read())
                {
                    model = new UsersPersonInfo();
                    model.LoginName = dr["LoginName"].ToString();
                    model.Uid = Convert.ToInt32(dr["Uid"]);
                    model.Pwd = dr["Pwd"].ToString();
                    model.PerId = Convert.ToInt32(dr["PerId"]);
                    model.Uname = dr["Uname"].ToString();
                    model.Sex = dr["Sex"].ToString();
                    if (dr["Birthday"]==DBNull.Value)
                    {
                        model.Birthday = null;
                    }
                    else
                       model.Birthday = Convert.ToDateTime(dr["Birthday"]);

                      model.Phone = dr["Phone"].ToString();
                    model.ImgPath = dr["ImgPath"].ToString();
                }
            }
            return model;
        }
        //修改密码
        public bool UpdatePwd(string Uid,string PwdNew)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid),
                new SqlParameter("@PwdNew",PwdNew)
            };
            return SqlHelper.ExecuteNonQuery("UpdatePwd_User", param);
        }
        //根据uid查询出对应信息
        public UsersPersonInfo GetList_ByUid(string Uid)
        {
            UsersPersonInfo model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetList_UserByUid", param))
            {
                if (dr.Read())
                {
                    model = new UsersPersonInfo();
                    model.LoginName = dr["LoginName"].ToString();
                    model.Pwd = dr["Pwd"].ToString();
                    model.Uid = Convert.ToInt32(dr["Uid"]);
                }
            }
            return model;
        }
    }
}
