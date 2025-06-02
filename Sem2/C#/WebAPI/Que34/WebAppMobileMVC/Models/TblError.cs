namespace WebAppMobileMVC.Models
{
    public class TblError
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

//database name ::- MobileManaged

//CREATE TABLE[dbo].[TblError] (
//    [Id]   INT IDENTITY(1, 1) NOT NULL,
//    [Name] VARCHAR (5000) NOT NULL,
//    PRIMARY KEY CLUSTERED ([Id] ASC)
//);