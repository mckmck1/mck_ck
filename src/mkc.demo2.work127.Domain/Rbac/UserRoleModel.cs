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
  [Table("UserRoleModel")]
  public  class UserRoleModel 
    {
        [Key]
        public Guid tug_id { get; set; }
        public Guid tu_id { get; set; }//用户id
        public Guid tr_id { get; set; }//角色id
    }
}
