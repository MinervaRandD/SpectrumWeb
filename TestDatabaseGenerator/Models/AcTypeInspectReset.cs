using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class AcTypeInspectReset
{
    public long PkTransactId { get; set; }

    public string? AircraftType { get; set; }

    public string? InspectName { get; set; }

    public string? NameToBeReset { get; set; }
}
