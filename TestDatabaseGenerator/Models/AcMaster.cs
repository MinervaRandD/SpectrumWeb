using System;
using System.Collections.Generic;

namespace TestDatabaseGenerator.Models;

public partial class AcMaster
{
    public long PkTransactId { get; set; }

    public string? TailNmbr { get; set; }

    public string? SerialNmbr { get; set; }

    public string? Description { get; set; }

    public DateTime? DateAcquired { get; set; }

    public DateTime? DateDispDuDef { get; set; }

    public int? DaysInService { get; set; }

    public int? DaysOutOfSvc { get; set; }

    public string? StatusState { get; set; }

    public string? MaintBase { get; set; }

    public string? AircraftType { get; set; }

    public string? AcIdnt { get; set; }

    public DateTime? Date { get; set; }

    public double? Hours { get; set; }

    public string? CheckForRemvl { get; set; }

    public int? Cycles { get; set; }

    public short? Weeks { get; set; }

    public short? FrstClassSeats { get; set; }

    public short? BusClassSeats { get; set; }

    public short? CoachSeats { get; set; }

    public string? FltFollName { get; set; }

    public string? IncRelRpts { get; set; }
}
