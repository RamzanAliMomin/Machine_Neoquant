USE [NeoquantEmployee]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllEmployees]    Script Date: 10/19/2020 01:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGetAllEmployees]      
as      
Begin      
    select  employees.EMPLOYEE_ID,
	    employees.EMP_NAME,
	    employees.EMP_ADDRESS,
	    employees.JOINING_DATE,
	    employees.SALARY ,
	    departments.DEPARTMENT_NAME
	    from employees INNER JOIN departments  on employees.DEPARTMENT_ID=departments.DEPARTMENT_ID
 
    order by employees.EMPLOYEE_ID      
End
GO
