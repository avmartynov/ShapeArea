USE [Test2]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[ProductsCategories]
DROP TABLE [dbo].[Products]
DROP TABLE [dbo].[Categories]

GO

CREATE TABLE [dbo].[Products](
	[ProductId] [int] NOT NULL,
	[Name] [nvarchar](50) COLLATE Cyrillic_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] NOT NULL,
	[Name] [nvarchar](50) COLLATE Cyrillic_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[ProductsCategories](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_ProductsCategories] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ProductsCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductsCategories_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO

ALTER TABLE [dbo].[ProductsCategories] CHECK CONSTRAINT [FK_ProductsCategories_Categories]
GO

ALTER TABLE [dbo].[ProductsCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductsCategories_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO

ALTER TABLE [dbo].[ProductsCategories] CHECK CONSTRAINT [FK_ProductsCategories_Products]
GO

INSERT INTO [dbo].[Products](ProductId,	Name) VALUES
(1,	'Стол'),
(2,	'Стул'),
(3,	'Ботинки'),
(4,	'Рубашка'),
(5,	'Шапка'),
(6,	'Мотоцикл')
GO

INSERT INTO [dbo].[Categories](CategoryId, Name) VALUES
(1,	'Мебель'),
(2,	'Одежда')
GO

INSERT INTO [dbo].[ProductsCategories]( ProductId,	CategoryId) VALUES
(1,	1),
(2,	1),
(3,	2),
(4,	2),
(5,	2)
GO
