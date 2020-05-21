CREATE TABLE [dbo].[Users]
(
    [Id]          INT IDENTITY (1, 1),
    [Email]       NVARCHAR(64) NOT NULL,
    [Created]     DATETIME2(7) NOT NULL DEFAULT (GETDATE()),

    [IsDeleted]   BIT          NOT NULL DEFAULT (0),
    [DeletedTime] DATETIME     NULL,

    PRIMARY KEY ([Id])
);

CREATE TABLE [dbo].[Messages]
(
    [Id]       UNIQUEIDENTIFIER       DEFAULT (NEWID()),
    [Content]  NVARCHAR(MAX) NOT NULL,
    [Sendtime] DATETIME2     NOT NULL DEFAULT (GETDATE()),
    [AuthorId] INT           NOT NULL,

    PRIMARY KEY ([Id]),
    CONSTRAINT [FK_dbo.Users.Id] FOREIGN KEY ([AuthorId]) REFERENCES [Users] ([Id]),
);

CREATE INDEX [Idx_Messages_AuthorId] ON [dbo].[Messages] ([AuthorId]);