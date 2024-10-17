using System;
using System.Collections.Generic;

namespace Monitoring.Models;

public partial class ViewUnscheduledMaintenanceFrequency
{
    public string? EquipmentName { get; set; }

    public int? UnscheduledMaintenanceCount { get; set; }
}
