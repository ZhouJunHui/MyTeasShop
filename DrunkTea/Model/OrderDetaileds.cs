using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class OrderDetaileds
    {
        public int OrDetaId { get; set; }
        public int OrId { get; set;}
        public int Tid { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public string Imagepath { get; set; }//图片路径
        public int Netcontent { get; set; }//净含量
        public string Tname { get; set; }
        public string brief { get; set; }//简介
        public decimal price { get; set; }
        public string cateName { get; set; }//分类名称
        public int cateId { get; set; }//类别ID
    }
}
