using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [Transaction(TransactionMode.Manual)]
    public class TestAPI : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDocument = commandData.Application.ActiveUIDocument;
            Document document = uiDocument.Document;
            //Aqui escribe tu codigo
            Reference selectRef = uiDocument.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element, "Seleccionar Elemento");

            Element elementSelect = document.GetElement(selectRef);

            return Result.Succeeded;
        }
    }
}
