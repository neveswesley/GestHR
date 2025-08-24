﻿namespace GestHR.Domain.Entities;

public class AuditLog : BaseEntity
{
    public Guid UserId { get; set; }
    public string Action { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string Details { get; set; } = string.Empty;
}