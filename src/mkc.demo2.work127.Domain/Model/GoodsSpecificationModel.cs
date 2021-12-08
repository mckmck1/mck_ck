using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkc.demo2.work127.Model
{
    //商品规格
    [Table("GoodsSpecificationModel")]
public    class GoodsSpecificationModel
    {
        [Key]
        public Guid gs_id { get; set; }
        public Guid go_id { get; set; }//商品id
        public Guid sp_id { get; set; }//规格id

    }
}
