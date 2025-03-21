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
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;

namespace RevisionModelos.Forms
{
    public partial class FormApp : Form
    {
        RevitUI.UIDocument uiDocument;
        RevitDB.Document document;
        public FormApp(RevitUI.UIDocument uiDocument, RevitDB.Document document)
        {
            this.uiDocument = uiDocument;
            this.document = document;

            InitializeComponent();
        }
    }
}
