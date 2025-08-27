namespace GestHR.Application.UseCases.Employee.Queries.GetByIdEmployee;

public sealed record GetByIdEmployeeResponse(
    Guid Id, 
    string FullName, 
    string CorporateEmail, 
    DateTime HireDate, 
    decimal BaseSalary, 
    Guid? PositionId,
    string PositionName,
    Guid? DepartmentId, 
    string DepartmentName,
    Guid? UserId,
    string UserName);