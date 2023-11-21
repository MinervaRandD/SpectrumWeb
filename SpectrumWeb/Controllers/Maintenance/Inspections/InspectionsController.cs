using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Utilities;

namespace SpectrumWeb.Controllers.Maintenance.Inspections
{
    public class InspectionsController : Controller
    {
        private readonly ArmsSpectrumDevelopmentContext context;

        public InspectionsController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }

        //***********************************************//
        //           Inspection Check Names              //
        //***********************************************//

        List<FieldSpec> InspectionCheckNamesDisplayFieldList = new List<FieldSpec>()
            {
                new FieldSpec("InspectionName", "Inspection Name", "InspectionName", "left", 160),
                new FieldSpec("Description", "Description", "Description", "left", 240),
                new FieldSpec("AcftType", "Acft Type", "AcftType", "center", 60),
                new FieldSpec("ResetToZero", "Reset To Zero", "ResetToZero", "center", 52, "bool"),
                new FieldSpec("IncludeOnTaskCard", "Include On Task Card", "IncludeOnTaskCard", "center", 40, "bool"),
                new FieldSpec("OneTimeInspection", "One Time Inspect", "OneTimeInspection", "center", 40, "bool"),
                new FieldSpec("ResetToZero", "Reset To Zero", "ResetToZero", "center", 40, "bool"),
                new FieldSpec("PerfEveryHours", "Perf Every Hours", "PerfEveryHours", "right", 52),
                new FieldSpec("PerfEveryCycles", "Perf Every Cycles", "PerfEveryCycles", "right", 52),
                new FieldSpec("PerfEveryDays", "Perf Every Days", "PerfEveryDays", "right", 52),
                new FieldSpec("EarlyWindEveryHours", "Early Wind Every Hours", "EarlyWindEveryHours", "right", 52),
                new FieldSpec("EarlyWindEveryCycles", "Early Wind Every Cycles", "EarlyWindEveryCycles", "right", 52),
                new FieldSpec("EarlyWindEveryDays", "Early Wind Every Days", "EarlyWindEveryDays", "right", 52),
                new FieldSpec("LateWindEveryHours", "Late Wind Every Hours", "LateWindEveryHours", "right", 52),
                new FieldSpec("LateWindEveryCycles", "Late Wind Every Cycles", "LateWindEveryCycles", "right", 52),
                new FieldSpec("LateWindEveryDays", "Late Wind Every Days", "LateWindEveryDays", "right", 52),
                new FieldSpec("RepeatEveryHours", "Repeat Every Hours", "RepeatEveryHours", "right", 52),
                new FieldSpec("RepeatEveryCycles", "Repeat Every Cycles", "RepeatEveryCycles", "right", 52),
                new FieldSpec("RepeatEveryDays", "Repeat Every Days", "RepeatEveryDays", "right", 52),
                new FieldSpec("ThreshHours", "Thresh Hours", "ThreshHours", "right", 52),
                new FieldSpec("ThreshCycles", "Thresh Cycles", "ThreshCycles", "right", 52),
                new FieldSpec("ThreshDays", "Thresh Days", "ThreshDays", "right", 52),
                new FieldSpec("WorkPackages", "Work Packages", "WorkPackages", "right", 52),
                new FieldSpec("ComplDate", "Compl Date", "ComplDate", "center", 100, "date"),
                new FieldSpec("PartNmbr1", "Part 1", "PartNmbr1", "center", 160),
                new FieldSpec("PartNmbr2", "Part 2", "PartNmbr2", "center", 160),
                new FieldSpec("PartNmbr3", "Part 3", "PartNmbr3", "center", 160)
            };

        public IActionResult InspectionCheckNames()
        {

            var classList = context.Inspections.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                InspectionCheckNamesDisplayFieldList
                , "Inspections"
                , classList.Select(e => (object)e).ToList());

        }

        //***********************************************//
        //           Inspection Check Names              //
        //***********************************************//

        List<FieldSpec> InspectionResetsDisplayFieldList = new List<FieldSpec>()
            {
                new FieldSpec("InspectionName", "Inspection Name", "InspectionName", "left", 120),
                new FieldSpec("InspectionResetName", "Inspection Reset Name", "InspectionResetName", "left", 120)
            };

        public IActionResult InspectionResets()
        {

            var classList = (from is1 in context.InspectionResets
                             join i1 in context.Inspections on is1.MasterInspectionId equals i1.PkRecordId
                             join i2 in context.Inspections on is1.ResetInspectionId equals i2.PkRecordId
                             select new
                             {
                                 is1.PkRecordId,
                                 InspectionName = i1.InspectionName,
                                 InspectionResetName = i2.InspectionName
                             });

            return (new GenericTableController()).GenericTableGenerator(
                InspectionResetsDisplayFieldList
                , "Inspection Resets"
                , classList.Select(e => (object)e).ToList());

        }


        //***********************************************//
        //           Inspection By Tail Nmbr             //
        //***********************************************//

        List<FieldSpec> InspectionsByTailNmbrDisplayFieldList = new List<FieldSpec>()
            {
                new FieldSpec("InspectionName", "Inspection Name", "InspectionName", "left", 120),
                new FieldSpec("Description", "Description", "Description", "left", 240),
                new FieldSpec("AircraftType", "Acft Type", "AircraftType", "center", 60),
                new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "center", 60),
                new FieldSpec("LastPerformedOn", "Last Perfor On", "LastPerformedOn", "center", 80, "date"),
                new FieldSpec("HoursCurr", "Hours Curr", "HoursCurr", "right", 50),
                new FieldSpec("CyclesCurr", "Cycles Curr", "CyclesCurr", "right", 50),
                new FieldSpec("DaysCurr", "Days Curr", "DaysCurr", "right", 50),
                new FieldSpec("HoursSinceNew", "Hours Since New", "HoursSinceNew", "right", 50),
                new FieldSpec("CyclesSinceNew", "Cycles Since New", "CyclesSinceNew", "right", 50),
                new FieldSpec("DaysSinceNew", "Days Since New", "DaysSinceNew", "right", 50),
                new FieldSpec("HoursCurrAirframe", "Hours Curr Airframe", "HoursCurrAirframe", "right", 50),
                new FieldSpec("CyclesCurrAirframe", "Cycles Curr Airframe", "CyclesCurrAirframe", "right", 50),
                new FieldSpec("DaysCurrAirframe", "Days Curr Airframe", "DaysCurrAirframe", "right", 50),
                new FieldSpec("PerformedTimes", "Performed Times", "PerformedTimes", "right", 50),
                new FieldSpec("LastAppliedOnDate", "Last Applied On", "LastAppliedOnDate", "center", 80, "date"),
                new FieldSpec("CurrWorkPckgNmbr", "Curr Work Pckg Nmbr", "CurrWorkPckgNmbr", "right", 50),
                new FieldSpec("ResetToZero", "Reset To Zero", "ResetToZero", "center", 48, "bool"),
                new FieldSpec("DaysToAccomplish", "Days To Accomplish", "DaysToAccomplish", "right", 50),
                new FieldSpec("TerminateInspection", "Terminate Inspect", "TerminateInspection", "center", 48, "bool")
            };

        public IActionResult InspectsByTailNmbr()
        {


            var classList =
                (from ibt in context.InspectionsByTailNmbrs
                 join am in context.AcMasters on ibt.TailNmbr equals am.TailNmbr
                 join ins in context.Inspections on ibt.InspectionId equals ins.PkRecordId
                 select new
                 {
                     ibt.PkRecordId,
                     ins.InspectionName,
                     ibt.Description,
                     am.AircraftType,
                     ibt.TailNmbr,
                     ibt.LastPerformedOn,
                     ibt.HoursCurr,
                     ibt.CyclesCurr,
                     ibt.DaysCurr,
                     ibt.HoursSinceNew,
                     ibt.CyclesSinceNew,
                     ibt.DaysSinceNew,
                     ibt.HoursCurrAirframe,
                     ibt.CyclesCurrAirframe,
                     ibt.DaysCurrAirframe,
                     ibt.PerformedTimes,
                     ibt.LastAppliedOnDate,
                     ibt.CurrWorkPckgNmbr,
                     ibt.ResetToZero,
                     ibt.DaysToAccomplish,
                     ibt.TerminateInspection
                 }).ToList();


            return (new GenericTableController()).GenericTableGenerator(
                InspectionsByTailNmbrDisplayFieldList
                , "Inspections"
                , classList.Select(e => (object)e).ToList());

        }

        //***********************************************//
        //           Inspection By Part Nmbr             //
        //***********************************************//

        List<FieldSpec> InspectionsByPartNmbrDisplayFieldList = new List<FieldSpec>()
            {
                new FieldSpec("InspectionName", "Inspection Name", "InspectionName", "left", 120),
                new FieldSpec("Description", "Description", "Description", "left", 240),
                new FieldSpec("PartNmbr", "Part Nmbr", "PartNmbr", "left", 120),
                new FieldSpec("SerialNmbr", "Serial Nmbr", "SerialNmbr", "left", 120),
                new FieldSpec("AcftType", "Acft Type", "AcftType", "center", 60),
                new FieldSpec("LastAppliedOnDate", "Last Applied On", "LastAppliedOnDate", "center", 80, "date"),
                new FieldSpec("HoursCurr", "Hours Curr", "HoursCurr", "right", 50),
                new FieldSpec("CyclesCurr", "Cycles Curr", "CyclesCurr", "right", 50),
                new FieldSpec("DaysCurr", "Days Curr", "DaysCurr", "right", 50),
                new FieldSpec("HoursSinceNew", "Hours Since New", "HoursSinceNew", "right", 50),
                new FieldSpec("CyclesSinceNew", "Cycles Since New", "CyclesSinceNew", "right", 50),
                new FieldSpec("DaysSinceNew", "Days Since New", "DaysSinceNew", "right", 50),
                new FieldSpec("HoursOverride", "Hours Override", "HoursOverride", "right", 50),
                new FieldSpec("CyclesOverride", "Cycles Override", "CyclesOverride", "right", 50),
                new FieldSpec("DaysOverride", "Days Override", "DaysOverride", "right", 50),
                new FieldSpec("PerformedTimes", "Performed Times", "PerformedTimes", "right", 50),
                new FieldSpec("LastPerformedOn", "Last Performed On", "LastPerformedOn", "center", 80, "date"),
                new FieldSpec("CurrWorkPckgNmbr", "Curr Work Pckg Nmbr", "CurrWorkPckgNmbr", "right", 50),
                new FieldSpec("ResetToZero", "Reset To Zero", "ResetToZero", "center", 48, "bool"),
                new FieldSpec("DaysToAccomplish", "Days To Accomplish", "DaysToAccomplish", "right", 50),
                new FieldSpec("TerminateInspection", "Terminate Inspect", "TerminateInspection", "center", 48, "bool")
            };

        public IActionResult InspectsByPartNmbr()
        {
            var classList =
               (from ibp in context.InspectionsByPartNmbrs
                select new
                {
                    ibp.PkRecordId,
                    ibp.InspectionName,
                    ibp.Description,
                    ibp.PartNmbr,
                    ibp.SerialNmbr,
                    ibp.AcftType,
                    ibp.LastAppliedOnDate,
                    ibp.HoursCurr,
                    ibp.CyclesCurr,
                    ibp.DaysCurr,
                    ibp.HoursSinceNew,
                    ibp.CyclesSinceNew,
                    ibp.DaysSinceNew,
                    ibp.HoursOverride,
                    ibp.CyclesOverride,
                    ibp.DaysOverride,
                    ibp.PerformedTimes,
                    ibp.LastPerformedOn,
                    ibp.CurrWorkPckgNmbr,
                    ibp.ResetToZero,
                    ibp.DaysToAccomplish,
                    ibp.TerminateInspection
                }).ToList();


            return (new GenericTableController()).GenericTableGenerator(
                InspectionsByPartNmbrDisplayFieldList
                , "Inspections By Part Number"
                , classList.Select(e => (object)e).ToList());

        }

        //***********************************************//
        //           Inspection Results                  //
        //***********************************************//

        public IActionResult InspectResults()
        {
            return View("/Views/TestViews/TestView1.cshtml");
        }
    }
}
