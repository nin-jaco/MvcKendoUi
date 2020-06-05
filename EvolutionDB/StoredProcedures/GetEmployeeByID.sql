CREATE PROC GetEmployeeByID
	@EmployeeID int
AS
select EmployeeID, EmployeeName, [Status], StatusDescription
from Employee
where [Status] = 'Active' AND EmployeeID = @EmployeeID