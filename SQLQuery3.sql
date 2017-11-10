USE [db_bookstore]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_addHDXbyID]
		@iMaNV = 4,
		@dNgaynhapsach = N'30-2-2017',
		@sMasach = N'SACH_06',
		@fGianhap = 6000,
		@fSoluongnhap = 3

SELECT	@return_value as 'Return Value'

GO
