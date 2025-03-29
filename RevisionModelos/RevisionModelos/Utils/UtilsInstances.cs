using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;

namespace RevisionModelos.Utils
{
    public static class UtilsInstances
    {
        public static List<string> GetValueParametersElement(Element instancia, List<string> nameParameters)
        {
            List<string> parametros = new List<string>();

            foreach (string name in nameParameters)
            {
                Parameter parameter = instancia.LookupParameter(name);
                if (parameter != null)
                {
                    parametros.Add(parameter.AsString());
                }
                else
                {
                    parametros.Add("Sin valor");
                }
            }
            return parametros;
        }
        public static string GetValueParameterElement(Element instancia, string parameterName)
        {
            string value;

            Parameter parameter = instancia.LookupParameter(parameterName);
            if (parameter != null)
            {
                value = parameter.AsString();
            }
            else
            {
                value = "Sin valor";
            }
            
            return value;
        }
    }
}
