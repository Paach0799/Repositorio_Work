﻿using System;
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
using System.Diagnostics;


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
            List<Element> familys = document.GetFamily();

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

                List<List<string>> valoresParametrosInstance = new List<List<string>>();
                int lastRowColumn4_1 = 2;
                int lastRowColumn4_2 = 1;
                int columnIni = 2;

                foreach (string param in nameParameters)
                {
                    terceraHoja.Cell(lastRowColumn4_2, columnIni).Value = param;
                    columnIni++;
                }

                int lastRowColumn4_3 = 2;

                foreach (var inst in instancesFamily)
                {
                    string name = inst.Name;
                    terceraHoja.Cell(lastRowColumn4_3, 1).Value = name;
                    lastRowColumn4_3++;
                }

                foreach (FamilyInstance instance in instancesFamily)
                {
                    

                    List<string> valoresParametros = UtilsInstances.GetValueParametersElement(instance, nameParameters);
                    valoresParametrosInstance.Add(valoresParametros);

                    int lastColumn = 2;
                    foreach (string valor in valoresParametros)
                    {
                        if (valor == null)
                        {
                            terceraHoja.Cell(lastRowColumn4_1, lastColumn).Value = "FALTA";
                            lastColumn++;
                        }
                        else
                        {
                            terceraHoja.Cell(lastRowColumn4_1, lastColumn).Value = valor;
                            lastColumn++;
                        }

                    }

                    lastRowColumn4_1++;
                }



                #endregion

                TaskDialogResult ts3 = TaskDialog.Show("Aviso 03 👇", "Hoja 03 completada 🚀");

                #region CUARTA HOJA 
                //Exportar nombres de familias

                List<string> listaFamilias = new List<string>();

                int lastRowColumn3_1 = 2;
                foreach (Element fam in familys)
                {
                    cuartaHoja.Cell(lastRowColumn3_1, 1).Value = fam.Name;
                    lastRowColumn3_1++;
                    listaFamilias.Add(fam.Name);
                }

                //Obtener categoria de cada familia
                List<string> categoryfamilys = document.GetCategoryFamily();

                #region DICCIONARIO Y CONCATENADO
                //Diccionario de categorias
                Dictionary<string, string> diccionarioCategorias = new Dictionary<string, string>();

                diccionarioCategorias.Add(document.GetCategoryName(-2000151), "GEN");
                diccionarioCategorias.Add(document.GetCategoryName(-2001320), "SFA");
                diccionarioCategorias.Add(document.GetCategoryName(-2008044), "PIP");
                diccionarioCategorias.Add(document.GetCategoryName(-2008049), "PFI");
                diccionarioCategorias.Add(document.GetCategoryName(-2000280), "TBL");
                diccionarioCategorias.Add(document.GetCategoryName(-2005022), "TAG");

                int lastRowColumn3_2 = 2;

                foreach (string cat in categoryfamilys)
                {
                    cuartaHoja.Cell(lastRowColumn3_2, 2).Value = cat;
                    lastRowColumn3_2++;

                }

                int lastRowColumn3_3 = 2;

                //Concatenar familias:
                foreach (string cat in categoryfamilys)
                {
                    string creador = "BRH";

                    //Concatenado:
                    if (diccionarioCategorias.ContainsKey(cat))
                    {
                        string concatenado = creador + "_" + diccionarioCategorias[cat] + "_";

                        cuartaHoja.Cell(lastRowColumn3_3, 3).Value = concatenado;
                        lastRowColumn3_3++;
                        continue;
                    }
                    else
                    {
                        string concatenado = "N/A";

                        cuartaHoja.Cell(lastRowColumn3_3, 3).Value = concatenado;
                        lastRowColumn3_3++;
                    }

                }

                //Lista de substring

                int lastRowColumn3_4 = 2;
                foreach (string famName in listaFamilias)
                {
                    if (famName.Length < 8)
                    {
                        string recorte = famName.Substring(0, famName.Length);
                        cuartaHoja.Cell(lastRowColumn3_4, 4).Value = recorte;
                        lastRowColumn3_4++;
                        continue;
                    }
                    else
                    {
                        string recorte = famName.Substring(0, 8);
                        cuartaHoja.Cell(lastRowColumn3_4, 4).Value = recorte;
                        lastRowColumn3_4++;
                    }
                }
                #endregion


                #endregion

                TaskDialogResult ts4 = TaskDialog.Show("Aviso 04", "Hoja 04 completada 🚀");

                //Guardar archivo
                workbook.SaveAs(rutaExcel);

                // Abrir el archivo automáticamente
                Process.Start(new ProcessStartInfo(rutaExcel) { UseShellExecute = true });
            }

            return Result.Succeeded;
        }
    }
}
