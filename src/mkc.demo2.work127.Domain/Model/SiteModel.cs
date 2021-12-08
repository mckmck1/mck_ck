using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkc.demo2.work127.Model
{
    [Table("SiteModel")]
    //地址
 public   class SiteModel
    {
        [Key]
        public Guid si_id { get; set; }//地址id
        public string si_name { get; set; }//地址名
        public Guid superiorid { get; set; }//上级id
        public string si_minute { get; set; }//详细地址
        public bool state { get; set; }//是否默认
    }
}
