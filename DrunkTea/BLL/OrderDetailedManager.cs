using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{

    public class OrderDetailedManager
    {
        OrderDetailedService dal = new OrderDetailedService();
        //根据订单总id获取详细信息
        public List<OrderDetaileds> GetList(string OrId)
        {
            return dal.GetList(OrId);
        }
        //添加订单详细
        public bool Add_OrDetail(OrderDetaileds ODads)
        {
            return dal.Add_OrDetail(ODads);
        }
     }
}
