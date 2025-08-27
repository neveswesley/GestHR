namespace GestHR.Application.UseCases.Employee.Queries.GetAllEmployee;

public sealed record GetAllEmployeeResponse(
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