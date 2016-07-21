
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using www.flymsg.com.context;

public partial class PageIpLog : IpLog
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; }
    [Display(Name = "客户端IP"), Required(ErrorMessage = "不可为空")]
    public string Ip { get; set; }
    [Display(Name = "请求地址"), Required(ErrorMessage = "不可为空")]
    public string ActionUrl { get; set; }
    [Display(Name = "点击链接"), Required(ErrorMessage = "不可为空")]
    public string ClientUrl { get; set; }
    [Display(Name = "上一页面"), Required(ErrorMessage = "不可为空")]
    public string UrlReferrer { get; set; }
    [Display(Name = "创建时间")]
    public Nullable<System.DateTime> CreateTime { get; set; } = DateTime.Now;
    [Display(Name = "创建用户")]
    public Nullable<int> CreateUser { get; set; }
    [Display(Name = "修改时间")]
    public Nullable<System.DateTime> UpdateTime { get; set; } = DateTime.Now;
    [Display(Name = "修改用户")]
    public Nullable<int> UpdateUser { get; set; }
}
