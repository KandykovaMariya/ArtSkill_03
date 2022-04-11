CREATE TABLE [dbo].[IllustrationModel] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX)  NULL,
    [shortDesc]   NVARCHAR (MAX)  NOT NULL,
    [longDesc]    NVARCHAR (MAX)  NULL,
    [ReleaseDate] DATETIME2 (7)   NOT NULL,
    [Category]    NVARCHAR (MAX)  NULL,
    [img]         IMAGE  NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_IllustrationModel] PRIMARY KEY CLUSTERED ([Id] ASC)
);

