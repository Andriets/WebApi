
CREATE PROCEDURE UpdateOrder
	@OrderId int,
	@Prodid int,
	@count int,
	@user int,
	@date datetime
AS
	DECLARE @sum float
	SELECT @sum = @count * Products.Price FROM Products WHERE @Prodid = Id
BEGIN
	UPDATE Orders
	SET ProductId=@Prodid, CountOfProduct=@count, OrderSum=@sum, UserId=@user, DateOfOrder=@date WHERE Id = @OrderId
END
