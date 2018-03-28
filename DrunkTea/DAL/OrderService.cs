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
   public class OrderService
    {   
        //根据用户id获取对应订单
        public List<Orders> GetList(string id)
        {
            List<Orders> lst = new List<Orders>();
            Orders model = null;
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@Uid",id)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetList_Orders", param))
            {
                while (dr.Read())
                {
                    model = new Orders();
                    model.Uid = Convert.ToInt32(dr["Uid"]);
                    model.Total=Convert.ToDecimal(dr["Total"]);
                    model.Address = dr["Address"].ToString();
                    model.RecId = Convert.ToInt32(dr["RecId"]);
                    model.Rname = dr["Rname"].ToString();
                    model.OrId = Convert.ToInt32(dr["OrId"]);
                    model.Phone = dr["Phone"].ToString();
                    model.Ordertime = Convert.ToDateTime(dr["Ordertime"]);
                    model.Ordernumber = dr["Ordernumber"].ToString();
                    lst.Add(model);
                }
            }
            return lst;
        }
        //删除订单以及订单明细
        public bool Delete(string Ordernumber)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Ordernumber",Ordernumber)
            };
            return SqlHelper.ExecuteNonQuery("Delete_OrdersByOrdernumber", param);
        }
        //添加订单
        public string Add(Orders Ods)
        {
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@Uid",Ods.Uid),
               new SqlParameter("@Total",Ods.Total),
               new SqlParameter("@RecId",Ods.RecId),
            };
            return SqlHelper.ExecuteScalar("Add_Orders", param).ToString();
        }
    }
}
