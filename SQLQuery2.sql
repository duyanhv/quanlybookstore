USE [db_bookstore]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_updateHDXbyID]
		@iSoHD1 = 1,
		@iSoHD2 = 1,
		@iMaNV = 4,
		@dNgaynhapsach = N'10-03-2015',
		@sMasach = N'SACH_04',
		@fGianhap = 5000,
		@fSoluongnhap = 5

SELECT	@return_value as 'Return Value'

GO
