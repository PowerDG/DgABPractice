using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UEditor
{
    public class Article
    {


        //https://github.com/baiyunchen/UEditor.Core/blob/master/Docs/DotnetCore%E4%B8%AD%E7%9A%84%E4%BD%BF%E7%94%A8.md
        [Key]
        public int ID { get; set; }

        [DisplayName("标题")]
        public string Title { get; set; }
        [DisplayName("描述")]
        public string Description { get; set; }
        [DisplayName("内容")]
        public string Content { get; set; }
        [DisplayName("评论数")]
        public long CommentCount { get; set; }
        [DisplayName("发表时间")]
        public DateTime PublishOn { get; set; }
        [DisplayName("其它字段")]
        [NotMapped]
        public string OtherField { get; set; }
    }
}
