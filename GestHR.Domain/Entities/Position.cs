namespace GestHR.Domain.Entities;

public class Position : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public decimal BaseSalary { get; set; }
}