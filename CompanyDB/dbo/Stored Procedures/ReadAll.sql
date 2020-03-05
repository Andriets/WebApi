
CREATE PROCEDURE ReadAll
AS
BEGIN
SELECT Orders.Id, ProductName, ProductType.TypeName, Price, CountOfProduct, OrderSum, Name, Surname, LastName, Phone, Adress, Email, DateOfOrder  FROM Orders
JOIN Users ON Users.Id = Orders.UserId
JOIN Products ON Products.Id = Orders.ProductId
JOIN ProductType ON ProductType.Id = Products.ProductTypeId
END
