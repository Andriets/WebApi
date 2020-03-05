CREATE PROCEDURE GetAll
	@TableName nvarchar(50) 
AS
BEGIN
	
	declare @TableX nvarchar(50) 
	if (@TableName is not null)
		select @TableX = QUOTENAME(@TableName)

	declare @query as nvarchar(MAX) 
	if (@TableX is not null)
		select @query = 'select * from ' + @TableX + ';'

	if(@query is not null)
		exec(@query)
	else
		select -1;
END