﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkc.demo2.work127.Model
{
    
    //商品图片
    [Table("GoodsImgModel")]
  public  class GoodsImgModel
    {
        [Key]
        public Guid gi_id { get; set; }
        public Guid go_id { get; set; }//商品id
        public Guid im_id { get; set; }//图片id
    }
}
