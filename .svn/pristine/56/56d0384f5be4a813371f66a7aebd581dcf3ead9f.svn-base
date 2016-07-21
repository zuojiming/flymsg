
using System;
using System.Collections.Generic;
using www.flymsg.com.context;
using System.ComponentModel.DataAnnotations;

public partial class PageEvaluation : Evaluation
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; }
    [Display(Name = "游戏ID"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> GameId { get; set; }
    [Display(Name = "点击数"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> ClientCount { get; set; } = 0;
    [Display(Name = "访问数"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> VisitCount { get; set; } = 0;
    [Display(Name = "评价"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> Eat { get; set; } = 4;
    [Display(Name = "创建时间")]
    public Nullable<System.DateTime> CreateTime { get; set; } = DateTime.Now;
    [Display(Name = "创建用户")]
    public Nullable<int> CreateUser { get; set; }
    [Display(Name = "修改时间")]
    public Nullable<System.DateTime> UpdateTime { get; set; } = DateTime.Now;
    [Display(Name = "修改用户")]
    public Nullable<int> UpdateUser { get; set; }
}