using Microsoft.Identity.Client.Kerberos;
using System.Text;

namespace SpectrumWeb.Controllers.ControllerCommon
{

    public static class ControllerCommon
    {
        public static string TwoPartCustomForm(List<FieldSpec> fieldList, List<FieldSpec> childFieldList)
        {
            //string rtrnValue = "<div id='customForm' class='row'>\n";
            string rtrnValue = "<div id='customForm'>\n";
            //rtrnValue += "    <div class='col'>\n";

            rtrnValue += "    <fieldset>\n";

            foreach (FieldSpec fieldSpec in fieldList)
            {
                if (isChildRow(fieldSpec, childFieldList))
                {
                    continue;
                }

                rtrnValue += "         <editor-field name='" + fieldSpec.field + "'></editor-field>\n";
            }

            // rtrnValue += "    </div>\n";

            rtrnValue += "    </fieldset>\n";

            rtrnValue += "    <fieldset>\n";

            foreach (FieldSpec fieldSpec in childFieldList)
            {
                rtrnValue += "         <editor-field name='" + fieldSpec.field + "' type='textarea' ";
                
                if (fieldSpec.fieldHeight != null)
                {
                    rtrnValue += " style='height:" + fieldSpec.fieldHeight.Value + "px'";
                }

                rtrnValue += "></editor-field>\n";
            }

            rtrnValue += "    </fieldset>\n";

            // rtrnValue += "    </div>\n";

            rtrnValue += "</div>";

            return rtrnValue;
        }


        public static bool isChildRow(FieldSpec fieldSpec, List<FieldSpec> childFieldList)
        {
            if (childFieldList is null)
            {
                return false;
            }

            return childFieldList.Any(x => x.field == fieldSpec.field);

        }

        public static string childFieldConstructor(List<string> inptHtmlLines)
        {
            string rtrnValu = "\\\"" + inptHtmlLines[0] + "\\\"\\n\"\n";

            for (int i = 1; i < inptHtmlLines.Count; i++)
            {
                rtrnValu += "\"+ \\\"" + inptHtmlLines[i].Replace("\"", "\\\"") + "\\\"\\n\"\n";
            }

            return rtrnValu;

            //"\"<style>\"\n"
            //        , "+ \"  table.childTable td, table.childTable th {\"\n"
            //        , "+ \"    border:solid;\"\n"
            //        , "+ \"    border-color:maroon;\"\n"
            //        , "+ \"    border-width:2px;\"\n"
            //        , "+ \"  }\"\n"
            //        , "+ \"</style>\"\n"
            //        , "+ \"<div style='height:16px'></div>\"\n"
            //        , "+ \"        <table class='childTable' style='border:solid;border-color:maroon;border-width:2px;margin:auto'>\"\n"
            //        , "+ \"            <tr style='background-color:#E9E9E9'><th style='width:400px'>Job Summary</th><th style='width:128px'>Task</th><th style='width:128px'>Interval</th><th style='width:128px'>Remarks</th></tr>\"\n"
            //        , "+ \"            <tr><td>\" + d.JobSummary + \"</td><td>\" + d.Task + \"</td><td>\" + d.Interval + \"</td><td>\" + d.Remarks + \"</td></tr>\"\n"
            //        , "+ \"        </table>\"\n"
            //        , "+ \"<div style='height:24px'></div>\"\n"
            //        , "+ \"<h6 align='center'>Instructions</h6>\"\n"
            //        , "+ \"<div style='height:128px;width:260px:margin:auto;border:solid;border-color:maroon;border-width:2px'>\" + d.Instructions + \"</div>\"\n"            //        , "+ \"<div style='height:16px'></div>\"\n"
        }
    }
}
