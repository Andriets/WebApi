CREATE TABLE [dbo].[Orders] (
    [Id]             INT        IDENTITY (1, 1) NOT NULL,
    [ProductId]      INT        NOT NULL,
    [CountOfProduct] INT        NOT NULL,
    [OrderSum]       FLOAT (53) NOT NULL,
    [UserId]         INT        NOT NULL,
    [DateOfOrder]    DATETIME   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

