namespace GestHR.Domain.Entities;

public class Attendence : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public DateTime Date { get; set; }
    public DateTime? CheckIn { get; set; }
    public DateTime? CheckOut { get; set; }
    public string Notes { get; set; } = string.Empty;
}