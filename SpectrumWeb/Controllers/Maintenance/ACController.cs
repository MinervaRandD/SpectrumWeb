using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class ACController : Controller
    {
       
        private readonly ArmsSpectrumDevelopmentContext context;

        public ACController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }


        List<FieldSpec> displayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("tailNmbr", "Tail Nmbr", "TailNmbr", "center", 80),
            new FieldSpec("aircraftType", "Acft Type", "AircraftType", "center", 80),
            new FieldSpec("serialNmbr", "Serial Nmbr", "SerialNmbr", "center", 120),
            new FieldSpec("description", "Description", "Description", "left", 240),
            new FieldSpec("dateAcquired", "Date Acquired", "DateAcquired", "center", 80, "date"),
            new FieldSpec("daysInService", "Days In Svc", "DaysInService", "right", 80),
            new FieldSpec("daysOutOfSvc", "Days Out Of Svc", "DaysOutOfSvc", "right", 80),
            new FieldSpec("statusState", "Status", "StatusState", "center", 90),
            new FieldSpec("maintBase", "Maint Base", "MaintBase", "center", 80),
            new FieldSpec("acIdnt", "Acft Idnt", "AcIdnt", "center", 80),    
            new FieldSpec("hours", "Hours", "Hours", "center", 80),
            new FieldSpec("checkForRemvl", "Check For Remvl", "CheckForRemvl", "center", 48, "bool"),
            new FieldSpec("cycles", "Cycles", "Cycles", "right", 80),
            new FieldSpec("frstClassSeats", "Frst Seats", "FrstClassSeats", "right", 80),
            new FieldSpec("busClassSeats", "Bus Seats", "BusClassSeats", "right", 80),
            new FieldSpec("coachSeats", "Cch Seats", "CoachSeats","right",  80),
            new FieldSpec("incRelRpts", "Inc Rel Rpts", "IncRelRpts", "center", 48, "bool")
        };

        public IActionResult Aircraft()
        {
            List<AcMaster> classList = context.AcMasters.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                displayFieldList
                , "Aircraft"
                , classList.Select(e => (object)e).ToList());
        }
    }
}
