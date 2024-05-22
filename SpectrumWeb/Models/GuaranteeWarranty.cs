using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class GuaranteeWarranty
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int Revision { get; set; }

    public string? Number { get; set; }

    public string? PartNumber { get; set; }

    public string? SerialNmbr { get; set; }

    public DateOnly? DateReceived { get; set; }

    public double? HoursGuaranteed { get; set; }

    public short? CyclesGuaranteed { get; set; }

    public short? WeeksGuaranteed { get; set; }

    public double? HoursAtInstall { get; set; }

    public short? CyclsAtInstall { get; set; }

    public short? WeeksAtInstall { get; set; }

    public string? Terms { get; set; }

    public string? Notes { get; set; }

    public string? ExchangedSerNmbr { get; set; }

    public int? ControlTag { get; set; }

    public string? VendorNumber { get; set; }

    public short? AtaChap { get; set; }
}
