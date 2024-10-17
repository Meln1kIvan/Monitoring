using System;
using System.Collections.Generic;

namespace Monitoring.Models;

public partial class MaintenanceType
{
    public int MaintenanceTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CompletedWork> CompletedWorks { get; set; } = new List<CompletedWork>();

    public virtual ICollection<MaintenanceSchedule> MaintenanceSchedules { get; set; } = new List<MaintenanceSchedule>();
}
