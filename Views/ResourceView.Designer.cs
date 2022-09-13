
using System;
using System.Reflection;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    partial class ResourceView
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
            this.Tbx_IdNum = new System.Windows.Forms.TextBox();
            this.Tbx_WebLink = new System.Windows.Forms.TextBox();
            this.Tbx_Type = new System.Windows.Forms.TextBox();
            this.Tbx_DoiNum = new System.Windows.Forms.TextBox();
            this.Tbx_Reference = new System.Windows.Forms.TextBox();
            this.Rtbx_MainPoint = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_CreateAddRef = new System.Windows.Forms.Button();
            this.Tbx_NewCategory = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Tbcl_ResourceList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lbl_CatList = new System.Windows.Forms.Label();
            this.Lbx_ViewResCategories = new System.Windows.Forms.ListBox();
            this.Lbl_SelectResource = new System.Windows.Forms.Label();
            this.Tbx_AssignIdNum = new System.Windows.Forms.TextBox();
            this.dataGridViewAssign = new System.Windows.Forms.DataGridView();
            this.Lbl_SelectAssignment = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Tbx_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.dataGridViewResource = new System.Windows.Forms.DataGridView();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_AddNew = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tbx_SearchTerm = new System.Windows.Forms.TextBox();
            this.Tbx_RefInFile = new System.Windows.Forms.TextBox();
            this.Lbl_RefInFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_NoteCharLength = new System.Windows.Forms.Button();
            this.Btn_MainCharLength = new System.Windows.Forms.Button();
            this.Rtbx_Notes = new System.Windows.Forms.RichTextBox();
            this.Lbl_ViewCategories = new System.Windows.Forms.Label();
            this.Lklbl_WebLink = new System.Windows.Forms.LinkLabel();
            this.Lbx_ListOfCategories = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_RefBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbcl_ResourceList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbx_IdNum
            // 
            this.Tbx_IdNum.Location = new System.Drawing.Point(7, 6);
            this.Tbx_IdNum.Name = "Tbx_IdNum";
            this.Tbx_IdNum.PlaceholderText = "Id number";
            this.Tbx_IdNum.ReadOnly = true;
            this.Tbx_IdNum.Size = new System.Drawing.Size(120, 31);
            this.Tbx_IdNum.TabIndex = 1;
            // 
            // Tbx_WebLink
            // 
            this.Tbx_WebLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_WebLink.Location = new System.Drawing.Point(7, 43);
            this.Tbx_WebLink.Multiline = true;
            this.Tbx_WebLink.Name = "Tbx_WebLink";
            this.Tbx_WebLink.PlaceholderText = "Paste web link";
            this.Tbx_WebLink.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_WebLink.Size = new System.Drawing.Size(804, 31);
            this.Tbx_WebLink.TabIndex = 2;
            // 
            // Tbx_Type
            // 
            this.Tbx_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Type.Location = new System.Drawing.Point(7, 117);
            this.Tbx_Type.Name = "Tbx_Type";
            this.Tbx_Type.PlaceholderText = "Enter resource type";
            this.Tbx_Type.Size = new System.Drawing.Size(366, 31);
            this.Tbx_Type.TabIndex = 3;
            // 
            // Tbx_DoiNum
            // 
            this.Tbx_DoiNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_DoiNum.Location = new System.Drawing.Point(7, 239);
            this.Tbx_DoiNum.Name = "Tbx_DoiNum";
            this.Tbx_DoiNum.PlaceholderText = "Enter DOI number";
            this.Tbx_DoiNum.Size = new System.Drawing.Size(366, 31);
            this.Tbx_DoiNum.TabIndex = 4;
            // 
            // Tbx_Reference
            // 
            this.Tbx_Reference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Reference.Location = new System.Drawing.Point(7, 197);
            this.Tbx_Reference.Multiline = true;
            this.Tbx_Reference.Name = "Tbx_Reference";
            this.Tbx_Reference.PlaceholderText = "Paste or add reference";
            this.Tbx_Reference.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Reference.Size = new System.Drawing.Size(804, 36);
            this.Tbx_Reference.TabIndex = 7;
            // 
            // Rtbx_MainPoint
            // 
            this.Rtbx_MainPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtbx_MainPoint.Location = new System.Drawing.Point(7, 276);
            this.Rtbx_MainPoint.Name = "Rtbx_MainPoint";
            this.Rtbx_MainPoint.Size = new System.Drawing.Size(659, 176);
            this.Rtbx_MainPoint.TabIndex = 8;
            this.Rtbx_MainPoint.Text = "Main point - \n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 31);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 31, 0, 0, 0, 0);
            // 
            // Btn_CreateAddRef
            // 
            this.Btn_CreateAddRef.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_CreateAddRef.BackColor = System.Drawing.Color.Bisque;
            this.Btn_CreateAddRef.Location = new System.Drawing.Point(672, 239);
            this.Btn_CreateAddRef.Name = "Btn_CreateAddRef";
            this.Btn_CreateAddRef.Size = new System.Drawing.Size(123, 60);
            this.Btn_CreateAddRef.TabIndex = 15;
            this.Btn_CreateAddRef.Text = "Add ref in file";
            this.Btn_CreateAddRef.UseVisualStyleBackColor = false;
            // 
            // Tbx_NewCategory
            // 
            this.Tbx_NewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_NewCategory.BackColor = System.Drawing.SystemColors.Window;
            this.Tbx_NewCategory.Location = new System.Drawing.Point(7, 80);
            this.Tbx_NewCategory.Name = "Tbx_NewCategory";
            this.Tbx_NewCategory.PlaceholderText = "Enter category";
            this.Tbx_NewCategory.Size = new System.Drawing.Size(366, 31);
            this.Tbx_NewCategory.TabIndex = 6;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.BackColor = System.Drawing.Color.Silver;
            this.Btn_Cancel.Location = new System.Drawing.Point(684, 487);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(111, 71);
            this.Btn_Cancel.TabIndex = 13;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.BackColor = System.Drawing.Color.Bisque;
            this.Btn_Save.Location = new System.Drawing.Point(684, 396);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(111, 73);
            this.Btn_Save.TabIndex = 12;
            this.Btn_Save.Text = "Save/\r\nUpdate";
            this.Btn_Save.UseVisualStyleBackColor = false;
            // 
            // Tbcl_ResourceList
            // 
            this.Tbcl_ResourceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbcl_ResourceList.Controls.Add(this.tabPage1);
            this.Tbcl_ResourceList.Controls.Add(this.tabPage2);
            this.Tbcl_ResourceList.Controls.Add(this.tabPage3);
            this.Tbcl_ResourceList.Location = new System.Drawing.Point(12, 12);
            this.Tbcl_ResourceList.Name = "Tbcl_ResourceList";
            this.Tbcl_ResourceList.SelectedIndex = 0;
            this.Tbcl_ResourceList.Size = new System.Drawing.Size(825, 684);
            this.Tbcl_ResourceList.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.Lbl_CatList);
            this.tabPage1.Controls.Add(this.Lbx_ViewResCategories);
            this.tabPage1.Controls.Add(this.Lbl_SelectResource);
            this.tabPage1.Controls.Add(this.Tbx_AssignIdNum);
            this.tabPage1.Controls.Add(this.dataGridViewAssign);
            this.tabPage1.Controls.Add(this.Lbl_SelectAssignment);
            this.tabPage1.Controls.Add(this.Btn_Close);
            this.tabPage1.Controls.Add(this.Btn_Edit);
            this.tabPage1.Controls.Add(this.Tbx_Search);
            this.tabPage1.Controls.Add(this.Btn_Search);
            this.tabPage1.Controls.Add(this.dataGridViewResource);
            this.tabPage1.Controls.Add(this.Btn_Delete);
            this.tabPage1.Controls.Add(this.Btn_AddNew);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resource list";
            // 
            // Lbl_CatList
            // 
            this.Lbl_CatList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CatList.AutoSize = true;
            this.Lbl_CatList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CatList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_CatList.Location = new System.Drawing.Point(440, 228);
            this.Lbl_CatList.Name = "Lbl_CatList";
            this.Lbl_CatList.Size = new System.Drawing.Size(329, 25);
            this.Lbl_CatList.TabIndex = 13;
            this.Lbl_CatList.Text = "List of categories to search for (readonly)";
            // 
            // Lbx_ViewResCategories
            // 
            this.Lbx_ViewResCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_ViewResCategories.BackColor = System.Drawing.SystemColors.Control;
            this.Lbx_ViewResCategories.FormattingEnabled = true;
            this.Lbx_ViewResCategories.ItemHeight = 25;
            this.Lbx_ViewResCategories.Location = new System.Drawing.Point(428, 256);
            this.Lbx_ViewResCategories.MultiColumn = true;
            this.Lbx_ViewResCategories.Name = "Lbx_ViewResCategories";
            this.Lbx_ViewResCategories.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Lbx_ViewResCategories.Size = new System.Drawing.Size(367, 54);
            this.Lbx_ViewResCategories.TabIndex = 12;
            // 
            // Lbl_SelectResource
            // 
            this.Lbl_SelectResource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_SelectResource.AutoSize = true;
            this.Lbl_SelectResource.Location = new System.Drawing.Point(19, 288);
            this.Lbl_SelectResource.Name = "Lbl_SelectResource";
            this.Lbl_SelectResource.Size = new System.Drawing.Size(322, 25);
            this.Lbl_SelectResource.TabIndex = 11;
            this.Lbl_SelectResource.Text = "Select Weblink to add, delete, edit/view";
            // 
            // Tbx_AssignIdNum
            // 
            this.Tbx_AssignIdNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_AssignIdNum.Location = new System.Drawing.Point(670, 3);
            this.Tbx_AssignIdNum.Name = "Tbx_AssignIdNum";
            this.Tbx_AssignIdNum.PlaceholderText = "Assign Id num";
            this.Tbx_AssignIdNum.ReadOnly = true;
            this.Tbx_AssignIdNum.Size = new System.Drawing.Size(125, 31);
            this.Tbx_AssignIdNum.TabIndex = 10;
            // 
            // dataGridViewAssign
            // 
            this.dataGridViewAssign.AllowUserToAddRows = false;
            this.dataGridViewAssign.AllowUserToDeleteRows = false;
            this.dataGridViewAssign.AllowUserToOrderColumns = true;
            this.dataGridViewAssign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssign.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewAssign.MultiSelect = false;
            this.dataGridViewAssign.Name = "dataGridViewAssign";
            this.dataGridViewAssign.ReadOnly = true;
            this.dataGridViewAssign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewAssign.RowTemplate.Height = 33;
            this.dataGridViewAssign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAssign.Size = new System.Drawing.Size(805, 191);
            this.dataGridViewAssign.TabIndex = 9;
            this.dataGridViewAssign.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAssign_CellClick);
            // 
            // Lbl_SelectAssignment
            // 
            this.Lbl_SelectAssignment.AutoSize = true;
            this.Lbl_SelectAssignment.Location = new System.Drawing.Point(19, 6);
            this.Lbl_SelectAssignment.Name = "Lbl_SelectAssignment";
            this.Lbl_SelectAssignment.Size = new System.Drawing.Size(434, 25);
            this.Lbl_SelectAssignment.TabIndex = 8;
            this.Lbl_SelectAssignment.Text = "Select assignment name for Id number and resources";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Close.ForeColor = System.Drawing.Color.Black;
            this.Btn_Close.Location = new System.Drawing.Point(632, 561);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(116, 46);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Edit.BackColor = System.Drawing.Color.Lavender;
            this.Btn_Edit.Location = new System.Drawing.Point(357, 562);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(142, 46);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Edit/View";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            // 
            // Tbx_Search
            // 
            this.Tbx_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Search.Location = new System.Drawing.Point(19, 238);
            this.Tbx_Search.Name = "Tbx_Search";
            this.Tbx_Search.PlaceholderText = "Enter resource Id or category";
            this.Tbx_Search.Size = new System.Drawing.Size(256, 31);
            this.Tbx_Search.TabIndex = 0;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.BackColor = System.Drawing.Color.Lavender;
            this.Btn_Search.Location = new System.Drawing.Point(281, 238);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(141, 31);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            // 
            // dataGridViewResource
            // 
            this.dataGridViewResource.AllowUserToAddRows = false;
            this.dataGridViewResource.AllowUserToDeleteRows = false;
            this.dataGridViewResource.AllowUserToOrderColumns = true;
            this.dataGridViewResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResource.Location = new System.Drawing.Point(6, 316);
            this.dataGridViewResource.MultiSelect = false;
            this.dataGridViewResource.Name = "dataGridViewResource";
            this.dataGridViewResource.ReadOnly = true;
            this.dataGridViewResource.RowHeadersWidth = 62;
            this.dataGridViewResource.RowTemplate.Height = 33;
            this.dataGridViewResource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewResource.Size = new System.Drawing.Size(805, 240);
            this.dataGridViewResource.TabIndex = 2;
            this.dataGridViewResource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewResource_CellClick);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Delete.BackColor = System.Drawing.Color.Lavender;
            this.Btn_Delete.Location = new System.Drawing.Point(194, 561);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(142, 47);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Btn_AddNew
            // 
            this.Btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_AddNew.BackColor = System.Drawing.Color.Lavender;
            this.Btn_AddNew.Location = new System.Drawing.Point(37, 561);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(142, 47);
            this.Btn_AddNew.TabIndex = 3;
            this.Btn_AddNew.Text = "Add new";
            this.Btn_AddNew.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.Tbx_SearchTerm);
            this.tabPage2.Controls.Add(this.Tbx_RefInFile);
            this.tabPage2.Controls.Add(this.Lbl_RefInFile);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Btn_NoteCharLength);
            this.tabPage2.Controls.Add(this.Btn_MainCharLength);
            this.tabPage2.Controls.Add(this.Rtbx_Notes);
            this.tabPage2.Controls.Add(this.Lbl_ViewCategories);
            this.tabPage2.Controls.Add(this.Lklbl_WebLink);
            this.tabPage2.Controls.Add(this.Lbx_ListOfCategories);
            this.tabPage2.Controls.Add(this.Tbx_IdNum);
            this.tabPage2.Controls.Add(this.Tbx_WebLink);
            this.tabPage2.Controls.Add(this.Btn_Save);
            this.tabPage2.Controls.Add(this.Btn_Cancel);
            this.tabPage2.Controls.Add(this.Tbx_Type);
            this.tabPage2.Controls.Add(this.Tbx_DoiNum);
            this.tabPage2.Controls.Add(this.Btn_CreateAddRef);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.Rtbx_MainPoint);
            this.tabPage2.Controls.Add(this.Tbx_Reference);
            this.tabPage2.Controls.Add(this.Tbx_NewCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resource edit";
            // 
            // Tbx_SearchTerm
            // 
            this.Tbx_SearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_SearchTerm.Location = new System.Drawing.Point(498, 136);
            this.Tbx_SearchTerm.Multiline = true;
            this.Tbx_SearchTerm.Name = "Tbx_SearchTerm";
            this.Tbx_SearchTerm.PlaceholderText = "Text used for search";
            this.Tbx_SearchTerm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_SearchTerm.Size = new System.Drawing.Size(313, 55);
            this.Tbx_SearchTerm.TabIndex = 27;
            // 
            // Tbx_RefInFile
            // 
            this.Tbx_RefInFile.Location = new System.Drawing.Point(580, 239);
            this.Tbx_RefInFile.Name = "Tbx_RefInFile";
            this.Tbx_RefInFile.Size = new System.Drawing.Size(73, 31);
            this.Tbx_RefInFile.TabIndex = 26;
            this.Tbx_RefInFile.Text = "No";
            // 
            // Lbl_RefInFile
            // 
            this.Lbl_RefInFile.AutoSize = true;
            this.Lbl_RefInFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_RefInFile.Location = new System.Drawing.Point(482, 242);
            this.Lbl_RefInFile.Name = "Lbl_RefInFile";
            this.Lbl_RefInFile.Size = new System.Drawing.Size(92, 25);
            this.Lbl_RefInFile.TabIndex = 25;
            this.Lbl_RefInFile.Text = "Ref in file?";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(379, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "accessed";
            // 
            // Btn_NoteCharLength
            // 
            this.Btn_NoteCharLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NoteCharLength.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_NoteCharLength.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_NoteCharLength.Location = new System.Drawing.Point(672, 586);
            this.Btn_NoteCharLength.Name = "Btn_NoteCharLength";
            this.Btn_NoteCharLength.Size = new System.Drawing.Size(112, 34);
            this.Btn_NoteCharLength.TabIndex = 11;
            this.Btn_NoteCharLength.Text = "Notes - char used";
            this.Btn_NoteCharLength.UseVisualStyleBackColor = false;
            // 
            // Btn_MainCharLength
            // 
            this.Btn_MainCharLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_MainCharLength.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_MainCharLength.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_MainCharLength.Location = new System.Drawing.Point(672, 329);
            this.Btn_MainCharLength.Name = "Btn_MainCharLength";
            this.Btn_MainCharLength.Size = new System.Drawing.Size(112, 34);
            this.Btn_MainCharLength.TabIndex = 10;
            this.Btn_MainCharLength.Text = "Main - char used";
            this.Btn_MainCharLength.UseVisualStyleBackColor = false;
            // 
            // Rtbx_Notes
            // 
            this.Rtbx_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtbx_Notes.Location = new System.Drawing.Point(7, 458);
            this.Rtbx_Notes.Name = "Rtbx_Notes";
            this.Rtbx_Notes.Size = new System.Drawing.Size(659, 173);
            this.Rtbx_Notes.TabIndex = 9;
            this.Rtbx_Notes.Text = "Notes - \n";
            // 
            // Lbl_ViewCategories
            // 
            this.Lbl_ViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ViewCategories.AutoSize = true;
            this.Lbl_ViewCategories.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ViewCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ViewCategories.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_ViewCategories.Location = new System.Drawing.Point(391, 80);
            this.Lbl_ViewCategories.Name = "Lbl_ViewCategories";
            this.Lbl_ViewCategories.Size = new System.Drawing.Size(97, 50);
            this.Lbl_ViewCategories.TabIndex = 20;
            this.Lbl_ViewCategories.Text = "categories \r\nused ";
            // 
            // Lklbl_WebLink
            // 
            this.Lklbl_WebLink.AutoSize = true;
            this.Lklbl_WebLink.Location = new System.Drawing.Point(133, 9);
            this.Lklbl_WebLink.Name = "Lklbl_WebLink";
            this.Lklbl_WebLink.Size = new System.Drawing.Size(90, 25);
            this.Lklbl_WebLink.TabIndex = 14;
            this.Lklbl_WebLink.TabStop = true;
            this.Lklbl_WebLink.Text = "linkLabel1";
            this.Lklbl_WebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lklbl_WebLink_LinkClicked);
            // 
            // Lbx_ListOfCategories
            // 
            this.Lbx_ListOfCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_ListOfCategories.BackColor = System.Drawing.SystemColors.Control;
            this.Lbx_ListOfCategories.FormattingEnabled = true;
            this.Lbx_ListOfCategories.ItemHeight = 25;
            this.Lbx_ListOfCategories.Location = new System.Drawing.Point(498, 80);
            this.Lbx_ListOfCategories.MultiColumn = true;
            this.Lbx_ListOfCategories.Name = "Lbx_ListOfCategories";
            this.Lbx_ListOfCategories.Size = new System.Drawing.Size(313, 54);
            this.Lbx_ListOfCategories.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox18);
            this.tabPage3.Controls.Add(this.textBox17);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.Btn_RefBack);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(817, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add reference";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(96, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox18.Location = new System.Drawing.Point(165, 17);
            this.textBox18.Name = "textBox18";
            this.textBox18.PlaceholderText = "Ref ID";
            this.textBox18.Size = new System.Drawing.Size(105, 31);
            this.textBox18.TabIndex = 28;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox17.Location = new System.Drawing.Point(40, 17);
            this.textBox17.Name = "textBox17";
            this.textBox17.PlaceholderText = "Resource ID";
            this.textBox17.Size = new System.Drawing.Size(119, 31);
            this.textBox17.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Location = new System.Drawing.Point(24, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 141);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(482, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date accessed";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(482, 104);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 31);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(482, 42);
            this.textBox16.Name = "textBox16";
            this.textBox16.PlaceholderText = "Issue";
            this.textBox16.Size = new System.Drawing.Size(150, 31);
            this.textBox16.TabIndex = 7;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(285, 104);
            this.textBox15.Name = "textBox15";
            this.textBox15.PlaceholderText = "Volume";
            this.textBox15.Size = new System.Drawing.Size(150, 31);
            this.textBox15.TabIndex = 6;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(285, 42);
            this.textBox14.Name = "textBox14";
            this.textBox14.PlaceholderText = "Pages";
            this.textBox14.Size = new System.Drawing.Size(150, 31);
            this.textBox14.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(47, 104);
            this.textBox10.Name = "textBox10";
            this.textBox10.PlaceholderText = "Edition";
            this.textBox10.Size = new System.Drawing.Size(150, 31);
            this.textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(47, 42);
            this.textBox9.Name = "textBox9";
            this.textBox9.PlaceholderText = "Year";
            this.textBox9.Size = new System.Drawing.Size(150, 31);
            this.textBox9.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(24, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 150);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(487, 96);
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "Publisher";
            this.textBox8.Size = new System.Drawing.Size(250, 31);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(487, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "City";
            this.textBox7.Size = new System.Drawing.Size(250, 31);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(20, 96);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "URL";
            this.textBox6.Size = new System.Drawing.Size(442, 46);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(20, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Journal name";
            this.textBox5.Size = new System.Drawing.Size(442, 31);
            this.textBox5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(24, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 150);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(413, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Corporate author";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(413, 94);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Webpage name";
            this.textBox4.Size = new System.Drawing.Size(324, 46);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(413, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Corporate author";
            this.textBox3.Size = new System.Drawing.Size(324, 31);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 94);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Title";
            this.textBox2.Size = new System.Drawing.Size(359, 46);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Author";
            this.textBox1.Size = new System.Drawing.Size(361, 46);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Website",
            "Book",
            "Journal",
            "E-Source"});
            this.comboBox2.Location = new System.Drawing.Point(543, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 33);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.Text = "Select source type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Harvard-Anglia",
            "APA",
            "Chicago",
            "IEEE"});
            this.comboBox1.Location = new System.Drawing.Point(284, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Select ref style";
            // 
            // Btn_RefBack
            // 
            this.Btn_RefBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_RefBack.Location = new System.Drawing.Point(617, 573);
            this.Btn_RefBack.Name = "Btn_RefBack";
            this.Btn_RefBack.Size = new System.Drawing.Size(122, 47);
            this.Btn_RefBack.TabIndex = 21;
            this.Btn_RefBack.Text = "Back";
            this.Btn_RefBack.UseVisualStyleBackColor = false;
            this.Btn_RefBack.Click += new System.EventHandler(this.Btn_RefBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAY NOT DEVELOPE HERE\r\nIts alot bigger than first thought";
            // 
            // ResourceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 701);
            this.Controls.Add(this.Tbcl_ResourceList);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "ResourceView";
            this.Text = "ResourceView";
            this.Tbcl_ResourceList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Tbx_IdNum;
        private System.Windows.Forms.TextBox Tbx_WebLink;
        private System.Windows.Forms.TextBox Tbx_Type;
        private System.Windows.Forms.TextBox Tbx_DoiNum;
        private System.Windows.Forms.TextBox Tbx_Reference;
        private System.Windows.Forms.RichTextBox Rtbx_MainPoint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btn_CreateAddRef;
        private System.Windows.Forms.TextBox Tbx_NewCategory;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TabControl Tbcl_ResourceList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_AddNew;
        private System.Windows.Forms.DataGridView dataGridViewResource;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Tbx_Search;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ListBox Lbx_ListOfCategories;
        private System.Windows.Forms.LinkLabel Lklbl_WebLink;
        private System.Windows.Forms.Label Lbl_ViewCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_SelectAssignment;
        private System.Windows.Forms.DataGridView dataGridViewAssign;
        private System.Windows.Forms.TextBox Tbx_AssignIdNum;
        private System.Windows.Forms.Button Btn_RefBack;
        private System.Windows.Forms.RichTextBox Rtbx_Notes;
        private System.Windows.Forms.Label Lbl_SelectResource;
        private System.Windows.Forms.Button Btn_NoteCharLength;
        private System.Windows.Forms.Button Btn_MainCharLength;
        private System.Windows.Forms.ListBox Lbx_ViewResCategories;
        private System.Windows.Forms.Label Lbl_CatList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Label Lbl_RefInFile;
        private TextBox Tbx_RefInFile;
        private TextBox Tbx_SearchTerm;
    }
}