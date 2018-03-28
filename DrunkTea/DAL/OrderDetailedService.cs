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
   public class OrderDetailedService
    {
        //根据订单总id获取详细信息
        public List<OrderDetaileds> GetList(string OrId)
        {
            List<OrderDetaileds> lst = new List<OrderDetaileds>();
            OrderDetaileds model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@OrId",OrId)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetList_OrderDetailedByOrId", param))
            {
                while (dr.Read())
                {
                    model = new OrderDetaileds();
                    model.Number =Convert.ToInt32(dr["Number"]);
                    model.OrDetaId = Convert.ToInt32(dr["OrDetaId"]);
                    model.OrId = Convert.ToInt32(dr["OrId"]);
                    model.Price = Convert.ToInt32(dr["Price"]);
                    model.Tid = Convert.ToInt32(dr["Tid"]);
                    model.brief = dr["brief"].ToString();
                    model.cateId = Convert.ToInt32(dr["cateId"].ToString());
                    model.Imagepath = dr["Imagepath"].ToString();
                    model.Netcontent = Convert.ToInt32(dr["Netcontent"].ToString());
                    model.price = Convert.ToDecimal(dr["price"].ToString());
                    model.Tname = dr["Tname"].ToString();
                    model.cateName = dr["cateName"].ToString();
                    lst.Add(model);
                }
            }
            return lst;
        }
        //添加订单详细
        public bool Add_OrDetail(OrderDetaileds ODads)
        {
            SqlParameter[] param = new SqlParameter[] {
               new SqlParameter("@Orid",ODads.OrId),
               new SqlParameter("@Tid",ODads.Tid),
               new SqlParameter("@Number",ODads.Number),
               new SqlParameter("@Price",ODads.Price)
            };
            return SqlHelper.ExecuteNonQuery("Add_OrDetaId", param);
        }
    }
}
