using System;
using System.Collections.Generic;
using Humanizer;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Data;

namespace WebAppliForeginKey.Models;

public partial class Studofclass
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }
}
//CREATE TABLE[dbo].[Studofclass]
//    (
//    [Id] INT          IDENTITY(1, 1) NOT NULL,
//    [name]    VARCHAR(50) NULL,
//    [age] INT NULL,
//    [classId] INT NULL,
//    CONSTRAINT[PK_Studofclass] PRIMARY KEY CLUSTERED([Id] ASC),
//    CONSTRAINT[FK_Studofclass_class_classId] FOREIGN KEY([classId]) REFERENCES[dbo].[class] ([classId]) ON DELETE CASCADE
//);

