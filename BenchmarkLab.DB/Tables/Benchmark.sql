CREATE TABLE [dbo].[Benchmark]
(
	[Id] BIGINT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(60) NOT NULL, 
    [Description] NVARCHAR(400) NULL, 
    [OwnerId] nvarchar(450) NULL, 
    [WhenCreated] DATETIME2 NOT NULL DEFAULT getdate(), 
    [ScriptPreparationCode] NVARCHAR(MAX) NULL, 
    [HtmlPreparationCode] NVARCHAR(MAX) NULL, 
    [Version] INT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_Benchmark_ToUsers] FOREIGN KEY (OwnerId) REFERENCES [AspNetUsers]([Id])
)
