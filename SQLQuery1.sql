USE [Online_Auction]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_ValidateUser]
		@Email = N'vanshikaagrawal@gmail.com',
		@Password = N'1234567890'

SELECT	@return_value as 'Return Value'

GO
