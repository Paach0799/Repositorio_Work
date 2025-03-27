﻿using System;
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
using ClosedXML.Excel;
using RevisionModelos.Extensions;

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

        private void ModelReviser_Load(object sender, EventArgs e)
        {
            List<string> viewParameters = document.GetCategoryParameters(RevitDB.BuiltInCategory.OST_Sections);
            foreach (string viewParameter in viewParameters)
            {
                boxViewGroup.Items.Add(viewParameters);
                boxViewSub.Items.Add(viewParameters);
            }
            List<string> sheetParameters = document.GetCategoryParameters(RevitDB.BuiltInCategory.OST_Sheets);
            foreach (string sheetParameter in sheetParameters)
            {
                boxSheetGroup.Items.Add(sheetParameter);
                boxSheetSub.Items.Add(sheetParameter);
            }
            List<string> elementParameters = document.GetParameterDefinitions();
            foreach (string sheetParameter in elementParameters)
            {
                boxElemParam.Items.Add(sheetParameter);
            }
        }
    }
}