
CREATE PROCEDURE AddOrder
	@Prodid int,
	@count int,
	@user int,
	@date datetime
AS
	DECLARE @sum float
	SELECT @sum = @count * Products.Price FROM Products WHERE @Prodid = Id
BEGIN
	INSERT INTO Orders(ProductId, CountOfProduct, OrderSum, UserId, DateOfOrder) 
	VALUES(@Prodid, @count, @sum, @user, @date)
END
