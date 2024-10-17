using System;
using System.Collections.Generic;

namespace Monitoring.Models;

public partial class ViewMaintenanceCostAnalysis
{
    public string? EquipmentName { get; set; }

    public decimal? TotalMaintenanceCost { get; set; }
}
