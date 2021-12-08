using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkc.demo2.work127.Model
{
    [Table("ImgModel")]
    //图片表
  public  class ImgModel
    {
        [Key]
        public Guid im_id { get; set; }//图片id
        public string im_url { get; set; }//图片路径
        public DateTime upl_time { get; set; }//图片上传时间

    }
}
