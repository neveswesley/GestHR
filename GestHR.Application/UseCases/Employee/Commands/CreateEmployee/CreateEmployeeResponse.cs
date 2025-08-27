namespace GestHR.Application.UseCases.Employee.Commands.CreateEmployee;

public sealed record CreateEmployeeResponse(
    Guid Id, 
    string FullName, 
    string CorporateEmail, 
    DateTime HireDate, 
    decimal BaseSalary, 
    Guid PositionId,
    string PositionName,
    Guid DepartmentId, 
    string DepartmentName,
    Guid UserId,
    string UserName);