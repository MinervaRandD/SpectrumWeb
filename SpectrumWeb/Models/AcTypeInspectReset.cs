using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class AcTypeInspectReset
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? AircraftType { get; set; }

    public string? InspectName { get; set; }

    public string? NameToBeReset { get; set; }
}
