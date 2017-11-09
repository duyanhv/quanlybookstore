USE [db_bookstore]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_getHDXbyID]
		@iSoHD = 2

SELECT	@return_value as 'Return Value'

GO
