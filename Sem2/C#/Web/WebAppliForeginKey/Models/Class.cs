using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace WebAppliForeginKey.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? Classname { get; set; }

    public virtual ICollection<Studofclass> Studofclasses { get; set; } = new List<Studofclass>();
}

//CREATE TABLE[dbo].[class] (
//    [classId] INT        NOT NULL,
//    [classname] NCHAR(10) NULL,
//    PRIMARY KEY CLUSTERED([classId] ASC)
//);