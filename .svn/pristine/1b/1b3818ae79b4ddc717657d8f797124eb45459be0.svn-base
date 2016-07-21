using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using www.flymsg.com.Model;

namespace www.flymsg.com.Models
{
    public class COSerachModel : ConvertOperation
    {
        [Display(Name = "主键ID"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Display(Name = "展示名称"), DataType(DataType.Text), Required(ErrorMessage = "名称必填"), StringLength(20, ErrorMessage = "名称最多20字符")]
        public override string Name { get; set; }
        [Display(Name = "调用码"), DataType(DataType.Text), Required(ErrorMessage = "调用代码必填"), StringLength(20, ErrorMessage = "调用代码最多20字符")]
        public override string Code { get; set; }
        [Display(Name = "输入信息"), Required(ErrorMessage = "请输入要转入的信息")]
        public override object SourceContent { get; set; }
        [Display(Name = "输出信息")]
        public override object ResultContent { get; set; }
        [Display(Name = "输入类型"), Required(ErrorMessage = "请选择转换起始类型")]
        public override Type SourceType { get; set; }
        [Display(Name = "输出类型"), Required(ErrorMessage = "请选择转换目标类型")]
        public override Type ResultType { get; set; }
        [Display(Name = "反射的方法名称")]
        public override string RefStr { get; set; }
        [Display(Name = "输入类型"), Required(ErrorMessage = "请选择转换起始类型")]
        public override string SourceTypeStr { get; set; }
        [Display(Name = "输出类型"), Required(ErrorMessage = "请选择转换目标类型")]
        public override string ResultTypeStr { get; set; }
    }
}