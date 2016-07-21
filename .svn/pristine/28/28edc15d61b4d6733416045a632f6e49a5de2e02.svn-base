using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class ViewTitleLink : www.flymsg.com.context.PageTitleLink
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; } = 1;
    [Display(Name="展示名称"), Required(ErrorMessage =  "不可为空")]
    public string Name { get; set; }
    [Display(Name = "内容标题"), Required(ErrorMessage = "不可为空")]
    public string Title { get; set; }
    [Display(Name = "展示图片"), Required(ErrorMessage = "不可为空")]
    public string ImagePath { get; set; }
    [Display(Name = "跳转地址"), Required(ErrorMessage = "不可为空")]
    public string ToUrl { get; set; }
    [Display(Name = "展示顺序"), Required(ErrorMessage = "不可为空"), Range(0, int.MaxValue)]
    public Nullable<int> OrderNum { get; set; } = 1;
    [Display(Name = "是否展示"), Required(ErrorMessage = "不可为空"), Range(0, int.MaxValue)]
    public Nullable<int> IsVisible { get; set; } = 0;
    [Display(Name = "创建时间")]
    public Nullable<System.DateTime> CreateTime { get; set; } = DateTime.Now;
    [Display(Name = "创建用户")]
    public Nullable<int> CreateUser { get; set; }
    [Display(Name = "修改时间")]
    public Nullable<System.DateTime> UpdateTime { get; set; } = DateTime.Now;
    [Display(Name = "修改用户")]
    public Nullable<int> UpdateUser { get; set; }
}
