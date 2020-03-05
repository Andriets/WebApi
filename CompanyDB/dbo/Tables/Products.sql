CREATE TABLE [dbo].[Products] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [ProductName]   NCHAR (50) NOT NULL,
    [ProductTypeId] INT        NOT NULL,
    [Price]         FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductType] ([Id])
);

