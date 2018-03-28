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
  public  class ReceivingaddressService
    {
        //新增收货地址
        public bool Add(Receivingaddress recAddress)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Rname",recAddress.Rname),
                new SqlParameter("@phone",recAddress.Phone),
                new SqlParameter("@Address",recAddress.Address),
                new SqlParameter("@Uid",recAddress.Uid)
            };
            return SqlHelper.ExecuteNonQuery("Add_Receivingaddress", param);
        }
        //修改收货地址
        public bool Update(Receivingaddress recAddress)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Rname",recAddress.Rname),
                new SqlParameter("@phone",recAddress.Phone),
                new SqlParameter("@Address",recAddress.Address),
                new SqlParameter("@RecId",recAddress.RecId)
            };
            return SqlHelper.ExecuteNonQuery("Update_Receivingaddress", param);
        }
        //删除收货地址
        public bool Delete(string recId)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@RecId",recId)
            };
            return SqlHelper.ExecuteNonQuery("delete_Receivingaddress", param);
        }
        //获取对应收货地址信息
        public List<Receivingaddress> GetList_ByUid(string Uid)
        {
            List<Receivingaddress> list = new List<Receivingaddress>();
            Receivingaddress model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("Get_ReceivingaddressByUid", param))
            {
                while (dr.Read())
                {
                    model = new Receivingaddress();
                    model.Address = dr["Address"].ToString();
                    model.Uid =Convert.ToInt32(dr["Uid"].ToString());
                    model.Rname = dr["Rname"].ToString();
                    model.RecId = Convert.ToInt32(dr["RecId"].ToString());
                    model.Phone = dr["Phone"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
       //根据收货地址ID获取对应信息
       public Receivingaddress GetAddress_ByReceid(string id)
        {
            Receivingaddress model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReceId",id)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetAddress_ByReceid", param))
            {
                if (dr.Read())
                {
                    model = new Receivingaddress();
                    model.Address = dr["Address"].ToString();
                    model.Uid = Convert.ToInt32(dr["Uid"]);
                    model.RecId= Convert.ToInt32(dr["RecId"]);
                    model.Rname = dr["Rname"].ToString();
                    model.Phone = dr["Phone"].ToString();
                }
            }
            return model;
        }
    }
}
