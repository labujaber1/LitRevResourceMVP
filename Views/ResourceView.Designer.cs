
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
            this.Rtbx_Notes = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_CreateAddRef = new System.Windows.Forms.Button();
            this.Tbx_NewCategory = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Tbcl_ResourceList = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Lbx_ViewAllModules = new System.Windows.Forms.ListBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_ViewAssignResources = new System.Windows.Forms.Button();
            this.Lbl_AssignList = new System.Windows.Forms.Label();
            this.Lbl_ModuleList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_AssignmentTitle = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewAssign = new System.Windows.Forms.DataGridView();
            this.Lbl_SelectAssignment = new System.Windows.Forms.Label();
            this.Btn_BackToMain = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Tbx_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.dataGridViewResource = new System.Windows.Forms.DataGridView();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_AddNew = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Lbl_ViewCategories = new System.Windows.Forms.Label();
            this.Lklbl_WebLink = new System.Windows.Forms.LinkLabel();
            this.Lbx_ListOfCategories = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbcl_ResourceList.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbx_IdNum
            // 
            this.Tbx_IdNum.Location = new System.Drawing.Point(7, 6);
            this.Tbx_IdNum.Name = "Tbx_IdNum";
            this.Tbx_IdNum.PlaceholderText = "Id number";
            this.Tbx_IdNum.ReadOnly = true;
            this.Tbx_IdNum.Size = new System.Drawing.Size(180, 31);
            this.Tbx_IdNum.TabIndex = 1;
            // 
            // Tbx_WebLink
            // 
            this.Tbx_WebLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_WebLink.Location = new System.Drawing.Point(7, 43);
            this.Tbx_WebLink.Name = "Tbx_WebLink";
            this.Tbx_WebLink.PlaceholderText = "Paste web link";
            this.Tbx_WebLink.Size = new System.Drawing.Size(788, 31);
            this.Tbx_WebLink.TabIndex = 2;
            // 
            // Tbx_Type
            // 
            this.Tbx_Type.Location = new System.Drawing.Point(7, 80);
            this.Tbx_Type.Name = "Tbx_Type";
            this.Tbx_Type.PlaceholderText = "Enter resource type";
            this.Tbx_Type.Size = new System.Drawing.Size(366, 31);
            this.Tbx_Type.TabIndex = 3;
            // 
            // Tbx_DoiNum
            // 
            this.Tbx_DoiNum.Location = new System.Drawing.Point(7, 117);
            this.Tbx_DoiNum.Name = "Tbx_DoiNum";
            this.Tbx_DoiNum.PlaceholderText = "Enter DOI number";
            this.Tbx_DoiNum.Size = new System.Drawing.Size(366, 31);
            this.Tbx_DoiNum.TabIndex = 4;
            // 
            // Tbx_Reference
            // 
            this.Tbx_Reference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Reference.Location = new System.Drawing.Point(7, 230);
            this.Tbx_Reference.Multiline = true;
            this.Tbx_Reference.Name = "Tbx_Reference";
            this.Tbx_Reference.PlaceholderText = "Paste or add reference";
            this.Tbx_Reference.Size = new System.Drawing.Size(568, 36);
            this.Tbx_Reference.TabIndex = 5;
            // 
            // Rtbx_MainPoint
            // 
            this.Rtbx_MainPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtbx_MainPoint.Location = new System.Drawing.Point(7, 272);
            this.Rtbx_MainPoint.Name = "Rtbx_MainPoint";
            this.Rtbx_MainPoint.Size = new System.Drawing.Size(659, 138);
            this.Rtbx_MainPoint.TabIndex = 8;
            this.Rtbx_MainPoint.Text = "Enter the main point - \n";
            // 
            // Rtbx_Notes
            // 
            this.Rtbx_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtbx_Notes.Location = new System.Drawing.Point(7, 416);
            this.Rtbx_Notes.Name = "Rtbx_Notes";
            this.Rtbx_Notes.Size = new System.Drawing.Size(659, 180);
            this.Rtbx_Notes.TabIndex = 9;
            this.Rtbx_Notes.Text = "Enter some notes - \n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 31);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Btn_CreateAddRef
            // 
            this.Btn_CreateAddRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CreateAddRef.Location = new System.Drawing.Point(613, 230);
            this.Btn_CreateAddRef.Name = "Btn_CreateAddRef";
            this.Btn_CreateAddRef.Size = new System.Drawing.Size(182, 36);
            this.Btn_CreateAddRef.TabIndex = 12;
            this.Btn_CreateAddRef.Text = "Create reference";
            this.Btn_CreateAddRef.UseVisualStyleBackColor = true;
            // 
            // Tbx_NewCategory
            // 
            this.Tbx_NewCategory.BackColor = System.Drawing.SystemColors.Window;
            this.Tbx_NewCategory.Location = new System.Drawing.Point(7, 191);
            this.Tbx_NewCategory.Name = "Tbx_NewCategory";
            this.Tbx_NewCategory.PlaceholderText = "Enter category";
            this.Tbx_NewCategory.Size = new System.Drawing.Size(366, 31);
            this.Tbx_NewCategory.TabIndex = 13;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(684, 434);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(111, 71);
            this.Btn_Cancel.TabIndex = 16;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.Location = new System.Drawing.Point(684, 346);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(111, 73);
            this.Btn_Save.TabIndex = 17;
            this.Btn_Save.Text = "Save/\r\nUpdate";
            this.Btn_Save.UseVisualStyleBackColor = true;
            // 
            // Tbcl_ResourceList
            // 
            this.Tbcl_ResourceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbcl_ResourceList.Controls.Add(this.tabPage4);
            this.Tbcl_ResourceList.Controls.Add(this.tabPage1);
            this.Tbcl_ResourceList.Controls.Add(this.tabPage2);
            this.Tbcl_ResourceList.Controls.Add(this.tabPage3);
            this.Tbcl_ResourceList.Location = new System.Drawing.Point(12, 12);
            this.Tbcl_ResourceList.Name = "Tbcl_ResourceList";
            this.Tbcl_ResourceList.SelectedIndex = 0;
            this.Tbcl_ResourceList.Size = new System.Drawing.Size(825, 656);
            this.Tbcl_ResourceList.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Tan;
            this.tabPage4.Controls.Add(this.Lbx_ViewAllModules);
            this.tabPage4.Controls.Add(this.Btn_Exit);
            this.tabPage4.Controls.Add(this.Btn_ViewAssignResources);
            this.tabPage4.Controls.Add(this.Lbl_AssignList);
            this.tabPage4.Controls.Add(this.Lbl_ModuleList);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(817, 618);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Assignment list";
            // 
            // Lbx_ViewAllModules
            // 
            this.Lbx_ViewAllModules.FormattingEnabled = true;
            this.Lbx_ViewAllModules.ItemHeight = 25;
            this.Lbx_ViewAllModules.Location = new System.Drawing.Point(52, 127);
            this.Lbx_ViewAllModules.Name = "Lbx_ViewAllModules";
            this.Lbx_ViewAllModules.Size = new System.Drawing.Size(514, 129);
            this.Lbx_ViewAllModules.TabIndex = 14;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(608, 525);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(112, 57);
            this.Btn_Exit.TabIndex = 13;
            this.Btn_Exit.Text = "Close";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_ViewAssignResources
            // 
            this.Btn_ViewAssignResources.Location = new System.Drawing.Point(608, 323);
            this.Btn_ViewAssignResources.Name = "Btn_ViewAssignResources";
            this.Btn_ViewAssignResources.Size = new System.Drawing.Size(113, 94);
            this.Btn_ViewAssignResources.TabIndex = 9;
            this.Btn_ViewAssignResources.Text = "View assignment resources";
            this.Btn_ViewAssignResources.UseVisualStyleBackColor = true;
            // 
            // Lbl_AssignList
            // 
            this.Lbl_AssignList.AutoSize = true;
            this.Lbl_AssignList.Location = new System.Drawing.Point(52, 286);
            this.Lbl_AssignList.Name = "Lbl_AssignList";
            this.Lbl_AssignList.Size = new System.Drawing.Size(114, 25);
            this.Lbl_AssignList.TabIndex = 7;
            this.Lbl_AssignList.Text = "Assignments";
            // 
            // Lbl_ModuleList
            // 
            this.Lbl_ModuleList.AutoSize = true;
            this.Lbl_ModuleList.Location = new System.Drawing.Point(52, 99);
            this.Lbl_ModuleList.Name = "Lbl_ModuleList";
            this.Lbl_ModuleList.Size = new System.Drawing.Size(73, 25);
            this.Lbl_ModuleList.TabIndex = 4;
            this.Lbl_ModuleList.Text = "Module";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_AssignmentTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 77);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_AssignmentTitle
            // 
            this.Lbl_AssignmentTitle.AutoSize = true;
            this.Lbl_AssignmentTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AssignmentTitle.Location = new System.Drawing.Point(263, 14);
            this.Lbl_AssignmentTitle.Name = "Lbl_AssignmentTitle";
            this.Lbl_AssignmentTitle.Size = new System.Drawing.Size(274, 45);
            this.Lbl_AssignmentTitle.TabIndex = 0;
            this.Lbl_AssignmentTitle.Text = "View assignments";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.dataGridViewAssign);
            this.tabPage1.Controls.Add(this.Lbl_SelectAssignment);
            this.tabPage1.Controls.Add(this.Btn_BackToMain);
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
            this.tabPage1.Size = new System.Drawing.Size(817, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resource list";
            // 
            // dataGridViewAssign
            // 
            this.dataGridViewAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssign.Location = new System.Drawing.Point(19, 34);
            this.dataGridViewAssign.Name = "dataGridViewAssign";
            this.dataGridViewAssign.ReadOnly = true;
            this.dataGridViewAssign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewAssign.RowTemplate.Height = 33;
            this.dataGridViewAssign.Size = new System.Drawing.Size(776, 198);
            this.dataGridViewAssign.TabIndex = 9;
            // 
            // Lbl_SelectAssignment
            // 
            this.Lbl_SelectAssignment.AutoSize = true;
            this.Lbl_SelectAssignment.Location = new System.Drawing.Point(19, 6);
            this.Lbl_SelectAssignment.Name = "Lbl_SelectAssignment";
            this.Lbl_SelectAssignment.Size = new System.Drawing.Size(154, 25);
            this.Lbl_SelectAssignment.TabIndex = 8;
            this.Lbl_SelectAssignment.Text = "Select assignment";
            // 
            // Btn_BackToMain
            // 
            this.Btn_BackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BackToMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_BackToMain.ForeColor = System.Drawing.Color.Black;
            this.Btn_BackToMain.Location = new System.Drawing.Point(666, 554);
            this.Btn_BackToMain.Name = "Btn_BackToMain";
            this.Btn_BackToMain.Size = new System.Drawing.Size(116, 46);
            this.Btn_BackToMain.TabIndex = 7;
            this.Btn_BackToMain.Text = "Back ";
            this.Btn_BackToMain.UseVisualStyleBackColor = true;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Edit.Location = new System.Drawing.Point(357, 554);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(142, 46);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Tbx_Search
            // 
            this.Tbx_Search.Location = new System.Drawing.Point(108, 238);
            this.Tbx_Search.Name = "Tbx_Search";
            this.Tbx_Search.PlaceholderText = "Enter resource Id or category";
            this.Tbx_Search.Size = new System.Drawing.Size(256, 31);
            this.Tbx_Search.TabIndex = 0;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Location = new System.Drawing.Point(383, 238);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(141, 31);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResource
            // 
            this.dataGridViewResource.AllowUserToOrderColumns = true;
            this.dataGridViewResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResource.Location = new System.Drawing.Point(19, 275);
            this.dataGridViewResource.Name = "dataGridViewResource";
            this.dataGridViewResource.ReadOnly = true;
            this.dataGridViewResource.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewResource.RowTemplate.Height = 33;
            this.dataGridViewResource.Size = new System.Drawing.Size(776, 272);
            this.dataGridViewResource.TabIndex = 2;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Delete.Location = new System.Drawing.Point(194, 553);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(142, 47);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Btn_AddNew
            // 
            this.Btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_AddNew.Location = new System.Drawing.Point(37, 553);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(142, 47);
            this.Btn_AddNew.TabIndex = 3;
            this.Btn_AddNew.Text = "Add new";
            this.Btn_AddNew.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.Lbl_ViewCategories);
            this.tabPage2.Controls.Add(this.Lklbl_WebLink);
            this.tabPage2.Controls.Add(this.Lbx_ListOfCategories);
            this.tabPage2.Controls.Add(this.Tbx_IdNum);
            this.tabPage2.Controls.Add(this.Tbx_WebLink);
            this.tabPage2.Controls.Add(this.Btn_Save);
            this.tabPage2.Controls.Add(this.Btn_Cancel);
            this.tabPage2.Controls.Add(this.Tbx_Type);
            this.tabPage2.Controls.Add(this.Tbx_DoiNum);
            this.tabPage2.Controls.Add(this.Rtbx_Notes);
            this.tabPage2.Controls.Add(this.Btn_CreateAddRef);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.Rtbx_MainPoint);
            this.tabPage2.Controls.Add(this.Tbx_Reference);
            this.tabPage2.Controls.Add(this.Tbx_NewCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resource edit";
            // 
            // Lbl_ViewCategories
            // 
            this.Lbl_ViewCategories.AutoSize = true;
            this.Lbl_ViewCategories.BackColor = System.Drawing.Color.Silver;
            this.Lbl_ViewCategories.Location = new System.Drawing.Point(484, 90);
            this.Lbl_ViewCategories.Name = "Lbl_ViewCategories";
            this.Lbl_ViewCategories.Size = new System.Drawing.Size(267, 25);
            this.Lbl_ViewCategories.TabIndex = 20;
            this.Lbl_ViewCategories.Text = "List of categories used, readonly";
            // 
            // Lklbl_WebLink
            // 
            this.Lklbl_WebLink.AutoSize = true;
            this.Lklbl_WebLink.Location = new System.Drawing.Point(236, 6);
            this.Lklbl_WebLink.Name = "Lklbl_WebLink";
            this.Lklbl_WebLink.Size = new System.Drawing.Size(90, 25);
            this.Lklbl_WebLink.TabIndex = 19;
            this.Lklbl_WebLink.TabStop = true;
            this.Lklbl_WebLink.Text = "linkLabel1";
            // 
            // Lbx_ListOfCategories
            // 
            this.Lbx_ListOfCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_ListOfCategories.BackColor = System.Drawing.SystemColors.Control;
            this.Lbx_ListOfCategories.FormattingEnabled = true;
            this.Lbx_ListOfCategories.ItemHeight = 25;
            this.Lbx_ListOfCategories.Location = new System.Drawing.Point(484, 118);
            this.Lbx_ListOfCategories.MultiColumn = true;
            this.Lbx_ListOfCategories.Name = "Lbx_ListOfCategories";
            this.Lbx_ListOfCategories.Size = new System.Drawing.Size(311, 104);
            this.Lbx_ListOfCategories.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(817, 618);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAY NOT DEVELOPE HERE\r\nIts alot bigger than first thourght";
            // 
            // ResourceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 681);
            this.Controls.Add(this.Tbcl_ResourceList);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "ResourceView";
            this.Text = "ResourceView";
            this.Tbcl_ResourceList.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Tbx_IdNum;
        private System.Windows.Forms.TextBox Tbx_WebLink;
        private System.Windows.Forms.TextBox Tbx_Type;
        private System.Windows.Forms.TextBox Tbx_DoiNum;
        private System.Windows.Forms.TextBox Tbx_Reference;
        private System.Windows.Forms.RichTextBox Rtbx_MainPoint;
        private System.Windows.Forms.RichTextBox Rtbx_Notes;
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
        private System.Windows.Forms.Button Btn_BackToMain;
        private System.Windows.Forms.ListBox Lbx_ListOfCategories;
        private System.Windows.Forms.LinkLabel Lklbl_WebLink;
        private System.Windows.Forms.Label Lbl_ViewCategories;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Btn_ViewAssignResources;
        private System.Windows.Forms.Label Lbl_AssignList;
        private System.Windows.Forms.Label Lbl_ModuleList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_AssignmentTitle;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ListBox Lbx_ViewAllModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_SelectAssignment;
        private System.Windows.Forms.DataGridView dataGridViewAssign;
    }
}