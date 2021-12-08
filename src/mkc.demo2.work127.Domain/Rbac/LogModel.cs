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
  
    public class LogModel
    {
        [Key]
        public Guid log_id { get; set; }//日志id
        public int op_type { get; set; }//操作类型
        public string content { get; set; }//操作内容
        public Guid tu_id { get; set; }//操作人
        public DateTime gen_time { get; set; } = DateTime.Now;//操作时间
    }
}
