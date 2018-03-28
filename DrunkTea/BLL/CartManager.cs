using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class CartManager
    {
        CartService dal = new CartService();
        //添加进购物车
        public bool Add(Cart cart)
        {
            return dal.Add(cart);
        }
        //获取对应用户购物车里商品的数量
        public int GetNumber_Cart(string Uid)
        {
            return dal.GetNumber_Cart(Uid);
        }
        //获取购物车的信息
        public List<Teas> GetListByUid(string Uid)
        {
            return dal.GetListByUid(Uid);
        }
        //删除购物车
        public bool Delete(string Uid, string Tid)
        {
            return dal.Delete(Uid, Tid);
        }
        //修改购物车的数量
        public bool UpdateCart_ByUidandTid(string Uid, string Tid, string Number)
        {
            return dal.UpdateCart_ByUidandTid(Uid, Tid, Number);
        }
    }
}
