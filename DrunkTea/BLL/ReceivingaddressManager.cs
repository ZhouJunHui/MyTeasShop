using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class ReceivingaddressManager
    {
        ReceivingaddressService dal = new ReceivingaddressService();
        //新增收货地址
        public bool Add(Receivingaddress recAddress)
        {
            return dal.Add(recAddress);
        }
        //修改收货地址
        public bool Update(Receivingaddress recAddress)
        {
            return dal.Update(recAddress);
        }
        //删除收货地址
        public bool Delete(string recId)
        {
            return dal.Delete(recId);
        }
        //获取对应收货地址信息
        public List<Receivingaddress> GetList_ByUid(string Uid)
        {
            return dal.GetList_ByUid(Uid);
        }
        //根据收货地址ID获取对应信息
        public Receivingaddress GetAddress_ByReceid(string id)
        {
            return dal.GetAddress_ByReceid(id);
        }
    }
}
