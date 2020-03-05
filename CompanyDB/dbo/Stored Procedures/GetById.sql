CREATE PROCEDURE GetById
	@tableName nvarchar,
	@id int
AS
BEGIN
	declare @tableX nvarchar
	select @tableX = QUOTENAME(@tableName)
	declare @sql nvarchar
	select @sql = 'select * from ' + @tableX + ' where Id = ' + @id +';' 

		exec(@sql)
END