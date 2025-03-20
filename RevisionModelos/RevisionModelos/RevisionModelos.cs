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

            //Informacion de muestra
            List<string> conteos = new List<string> { "Cantidad de instances: " + ids.Count.ToString(), "Cantidad de vistas: " + views.Count.ToString(), "Cantidad de planos: " + sheets.Count.ToString() };
            string mensajeConteo = string.Join("\n", conteos);
            TaskDialogResult mensajecontador = TaskDialog.Show("Elementos encontrados", mensajeConteo);

            #region OBTENER PARAMETROS DE VISTAS

            //Lista de valor de los parametros name
            List<string> valoresName = new List<string>();

            //Obtencion de parametro name de las vistas
            foreach (Element vista in views)
            {
                string parametroName = vista.Name;
                if (parametroName != null)
                {
                    valoresName.Add(parametroName);
                }
                else
                {
                    valoresName.Add("Sin valor");
                }

            }

            //Lista de valor de los parametros grupo
            List<string> valoresGrupo = new List<string>();

            //Obtencion de parametro grupos de las vistas
            foreach (Element vista in views)
            {
                Parameter parametroGrupo = vista.LookupParameter("BRH_GRUPO_NAVEGADOR");
                if (parametroGrupo != null && parametroGrupo.HasValue)
                {
                    valoresGrupo.Add(parametroGrupo.AsString());
                }
                else
                {
                    valoresGrupo.Add("Sin valor");
                }

            }

            //Lista de valor de los parametros Sub grupo
            List<string> valoresSubGrupo = new List<string>();

            //Obtencion de parametro grupos de las vistas
            foreach (Element vista in views)
            {
                Parameter parametroSubGrupo = vista.LookupParameter("BRH_GRUPO_NAVEGADOR");
                if (parametroSubGrupo != null && parametroSubGrupo.HasValue)
                {
                    valoresSubGrupo.Add(parametroSubGrupo.AsString());
                }
                else
                {
                    valoresSubGrupo.Add("Sin valor");
                }

            }

            #endregion

            #region CREAR ARCHIVO EXCEL

            //Definir varibles para archivo excel
            string rutaExcel = @"D:\WIP_SCRIPTS\INP\Check_Models.xlsx";

            #endregion

            // Abrir libro de excel
            using (var workbook = new XLWorkbook(rutaExcel))
            {

                // Obtener hoja de excel de vistas
                var primeraHoja = workbook.Worksheet("VISTAS");

                // Obtener hoja de excel de planos
                var segundaHoja = workbook.Worksheet("SHEETS");

                // Obtener hoja de excel de familias
                var terceraHoja = workbook.Worksheet("FAMILIAS");

                // Obtener hoja de excel de parametros de elementos
                var cuartaHoja = workbook.Worksheet("PARAMETROS_ELEMENTOS");

                //Escribir datos en la hoja

                // Buscar la primera fila vacía para escribir los datos nuevos
                int lastRowColumn1 = 2;

                #region NOMBRES DE VISTAS


                foreach (string nameVista in valoresName)
                {
                    

                    primeraHoja.Cell(lastRowColumn1, 1).Value = nameVista;
                    lastRowColumn1++;
                }


                #endregion


                #region GRUPOS DE VISTAS

                int lastRowColumn2 = 2;
                foreach (string grupoVista in valoresGrupo)
                {

                    primeraHoja.Cell(lastRowColumn2,2).Value = grupoVista;
                    lastRowColumn2++;

                }

                #endregion


                #region SUBGRUPOS DE VISTAS

                int lastRowColumn3 = 2;
                foreach (string subGrupoVista in valoresSubGrupo)
                {

                    primeraHoja.Cell(lastRowColumn3, 3).Value = subGrupoVista;
                    lastRowColumn3++;

                }

                #endregion


                //Guardar archivo
                workbook.SaveAs(rutaExcel);
                TaskDialogResult ts = TaskDialog.Show("Mensaje", "Archivo Guardado");
            }

            return Result.Succeeded;
        }
    }
}
