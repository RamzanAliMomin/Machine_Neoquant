USE [NeoquantEmployee]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateEmployee]    Script Date: 10/19/2020 01:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spUpdateEmployee]        
(        
   @EmpId INTEGER ,      
   @Name VARCHAR(20),       
   @Address VARCHAR(20),        
   @JoiningDate Date,        
   @Salary VARCHAR(6) ,
   @Department int
   
)        
as        
begin        
   Update employeesNew         
   set EMP_NAME=@Name,        
   EMP_ADDRESS=@Address,        
   JOINING_DATE=@JoiningDate,      
   SALARY=@Salary, 
   DEPARTMENT_ID=@Department
  
   where EMPLOYEE_ID=@EmpId        
End
GO
