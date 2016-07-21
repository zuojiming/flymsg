﻿
using System;
using System.Collections.Generic;
using www.flymsg.com.context;
using System.ComponentModel.DataAnnotations;
using www.flymsg.com.Common;

public partial class PageGame : Game
{
    [Display(Name = "主键ID"), Required(ErrorMessage = "不可为空")]
    public int Id { get; set; }
    [Display(Name = "列表图片"), Required(ErrorMessage = "不可为空")]
    public string SmallImage { get; set; }
    [Display(Name = "推广图片"), Required(ErrorMessage = "不可为空")]
    public string BigImage { get; set; }
    [Display(Name = "排序顺序"), Required(ErrorMessage = "不可为空")]
    public Nullable<int> OrderNum { get; set; } = 1;
    [Display(Name = "主体文件引用路径"), Required(ErrorMessage = "不可为空")]
    public string GamePath { get; set; }
    [Display(Name = "游戏作者"), Required(ErrorMessage = "不可为空")]
    public string Anthor { get; set; }
    [Display(Name = "标题"), Required(ErrorMessage = "不可为空")]
    public string Title { get; set; }
    [Display(Name = "操作类型"), Required(ErrorMessage = "不可为空")]
    public string OperationType { get; set; }
    [Display(Name = "简介"), Required(ErrorMessage = "不可为空")]
    public string Intro { get; set; }
    [Display(Name = "标签"), Required(ErrorMessage = "不可为空")]
    public string Label { get; set; }
    [Display(Name = "游戏类型"), Required(ErrorMessage = "不可为空")]
    public string GameType { get; set; }
    [Display(Name = "备注"), Required(ErrorMessage = "不可为空")]
    public string Backup { get; set; }
    [Display(Name = "是否展示"), Required(ErrorMessage = "不可为空")]
    public IsVisible IsVisible { get; set; } = IsVisible.否;
    [Display(Name = "创建时间")]
    public Nullable<System.DateTime> CreateTime { get; set; } = DateTime.Now;
    [Display(Name = "创建用户")]
    public Nullable<int> CreateUser { get; set; }
    [Display(Name = "修改时间")]
    public Nullable<System.DateTime> UpdateTime { get; set; } = DateTime.Now;
    [Display(Name = "修改用户")]
    public Nullable<int> UpdateUser { get; set; }
}