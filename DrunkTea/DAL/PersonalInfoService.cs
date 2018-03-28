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
     public class PersonalInfoService
    {
        //修改个人信息
        public bool Update(UsersPersonInfo Info)
        {
            if (Info.Birthday==null)
            {
                Info.Birthday = Convert.ToDateTime(DBNull.Value);
            }
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Info.Uid),
                new SqlParameter("@Uname",Info.Uname),
                new SqlParameter("@Sex",Info.Sex),
                new SqlParameter("@Birthday",Info.Birthday),
                new SqlParameter("@Phone",Info.Phone),
                new SqlParameter("@ImgPath",Info.ImgPath)
            };
            return SqlHelper.ExecuteNonQuery("Update_personalInfo", param);
         
        }
    }
}
