USE [NeoquantEmployee]
GO
/****** Object:  StoredProcedure [dbo].[spAddEmployee]    Script Date: 10/19/2020 01:29:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC dbo.spAddEmployee @Name = 'ABCS',@Address='Thane',@JoiningDate='12/12/2020',@Salary='1500',@DepartmentId=1;


CREATE procedure [dbo].[spAddEmployee]         
(        
    @Name VARCHAR(20),         
    @Address VARCHAR(20),        
    @JoiningDate Date,        
    @Salary VARCHAR(6),
    @Department int
)        
as         
Begin         
    Insert into employees (EMP_NAME,EMP_ADDRESS,JOINING_DATE, SALARY,DEPARTMENT_ID)         
    Values (@Name,@Address,@JoiningDate, @Salary,@Department)         
End
GO
