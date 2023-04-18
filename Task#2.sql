/*
Tables:
    Products - (PK)Id, Name
    Categories - (PK)Id, Name
    ProductsCategories - (PK)Id, (FK)ProductId, (FK)CategoryId
*/

SELECT Products.Name, Categories.Name FROM ProductsCategories AS ProductsCategories
INNER JOIN Categories AS Categories ON Categories.Id = ProductsCategories.CategoryId
RIGHT JOIN Products AS Products ON Products.Id = ProductsCategories.ProductId