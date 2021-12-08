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
   
    public class RoleMenuModel 
    {

        [Key]
        public Guid tro_id { get; set; }
        public Guid tr_id { get; set; }//角色id
        public Guid tm_id { get; set; }//权限id

    }
}
