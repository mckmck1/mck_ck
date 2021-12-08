using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkc.demo2.work127.Model
{
    [Table("GoodsTypeModel")]
    //商品类型
  public  class GoodsTypeModel
    {
        [Key]
        public Guid gt_id { get; set; }
        public Guid go_id { get; set; }//商品id
        public Guid ty_id { get; set; }//类型id
    }
}
