using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class TeasManager
    {
        TeasService dal = new TeasService();
        //查询所有的茶叶信息
        public List<Teas> GetList()
        {
            return dal.GetList();
        }
        //根据分类获取商品信息
        public List<Teas> Teas_GetListByCateid(string cateId)
        {
            return dal.Teas_GetListByCateid(cateId);
        }
        //根据茶叶名获取对应商品信息
        public List<Teas> Teas_GetListByTName(string Tname)
        {
            return dal.Teas_GetListByTName(Tname);
        }
        //根据id获取对应信息
        public Teas GetList_TeasByTid(string Tid)
        {
            return dal.GetList_TeasByTid(Tid);
        }
      }
}
