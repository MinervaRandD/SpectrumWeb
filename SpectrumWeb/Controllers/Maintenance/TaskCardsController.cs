using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Principal;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class TaskCardsController : Controller
    {
        private readonly ArmsSpectrumDevelopmentContext context;

        public TaskCardsController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }

        List<FieldSpec> taskCardsDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Details", "E<br/>d<br/>i<br/>t", "Details", "center", 20, "details"),
            new FieldSpec("Revision", "Rev", "Revision", "center", 20),
            new FieldSpec("TaskId", "Task<br/>Id", "TaskId", "left", 60),
            new FieldSpec("PackageNmbr", "Pkg<br/>Nmbr", "PackageNmbr", "center", 60),
            new FieldSpec("OneTimeCard", "One<br/>Time<br/>Card", "OneTimeCard", "center", 30, "bool"),
            new FieldSpec("SeqNmbr", "Seqn<br/>Nmbr", "SeqNmbr", "center", 36),
            new FieldSpec("IssueDate", "Issue<br/>Date", "IssueDate", "center", 68, "date"),
            new FieldSpec("RevisionDate", "Revision<br/>Date", "RevisionDate", "center", 68, "date"),
            new FieldSpec("AcftType", "Acft<br/>Type", "AcftType", "center", 64, "selectable"),
            new FieldSpec("AirframeNmbr","Airframe<br/>Nmbr", "AirframeNmbr", "center", 80, "selectable"),
            new FieldSpec("SrcRef", "Source<br/>Ref", "SrcRef", "left", 160),
            new FieldSpec("Category", "Cat", "Category", "center", 30),
            new FieldSpec("CheckName", "Check<br/>Name", "CheckName", "center", 60),
            new FieldSpec("Priority", "Prio", "Priority", "center", 30),
            new FieldSpec("MaintManRef", "Maint<br/>Manual<br/>Ref", "MaintManRef", "center", 80),
            new FieldSpec("Ata", "Ata", "Ata", "center", 80),
            new FieldSpec("SignatureMode", "Sign<br/>Mode", "SignatureMode", "center", 30),
            new FieldSpec("WorkZone", "Work<br/>Zone", "WorkZone", "center", 40),
            new FieldSpec("Section", "Section", "Section", "center", 60),
            new FieldSpec("Station", "Station",  "Station", "center", 60),
            new FieldSpec("JobSummary", "Job<br/>Summary", "JobSummary", "left", 120),
            new FieldSpec("Task", "Task", "Task", "left", 120),
            new FieldSpec("Interval", "Interval", "Interval", "left", 120),
            new FieldSpec("Instructions", "Instructions","Instructions", "left", 120),
            new FieldSpec("Remarks", "Remarks", "Remarks", "left", 120),


        };

        List<FieldSpec> taskCardsChildDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("JobSummary", "Job<br/>Summary", "JobSummary", "left", 120),
            new FieldSpec("Task", "Task", "Task", "left", 120),
            new FieldSpec("Interval", "Interval", "Interval", "left", 120),
            new FieldSpec("Instructions", "Instructions","Instructions", "left", 120),
            new FieldSpec("Remarks", "Remarks", "Remarks", "left", 120),
        };

        
        static List<string> taskCardChildField = new List<string>()
        {
            "<style>"
            , "  table.childTable td, table.childTable th {"
            , "    border:solid;"
            , "    border-color:maroon;"
            , "    border-width:2px;"
            , "  }"
            , "</style>"
            , "<div style='height:16px'></div>"
            , "        <table class='childTable' style='border:solid;border-color:maroon;border-width:2px;margin:auto'>"
            , "            <tr style='background-color:#E9E9E9'><th style='width:400px'>Job Summary</th><th style='width:128px'>Task</th><th style='width:128px'>Interval</th><th style='width:128px'>Remarks</th></tr>"
            , "            <tr><td>\" + d.JobSummary + \"</td><td>\" + d.Task + \"</td><td>\" + d.Interval + \"</td><td>\" + d.Remarks + \"</td></tr>"
            , "        </table>"
            , "<div style='height:24px'></div>"
            , "<h6 align='center'>Instructions</h6>"
            , "<div style='height:128px;width:260px:margin:auto;border:solid;border-color:maroon;border-width:2px'>\" + d.Instructions + \"</div>"
            , "<div style='height:16px'></div>"
        };

        static private string taskCardsChildFieldFormatter =
             "\"" + string.Join("\"\n + \"", taskCardChildField) + "\"";


        public IActionResult TaskCards()
        {
            List<TaskCard> classList = context.TaskCards.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                taskCardsDisplayFieldList
                , "Task Cards"
                , classList.Select(e => (object)e).ToList()
                , taskCardsChildDisplayFieldList
                , taskCardsChildFieldFormatter
                , "TaskCardDetailView"
                );

        }

        public IActionResult TaskCardDetailView(string id, string data1)
        {
            var data = context.TaskCards.Where(t => t.PkRecordId == id).FirstOrDefault();

            ViewBag.Id = "'" + id + "'";
            ViewBag.Data = data;

            return View("~/Views/Maintenance/TaskCardDetailView.cshtml");
        }
    }
}
