USE [NeoquantEmployee]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteEmployee]    Script Date: 10/19/2020 01:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spDeleteEmployee]       
(        
   @EmpId int        
)        
as         
begin        
   Delete from employees where EMPLOYEE_ID=@EmpId        
End
GO
