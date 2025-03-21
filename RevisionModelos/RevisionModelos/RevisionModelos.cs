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
using RevisionModelos.Utils;

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

            List<Element> instancesFamily = document.GetInstances();
            List<Element> views = document.GetViews();
            List<Element> sheets = document.GetSheets();

            //Informacion de muestra
            List<string> conteos = new List<string> { "Cantidad de instances: " + instancesFamily.Count.ToString(), "Cantidad de vistas: " + views.Count.ToString(), "Cantidad de planos: " + sheets.Count.ToString() };
            string mensajeConteo = string.Join("\n", conteos);
            TaskDialogResult mensajecontador = TaskDialog.Show("Elementos encontrados 👇", mensajeConteo);

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
                Parameter parametroSubGrupo = vista.LookupParameter("BRH_SUBGRUPO_NAVEGADOR");
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

            #region OBTENER PARAMETROS DE PLANOS

            //Lista de valor de los parametros name
            List<string> valoresNameSheets = new List<string>();

            //Obtencion de parametro name de las vistas
            foreach (Element sheet in sheets)
            {
                string parametroName = sheet.Name;
                if (parametroName != null)
                {
                    valoresNameSheets.Add(parametroName);
                }
                else
                {
                    valoresNameSheets.Add("Sin valor");
                }

            }

            //Lista de valor de los parametros grupo
            List<string> valoresGrupoSheets = new List<string>();

            //Obtencion de parametro grupos de las vistas
            foreach (Element sheet in sheets)
            {
                Parameter parametroGrupo = sheet.LookupParameter("BRH_GRUPO_NAVEGADOR");
                if (parametroGrupo != null && parametroGrupo.HasValue)
                {
                    valoresGrupoSheets.Add(parametroGrupo.AsString());
                }
                else
                {
                    valoresGrupoSheets.Add("Sin valor");
                }

            }

            //Lista de valor de los parametros Sub grupo
            List<string> valoresSubGrupoSheets = new List<string>();

            //Obtencion de parametro grupos de las vistas
            foreach (Element sheet in sheets)
            {
                Parameter parametroSubGrupo = sheet.LookupParameter("BRH_SUBGRUPO_NAVEGADOR");
                if (parametroSubGrupo != null && parametroSubGrupo.HasValue)
                {
                    valoresSubGrupoSheets.Add(parametroSubGrupo.AsString());
                }
                else
                {
                    valoresSubGrupoSheets.Add("Sin valor");
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
                var terceraHoja = workbook.Worksheet("PARAMETROS_ELEMENTOS");

                // Obtener hoja de excel de parametros de elementos
                var cuartaHoja = workbook.Worksheet("FAMILIAS");

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


                TaskDialogResult ts1 = TaskDialog.Show("Aviso 01 👇", "Hoja 01 completada 🚀");

                //Escribir datos en la hoja

                // Buscar la primera fila vacía para escribir los datos nuevos
                int lastRowColumn2_1 = 2;

                #region NOMBRES DE PLANOS


                foreach (string nameSheet in valoresNameSheets)
                {


                    segundaHoja.Cell(lastRowColumn2_1, 1).Value = nameSheet;
                    lastRowColumn2_1++;
                }


                #endregion


                #region GRUPOS DE PLANOS

                int lastRowColumn2_2 = 2;
                foreach (string grupoSheet in valoresGrupoSheets)
                {

                    segundaHoja.Cell(lastRowColumn2_2, 2).Value = grupoSheet;
                    lastRowColumn2_2++;

                }

                #endregion


                #region SUBGRUPOS DE PLANOS

                int lastRowColumn2_3 = 2;
                foreach (string subGrupoSheet in valoresSubGrupoSheets)
                {

                    segundaHoja.Cell(lastRowColumn2_3, 3).Value = subGrupoSheet;
                    lastRowColumn2_3++;

                }

                #endregion

                TaskDialogResult ts2 = TaskDialog.Show("Aviso 02 👇", "Hoja 02 completada 🚀");

                #region TERCERA HOJA EN PROCESO

                //Obtencion de parametros de cada instancia
                List<string> nameParameters = new List<string> { "BRH_CategoriaElemento", "BRH_CodigoElemento", "BRH_ComponenteElemento", "BRH_IdElemento", "BRH_MetradoElemento", "BRH_SectorElemento", "BRH_SubSectorElemento", "BRH_TipoELemento", "BRH_TramoElemento" };

                List<List<string>> valoresParametrosTypes = new List<List<string>>();

                #endregion

                //Obtencion de nombre de cada familia

                List<string> listaTypes = new List<string>();

                foreach (FamilyInstance instance in instancesFamily)
                {
                    FamilySymbol symbol = instance.Symbol;
                    if (symbol != null)
                    {
                        string familyName = symbol.FamilyName; //-----------> Nombre de la familia
                        string typeName = symbol.Name; //-----------> Nombre del tipo de familia
                        listaTypes.Add(familyName);
                    }
                }

                int lastRow4_1 = 2;
                foreach (string type in listaTypes)
                {
                    cuartaHoja.Cell(lastRow4_1, 1).Value = type;
                    lastRow4_1++;
                }

                //Guardar archivo
                workbook.SaveAs(rutaExcel);

                TaskDialogResult ts = TaskDialog.Show("Realizado", "Archivo Guardado 👌");

                //Mensaje de prueba

                TaskDialogResult mensajePrueba = TaskDialog.Show("Elementos encontrados 👇", "Cantidad de instancias: " + listaTypes.Count.ToString());
            }

            return Result.Succeeded;
        }
    }
}
