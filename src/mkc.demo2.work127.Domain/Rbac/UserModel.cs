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
    [Table("UserModel")]
  public  class UserModel 
    {
        [Key]
        public Guid tu_id { get; set; } = new Guid();//用户ID
        public string ligin_name { get; set; }//登录账号
        public string password { get; set; }//登录密码
        public string vsername { get; set; }//姓名
        public string phone { get; set; }//手机号
        public string email { get; set; }//电子邮件
        public DateTime gen_time { get; set; } = DateTime.Now;//创建时间
        public DateTime login_time { get; set; }//登录时间
        public DateTime last_login_time { get; set; }//上次登录时间
        public string count { get; set; }//登录次数
    }
}
