﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkc.demo2.work127.Model
{
    [Table("IndentModel")]
    //订单
  public  class IndentModel
    {
        [Key]
        public Guid ind_id { get; set; }//订单id
        public string OrderInfoId { get; set; }//订单号ID
        public string CommodityId { get; set; }//商品id
        public decimal Price { get; set; }//价格(购买时)
        public int Num { get; set; }//销售数量
        public string Name { get; set; }//商品名称
        public string SmallImage { get; set; }//商品图片
    }
}
