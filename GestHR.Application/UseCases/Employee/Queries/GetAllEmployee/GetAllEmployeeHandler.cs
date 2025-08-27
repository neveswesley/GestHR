using GestHR.Domain.Repositories;
using MediatR;

namespace GestHR.Application.UseCases.Employee.Queries.GetAllEmployee;

public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<GetAllEmployeeResponse>>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IUserRepository _userRepository;
    private readonly IPositionRepository _positionRepository;

    public GetAllEmployeeHandler(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository,
        IUserRepository userRepository, IPositionRepository positionRepository)
    {
        _employeeRepository = employeeRepository;
        _departmentRepository = departmentRepository;
        _userRepository = userRepository;
        _positionRepository = positionRepository;
    }

    public async Task<List<GetAllEmployeeResponse>> Handle(GetAllEmployeeQuery request,
        CancellationToken cancellationToken)
    {
        var employees = await _employeeRepository.GetAllAsync(cancellationToken);

        var responses = await Task.WhenAll(employees.Select(async e =>
        {
            var department = e.DepartmentId.HasValue
                ? await _departmentRepository.GetByIdAsync(e.DepartmentId.Value, cancellationToken: cancellationToken)
                : null;
            var position = e.PositionId.HasValue
                ? await _positionRepository.GetByIdAsync(e.PositionId.Value, cancellationToken: cancellationToken)
                : null;
            var user = e.UserId.HasValue
                ? await _userRepository.GetByIdAsync(e.UserId.Value, cancellationToken: cancellationToken)
                : null;

            return new GetAllEmployeeResponse(
                e.Id,
                e.FullName,
                e.CorporateEmail,
                e.HireDate,
                e.BaseSalary,
                e.DepartmentId,
                department?.Name ?? string.Empty,
                e.PositionId,
                position?.Name ?? string.Empty,
                e.UserId,
                user?.Username);
        }));

        return responses.ToList();
    }
}