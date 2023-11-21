using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class Transaction
{
    public string PkTransactionId { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string TableId { get; set; } = null!;

    public DateTime TransactDate { get; set; }
}
