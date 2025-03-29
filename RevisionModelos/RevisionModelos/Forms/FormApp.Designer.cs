﻿namespace RevisionModelos.Forms
{
    partial class ModelReviser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFooter = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.tabViewParam = new System.Windows.Forms.TabPage();
            this.boxViewParam = new System.Windows.Forms.GroupBox();
            this.boxViewSub = new System.Windows.Forms.ComboBox();
            this.boxViewGroup = new System.Windows.Forms.ComboBox();
            this.lblParam2 = new System.Windows.Forms.Label();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.boxSheet4 = new System.Windows.Forms.ComboBox();
            this.boxSheet3 = new System.Windows.Forms.ComboBox();
            this.boxSheet2 = new System.Windows.Forms.ComboBox();
            this.boxSheet1 = new System.Windows.Forms.ComboBox();
            this.lblSheet4 = new System.Windows.Forms.Label();
            this.lblSheet3 = new System.Windows.Forms.Label();
            this.lblSheet2 = new System.Windows.Forms.Label();
            this.lblSheet1 = new System.Windows.Forms.Label();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.boxSelectFile = new System.Windows.Forms.TextBox();
            this.boxFileTab = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSheetsParam = new System.Windows.Forms.TabPage();
            this.boxSheetParam = new System.Windows.Forms.GroupBox();
            this.boxSheetSub = new System.Windows.Forms.ComboBox();
            this.boxSheetGroup = new System.Windows.Forms.ComboBox();
            this.lblParam4 = new System.Windows.Forms.Label();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.tabElementParam = new System.Windows.Forms.TabPage();
            this.boxElementParam = new System.Windows.Forms.GroupBox();
            this.boxElemParam = new System.Windows.Forms.CheckedListBox();
            this.lblParam9 = new System.Windows.Forms.Label();
            this.grpFooter.SuspendLayout();
            this.grpHeader.SuspendLayout();
            this.tabViewParam.SuspendLayout();
            this.boxViewParam.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSheetsParam.SuspendLayout();
            this.boxSheetParam.SuspendLayout();
            this.tabElementParam.SuspendLayout();
            this.boxElementParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(99, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Model Reviewer";
            // 
            // grpFooter
            // 
            this.grpFooter.Controls.Add(this.btnCancel);
            this.grpFooter.Controls.Add(this.btnOk);
            this.grpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFooter.Location = new System.Drawing.Point(0, 379);
            this.grpFooter.Name = "grpFooter";
            this.grpFooter.Size = new System.Drawing.Size(338, 47);
            this.grpFooter.TabIndex = 3;
            this.grpFooter.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(249, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpHeader
            // 
            this.grpHeader.Controls.Add(this.lblTitle);
            this.grpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHeader.Location = new System.Drawing.Point(0, 0);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(338, 40);
            this.grpHeader.TabIndex = 4;
            this.grpHeader.TabStop = false;
            // 
            // tabViewParam
            // 
            this.tabViewParam.Controls.Add(this.boxViewParam);
            this.tabViewParam.Location = new System.Drawing.Point(4, 22);
            this.tabViewParam.Name = "tabViewParam";
            this.tabViewParam.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewParam.Size = new System.Drawing.Size(330, 313);
            this.tabViewParam.TabIndex = 3;
            this.tabViewParam.Text = "Views";
            this.tabViewParam.UseVisualStyleBackColor = true;
            // 
            // boxViewParam
            // 
            this.boxViewParam.Controls.Add(this.boxViewSub);
            this.boxViewParam.Controls.Add(this.boxViewGroup);
            this.boxViewParam.Controls.Add(this.lblParam2);
            this.boxViewParam.Controls.Add(this.lblParam1);
            this.boxViewParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxViewParam.Location = new System.Drawing.Point(3, 3);
            this.boxViewParam.Name = "boxViewParam";
            this.boxViewParam.Size = new System.Drawing.Size(324, 307);
            this.boxViewParam.TabIndex = 1;
            this.boxViewParam.TabStop = false;
            this.boxViewParam.Text = "View Parameters";
            // 
            // boxViewSub
            // 
            this.boxViewSub.FormattingEnabled = true;
            this.boxViewSub.Location = new System.Drawing.Point(125, 45);
            this.boxViewSub.Name = "boxViewSub";
            this.boxViewSub.Size = new System.Drawing.Size(193, 21);
            this.boxViewSub.TabIndex = 3;
            // 
            // boxViewGroup
            // 
            this.boxViewGroup.FormattingEnabled = true;
            this.boxViewGroup.Location = new System.Drawing.Point(125, 20);
            this.boxViewGroup.Name = "boxViewGroup";
            this.boxViewGroup.Size = new System.Drawing.Size(193, 21);
            this.boxViewGroup.TabIndex = 2;
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Location = new System.Drawing.Point(10, 50);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(107, 13);
            this.lblParam2.TabIndex = 1;
            this.lblParam2.Text = "Subgroup Parameter:";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(10, 25);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(90, 13);
            this.lblParam1.TabIndex = 0;
            this.lblParam1.Text = "Group Parameter:";
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.boxSheet4);
            this.tabFile.Controls.Add(this.boxSheet3);
            this.tabFile.Controls.Add(this.boxSheet2);
            this.tabFile.Controls.Add(this.boxSheet1);
            this.tabFile.Controls.Add(this.lblSheet4);
            this.tabFile.Controls.Add(this.lblSheet3);
            this.tabFile.Controls.Add(this.lblSheet2);
            this.tabFile.Controls.Add(this.lblSheet1);
            this.tabFile.Controls.Add(this.lblSelectFile);
            this.tabFile.Controls.Add(this.btnSelectFile);
            this.tabFile.Controls.Add(this.boxSelectFile);
            this.tabFile.Controls.Add(this.boxFileTab);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(330, 313);
            this.tabFile.TabIndex = 0;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // boxSheet4
            // 
            this.boxSheet4.FormattingEnabled = true;
            this.boxSheet4.Location = new System.Drawing.Point(110, 125);
            this.boxSheet4.Name = "boxSheet4";
            this.boxSheet4.Size = new System.Drawing.Size(212, 21);
            this.boxSheet4.TabIndex = 10;
            // 
            // boxSheet3
            // 
            this.boxSheet3.FormattingEnabled = true;
            this.boxSheet3.Location = new System.Drawing.Point(110, 100);
            this.boxSheet3.Name = "boxSheet3";
            this.boxSheet3.Size = new System.Drawing.Size(212, 21);
            this.boxSheet3.TabIndex = 9;
            // 
            // boxSheet2
            // 
            this.boxSheet2.FormattingEnabled = true;
            this.boxSheet2.Location = new System.Drawing.Point(110, 75);
            this.boxSheet2.Name = "boxSheet2";
            this.boxSheet2.Size = new System.Drawing.Size(212, 21);
            this.boxSheet2.TabIndex = 8;
            // 
            // boxSheet1
            // 
            this.boxSheet1.FormattingEnabled = true;
            this.boxSheet1.Location = new System.Drawing.Point(110, 50);
            this.boxSheet1.Name = "boxSheet1";
            this.boxSheet1.Size = new System.Drawing.Size(212, 21);
            this.boxSheet1.TabIndex = 7;
            // 
            // lblSheet4
            // 
            this.lblSheet4.AutoSize = true;
            this.lblSheet4.Location = new System.Drawing.Point(10, 130);
            this.lblSheet4.Name = "lblSheet4";
            this.lblSheet4.Size = new System.Drawing.Size(80, 13);
            this.lblSheet4.TabIndex = 6;
            this.lblSheet4.Text = "Select Sheet 4:";
            // 
            // lblSheet3
            // 
            this.lblSheet3.AutoSize = true;
            this.lblSheet3.Location = new System.Drawing.Point(10, 105);
            this.lblSheet3.Name = "lblSheet3";
            this.lblSheet3.Size = new System.Drawing.Size(80, 13);
            this.lblSheet3.TabIndex = 5;
            this.lblSheet3.Text = "Select Sheet 3:";
            // 
            // lblSheet2
            // 
            this.lblSheet2.AutoSize = true;
            this.lblSheet2.Location = new System.Drawing.Point(10, 80);
            this.lblSheet2.Name = "lblSheet2";
            this.lblSheet2.Size = new System.Drawing.Size(80, 13);
            this.lblSheet2.TabIndex = 4;
            this.lblSheet2.Text = "Select Sheet 2:";
            // 
            // lblSheet1
            // 
            this.lblSheet1.AutoSize = true;
            this.lblSheet1.Location = new System.Drawing.Point(10, 55);
            this.lblSheet1.Name = "lblSheet1";
            this.lblSheet1.Size = new System.Drawing.Size(80, 13);
            this.lblSheet1.TabIndex = 3;
            this.lblSheet1.Text = "Select Sheet 1:";
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(10, 25);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(59, 13);
            this.lblSelectFile.TabIndex = 2;
            this.lblSelectFile.Text = "Select File:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(296, 19);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(26, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // boxSelectFile
            // 
            this.boxSelectFile.Enabled = false;
            this.boxSelectFile.Location = new System.Drawing.Point(110, 20);
            this.boxSelectFile.Name = "boxSelectFile";
            this.boxSelectFile.ReadOnly = true;
            this.boxSelectFile.Size = new System.Drawing.Size(180, 20);
            this.boxSelectFile.TabIndex = 0;
            this.boxSelectFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxFileTab
            // 
            this.boxFileTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxFileTab.Location = new System.Drawing.Point(3, 3);
            this.boxFileTab.Name = "boxFileTab";
            this.boxFileTab.Size = new System.Drawing.Size(324, 307);
            this.boxFileTab.TabIndex = 2;
            this.boxFileTab.TabStop = false;
            this.boxFileTab.Text = "Select Worksheets";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFile);
            this.tabControl.Controls.Add(this.tabViewParam);
            this.tabControl.Controls.Add(this.tabSheetsParam);
            this.tabControl.Controls.Add(this.tabElementParam);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(338, 339);
            this.tabControl.TabIndex = 2;
            // 
            // tabSheetsParam
            // 
            this.tabSheetsParam.Controls.Add(this.boxSheetParam);
            this.tabSheetsParam.Location = new System.Drawing.Point(4, 22);
            this.tabSheetsParam.Name = "tabSheetsParam";
            this.tabSheetsParam.Padding = new System.Windows.Forms.Padding(3);
            this.tabSheetsParam.Size = new System.Drawing.Size(330, 313);
            this.tabSheetsParam.TabIndex = 4;
            this.tabSheetsParam.Text = "Sheets";
            this.tabSheetsParam.UseVisualStyleBackColor = true;
            // 
            // boxSheetParam
            // 
            this.boxSheetParam.Controls.Add(this.boxSheetSub);
            this.boxSheetParam.Controls.Add(this.boxSheetGroup);
            this.boxSheetParam.Controls.Add(this.lblParam4);
            this.boxSheetParam.Controls.Add(this.lblParam3);
            this.boxSheetParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxSheetParam.Location = new System.Drawing.Point(3, 3);
            this.boxSheetParam.Name = "boxSheetParam";
            this.boxSheetParam.Size = new System.Drawing.Size(324, 307);
            this.boxSheetParam.TabIndex = 2;
            this.boxSheetParam.TabStop = false;
            this.boxSheetParam.Text = "Sheet Parameters";
            // 
            // boxSheetSub
            // 
            this.boxSheetSub.FormattingEnabled = true;
            this.boxSheetSub.Location = new System.Drawing.Point(125, 45);
            this.boxSheetSub.Name = "boxSheetSub";
            this.boxSheetSub.Size = new System.Drawing.Size(193, 21);
            this.boxSheetSub.TabIndex = 3;
            // 
            // boxSheetGroup
            // 
            this.boxSheetGroup.FormattingEnabled = true;
            this.boxSheetGroup.Location = new System.Drawing.Point(125, 20);
            this.boxSheetGroup.Name = "boxSheetGroup";
            this.boxSheetGroup.Size = new System.Drawing.Size(193, 21);
            this.boxSheetGroup.TabIndex = 2;
            // 
            // lblParam4
            // 
            this.lblParam4.AutoSize = true;
            this.lblParam4.Location = new System.Drawing.Point(10, 50);
            this.lblParam4.Name = "lblParam4";
            this.lblParam4.Size = new System.Drawing.Size(107, 13);
            this.lblParam4.TabIndex = 1;
            this.lblParam4.Text = "Subgroup Parameter:";
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Location = new System.Drawing.Point(10, 25);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(90, 13);
            this.lblParam3.TabIndex = 0;
            this.lblParam3.Text = "Group Parameter:";
            // 
            // tabElementParam
            // 
            this.tabElementParam.Controls.Add(this.boxElementParam);
            this.tabElementParam.Location = new System.Drawing.Point(4, 22);
            this.tabElementParam.Name = "tabElementParam";
            this.tabElementParam.Padding = new System.Windows.Forms.Padding(3);
            this.tabElementParam.Size = new System.Drawing.Size(330, 313);
            this.tabElementParam.TabIndex = 2;
            this.tabElementParam.Text = "Elements";
            this.tabElementParam.UseVisualStyleBackColor = true;
            // 
            // boxElementParam
            // 
            this.boxElementParam.Controls.Add(this.boxElemParam);
            this.boxElementParam.Controls.Add(this.lblParam9);
            this.boxElementParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxElementParam.Location = new System.Drawing.Point(3, 3);
            this.boxElementParam.Name = "boxElementParam";
            this.boxElementParam.Size = new System.Drawing.Size(324, 307);
            this.boxElementParam.TabIndex = 2;
            this.boxElementParam.TabStop = false;
            this.boxElementParam.Text = "Element Parameters";
            // 
            // boxElemParam
            // 
            this.boxElemParam.FormattingEnabled = true;
            this.boxElemParam.Location = new System.Drawing.Point(125, 20);
            this.boxElemParam.Name = "boxElemParam";
            this.boxElemParam.Size = new System.Drawing.Size(193, 154);
            this.boxElemParam.TabIndex = 2;
            // 
            // lblParam9
            // 
            this.lblParam9.AutoSize = true;
            this.lblParam9.Location = new System.Drawing.Point(10, 25);
            this.lblParam9.Name = "lblParam9";
            this.lblParam9.Size = new System.Drawing.Size(90, 13);
            this.lblParam9.TabIndex = 0;
            this.lblParam9.Text = "Group Parameter:";
            // 
            // ModelReviser
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(338, 426);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.grpFooter);
            this.Controls.Add(this.grpHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelReviser";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModelReviser_Load);
            this.grpFooter.ResumeLayout(false);
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            this.tabViewParam.ResumeLayout(false);
            this.boxViewParam.ResumeLayout(false);
            this.boxViewParam.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSheetsParam.ResumeLayout(false);
            this.boxSheetParam.ResumeLayout(false);
            this.boxSheetParam.PerformLayout();
            this.tabElementParam.ResumeLayout(false);
            this.boxElementParam.ResumeLayout(false);
            this.boxElementParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFooter;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.ComboBox boxSheet4;
        private System.Windows.Forms.ComboBox boxSheet3;
        private System.Windows.Forms.ComboBox boxSheet2;
        private System.Windows.Forms.ComboBox boxSheet1;
        private System.Windows.Forms.Label lblSheet4;
        private System.Windows.Forms.Label lblSheet3;
        private System.Windows.Forms.Label lblSheet2;
        private System.Windows.Forms.Label lblSheet1;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox boxSelectFile;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabElementParam;
        private System.Windows.Forms.GroupBox boxElementParam;
        private System.Windows.Forms.CheckedListBox boxElemParam;
        private System.Windows.Forms.Label lblParam9;
        private System.Windows.Forms.GroupBox boxFileTab;
        private System.Windows.Forms.TabPage tabViewParam;
        private System.Windows.Forms.TabPage tabSheetsParam;
        private System.Windows.Forms.GroupBox boxViewParam;
        private System.Windows.Forms.ComboBox boxViewSub;
        private System.Windows.Forms.ComboBox boxViewGroup;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.GroupBox boxSheetParam;
        private System.Windows.Forms.ComboBox boxSheetSub;
        private System.Windows.Forms.ComboBox boxSheetGroup;
        private System.Windows.Forms.Label lblParam4;
        private System.Windows.Forms.Label lblParam3;
    }
}