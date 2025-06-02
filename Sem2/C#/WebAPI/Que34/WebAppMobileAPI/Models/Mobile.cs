using System;
using System.Collections.Generic;

namespace WebAppMobileAPI.Models;

public partial class Mobile
{
    public int Id { get; set; }

    public string Model { get; set; }

    public string Brand { get; set; }

    public int? Price { get; set; }
}
//database name ::- MobileManaged

//CREATE TABLE[dbo].[Mobile]
//    (
//    [Id] INT          NOT NULL,
//    [model] VARCHAR(50) NOT NULL,
//    [brand] VARCHAR(50) NOT NULL,
//    [price] INT NOT NULL,
//    PRIMARY KEY CLUSTERED([Id] ASC)
//);