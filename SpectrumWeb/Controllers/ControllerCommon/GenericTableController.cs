using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using Newtonsoft.Json;

namespace SpectrumWeb.Controllers.ControllerCommon
{
    public class GenericTableController : Controller
    {
        public IActionResult GenericTableGenerator(
            List<FieldSpec> displayFieldList
            , string title
            , List<object> classList
            , List<FieldSpec> childFieldList = null)
        {
            ViewBag.Title = title;

            List<List<string>> classFullValueList = new List<List<string>>();

            List<List<string>> classDisplayValueListWithRecordId = new List<List<string>>();

            foreach (object instance in classList)
            {
                string str = JsonConvert.SerializeObject(instance);

                var fieldsDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(str);

                if (childFieldList != null)
                {
                    foreach (FieldSpec childRowField in childFieldList)
                    {
                        if (fieldsDict.ContainsKey(childRowField.field))
                        {
                            fieldsDict.Remove(childRowField.field);
                        }
                    }
                }

                classFullValueList.Add(fieldsDict.Values.ToList());

                List<string> displayFieldValueList = WebPageGenerator.generateTableFieldValueList(fieldsDict, displayFieldList);

                classDisplayValueListWithRecordId.Add(displayFieldValueList);
            }

            string tableFields = WebPageGenerator.generateTableFields(displayFieldList, childFieldList);

            ViewBag.TableFields = tableFields;

            string tableColumns = WebPageGenerator.generateTableColumns(displayFieldList, childFieldList);

            ViewBag.TableColumns = tableColumns;

            string tableHeader = WebPageGenerator.generateTableHeader(displayFieldList, childFieldList);

            ViewBag.TableHeader = tableHeader;

            string tableFooter = WebPageGenerator.generateTableFooter(displayFieldList, childFieldList);

            ViewBag.TableFooter = tableFooter;

            string classTableBody = WebPageGenerator.generateTableBody(classDisplayValueListWithRecordId, displayFieldList, childFieldList);

            ViewBag.ClassTableBody = classTableBody;

            string tableBodyBuilder = WebPageGenerator.generateTableBodyBuilder(displayFieldList, "PkRecordId", childFieldList);

            ViewBag.TableBodyBuilder = tableBodyBuilder;

            string childRows = WebPageGenerator.generateChildRows(childFieldList);

            ViewBag.ChildRows = childRows;
            //string classMapInitializer = WebPageGenerator.generateClassMapInitializer(classFullValueList, className);

            //ViewBag.ClassMapInitializer = classMapInitializer;

            int? totalTableWidth = WebPageGenerator.generateTableWidth(displayFieldList);

            if (totalTableWidth != null)
            {
                ViewBag.TableWidth = "width:" + totalTableWidth.Value.ToString() + "px;";
            }

            else
            {
                ViewBag.TableWidth = string.Empty;
            }

            //ViewBag.ClassDefnScript = "<script type='text/javascript' language='javascript' src='/local/" + classDefnFileName + ".js'></script >";

            return View("~/Views/Maintenance/GenericTable.cshtml");
        }
    }
}
