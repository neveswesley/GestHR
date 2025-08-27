using GestHR.Domain.Repositories;
using MediatR;

namespace GestHR.Application.UseCases.Employee.Queries.GetByIdEmployee;

public class GetByIdEmployeeHandler : IRequestHandler<GetByIdEmployeeQuery, GetByIdEmployeeResponse>
{
    
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IUserRepository _userRepository;
    private readonly IPositionRepository _positionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public GetByIdEmployeeHandler(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository, IUserRepository userRepository, IPositionRepository positionRepository, IUnitOfWork unitOfWork)
    {
        _employeeRepository = employeeRepository;
        _departmentRepository = departmentRepository;
        _userRepository = userRepository;
        _positionRepository = positionRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<GetByIdEmployeeResponse> Handle(GetByIdEmployeeQuery request, CancellationToken cancellationToken)
    {
        var employee = await _employeeRepository.GetByIdAsync(request.Id, cancellationToken);

        if (employee == null)
            throw new ApplicationException($"No employee found with id: {request.Id}");
        
        var department = employee.DepartmentId.HasValue ? await _departmentRepository.GetByIdAsync(employee.DepartmentId.Value, cancellationToken: cancellationToken) : null;
        var position = employee.PositionId.HasValue ? await _positionRepository.GetByIdAsync(employee.PositionId.Value, cancellationToken: cancellationToken) : null;
        var user = employee.UserId.HasValue ? await _userRepository.GetByIdAsync(employee.UserId.Value, cancellationToken: cancellationToken) : null;

        return new GetByIdEmployeeResponse(
            employee.Id,
            employee.FullName,
            employee.CorporateEmail,
            employee.HireDate,
            employee.BaseSalary,
            employee.DepartmentId,
            department?.Name ?? string.Empty,
            employee.PositionId,
            position?.Name ?? string.Empty,
            employee.UserId ?? Guid.Empty,
            user?.Username
            );


    }
}