CREATE TABLE [dbo].[Posts] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [PostType] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

