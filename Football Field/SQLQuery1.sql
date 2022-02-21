CREATE TABLE [dbo].[EmployeeTb1] (
    [EmployeeId]       VARCHAR (10) NOT NULL,
    [EmployeeName]     VARCHAR (50) NOT NULL,
    [EmployeeAddress]  VARCHAR (50) NOT NULL,
    [EmployeePosition] VARCHAR (50) NOT NULL,
    [EmployeeDBO]      VARCHAR (50) NOT NULL,
    [EmployeePhone]    VARCHAR (20) NOT NULL,
    [EmployeeEdu]      VARCHAR (50) NOT NULL,
    [EmployeeGender]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

