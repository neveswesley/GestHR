namespace GestHR.Domain.Entities;

public class Payroll : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal GrossSalary { get; set; }
    public decimal Deductions { get; set; }
    public decimal Benefits { get; set; }
    public decimal NetSalary { get; set; }
    public DateTime GenerateAt { get; set; }
}