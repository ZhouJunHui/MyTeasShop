using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class OrderManager
    {
        OrderService dal = new OrderService();
        //根据用户id获取对应订单
        public List<Orders> GetList(string id)
        {
            return dal.GetList(id);
        }
        //删除订单以及订单明细
        public bool Delete(string Ordernumber)
        {
            return dal.Delete(Ordernumber);
        }
        //添加订单
        public string Add(Orders Ods)
        {
            return dal.Add(Ods);
        }
     }
}
