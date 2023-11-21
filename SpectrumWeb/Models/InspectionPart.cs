using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class InspectionPart
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string MasterInspectionId { get; set; } = null!;

    public string PartId { get; set; } = null!;
}
