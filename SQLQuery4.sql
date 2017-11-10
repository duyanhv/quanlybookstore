USE [db_bookstore]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_addHDXbyID]
		@iSoHD1 = 4,
		@iSoHD2 = 4,
		@iMaNV = 5,
		@dNgaynhapsach = N'1-2-2017',
		@sMasach = N'SACH_03',
		@fGianhap = 4000,
		@fSoluongnhap = 3

SELECT	@return_value as 'Return Value'

GO
