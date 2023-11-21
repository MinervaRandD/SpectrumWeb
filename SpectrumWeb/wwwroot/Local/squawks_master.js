class SquawksMasterClass {
    PkRecordId;
    TransactId;
    SquawkNumber;
    TypeCode;
    AtaChapCode;
    DateReceived;
    ReportedBy;
    DateDispDuDef;
    FlightLogNmbr;
    ItemNmbr;
    Flight;
    DateComp;
    WorkOrderNmbr;
    PartNumbers;
    EtopsSignific;
    EtopsConfirmed;
    ByWhom;
    EtopsVerified;
    ByWho;
    CatIIISignif;
    CatIIIVerified;
    CatIIIApproach;
    CatIIILndgTyp;
    TextProbAndResolu;
    EngPositionNmbr;
    TailNmbr;
    City;
    EngineShutDown;
    DelayYN;
    CancellationYN;
    ServiceDiffYN;
    AtaChapAndSub;
    AtaParagraph;
    MinEquipList;
    AirframeAtSqwk;
    AFWhenDone;
    DelayMinutes;
    DmiNumber;
    AuditPrint;
    WhoFixed;
    FirstInspector;
    SecondInspector;
    SerialNumbers;

    constructor(
        pkRecordId,
        transactId,
        squawkNumber,
        typeCode,
        ataChapCode,
        dateReceived,
        reportedBy,
        dateDispDuDef,
        flightLogNmbr,
        itemNmbr,
        flight,
        dateComp,
        workOrderNmbr,
        partNumbers,
        etopsSignific,
        etopsConfirmed,
        byWhom,
        etopsVerified,
        byWho,
        catIIISignif,
        catIIIVerified,
        catIIIApproach,
        catIIILndgTyp,
        textProbAndResolu,
        engPositionNmbr,
        tailNmbr,
        city,
        engineShutDown,
        delayYN,
        cancellationYN,
        serviceDiffYN,
        ataChapAndSub,
        ataParagraph,
        minEquipList,
        airframeAtSqwk,
        aFWhenDone,
        delayMinutes,
        dmiNumber,
        auditPrint,
        whoFixed,
        firstInspector,
        secondInspector,
        serialNumbers
    ) {
        this.PkRecordId = pkRecordId;
        this.TransactId = transactId;
        this.SquawkNumber = squawkNumber;
        this.TypeCode = typeCode;
        this.AtaChapCode = ataChapCode;
        this.DateReceived = new Date(dateReceived);
        this.ReportedBy = reportedBy;
        this.DateDispDuDef = dateDispDuDef;
        this.FlightLogNmbr = flightLogNmbr;
        this.ItemNmbr = itemNmbr;
        this.Flight = flight;
        this.DateComp = dateComp;
        this.WorkOrderNmbr = workOrderNmbr;
        this.PartNumbers = partNumbers;
        this.EtopsSignific = etopsSignific;
        this.EtopsConfirmed = etopsConfirmed;
        this.ByWhom = byWhom;
        this.EtopsVerified = etopsVerified;
        this.ByWho = byWho;
        this.CatIIISignif = catIIISignif;
        this.CatIIIVerified = catIIIVerified;
        this.CatIIIApproach = catIIIApproach;
        this.CatIIILndgTyp = catIIILndgTyp;
        this.TextProbAndResolu = textProbAndResolu;
        this.EngPositionNmbr = engPositionNmbr;
        this.TailNmbr = tailNmbr;
        this.City = city;
        this.EngineShutDown = engineShutDown;
        this.DelayYN = delayYN;
        this.CancellationYN = cancellationYN;
        this.ServiceDiffYN = serviceDiffYN;
        this.AtaChapAndSub = ataChapAndSub;
        this.AtaParagraph = ataParagraph;
        this.MinEquipList = minEquipList;
        this.AirframeAtSqwk = airframeAtSqwk;
        this.AFWhenDone = aFWhenDone;
        this.DelayMinutes = delayMinutes;
        this.DmiNumber = dmiNumber;
        this.AuditPrint = auditPrint;
        this.WhoFixed = whoFixed;
        this.FirstInspector = firstInspector;
        this.SecondInspector = secondInspector;
        this.SerialNumbers = serialNumbers;
    }
}
