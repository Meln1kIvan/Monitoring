using System;
using System.Collections.Generic;

namespace Monitoring.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public virtual ICollection<CompletedWork> CompletedWorks { get; set; } = new List<CompletedWork>();

    public virtual ICollection<MaintenanceSchedule> MaintenanceSchedules { get; set; } = new List<MaintenanceSchedule>();
}
