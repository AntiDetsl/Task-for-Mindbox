SELECT p.Name, c.Name
FROM Products AS p
LEFT JOIN ProductsCategory AS pc 
ON p.ID = pc.ProductID
LEFT JOIN Categories AS c
ON c.ID = pc.CategoryID