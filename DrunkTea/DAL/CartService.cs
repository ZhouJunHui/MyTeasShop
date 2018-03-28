using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using System.Data;
using System.Data.SqlClient;
using Model;
namespace DAL
{
   public class CartService
    {
        //添加进购物车
        public bool Add(Cart cart)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",cart.Uid),
                new SqlParameter("@Tid",cart.Tid)
            };
            return SqlHelper.ExecuteNonQuery("Add_Cart", param);
        }
        //获取对应用户购物车里商品的数量
        public int GetNumber_Cart(string Uid)
        {
            int number = 0;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetNumber_Cart", param))
            {
                if (dr.Read())
                {
                   number = Convert.ToInt32(dr[0]);
                }
            }
            return number;
        }
        //获取购物车的信息
        public List<Teas> GetListByUid(string Uid)
        {
            List<Teas> lst = new List<Teas>();
            Teas model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetCartByUid", param))
            {
                while (dr.Read())
                {
                    model = new Teas();
                    model.brief = dr["brief"].ToString();
                    model.cateId = Convert.ToInt32(dr["cateId"]);
                    model.Imagepath = dr["Imagepath"].ToString();
                    model.Netcontent = Convert.ToInt32(dr["Netcontent"].ToString());
                    model.Place = dr["Place"].ToString();
                    model.price = Convert.ToDecimal(dr["price"].ToString());
                    model.Purchaseqtity = Convert.ToInt32(dr["Purchaseqtity"].ToString());
                    model.Shelflife = Convert.ToInt32(dr["Shelflife"].ToString());
                    model.Tid = Convert.ToInt32(dr["Tid"].ToString());
                    model.Tname = dr["Tname"].ToString();
                    model.cateName = dr["cateName"].ToString();
                    model.CarId= Convert.ToInt32(dr["CarId"]);
                    model.Number = Convert.ToInt32(dr["Number"]);
                    model.Uid= Convert.ToInt32(dr["Uid"]);
                    lst.Add(model);
                }
            }
            return lst;
        }
        //删除购物车
        public bool Delete(string Uid,string Tid)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid),
                new SqlParameter("@Tid",Tid)
            };
            return SqlHelper.ExecuteNonQuery("Delete_Cart", param);
        }
        //修改购物车的数量
        public bool UpdateCart_ByUidandTid(string Uid,string Tid,string Number)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid),
                new SqlParameter("@Tid",Tid),
                new SqlParameter("@Number",Number)
            };
            return SqlHelper.ExecuteNonQuery("UpdateCart_ByUidandTid", param);

        }
    }
}
