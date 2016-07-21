
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using www.flymsg.com.context;

public partial class PageGameType : GameType
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; }
    [Display(Name = "类型名称"), Required(ErrorMessage = "不可为空")]
    public string Name { get; set; }
    [Display(Name = "类型标题"), Required(ErrorMessage = "不可为空")]
    public string Title { get; set; }
    [Display(Name = "父级类型"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> ParentId { get; set; }
    [Display(Name = "简介"), Required(ErrorMessage = "不可为空")]
    public string Intro { get; set; }
    [Display(Name = "排序顺序"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> OrderNum { get; set; } = 1;
    [Display(Name = "主题样式"), Required(ErrorMessage = "不可为空")]
    public string BodyCss { get; set; }
    [Display(Name = "加载的js类库"), Required(ErrorMessage = "不可为空")]
    public string JavaScript { get; set; }
    [Display(Name = "展示图片"), Required(ErrorMessage = "不可为空")]
    public string Image { get; set; }
    [Display(Name = "专有Action"), Required(ErrorMessage = "不可为空")]
    public string PageAction { get; set; }
    [Display(Name = "是否展示"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> IsVisible { get; set; } = 1;
    [Display(Name = "创建时间")]
    public Nullable<System.DateTime> CreateTime { get; set; } = DateTime.Now;
    [Display(Name = "创建用户")]
    public Nullable<int> CreateUser { get; set; }
    [Display(Name = "修改时间")]
    public Nullable<System.DateTime> UpdateTime { get; set; } = DateTime.Now;
    [Display(Name = "修改用户")]
    public Nullable<int> UpdateUser { get; set; }
}
