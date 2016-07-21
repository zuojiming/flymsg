using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace www.flymsg.com.Model
{
    /// <summary>
    /// 转换操作类
    /// </summary>
    public class ConvertOperation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual object SourceContent { get; set; }
        public virtual object ResultContent { get; set; }
        public virtual Type SourceType { get; set; }
        public virtual Type ResultType { get; set; }
        public virtual string RefStr { get; set; }
        public virtual string SourceTypeStr { get; set; }
        public virtual string ResultTypeStr { get; set; }
    }
}
