﻿using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.InteropServices.ComTypes;
using SpectrumWeb.Controllers.ControllerCommon;

namespace SpectrumWeb.Controllers.ControllerCommon
{
    public static class WebPageGenerator
    {
      

        public static string generateTableFields(List<FieldSpec> fieldList, List<FieldSpec> childRowList = null)
        {
            List<string> tableFields = new List<string>();

            foreach (FieldSpec field in fieldList)
            {
                if (ControllerCommon.isChildRow(field, childRowList))
                {
                    tableFields.Add("{ label: '" + field.description + "', name: '" + field.field + "', type:'textarea', className:'largeTextArea'}");
                }
                else
                {
                    tableFields.Add("{ label: '" + field.description + "', name: '" + field.field + "'}");
                }
            }

            string rtrnValue = string.Join(",\n", tableFields);
           
            return rtrnValue;
        }

        public static string generateTableColumns(List<FieldSpec> fieldList, List<FieldSpec> childRowList = null)
        {

            string rtrnValue = string.Empty;
               // "{ className: 'dt-control', orderable: false,data: null, defaultContent: '' },";

            if (childRowList != null)
            {
                rtrnValue += "{\r\n            className: 'dt-control',\r\n            orderable: false,\r\n            data: null,\r\n            defaultContent: ''\r\n        },";
            }

            //rtrnValue += string.Join(",\n", fieldList.Where(f => !isChildRow(f, childRowList)).Select(f=>"{ data: '" + f.label + "' }"));

            List<string> tableColumnSpecs = new List<string>();

            foreach (FieldSpec fieldSpec in fieldList)
            {
        
                if (ControllerCommon.isChildRow(fieldSpec,childRowList))
                {
                    tableColumnSpecs.Add("{ data: '" + fieldSpec.label + "', visible: false }");
                }

                else
                {
                    tableColumnSpecs.Add("{ data: '" + fieldSpec.label + "' }");
                }
            }

            rtrnValue += string.Join(",\n", tableColumnSpecs);
            
           // rtrnValue += string.Join(",\n", fieldList.Select(f => "{ data: '" + f.label + "' }"));

            //if (childRowList != null)
            //{
            //    rtrnValue += ",\n" + string.Join(",\n", childRowList.Select(f => "{ data: '" + f.label + "' }"));
            //}
            return rtrnValue;
        }

        public static string generateTableHeader(List<FieldSpec> fieldList, List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = string.Empty;

            if (childFieldList != null)
            {
                rtrnValue += "<th></th>\n";
            }

            foreach (FieldSpec fieldSpec in fieldList)
            {
                //if (isChildRow(fieldSpec, childFieldList))
                //{
                //    continue;
                //}

                string styleStr = "'text-align:center;";

                if (fieldSpec.fieldWidth.HasValue)
                {
                    styleStr += "width:" + fieldSpec.fieldWidth.Value.ToString() + "px;";
                }

                styleStr += "'";

                rtrnValue += "<th style=" + styleStr + ">" + fieldSpec.description + "</th>\n";
            }

            //if (childFieldList != null)
            //{
            //    foreach (FieldSpec fieldSpec in childFieldList)
            //    {
            //        string styleStr = "'text-align:center;";

            //        if (fieldSpec.fieldWidth.HasValue)
            //        {
            //            styleStr += "width:" + fieldSpec.fieldWidth.Value.ToString() + "px;";
            //        }

            //        styleStr += "'";

            //        rtrnValue += "<th style=" + styleStr + ">" + fieldSpec.description + "</th>\n";
            //    }
            //}

            return rtrnValue;
        }

        public static string generateTableFooter(List<FieldSpec> fieldList, List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = string.Empty;

            if (childFieldList != null)
            {
                rtrnValue += "<th></th>\n";
            }

            foreach (FieldSpec fieldSpec in fieldList)
            {
                //if (isChildRow(fieldSpec, childFieldList))
                //{
                //    continue;
                //}

                rtrnValue += "<th id='" + fieldSpec.label + "Footer'>" + fieldSpec.description + "</th>\n";
            }

            //if (childFieldList != null)
            //{
            //    foreach (FieldSpec fieldSpec in childFieldList)
            //    {
            //        rtrnValue += "<th id='" + fieldSpec.label + "Footer'>" + fieldSpec.description + "</th>\n";
            //    }
            //}

            return rtrnValue;
        }


        public static string generateTableBody(List<List<string>> classDisplayValueListWithRecordId, List<FieldSpec> fieldSpecList, List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = string.Empty;
            List<int> ilist = new List<int>();

            foreach (List<string> fieldValueList in classDisplayValueListWithRecordId)
            {
                rtrnValue += "<tr id='" + fieldValueList[0] + "'>\n"; // item 0 is the record id.

                if (childFieldList != null)
                {
                    rtrnValue += "<td></td>\n";
                }

                for (int i = 1; i < fieldValueList.Count; i++)
                {
                   
                    string? fieldJustify = fieldSpecList[i - 1].fieldJustify;


                    if (fieldSpecList[i - 1].fieldType == "details")
                    {
                        if (fieldJustify != null)
                        {
                            rtrnValue += "    <td style='text-align:" + fieldJustify + ";' class='detailsCell'><img src='/Img/EditIcon.png' style='width:24px;height:24px;'/></td>\n";
                        }

                        else
                        {
                            rtrnValue += "    <td class='detailsCell'><img src='/Img/EditIcon.png'/></td>\n";
                        }
                    }

                    else
                    {
                        if (fieldJustify != null)
                        {
                            rtrnValue += "    <td style='text-align:" + fieldJustify + ";'>" + fieldValueList[i] + "</td>\n";
                        }

                        else
                        {
                            rtrnValue += "    <td>" + fieldValueList[i] + "</td>\n";
                        }
                    }
                }

                rtrnValue += "</tr>\n";
            }
           
            return rtrnValue;
        }

        public static string generateTableBodyBuilder(List<FieldSpec> fieldList,  string keyField = "PkRecordId", List<FieldSpec> childFieldList = null)
        {
            string rtrnValue = "var tableBodyHtml = '';\n\n";

            rtrnValue += "classMap.forEach(function(classInstance) {\n";

            rtrnValue += "    " + "tableBodyHtml += \"<tr id='classInstance." + keyField + "'>\\n\\n\";\n\n";

            if (childFieldList != null)
            {
                rtrnValue += "    tableBodyHtml += \"    \" + \"<td style='width:16px'></td>\"" + " + \"\\n\";\n";
            }

            foreach (var fieldSpec in fieldList)
            {
                //if (isChildRow(fieldSpec,childFieldList))
                //{
                //    continue;
                //}

                rtrnValue += "    tableBodyHtml += \"    \" + \"" + tableRow(fieldSpec) + " + \"\\n\";\n";
            }

            rtrnValue += "    " + "    tableBodyHtml += \"</tr>\\n\\n\";\n\n";

            rtrnValue += "   });\n\n";

            rtrnValue += "document.getElementById('classTableBody').innerHTML = tableBodyHtml;";

            return rtrnValue;
        }

        internal static List<string> generateTableFieldValueList(Dictionary<string, string> fieldsDict, List<FieldSpec> displayFieldList)
        {
            List<string> rtrnValue = new List<string>();

            string field = fieldsDict["PkRecordId"];


            rtrnValue.Add(field);

            foreach (FieldSpec fieldSpec in displayFieldList)
            {
                //if (!fieldsDict.ContainsKey(fieldSpec.field))
                //{
                //    // This will happen if the field is a child row

                //    continue;
                //}

                if (fieldSpec.fieldType == "details")
                {
                    field = @"&rarrhk;";
                }

                else
                {
                    field = fieldsDict[fieldSpec.field];

                    if (fieldSpec.fieldType == "date")
                    {
                        if (!string.IsNullOrEmpty(field))
                        {
                            field = field.Substring(0, 10);
                        }
                    }

                    else if (fieldSpec.fieldType == "bool")
                    {
                        if (field == "true")
                        {
                            field = "Y";
                        }

                        else if (field == "false")
                        {
                            field = "N";
                        }
                    }

                    else if (fieldSpec.fieldType == "fixed")
                    {
                        int dotIndx = field.LastIndexOf('.');

                        if (dotIndx == 0)
                        {
                            field = "0";
                        }

                        else if (dotIndx > 0)
                        {
                            field = field.Substring(0, dotIndx);
                        }
                    }
                }

                rtrnValue.Add(field);
            }

            return rtrnValue;
        }

        internal static string generateChildRows(List<FieldSpec> childFieldList)
        {
            string rtrnValue = string.Empty;

            if (childFieldList is null)
            {
                return "null";
            }

            rtrnValue = "[\n";

            List<string> childTuples = new List<string>();

            foreach (FieldSpec childField in childFieldList)
            {
                short fieldHeight = 16;

                if (childField.fieldHeight != null)
                {
                    fieldHeight = childField.fieldHeight.Value;
                }

                childTuples.Add("    [ '" + childField.description + "', '" + childField.field + "', " + fieldHeight + " ]");
            }

            rtrnValue += string.Join(",\n", childTuples);

            rtrnValue += "\n]";

            return rtrnValue;
        }

        private static string tableRow(FieldSpec fieldSpec)
        {

            string? justify = fieldSpec.fieldJustify;

            if (string.IsNullOrEmpty(justify))
            {
                justify = "left";
            }

            string styleStr = "'text-align:" + justify + ";padding-left:2px;padding-right:2px;'";


            string rtrnValue = "<td style=" + styleStr + ">\" + classInstance." + fieldSpec.label + " + \"</td>\"";

            return rtrnValue;
        }

        internal static string generateClassMapInitializer(List<List<string>> classValueList, string className, string key = "PkRecordId")
        {
            string rtrnValue = "classMap.clear();\n\nvar classInstance;\n\n";

            foreach (List<string> fieldList in classValueList)
            {
                rtrnValue += "classInstance = new " + className + "(";

                rtrnValue += string.Join(",", fieldList.Select(f=>"'" + f + "'"));

                rtrnValue += ");\n";

                rtrnValue += "classMap.set(classInstance." + key + ", classInstance);\n";
            }

            return rtrnValue;
        }

        internal static int? generateTableWidth(List<FieldSpec> displayFieldList, List<FieldSpec> childFieldList = null)
        {
            int totalWidth = 0;

            foreach (FieldSpec field in displayFieldList)
            {
                if (field.fieldWidth == null)
                {
                    return null;
                }

                if (ControllerCommon.isChildRow(field, childFieldList))
                {
                    continue;
                }

                totalWidth += field.fieldWidth.Value;
            }

            return totalWidth;
        }


    }
}
