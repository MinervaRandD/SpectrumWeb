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

        }
    }
}
