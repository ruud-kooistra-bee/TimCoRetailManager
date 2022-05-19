CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 

	[Id], 
	[Name], 
	[Description], 
	[RetailPrice], 
	[QuantityInStock], 
	[CreateDate], 
	[LastModified]

	FROM 
	
	[dbo].[Product]

	ORDER BY 
	
	[Name];
END
