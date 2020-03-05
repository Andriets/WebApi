CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NCHAR (20)    NOT NULL,
    [Surname]  NCHAR (20)    NOT NULL,
    [LastName] NCHAR (20)    NOT NULL,
    [Phone]    NVARCHAR (20) NULL,
    [Adress]   NCHAR (100)   NULL,
    [Email]    NCHAR (30)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Phone] like '+380[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);

