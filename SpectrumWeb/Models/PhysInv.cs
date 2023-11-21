using System;
using System.Collections.Generic;

namespace SpectrumWeb.Models;

public partial class PhysInv
{
    public string PkRecordId { get; set; } = null!;

    public string PkTransactionId { get; set; } = null!;

    public int? CountCards { get; set; }

    public short? SerialNmbrCtCard { get; set; }

    public string? PartNumber { get; set; }

    public string? SerialNmbr { get; set; }

    public string? Description { get; set; }

    public string? UnitOfIssue { get; set; }

    public double? AccountNumber { get; set; }

    public int? QtyOnHand1 { get; set; }

    public short? QtyInRepair1 { get; set; }

    public short? QtyInSuspense1 { get; set; }

    public short? VarianceQty { get; set; }

    public double? AveragePrice { get; set; }

    public double? PurchasePrice { get; set; }

    public string? CrossRef1 { get; set; }

    public string? StatusState { get; set; }

    public string? ShelfLocation { get; set; }

    public string? BinLocation { get; set; }

    public string? NewUsedConsign { get; set; }

    public string? CategoryType { get; set; }

    public string? CityName { get; set; }

    public int? QtyOnHand2 { get; set; }

    public short? QtyInRepair2 { get; set; }

    public short? QtyInSuspense2 { get; set; }

    public DateTime? CardUpdated { get; set; }

    public string? Remarks { get; set; }

    public string? Control { get; set; }

    public string? Auditor1 { get; set; }

    public string? Auditor2 { get; set; }

    public string? UseridOfLoad { get; set; }

    public string? WsidLoaded { get; set; }

    public DateTime? DateLoaded { get; set; }

    public int? TimeLoaded { get; set; }

    public string? WhseLoadedFrom { get; set; }
}
