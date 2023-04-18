/*
Tables:
    Products - (PK)Id, Name
    Categories - (PK)Id, Name
    ProductsCategories - (PK)Id, (FK)ProductId, (FK)CategoryId
*/

SELECT P.Name, C.Name FROM ProductsCategories AS PC
INNER JOIN Categories AS C ON C.Id = PC.CategoryId
RIGHT JOIN Products AS P ON P.Id = PC.ProductId