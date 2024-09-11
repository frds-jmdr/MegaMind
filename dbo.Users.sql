CREATE TABLE [dbo].[users] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (100) NOT NULL,
    [Email]   NVARCHAR (100) NOT NULL,
    [Phone]   NVARCHAR (15)  NOT NULL,
    [Address] NVARCHAR (255) NULL,
    [State]   NVARCHAR (50)  NOT NULL,
    [City]    NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

