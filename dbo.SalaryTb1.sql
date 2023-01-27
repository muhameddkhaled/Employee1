CREATE TABLE [dbo].[SalaryTb1] (
    [SCode]      INT           IDENTITY (1, 1) NOT NULL,
    [Employee]   INT           NOT NULL,
    [Attendance] INT           NOT NULL,
    [Period]     VARCHAR (100) NOT NULL,
    [Amount]     INT           NOT NULL,
    [PayDate]    DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([SCode] ASC),
    CONSTRAINT [FK3] FOREIGN KEY ([Employee]) REFERENCES [dbo].[EmployeeTb1] ([EmpId])
);

