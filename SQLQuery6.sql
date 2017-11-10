USE [db_bookstore]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_addHDXbyID]
		@iSoHD1 = 6,
		@iSoHD2 = 6,
		@iMaNV = 3,
		@dNgaynhapsach = N'2-3-2017',
		@sMasach = N'SACH_03',
		@fGianhap = 2000,
		@fSoluongnhap = 3

SELECT	@return_value as 'Return Value'

GO
