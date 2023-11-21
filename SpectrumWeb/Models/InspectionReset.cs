using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class InspectionReset
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public string MasterInspectionId { get; set; } = null!;

    public string ResetInspectionId { get; set; } = null!;
}
