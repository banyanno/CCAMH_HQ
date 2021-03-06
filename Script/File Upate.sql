USE [TEHScreening]
GO

/****** Object:  Table [dbo].[SCREENING_BOOK]    Script Date: 08/27/2018 16:40:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SCREENING_BOOK](
	[SCREEN_BOOKID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SCREAN_DATE] [datetime] NULL,
	[SYS_SETTING] [numeric](18, 0) NULL,
	[SCREEN_PLACE] [nvarchar](50) NULL,
	[PATIENT_NO] [numeric](18, 0) NULL,
	[IS_REFRACTION] [bit] NULL,
	[IS_OPTICALSHOP] [bit] NULL,
	[IS_REFER_PICKUP] [bit] NULL,
	[IS_REFER_BYSELF] [bit] NULL,
	[SCREEN_NOTE] [nvarchar](150) NULL,
 CONSTRAINT [PK_SCREENING_BOOK] PRIMARY KEY CLUSTERED 
(
	[SCREEN_BOOKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



USE [TEHScreening]
GO

/****** Object:  View [dbo].[SCREENING_BOOK_VIEW]    Script Date: 08/27/2018 16:39:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[SCREENING_BOOK_VIEW]
AS
SELECT     dbo.SCREENING_BOOK.SCREAN_DATE, dbo.TblPatients.PatientNo, dbo.TblPatients.NameEng, dbo.TblPatients.NameKhmer, dbo.TblPatients.Age, dbo.TblPatients.Sex, dbo.TblPatients.Address, 
                      dbo.SCREENING_BOOK.SCREEN_PLACE, dbo.SCREENING_BOOK.SCREEN_BOOKID, dbo.SCREENING_BOOK.IS_REFRACTION, dbo.SCREENING_BOOK.IS_OPTICALSHOP, 
                      dbo.SCREENING_BOOK.IS_REFER_PICKUP, dbo.SCREENING_BOOK.IS_REFER_BYSELF, dbo.SCREENING_BOOK.SYS_SETTING, dbo.SCREENING_BOOK.SCREEN_NOTE
FROM         dbo.TblPatients INNER JOIN
                      dbo.SCREENING_BOOK ON dbo.TblPatients.PatientNo = dbo.SCREENING_BOOK.PATIENT_NO

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[33] 2[3] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblPatients"
            Begin Extent = 
               Top = 32
               Left = 71
               Bottom = 328
               Right = 240
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "SCREENING_BOOK"
            Begin Extent = 
               Top = 36
               Left = 416
               Bottom = 297
               Right = 595
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2280
         Alias = 900
         Table = 3480
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SCREENING_BOOK_VIEW'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SCREENING_BOOK_VIEW'
GO

