
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using www.flymsg.com.context;

public partial class PageSiteUser : SiteUser
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; }
    [Display(Name = "用户名称"), Required(ErrorMessage = "不可为空")]
    public string Name { get; set; }
    [Display(Name = "性别"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> Sex { get; set; } = 0;
    [Display(Name = "联系电话"), Required(ErrorMessage = "不可为空")]
    public string Telephone { get; set; }
    [Display(Name = "联系邮箱"), Required(ErrorMessage = "不可为空")]
    public string Email { get; set; }
    [Display(Name = "用户等级"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> ULevel { get; set; } = 0;
    [Display(Name = "登录名"), Required(ErrorMessage = "不可为空")]
    public string LoginName { get; set; }
    [Display(Name = "密码"), Required(ErrorMessage = "不可为空")]
    public string Passwork { get; set; }
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