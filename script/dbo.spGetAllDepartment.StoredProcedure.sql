USE [NeoquantEmployee]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllDepartment]    Script Date: 10/19/2020 01:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spGetAllDepartment]      
as      
Begin      
       select * from  departments order by DEPARTMENT_ID

End
GO
