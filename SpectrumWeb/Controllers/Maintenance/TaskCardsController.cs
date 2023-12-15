using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace SpectrumWeb.Controllers.Maintenance
{
    public class TaskCardsController : Controller
    {
        private readonly ArmsSpectrumDevelopmentContext _context;

        public TaskCardsController(ArmsSpectrumDevelopmentContext context)
        {
            _context = context;
        }

        List<FieldSpec> taskCardsDisplayFieldList = new List<FieldSpec>()
        {
            new FieldSpec("Revision", "Rev", "Revision", "center", 20),
            new FieldSpec("TaskId", "Task<br/>Id", "TaskId", "left", 60),
            new FieldSpec("TaskIdSub", "Task<br/>ID<br/>Extn", "TaskIdSub", "center", 40),
            new FieldSpec("OneTimeCard", "One<br/>Time<br/>Card", "OneTimeCard", "center", 30, "bool"),
            new FieldSpec("SeqNmbr", "Seqn<br/>Nmbr", "SeqNmbr", "center", 36),
            new FieldSpec("IssueDate", "Issue<br/>Date", "IssueDate", "center", 68, "date"),
            new FieldSpec("AcftType", "Acft<br/>Type", "AcftType", "center", 64),
            new FieldSpec("SrcRef", "Source<br/>Ref", "SrcRef", "left", 160),
            new FieldSpec("Category", "Cat", "Category", "center", 30),
            new FieldSpec("Priority", "Prio", "Priority", "center", 30),
            new FieldSpec("MaintManRef", "Maint<br/>Manual<br/>Ref", "MaintManRef", "center", 80),
            new FieldSpec("WorkZone", "Work<br/>Zone", "WorkZone", "center", 40),
            new FieldSpec("Section1", "Section<br/>Base", "Section1", "center", 40),
            new FieldSpec("Section2", "Section<br/>Extn", "Section2", "center", 40),
            new FieldSpec("Station1", "Station<br/>Base",  "Station1", "center", 40),
            new FieldSpec("Station2", "Station<br/>Extn", "Station2", "center", 40),
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

        private string taskCardsChildFieldFormatter =
            "\"<div class='row'>\"\n"
            + "+ \"    <div class='col-1'></div>\"\n"
            + "+ \"    <div class='col-4'>\"\n"
            + "+ \"        <table>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Job Summary:</td><td>\" + d.JobSummary + \"</td></tr>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Task:</td><td>\" + d.Task + \"</td></tr>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Interval:</td><td>\" + d.Interval + \"</td></tr>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Instructions:</td><td style='width:240px>\" + d.Instructions + \"</td></tr>\"\n"
            + "+ \"            <tr><td style='text-align:right'>Remarks:</td><td style='width:240px'>\" + d.Remarks + \"</td></tr>\"\n"
            + "+ \"        </table>\"\n"
            + "+ \"    </div>\"\n"
            + "+ \"</div>\"\n"
            ;

        public IActionResult TaskCards()
        {
            List<TaskCard> classList = _context.TaskCards.ToList();

            return (new GenericTableController()).GenericTableGenerator(
                taskCardsDisplayFieldList
                , "Task Cards"
                , classList.Select(e => (object)e).ToList()
                , taskCardsChildDisplayFieldList
                , taskCardsChildFieldFormatter
                , "TaskCardDetailView"
                );

        }

        public IActionResult TaskCardDetailView()
        {
            return View("~/Views/Maintenance/TaskCardDetailView.cshtml");
        }
    }
}
