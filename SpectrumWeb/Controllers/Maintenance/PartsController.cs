using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Utilities;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class PartsController : Controller
    {
        private readonly ArmsSpectrumDevelopmentContext context;

        public PartsController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }

        List<FieldSpec> displayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("PartNumber", "Part\nNmbr", "PartNumber", "center", 120),
            new FieldSpec("PartDesignator", "Part\nDesig.", "PartDesignator"),
            new FieldSpec("QtyOutForRepr", "Qty\nOut\nFor\nRepr", "QtyOutForRepr"),
            new FieldSpec("Allotment", "Allot.", "Allotment"),
            new FieldSpec("InSuspense", "In Suspense", "InSuspense"),
            new FieldSpec("OrderQuantity", "Order\nQty", "OrderQuantity"),
            new FieldSpec("NumberOfSpares", "Nmbr\nOf\nSpares", "NumberOfSpares"),
            new FieldSpec("LastPoNmbr", "Last PO Nmbr", "LastPoNmbr"),
            new FieldSpec("LastPoType", "Last PO Type", "LastPoType"),
            new FieldSpec("LastPrice", "LastPrice", "LastPrice"),
            new FieldSpec("CurrentPrice", "Curr Price", "CurrentPrice"),
            new FieldSpec("AveragePrice", "Ave Price", "AveragePrice"),
            new FieldSpec("NotesOnPart", "Notes", "NotesOnPart"),
            new FieldSpec("LastInventDate", "Last Inv Date", "LastInventDate"),
            new FieldSpec("PhyCycleNmbr", "Phy Cycle Nmbr", "PhyCycleNmbr"),
            new FieldSpec("LastIssueDate", "Last Issue Date", "LastIssueDate"),
            new FieldSpec("LastRecvdDate", "Last Recvd Date", "LastRecvdDate"),
            new FieldSpec("Used", "Used", "Used"),
            new FieldSpec("ShelfLocation", "Shelf Loc", "ShelfLocation"),
            new FieldSpec("BinLocation", "Bin Loc", "BinLocation"),
            new FieldSpec("QtyOnHand", "Qty On Hand", "QtyOnHand"),
            new FieldSpec("QuantityOnOrdr", "Qty On Ordr", "QuantityOnOrdr"),
            new FieldSpec("ThreeMosStaticUse", "Three Mos Stat Use", "ThreeMosStaticUse"),
            new FieldSpec("SixMosStaticUse", "Six Mos Stat Use", "SixMosStaticUse"),
            new FieldSpec("TwelveMoStaticUse", "Twelve Mos Stat Use", "TwelveMoStaticUse")
        };

        public IActionResult Parts()
        {
            
            List<PartsMaster> classList = context.PartsMasters.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                displayFieldList
                , "Parts"
                , classList.Select(e => (object)e).ToList());
        }


        List<FieldSpec> PartsOnGuaranteeWarrantyDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Expendable", "Expendable", "Expendable", "center", 60, "bool"),
            new FieldSpec("Rotable", "Rotable", "Rotable", "center", 40, "bool"),
            new FieldSpec("Repairable", "Repairable", "Repairable","center", 40, "bool"),
            new FieldSpec("PartNumber", "Part Nmbr", "PartNumber","center", 120, "bool"),
            new FieldSpec("PartType", "Part Type", "PartType","center", 60),
            new FieldSpec("AircraftType", "A/C Type", "AircraftType","center", 60),
            new FieldSpec("Warehouse", "Warehouse", "Warehouse","center", 60),
            new FieldSpec("PartDesignator", "Part Designator", "PartDesignator","center", 60),
            new FieldSpec("QtyOnHand", "Quantity On Hand", "QtyOnHand","center", 60),
            new FieldSpec("QtyOnOrdr", "Quantity On Order", "QtyOnOrdr","center", 60),
            new FieldSpec("QtyInRepair", "Quantity In Repair", "QtyInRepair","center", 60),
            new FieldSpec("QtyInSuspense", "Quantity In Suspense", "QtyInSuspense","center", 60),
            new FieldSpec("WarrantyNumber", "Warranty Number", "WarrantyNumber","center", 60),
            new FieldSpec("AveragePrice", "Average Price", "AveragePrice","center", 60),
        };

        public IActionResult PartsOnGuaranteeWarranty()
        {
            var classList = (from r0 in context.Resources0s
                             join r1 in context.Resources1s on r0.PartNumber equals r1.PartNumber
                             join p in context.PhysInvs on r0.PartNumber equals p.PartNumber
                             select new
                             {
                                 r0.PkRecordId
                                ,
                                 Expendable = true
                                ,
                                 r0.Rotable
                                ,
                                 Repairable = true
                                ,
                                 r0.PartNumber
                                ,
                                 r0.PartType
                                ,
                                 r0.AircraftType
                                ,
                                 r0.Warehouse
                                ,
                                 r0.PartDesignator
                                ,
                                 r0.QtyOnHand
                                ,
                                 r0.QtyOnOrdr
                                ,
                                 QtyInRepair = p.QtyInRepair1 + p.QtyInRepair2
                                ,
                                 QtyInSuspense = p.QtyInSuspense1 + p.QtyInSuspense2
                                ,
                                 r1.WarrantyNumber
                                ,
                                 r0.AveragePrice

                             }).ToList();

            return (new GenericTableController()).GenericTableGenerator(
                PartsOnGuaranteeWarrantyDisplayFieldList
                , "Parts On Warranty"
                , classList.Select(e => (object)e).ToList());

        }


        List<FieldSpec> ProjDueDateByPartNmbrDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("PartNmbr", "Part Nmbr", "PartNmbr", "left", 120),
            new FieldSpec("SerialNmbr", "Serial Nmbr", "SerialNmbr", "left", 120),
            new FieldSpec("AtaChapCode", "ATA Chapter", "AtaChapCode", "center", 60),
            new FieldSpec("AtaSubCode", "ATA Sub Chap", "AtaSubCode", "center", 60),
            new FieldSpec("AtaParCode", "ATA Par Code", "AtaParCode", "center", 60),
            new FieldSpec("OnAcft", "On Acft", "OnAcft", "center", 48, "bool")
        };

        //***************************************************//
        //           15 Proj Due Dates By Part Number        //
        //***************************************************//

        public IActionResult M15ProjDueDateByPartNmbr()
        {
            var classList = (from r0 in context.Resources0s
                             join r1 in context.Resources1s on r0.PartNumber equals r1.PartNumber
                             select new
                             {
                                 r0.PkRecordId,
                                 r1.SerialNmbr,
                                 PartNmbr = r0.PartNumber,
                                 AtaChapCode = SpectrumUtils.AtaChapter(r0.AtaChapCode),
                                 AtaSubCode = SpectrumUtils.AtaSubChapter(r0.AtaSubchptPara),
                                 AtaParCode = SpectrumUtils.AtaParagraph(r0.AtaSubchptPara),
                                 OnAcft = (r1.TailNmbr != null)
                             }).ToList();


            return (new M15ProjDueDateByPartNmbrController()).ProjDueDateByPartNmbrGenerator(
                ProjDueDateByPartNmbrDisplayFieldList
                , "Proj Due Date By Part Nmbr"
                , classList.Select(e => (object)e).ToList()
                , "WarrantyClass"
                , "warranties");
        }

        //***************************************************//
        //           16 Proj Due Dates By Tail Number        //
        //***************************************************//

        List<FieldSpec> ProjDueDatebyTailNmbrDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("AircraftType", "Acft Type", "AircraftType", "left", 120),
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "left", 120),
        };

        public IActionResult M16ProjDueDateByTailNmbr()
        {
            var classList = (from r0 in context.Resources0s
                             join r1 in context.Resources1s on r0.PartNumber equals r1.PartNumber
                             select new
                             {
                                 r0.PkRecordId
                                 ,
                                 r0.AircraftType
                                 ,
                                 r1.TailNmbr
                             }).ToList();


            return (new M16ProjDueDateByTailNmbrController()).ProjDueDateByTailNmbrGenerator(
                ProjDueDatebyTailNmbrDisplayFieldList
                , "Proj Due Date By Part Nmbr"
                , classList.Select(e => (object)e).ToList()
                , "WarrantyClass"
                , "warranties");
        }


        //***************************************************//
        //           18 Proj Maint By Time                   //
        //***************************************************//

        public IActionResult M18ProjMaintByTime()
        {
            return (new M18ProjMaintByTimeController()).ProjMaintByTime();
        }

        //***************************************************//
        //           19 Print Component Removals             //
        //***************************************************//

        List<FieldSpec> CompRemovalsDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("SchedRemoveYN", "Scheduled", "SchedRemoveYN", "center", 60, "bool"),
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "left", 120),
            new FieldSpec("AircraftType", "Acft Type", "AircraftType", "left", 120),
            new FieldSpec("AtaOfRemoval", "ATA Chapter", "AtaOfRemoval", "center", 80),
            new FieldSpec("AtaSubChap", "ATA Sub Chapt", "AtaSubChap", "center", 80),
            new FieldSpec("AtaParagph", "ATA Paragraph", "AtaParagrph", "center", 80),
            new FieldSpec("PartNmbr", "Part Nmbr", "PartNmbr", "center", 200),
            new FieldSpec("SerialNmbr", "Serial Nmbr", "SerialNmbr", "center", 200)
        };

        public IActionResult M19ComponentRemovals()
        {
            var classList = (from r0 in context.Resources0s
                             join s0 in context.MaintHistOfReceiptsFromAcs on r0.PartNumber equals s0.Part
                             select new
                             {
                                 r0.PkRecordId,
                                 s0.SchedRemoveYN,
                                 s0.TailNmbr,
                                 s0.Date,
                                 r0.AircraftType,
                                 s0.AtaOfRemoval,
                                 AtaSubChap = (int) (s0.AtaParagraph / 100), // ???
                                 AtaParagph = s0.AtaParagraph % 100,
                                 s0.Part,
                                 s0.SerialNmbr,
                                 s0.PostionOnAC,
                                 s0.LocationOnAC
                                 
                             }).ToList();


            return (new M19ComponentRemovalsController()).ComponentRemovalsGenerator(
                CompRemovalsDisplayFieldList
                , "Print Component Removals"
                , classList.Select(e => (object)e).ToList()
                , "WarrantyClass"
                , "warranties");
        }


        //***************************************************//
        //           22 Print Part Utilization               //
        //***************************************************//

        public IActionResult M23PartsUtilization()
        {
            return (new M22PartUtilizationController()).PartUtilization();
        }

        //***************************************************//
        //           23 Print Reliability Monitoring         //
        //***************************************************//

        List<FieldSpec> ReliabilityMonitoringDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("TailNmbr", "Tail Nmbr", "TailNmbr", "left", 120),
            new FieldSpec("AircraftType", "Acft Type", "AircraftType", "left", 120),
            new FieldSpec("PartNmbr", "Part Nmbr", "PartNmbr", "center", 200)
        };

        public IActionResult ReliabilityMonitoring()
        {
            var classList = (from r0 in context.Resources0s
                             join r1 in context.Resources1s on r0.PartNumber equals r1.PartNumber
                             select new
                             {
                                 r0.PkRecordId,
                                 r0.AircraftType,
                                 r1.TailNmbr,
                                 PartNmbr = r0.PartNumber
                             }).ToList();


            return (new M23ReliabilityMonitoringController()).ReliabilityMonitoring(
                ReliabilityMonitoringDisplayFieldList
                , "Reliability Monitoring"
                , classList.Select(e => (object)e).ToList()
                , "WarrantyClass"
                , "warranties");
        }

    }

}
