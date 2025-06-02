using Humanizer;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Diagnostics;

namespace WebAppliForeginKey.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

//CREATE TABLE[dbo].[ErrorLogs] (
//    [Id]           INT IDENTITY(1, 1) NOT NULL,
//    [ErrorMessage] NVARCHAR (4000) NULL,
//    [StackTrace]   NVARCHAR (MAX)  NULL,
//    [LogTime]      DATETIME        DEFAULT (getdate()) NULL,
//    PRIMARY KEY CLUSTERED ([Id] ASC)
//);