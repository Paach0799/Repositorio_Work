using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevitDB = Autodesk.Revit.DB;
using RevitUI = Autodesk.Revit.UI;
using RevitApp = Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using RevisionModelos.Forms;

namespace RevisionModelos
{
    [Transaction(TransactionMode.Manual)]
    public class Application : RevitUI.IExternalCommand
    {
        public RevitUI.Result Execute(RevitUI.ExternalCommandData commandData, ref string message, RevitDB.ElementSet elements)
        {
            RevitUI.UIDocument uiDocument = commandData.Application.ActiveUIDocument;
            RevitDB.Document document = uiDocument.Document;

            ModelReviser app = new ModelReviser(uiDocument, document);
            app.ShowDialog();

            return RevitUI.Result.Succeeded;



        }
    }
}
