class ACMasterClass {
    PkRecordId;
    TransactId;
    TailNmbr;
    SerialNmbr;
    Description;
    DateAcquired;
    DateDispDuDef;
    DaysInService;
    DaysOutOfSvc;
    StatusState;
    MaintBase;
    AircraftType;
    AcIdnt;
    Date;
    Hours;
    CheckForRemvl;
    Cycles;
    Weeks;
    FrstClassSeats;
    BusClassSeats;
    CoachSeats;
    FltFollName;
    IncRelRpts;
    constructor(
        pkRecordId,
        transactId,
        tailNmbr,
        serialNmbr,
        description,
        dateAcquired,
        dateDispDuDef,
        daysInService,
        daysOutOfSvc,
        statusState,
        maintBase,
        aircraftType,
        acIdnt,
        date,
        hours,
        checkForRemvl,
        cycles,
        weeks,
        frstClassSeats,
        busClassSeats,
        coachSeats,
        fltFollName,
        incRelRpts
    ) {
        this.PkRecordId = pkRecordId;
        this.TransactId = transactId;
        this.TailNmbr = tailNmbr,
        this.SerialNmbr = serialNmbr,
        this.Description = description,
        this.DateAcquired = dateAcquired,
        this.DateDispDuDef = dateDispDuDef,
        this.DaysInService = daysInService,
        this.DaysOutOfSvc = daysOutOfSvc,
        this.StatusState = statusState,
        this.MaintBase = maintBase,
        this.AircraftType = aircraftType,
        this.AcIdnt = acIdnt,
        this.Date = date,
        this.Hours = hours,
        this.CheckForRemvl = checkForRemvl,
        this.Cycles = cycles,
        this.Weeks = weeks,
        this.FrstClassSeats = frstClassSeats,
        this.BusClassSeats = busClassSeats,
        this.CoachSeats = coachSeats,
        this.FltFollName = fltFollName,
        this.IncRelRpts = incRelRpts
    }
}