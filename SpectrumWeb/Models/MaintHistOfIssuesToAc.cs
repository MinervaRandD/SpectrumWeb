using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class MaintHistOfIssuesToAc
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string? TailNmbr { get; set; }

    public string? PartNmbr { get; set; }

    public int? VendorBatch { get; set; }

    public DateOnly? Date { get; set; }

    public int? IssueNumber { get; set; }

    public double? HoursSinceNew { get; set; }

    public double? HoursAtIntsall { get; set; }

    public double? HoursThisInst { get; set; }

    public double? CyclsSinceNew { get; set; }

    public double? CyclsAtIntsall { get; set; }

    public double? CyclsThisInst { get; set; }

    public short? WeeksSinceNew { get; set; }

    public short? WeeksAtIntsall { get; set; }

    public short? WeeksThisInst { get; set; }

    public double? HoursTbo { get; set; }

    public short? WeeksTbo { get; set; }

    public double? CyclsTbo { get; set; }

    public double? HoursTso { get; set; }

    public short? WeeksTso { get; set; }

    public double? CyclsTso { get; set; }

    public short? MatchToReceipt { get; set; }

    public short? AtaCode { get; set; }

    public double? OverrideAfHrs { get; set; }

    public int? OverrideAFCyc { get; set; }

    public int? OverrideAFDay { get; set; }

    public short? AtaParagraph { get; set; }

    public string? SerialNmbr { get; set; }

    public string? JobCardNmbr { get; set; }
}
