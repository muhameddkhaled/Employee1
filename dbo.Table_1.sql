CREATE TABLE [dbo].[EmployeeTb1]
(
	[Empld] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpGen] VARCHAR(10) NOT NULL, 
    [EmpDep] INT NOT NULL, 
    [EmpDOB] INT NOT NULL, 
    [EmpJDate] DATE NOT NULL, 
    [Empsal] INT NOT NULL
	CONSTRAINT [FK] FOREIGN KEY ([EmpDep]) REFERENCES [DepatmentTb1]([Depid])
)
