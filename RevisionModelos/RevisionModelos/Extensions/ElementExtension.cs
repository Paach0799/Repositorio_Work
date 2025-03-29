using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;

namespace RevisionModelos.Extensions
{
    public static class ElementExtension 
    {
        public static List<string> GetValueParameter(this List<Element> elements, BuiltInParameter parameterId)
        {
            List<string> values = new List<string>();

            foreach (Element element in elements)
            {
                Parameter parameter = element.get_Parameter(parameterId);
                if (parameter != null && parameter.HasValue)
                {
                    values.Add(parameter.AsString());
                }
                else
                {
                    values.Add("Sin valor");
                }
            }
            return values;
        }
        public static List<string> GetValueParameter(this List<Element> elements, string parameterName)
        {
            List<string> values = new List<string>();

            foreach (Element element in elements)
            {
                Parameter parameter = element.LookupParameter(parameterName);
                if (parameter != null && parameter.HasValue)
                {
                    values.Add(parameter.AsString());
                }
                else
                {
                    values.Add("Sin valor");
                }
            }
            return values;
        }
    }
}
