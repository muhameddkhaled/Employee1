﻿CREATE TABLE [dbo].[EmployeeTb1] (
    [EmpId]    INT          IDENTITY (1, 1) NOT NULL,
    [EmpName]  VARCHAR (50) NOT NULL,
    [EmpGen]   VARCHAR (10) NOT NULL,
    [EmpDep]   INT          NOT NULL,
    [EmpDOB]   INT          NOT NULL,
    [EmpJDate] DATE         NOT NULL,
    [Empsal]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([EmpId] ASC),
    CONSTRAINT [FK1] FOREIGN KEY ([EmpDep]) REFERENCES [dbo].[DepartmentTb1] ([Depid])
);

