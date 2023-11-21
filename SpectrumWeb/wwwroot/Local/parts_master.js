class PartsMasterClass {
    PartNumber;
    Rwitmx;
    Rwwhse;
    PartDesignator;
    QtyOutForRepr;
    Allotment;
    InSuspense;
    OrderQuantity;
    RefnmbrLinksFiles;
    NumberOfSpares;
    Vendor1;
    Vendor2;
    Vendor3;
    CurrentPoNmbr;
    CurrentPoType;
    LastPoNmbr;
    LastPoType;
    LastPrice;
    CurrentPrice;
    AveragePrice;
    PrcBreakAvail;
    NotesOnPart;
    AvgVendLeadTm;
    AvgReprLeadTm;
    LastInventDate;
    PhyCycleNmbr;
    LastIssueDate;
    LastRecvdDate;
    GLAcctNbr;
    Used;
    ShelfLocation;
    BinLocation;
    QtyOnHand;
    QuantityOnOrdr;
    OrderLevel;
    QtyRequested;
    ExtraDta;
    PhyInvActive;
    ThreeMosStaticUse;
    SixMosStaticUse;
    TwelveMoStaticUse;
    DateUpdated;
    IssTypeInUse;
    constructor(
        partNumber,
        rwitmx,
        rwwhse,
        partDesignator,
        qtyOutForRepr,
        allotment,
        inSuspense,
        orderQuantity,
        refnmbrLinksFiles,
        numberOfSpares,
        vendor1,
        vendor2,
        vendor3,
        currentPoNmbr,
        currentPoType,
        lastPoNmbr,
        lastPoType,
        lastPrice,
        currentPrice,
        averagePrice,
        prcBreakAvail,
        notesOnPart,
        avgVendLeadTm,
        avgReprLeadTm,
        lastInventDate,
        phyCycleNmbr,
        lastIssueDate,
        lastRecvdDate,
        gLAcctNbr,
        used,
        shelfLocation,
        binLocation,
        qtyOnHand,
        quantityOnOrdr,
        orderLevel,
        extraDta,
        phyInvActive,
        threeMosStaticUse,
        sixMosStaticUse,
        twelveMoStaticUse,
        dateUpdated,
        issTypeInUse
    ) {
        this.PartNumber = partNumber;
        this.Rwitmx = rwitmx;
        this.Rwwhse = rwwhse;
        this.PartDesignator = partDesignator;
        this.QtyOutForRepr = qtyOutForRepr;
        this.Allotment = allotment;
        this.InSuspense = inSuspense;
        this.OrderQuantity = orderQuantity;
        this.RefnmbrLinksFiles = refnmbrLinksFiles;
        this.NumberOfSpares = numberOfSpares;
        this.Vendor1 = vendor1;
        this.Vendor2 = vendor2;
        this.Vendor3 = vendor3;
        this.CurrentPoNmbr = currentPoNmbr;
        this.CurrentPoType = currentPoType;
        this.LastPoNmbr = lastPoNmbr;
        this.LastPoType = lastPoType;
        this.LastPrice = lastPrice;
        this.CurrentPrice = currentPrice;
        this.AveragePrice = averagePrice;
        this.PrcBreakAvail = prcBreakAvail;
        this.NotesOnPart = notesOnPart;
        this.AvgVendLeadTm = avgVendLeadTm;
        this.AvgReprLeadTm = avgReprLeadTm;
        this.LastInventDate = lastInventDate;
        this.PhyCycleNmbr = phyCycleNmbr;
        this.LastIssueDate = lastIssueDate;
        this.LastRecvdDate = lastRecvdDate;
        this.GLAcctNbr = gLAcctNbr;
        this.Used = used;
        this.ShelfLocation = shelfLocation;
        this.BinLocation = binLocation;
        this.QtyOnHand = qtyOnHand;
        this.QuantityOnOrdr = quantityOnOrdr;
        this.OrderLevel = orderLevel;
        this.QtyRequested = orderLevel;
        this.ExtraDta = extraDta;
        this.PhyInvActive = phyInvActive;
        this.ThreeMosStaticUse = threeMosStaticUse;
        this.SixMosStaticUse = sixMosStaticUse;
        this.TwelveMoStaticUse = twelveMoStaticUse;
        this.DateUpdated = dateUpdated;
        this.IssTypeInUse = issTypeInUse;
    }
}