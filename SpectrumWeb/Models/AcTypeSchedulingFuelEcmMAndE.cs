using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class AcTypeSchedulingFuelEcmMAndE
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? TypeCode { get; set; }

    public string? Description { get; set; }

    public string? ActyAbbreviatn { get; set; }

    public short? NmbrSeatsOnAcft { get; set; }

    public short? NmbrInFlightCrew { get; set; }

    public short? NmbrInCabinCrew { get; set; }

    public double? TaxiFuel { get; set; }

    public double? FlightFuel { get; set; }

    public short? CabACNmbr { get; set; }

    public string? NmbrInCrew { get; set; }

    public short? EgtOffset { get; set; }

    public short? FFOffset { get; set; }

    public short? RpmOffset { get; set; }

    public short? ThrotOffset { get; set; }

    public double? AvgMachNmbr { get; set; }

    public short? PressAlt { get; set; }

    public short? GrossWeight { get; set; }

    public double? ChartEpr { get; set; }

    public double? SpecificRange { get; set; }

    public short? FuelFlow { get; set; }

    public short? GradientFactor { get; set; }

    public short? ReactionFactor { get; set; }

    public short? EgtLowerLimit { get; set; }

    public short? EgtUpperLimit { get; set; }

    public short? FFLowerLimit { get; set; }

    public short? FFUpperLimit { get; set; }

    public short? N1n2LowerLimit { get; set; }

    public short? N1n2UpperLimit { get; set; }

    public short? ThrotlLowerLim { get; set; }

    public short? ThrotlUpperLim { get; set; }

    public short? NbrOfEngines { get; set; }

    public short? FrstClassSeats { get; set; }

    public short? BusClassSeats { get; set; }

    public short? CoachClassSeat { get; set; }
}
