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
    public class TeasService
    {
        //查询所有的茶叶信息
        public List<Teas> GetList()
        {
            List<Teas> lst = new List<Teas>();
            Teas model = null;
            using (SqlDataReader dr=SqlHelper.ExecuteReader("Teas_GetList", null))
            {
                while (dr.Read())
                {
                    model = new Teas();
                    model.brief = dr["brief"].ToString();
                    model.cateId =  Convert.ToInt32(dr["cateId"].ToString());
                    model.Imagepath = dr["Imagepath"].ToString();
                    model.Netcontent =  Convert.ToInt32(dr["Netcontent"].ToString());
                    model.Place = dr["Place"].ToString();
                    model.price =  Convert.ToDecimal(dr["price"].ToString());
                    model.Purchaseqtity =  Convert.ToInt32(dr["Purchaseqtity"].ToString());
                    model.Shelflife =  Convert.ToInt32(dr["Shelflife"].ToString());
                    model.Tid =Convert.ToInt32(dr["Tid"].ToString());
                    model.Tname = dr["Tname"].ToString();
                    model.cateName = dr["cateName"].ToString();
                    lst.Add(model);
                }
            }
            return lst;
        }
        //根据分类获取商品信息
        public List<Teas> Teas_GetListByCateid(string cateId)
        {
            List<Teas> lst = new List<Teas>();
            Teas model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Cateid",cateId)
            };
            using (SqlDataReader dr = SqlHelper.ExecuteReader("Teas_GetListByCateid", param))
            {
                while (dr.Read())
                {
                    model = new Teas();
                    model.brief = dr["brief"].ToString();
                    model.cateId = Convert.ToInt32(dr["cateId"].ToString());
                    model.Imagepath = dr["Imagepath"].ToString();
                    model.Netcontent = Convert.ToInt32(dr["Netcontent"].ToString());
                    model.Place = dr["Place"].ToString();
                    model.price = Convert.ToDecimal(dr["price"].ToString());
                    model.Purchaseqtity = Convert.ToInt32(dr["Purchaseqtity"].ToString());
                    model.Shelflife = Convert.ToInt32(dr["Shelflife"].ToString());
                    model.Tid = Convert.ToInt32(dr["Tid"].ToString());
                    model.Tname = dr["Tname"].ToString();
                    model.cateName = dr["cateName"].ToString();
                    lst.Add(model);
                }
            }
            return lst;
        }
        //根据茶叶名获取对应商品信息
        public List<Teas> Teas_GetListByTName(string Tname)
        {
            List<Teas> lst = new List<Teas>();
            Teas model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@TName",Tname)
            };
            using (SqlDataReader dr = SqlHelper.ExecuteReader("Teas_GetListByTName", param))
            {
                while (dr.Read())
                {
                    model = new Teas();
                    model.brief = dr["brief"].ToString();
                    model.cateId = Convert.ToInt32(dr["cateId"].ToString());
                    model.Imagepath = dr["Imagepath"].ToString();
                    model.Netcontent = Convert.ToInt32(dr["Netcontent"].ToString());
                    model.Place = dr["Place"].ToString();
                    model.price = Convert.ToDecimal(dr["price"].ToString());
                    model.Purchaseqtity = Convert.ToInt32(dr["Purchaseqtity"].ToString());
                    model.Shelflife = Convert.ToInt32(dr["Shelflife"].ToString());
                    model.Tid = Convert.ToInt32(dr["Tid"].ToString());
                    model.Tname = dr["Tname"].ToString();
                    model.cateName = dr["cateName"].ToString();
                    lst.Add(model);
                }
            }
            return lst;
        }
        //根据id获取对应信息
        public Teas GetList_TeasByTid(string Tid)
        {
            Teas model = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Tid",Tid)
            };
            using (SqlDataReader dr=SqlHelper.ExecuteReader("GetList_TeasByTid",param))
            {
                while (dr.Read())
                {
                    model = new Teas();
                    model.brief = dr["brief"].ToString();
                    model.cateId = Convert.ToInt32(dr["cateId"].ToString());
                    model.Imagepath = dr["Imagepath"].ToString();
                    model.Netcontent = Convert.ToInt32(dr["Netcontent"].ToString());
                    model.Place = dr["Place"].ToString();
                    model.price = Convert.ToDecimal(dr["price"].ToString());
                    model.Purchaseqtity = Convert.ToInt32(dr["Purchaseqtity"].ToString());
                    model.Shelflife = Convert.ToInt32(dr["Shelflife"].ToString());
                    model.Tid = Convert.ToInt32(dr["Tid"].ToString());
                    model.Tname = dr["Tname"].ToString();
                    model.cateName = dr["cateName"].ToString();
                }
            }
            return model;
        }
    }
}
