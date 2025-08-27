using MediatR;

namespace GestHR.Application.UseCases.Employee.Queries.GetByIdEmployee;

public sealed record GetByIdEmployeeQuery(Guid Id) : IRequest<GetByIdEmployeeResponse>;
