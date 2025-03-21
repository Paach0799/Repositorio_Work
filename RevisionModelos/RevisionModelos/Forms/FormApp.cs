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
            boxSelectFile.Text = DisplayFileDialog();
        }
    }
}