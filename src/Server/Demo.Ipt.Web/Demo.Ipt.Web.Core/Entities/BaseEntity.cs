﻿namespace Demo.Ipt.Web.Core.Entities;
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}
