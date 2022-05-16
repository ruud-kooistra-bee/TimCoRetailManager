CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, FirstName, LastName, EmailAddress, CreatedDate, RoleId
	FROM [dbo].[User]
	WHERE Id = @Id;
END
RETURN 0;
