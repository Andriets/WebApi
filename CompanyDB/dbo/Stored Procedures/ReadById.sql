
CREATE PROCEDURE ReadById
	@id int
AS
BEGIN
	SELECT Orders.Id, ProductName, ProductType.TypeName, Price, CountOfProduct, OrderSum, Name, Surname, LastName, Phone, Adress, Email, DateOfOrder  FROM Orders
	JOIN Users ON Users.Id = Orders.UserId
	JOIN Products ON Products.Id = Orders.Id
	JOIN ProductType ON ProductType.Id = Products.ProductTypeId
	WHERE Orders.Id = @id
END
