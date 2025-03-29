using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevitDB = Autodesk.Revit.DB;
using RevitUI = Autodesk.Revit.UI;
using RevitApp = Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using RevisionModelos.Extensions;
using RevisionModelos.Utils;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;

namespace RevisionModelos.Forms
{
    public partial class ModelReviser : Form
    {
        RevitUI.UIDocument uiDocument;
        RevitDB.Document document;
        public ModelReviser(RevitUI.UIDocument uiDocument, RevitDB.Document document)
        {
            this.uiDocument = uiDocument;
            this.document = document;

            InitializeComponent();
        }
        private void ModelReviser_Load(object sender, EventArgs e)
        {
            List<string> viewParameters = document.GetDefinitionsForCategory("Views");
            foreach (string viewParameter in viewParameters)
            {
                boxViewGroup.Items.Add(viewParameter);
                boxViewSub.Items.Add(viewParameter);
            }
            List<string> sheetParameters = document.GetDefinitionsForCategory("Sheets");
            foreach (string sheetParameter in sheetParameters)
            {
                boxSheetGroup.Items.Add(sheetParameter);
                boxSheetSub.Items.Add(sheetParameter);
            }
            List<string> elementParameters = document.GetDefinitions();
            foreach (string elementParameter in elementParameters)
            {
                boxElemParam.Items.Add(elementParameter);
            }
        }
        public static string DisplayFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a document";
            openFileDialog.Filter = "Select a document (*.xlsx)|*.xlsx";

            string filePath = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            return filePath;
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string filepath = DisplayFileDialog();
            boxSelectFile.Text = filepath;

            if (filepath != null)
            {
                using (XLWorkbook workBook = new XLWorkbook(filepath))
                {
                    foreach (var sheet in workBook.Worksheets)
                    {
                        boxSheet1.Items.Add(sheet.Name);
                        boxSheet2.Items.Add(sheet.Name);
                        boxSheet3.Items.Add(sheet.Name);
                        boxSheet4.Items.Add(sheet.Name);
                    }
                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {


            using (var workbook = new XLWorkbook(boxSelectFile.Text))
            {
                var viewSheet = workbook.Worksheet(boxSheet1.SelectedItem.ToString());
                var sheetSheet = workbook.Worksheet(boxSheet2.SelectedItem.ToString());
                var parameterSheet = workbook.Worksheet(boxSheet3.SelectedItem.ToString());
                var familySheet = workbook.Worksheet(boxSheet4.SelectedItem.ToString());

                #region VIEWS

                List<RevitDB.Element> views = document.GetViews();
                List<string> viewNames = views.GetValueParameter(RevitDB.BuiltInParameter.VIEW_NAME);
                List<string> viewGroupNames = views.GetValueParameter(boxViewGroup.SelectedItem.ToString());
                List<string> viewSubGroupNames = views.GetValueParameter(boxViewSub.SelectedItem.ToString());

                for (int i = 2; i < viewNames.Count; i++)
                {
                    viewSheet.Cell(i + 2, 1).Value = viewNames[i];
                    viewSheet.Cell(i + 2, 2).Value = viewGroupNames[i];
                    viewSheet.Cell(i + 2, 3).Value = viewSubGroupNames[i];
                }

                #endregion

                RevitUI.TaskDialog.Show("Aviso 01 👇", "Hoja 01 completada 🚀");

                #region SHEETS

                List<RevitDB.Element> sheets = document.GetViews();
                List<string> sheetNames = views.GetValueParameter(RevitDB.BuiltInParameter.SHEET_NAME);
                List<string> sheetGroupNames = views.GetValueParameter(boxSheetGroup.SelectedItem.ToString());
                List<string> sheetSubGroupNames = views.GetValueParameter(boxSheetSub.SelectedItem.ToString());

                for (int i = 0; i < sheetNames.Count; i++)
                {
                    sheetSheet.Cell(i + 2, 1).Value = sheetNames[i];
                    sheetSheet.Cell(i + 2, 2).Value = sheetGroupNames[i];
                    sheetSheet.Cell(i + 2, 3).Value = sheetSubGroupNames[i];
                }

                #endregion

                RevitUI.TaskDialog.Show("Aviso 02 👇", "Hoja 02 completada 🚀");

                #region INSTANCES

                List<RevitDB.Element> instanceFamilies = document.GetInstances();

                for (int i = 0; i < boxElemParam.CheckedItems.Count; i++)
                {
                    parameterSheet.Cell(1, i + 2).Value = boxElemParam.CheckedItems[i];
                }

                for (int i = 0; i < instanceFamilies.Count; i++)
                {
                    parameterSheet.Cell(i + 2, 1).Value = instanceFamilies[i].Name;

                    for (int j = 0; j < boxElemParam.CheckedItems.Count; j++)
                    {
                        string parameterName = boxElemParam.CheckedItems[j].ToString();
                        
                        string value = UtilsInstances.GetValueParameterElement(instanceFamilies[i], parameterName);
                        parameterSheet.Cell(i + 2, j + 2).Value = value;
                    }
                }

                #endregion

                RevitUI.TaskDialog.Show("Aviso 03 👇", "Hoja 03 completada 🚀");



                workbook.SaveAs(boxSelectFile.Text);
                RevitUI.TaskDialog.Show("View", "Done");
            }
        }
    }
}