USE [Test2]
GO

SELECT *  FROM [dbo].[Products]
SELECT *  FROM [dbo].[Categories]
SELECT *  FROM [dbo].[ProductsCategories]

-- Список всех продуктов с указанием их категорий, если таковые (категории)есть.
Select p.ProductId, p.Name, c.CategoryId, c.Name
from [dbo].[Products] as p
LEFT JOIN [dbo].[ProductsCategories] as pc ON p.ProductId  = pc.ProductId
LEFT JOIN [dbo].[Categories]         as c  ON c.CategoryId = pc.CategoryId
