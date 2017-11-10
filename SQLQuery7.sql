USE [db_bookstore]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_addHDXbyID]
		@iSoHD1 = 6,
		@iSoHD2 = 6,
		@iMaNV = 4,
		@dNgaynhapsach = N'3-3-2017',
		@sMasach = N'SACH_3',
		@fGianhap = 3000,
		@fSoluongnhap = 4

SELECT	@return_value as 'Return Value'

GO
