namespace GestHR.Domain.Entities;

public class Employee : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string CorporateEmail { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public decimal BaseSalary { get; set; }

    public Guid? PositionId { get; set; }
    public Guid? DepartmentId { get; set; }
    public Guid? UserId { get; set; }
    
    public void AssignDepartment(Guid departmentId) => DepartmentId = departmentId;
    public void AssignPosition(Guid positionId) => PositionId = positionId;
    public void AssignUser(Guid userId) => UserId = userId;
    
}