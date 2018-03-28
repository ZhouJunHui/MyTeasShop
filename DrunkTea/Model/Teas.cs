using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Teas
    {
   public int Tid  { get; set; }
   public string Tname { get; set; }
   public string brief { get; set; }//简介
   public decimal price { get; set; }
   public string cateName { get; set; }//分类名称
   public int cateId { get; set; }//类别ID
   public int Netcontent { get; set; }//净含量
   public string Place  { get; set; }//产地
   public int Shelflife  { get; set; }//保质期
   public int Purchaseqtity { get; set; }//购买数量
   public string Imagepath { get; set; }//图片路径
        public int CarId { get; set; }
        public int Uid { get; set; }
        public int Number { get; set; }
    }
}
