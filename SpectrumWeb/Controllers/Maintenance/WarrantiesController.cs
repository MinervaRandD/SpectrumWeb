using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class WarrantiesController : Controller
    {
       
        private readonly ArmsSpectrumDevelopmentContext context;

        public WarrantiesController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }


        List<FieldSpec> displayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Number", "Number", "Number", "center", 120)
            ,new FieldSpec("PartNumber", "Part<br/>Number", "PartNumber", "center", 120)
            ,new FieldSpec("SerialNmbr", "Serial<br/>Number", "SerialNmbr", "center", 120)
            ,new FieldSpec("DateReceived", "Date<br/>Received", "DateReceived", "center", 80, "date")
            ,new FieldSpec("HoursGuaranteed", "Hours<br/>Guaranteed", "HoursGuaranteed", "right", 80, "#,##0.0")
            ,new FieldSpec("CyclesGuaranteed", "Cycles<br/>Guaranteed", "CyclesGuaranteed", "right", 80)
            ,new FieldSpec("WeeksGuaranteed", "Weeks<br/>Guaranteed", "WeeksGuaranteed", "right", 80)
            ,new FieldSpec("HoursAtInstall", "Hours At<br/>Install", "HoursAtInstall", "right", 80)
            ,new FieldSpec("CyclesAtInstall", "Cycles At<br/>Install", "CyclsAtInstall", "right", 80)
            ,new FieldSpec("WeeksAtInstall", "Weeks At<br/>Install", "WeeksAtInstall", "right", 80)
            ,new FieldSpec("TermsTerminalNmbr", "Terms<br/>Terminal", "TermsTerminalNmbr", "center",120)
            ,new FieldSpec("Notes", "Notes", "Notes", "left", 120)
            ,new FieldSpec("ExchangedSerNmbr", "Exchanged<br/>Serial<br/>Number","ExchangedSerNmbr", "center", 120)
            ,new FieldSpec("ControlTag", "Control<br/>Tag", "ControlTag", "center", 120)
            ,new FieldSpec("VendorNumber", "Vendor<br/>Number", "VendorNumber", "center", 120)
            ,new FieldSpec("AtaChap", "ATA<br/>Chap", "AtaChap", "center", 50)
        };

        List<FieldSpec> childFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Terms", "Terms", "Terms", "Left", 500)
        };

        public IActionResult Warranties()
        {
            List<GuaranteeWarranty> classList = context.GuaranteeWarranties.ToList();

            List<string> childRows = new List<string>()
            {
                "TermsTerminalNmbr"
            };

            List<object> childRowField = new List<object>();

            foreach (GuaranteeWarranty guaranteeWarranty in classList)
            {
                //List<object> fieldList = new List<object>();

                if (guaranteeWarranty.HoursGuaranteed.HasValue)
                {
                    guaranteeWarranty.HoursGuaranteed = Math.Round(guaranteeWarranty.HoursGuaranteed.Value, 1);
                }

                if (guaranteeWarranty.HoursAtInstall.HasValue)
                {
                    guaranteeWarranty.HoursAtInstall = Math.Round(guaranteeWarranty.HoursAtInstall.Value, 1);
                }
            }

            return (new GenericTableController()).GenericTableGenerator(
                displayFieldList
                , "Guarantees and Warranties"
                , classList.Select(e => (object)e).ToList()
                , childRows);
        }
    }
    
}
