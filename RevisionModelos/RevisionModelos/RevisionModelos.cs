using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using RevisionModelos.Extensions;

using ClosedXML.Excel;


namespace RevisionModelos
{
    [Transaction(TransactionMode.Manual)]
    public class RevisionModelos : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDocument = commandData.Application.ActiveUIDocument;
            Document document = uiDocument.Document;

            List<ElementId> ids = document.GetInstances();
            List<Element> views = document.GetViews();
            List<Element> sheets = document.GetSheets();

            TaskDialogResult mensaje01 = TaskDialog.Show("INICIO DE APLICACION", "Se inicia el comando ");

            // Mostrar informacion en el proceso
            TaskDialogResult mensaje02 = TaskDialog.Show("Elementos encontrados", $"Se encontraron {ids.Count} instancias.");
            TaskDialogResult mensaje03 = TaskDialog.Show("Vistas encontradas", $"Se encontraron {views.Count} vistas.");
            TaskDialogResult mensaje04 = TaskDialog.Show("Planos encontrados", $"Se encontraron {sheets.Count} planos.");

            //Obtencion de parametros de las vistas
            foreach (Element vista in views)
            {

                
            }

            #region Crear archivo excel
            //Definir varibles para archivo excel
            string rutaExcel = @"D:\WIP_SCRIPTS\INP\Check_Models.xlsx";

            // Crear libro de excel
            using (var workbook = new XLWorkbook(rutaExcel))
            {
                // Obtener hoja de excel
                var primeraHoja = workbook.Worksheet("VISTAS");

                //Escribir datos en la hoja
                // Buscar la primera fila vacía para escribir los datos nuevos
                int lastRow = primeraHoja.LastRowUsed().RowNumber() + 1;

                // Escribir los datos en la primera hoja
                primeraHoja.Cell(lastRow, 1).Value = "Prueba de primera celda";

                //Guardar archivo
                workbook.SaveAs(rutaExcel);
            }
            #endregion


            return Result.Succeeded;
        }
    }
}
