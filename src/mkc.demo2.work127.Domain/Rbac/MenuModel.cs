using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace mkc.demo2.work127.Rbac
{
 
    public  class MenuModel
    {

        [Key]
        public Guid tm_id { get; set; } = new Guid();
        public Guid superiorid { get; set; }//上级id
        public string menu_name { get; set; }//权限名称
        public string description { get; set; }//权限描述
    }
}
