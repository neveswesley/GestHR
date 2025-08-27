using MediatR;

namespace GestHR.Application.UseCases.Employee.Commands.CreateEmployee;

public sealed record CreateEmployeeCommand(
    string FullName, 
    string CPF, 
    string CorporateEmail, 
    DateTime HireDate, 
    decimal BaseSalary) 
    : IRequest<CreateEmployeeResponse>;