
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using www.flymsg.com.context;

public partial class PageGameBBS : GameBBS
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; }
    [Display(Name = "游戏ID"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> GameId { get; set; }
    [Display(Name = "父级帖子"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> ParentId { get; set; }
    [Display(Name = "标题"), Required(ErrorMessage = "不可为空")]
    public string Title { get; set; }
    [Display(Name = "正文"), Required(ErrorMessage = "不可为空")]
    public string Context { get; set; }
    [Display(Name = "发帖IP"), Required(ErrorMessage = "不可为空")]
    public string Ip { get; set; }
    [Display(Name = "发帖IP地址"), Required(ErrorMessage = "不可为空")]
    public string Address { get; set; }
    [Display(Name = "发帖用户名"), Required(ErrorMessage = "不可为空")]
    public string UserName { get; set; }
    [Display(Name = "创建时间")]
    public Nullable<System.DateTime> CreateTime { get; set; } = DateTime.Now;
    [Display(Name = "创建用户")]
    public Nullable<int> CreateUser { get; set; }
    [Display(Name = "修改时间")]
    public Nullable<System.DateTime> UpdateTime { get; set; } = DateTime.Now;
    [Display(Name = "修改用户")]
    public Nullable<int> UpdateUser { get; set; }
}