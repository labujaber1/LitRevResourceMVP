
namespace LitRevResourceMVP.Views
{
    partial class AssignmentView
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
            this.Lbl_AssignmentTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_ModuleList = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_Info1 = new System.Windows.Forms.Label();
            this.Lbl_DisplayIdNum = new System.Windows.Forms.Label();
            this.Lbx_ModuleList = new System.Windows.Forms.ListBox();
            this.Tbx_ModuleIdNum = new System.Windows.Forms.TextBox();
            this.Btn_ExitAssignView = new System.Windows.Forms.Button();
            this.Lbl_AssignMainTitle = new System.Windows.Forms.Label();
            this.Btn_EditAssign = new System.Windows.Forms.Button();
            this.Btn_DeleteAssign = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Lbl_AssignTrimester = new System.Windows.Forms.Label();
            this.Btn_AddAssign = new System.Windows.Forms.Button();
            this.Lbl_AssignDueDate = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_AssignName = new System.Windows.Forms.Label();
            this.Tbx_AssignName = new System.Windows.Forms.TextBox();
            this.Lbl_AssignIdNum = new System.Windows.Forms.Label();
            this.Tbx_AssignIdNum = new System.Windows.Forms.TextBox();
            this.Lbl_AddNewAssign = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_AssignmentTitle
            // 
            this.Lbl_AssignmentTitle.AutoSize = true;
            this.Lbl_AssignmentTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AssignmentTitle.Location = new System.Drawing.Point(282, 21);
            this.Lbl_AssignmentTitle.Name = "Lbl_AssignmentTitle";
            this.Lbl_AssignmentTitle.Size = new System.Drawing.Size(351, 45);
            this.Lbl_AssignmentTitle.TabIndex = 0;
            this.Lbl_AssignmentTitle.Text = "Assignment Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Lbl_AssignmentTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 82);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_ModuleList
            // 
            this.Lbl_ModuleList.AutoSize = true;
            this.Lbl_ModuleList.Location = new System.Drawing.Point(7, 13);
            this.Lbl_ModuleList.Name = "Lbl_ModuleList";
            this.Lbl_ModuleList.Size = new System.Drawing.Size(104, 25);
            this.Lbl_ModuleList.TabIndex = 5;
            this.Lbl_ModuleList.Text = "Module List";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Lbl_Info1);
            this.panel3.Controls.Add(this.Lbl_DisplayIdNum);
            this.panel3.Controls.Add(this.Lbx_ModuleList);
            this.panel3.Controls.Add(this.Tbx_ModuleIdNum);
            this.panel3.Controls.Add(this.Lbl_ModuleList);
            this.panel3.Controls.Add(this.Btn_ExitAssignView);
            this.panel3.Controls.Add(this.Lbl_AssignMainTitle);
            this.panel3.Controls.Add(this.Btn_EditAssign);
            this.panel3.Controls.Add(this.Btn_DeleteAssign);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 599);
            this.panel3.TabIndex = 3;
            // 
            // Lbl_Info1
            // 
            this.Lbl_Info1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Info1.AutoSize = true;
            this.Lbl_Info1.Location = new System.Drawing.Point(410, 64);
            this.Lbl_Info1.Name = "Lbl_Info1";
            this.Lbl_Info1.Size = new System.Drawing.Size(128, 100);
            this.Lbl_Info1.TabIndex = 24;
            this.Lbl_Info1.Text = "Click a module\r\nto display the\r\nassignments\r\nbelow..";
            // 
            // Lbl_DisplayIdNum
            // 
            this.Lbl_DisplayIdNum.AutoSize = true;
            this.Lbl_DisplayIdNum.Location = new System.Drawing.Point(12, 222);
            this.Lbl_DisplayIdNum.Name = "Lbl_DisplayIdNum";
            this.Lbl_DisplayIdNum.Size = new System.Drawing.Size(161, 25);
            this.Lbl_DisplayIdNum.TabIndex = 23;
            this.Lbl_DisplayIdNum.Text = "Module Id number";
            // 
            // Lbx_ModuleList
            // 
            this.Lbx_ModuleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_ModuleList.FormattingEnabled = true;
            this.Lbx_ModuleList.ItemHeight = 25;
            this.Lbx_ModuleList.Location = new System.Drawing.Point(7, 41);
            this.Lbx_ModuleList.Name = "Lbx_ModuleList";
            this.Lbx_ModuleList.Size = new System.Drawing.Size(364, 154);
            this.Lbx_ModuleList.TabIndex = 1;
            // 
            // Tbx_ModuleIdNum
            // 
            this.Tbx_ModuleIdNum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Tbx_ModuleIdNum.Location = new System.Drawing.Point(207, 219);
            this.Tbx_ModuleIdNum.Name = "Tbx_ModuleIdNum";
            this.Tbx_ModuleIdNum.ReadOnly = true;
            this.Tbx_ModuleIdNum.Size = new System.Drawing.Size(99, 31);
            this.Tbx_ModuleIdNum.TabIndex = 13;
            // 
            // Btn_ExitAssignView
            // 
            this.Btn_ExitAssignView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ExitAssignView.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_ExitAssignView.Location = new System.Drawing.Point(426, 519);
            this.Btn_ExitAssignView.Name = "Btn_ExitAssignView";
            this.Btn_ExitAssignView.Size = new System.Drawing.Size(112, 63);
            this.Btn_ExitAssignView.TabIndex = 5;
            this.Btn_ExitAssignView.Text = "Close";
            this.Btn_ExitAssignView.UseVisualStyleBackColor = false;
            this.Btn_ExitAssignView.Click += new System.EventHandler(this.Btn_ExitAssignView_Click);
            // 
            // Lbl_AssignMainTitle
            // 
            this.Lbl_AssignMainTitle.AutoSize = true;
            this.Lbl_AssignMainTitle.Location = new System.Drawing.Point(7, 261);
            this.Lbl_AssignMainTitle.Name = "Lbl_AssignMainTitle";
            this.Lbl_AssignMainTitle.Size = new System.Drawing.Size(118, 25);
            this.Lbl_AssignMainTitle.TabIndex = 15;
            this.Lbl_AssignMainTitle.Text = "Assignments:";
            // 
            // Btn_EditAssign
            // 
            this.Btn_EditAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_EditAssign.Location = new System.Drawing.Point(36, 519);
            this.Btn_EditAssign.Name = "Btn_EditAssign";
            this.Btn_EditAssign.Size = new System.Drawing.Size(112, 63);
            this.Btn_EditAssign.TabIndex = 4;
            this.Btn_EditAssign.Text = "Edit";
            this.Btn_EditAssign.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteAssign
            // 
            this.Btn_DeleteAssign.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_DeleteAssign.Location = new System.Drawing.Point(239, 519);
            this.Btn_DeleteAssign.Name = "Btn_DeleteAssign";
            this.Btn_DeleteAssign.Size = new System.Drawing.Size(112, 63);
            this.Btn_DeleteAssign.TabIndex = 3;
            this.Btn_DeleteAssign.Text = "Delete";
            this.Btn_DeleteAssign.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(555, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.Lbl_AssignTrimester);
            this.panel2.Controls.Add(this.Btn_AddAssign);
            this.panel2.Controls.Add(this.Lbl_AssignDueDate);
            this.panel2.Controls.Add(this.DateTimePicker2);
            this.panel2.Controls.Add(this.Lbl_AssignName);
            this.panel2.Controls.Add(this.Tbx_AssignName);
            this.panel2.Controls.Add(this.Lbl_AssignIdNum);
            this.panel2.Controls.Add(this.Tbx_AssignIdNum);
            this.panel2.Controls.Add(this.Lbl_AddNewAssign);
            this.panel2.Location = new System.Drawing.Point(576, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 599);
            this.panel2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 329);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 31);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_AssignTrimester
            // 
            this.Lbl_AssignTrimester.AutoSize = true;
            this.Lbl_AssignTrimester.Location = new System.Drawing.Point(14, 295);
            this.Lbl_AssignTrimester.Name = "Lbl_AssignTrimester";
            this.Lbl_AssignTrimester.Size = new System.Drawing.Size(83, 25);
            this.Lbl_AssignTrimester.TabIndex = 11;
            this.Lbl_AssignTrimester.Text = "Trimester";
            // 
            // Btn_AddAssign
            // 
            this.Btn_AddAssign.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_AddAssign.Location = new System.Drawing.Point(64, 491);
            this.Btn_AddAssign.Name = "Btn_AddAssign";
            this.Btn_AddAssign.Size = new System.Drawing.Size(144, 73);
            this.Btn_AddAssign.TabIndex = 9;
            this.Btn_AddAssign.Text = "Add";
            this.Btn_AddAssign.UseVisualStyleBackColor = false;
            // 
            // Lbl_AssignDueDate
            // 
            this.Lbl_AssignDueDate.AutoSize = true;
            this.Lbl_AssignDueDate.Location = new System.Drawing.Point(14, 380);
            this.Lbl_AssignDueDate.Name = "Lbl_AssignDueDate";
            this.Lbl_AssignDueDate.Size = new System.Drawing.Size(181, 25);
            this.Lbl_AssignDueDate.TabIndex = 9;
            this.Lbl_AssignDueDate.Text = "Assignment due date";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(14, 419);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(245, 31);
            this.DateTimePicker2.TabIndex = 8;
            this.DateTimePicker2.Value = new System.DateTime(2022, 6, 21, 11, 31, 46, 0);
            // 
            // Lbl_AssignName
            // 
            this.Lbl_AssignName.AutoSize = true;
            this.Lbl_AssignName.Location = new System.Drawing.Point(13, 182);
            this.Lbl_AssignName.Name = "Lbl_AssignName";
            this.Lbl_AssignName.Size = new System.Drawing.Size(155, 25);
            this.Lbl_AssignName.TabIndex = 7;
            this.Lbl_AssignName.Text = "Assignment name";
            // 
            // Tbx_AssignName
            // 
            this.Tbx_AssignName.Location = new System.Drawing.Point(14, 219);
            this.Tbx_AssignName.Multiline = true;
            this.Tbx_AssignName.Name = "Tbx_AssignName";
            this.Tbx_AssignName.PlaceholderText = "Name ";
            this.Tbx_AssignName.Size = new System.Drawing.Size(245, 53);
            this.Tbx_AssignName.TabIndex = 6;
            // 
            // Lbl_AssignIdNum
            // 
            this.Lbl_AssignIdNum.AutoSize = true;
            this.Lbl_AssignIdNum.Location = new System.Drawing.Point(14, 76);
            this.Lbl_AssignIdNum.Name = "Lbl_AssignIdNum";
            this.Lbl_AssignIdNum.Size = new System.Drawing.Size(161, 50);
            this.Lbl_AssignIdNum.TabIndex = 5;
            this.Lbl_AssignIdNum.Text = "Assign Id Number \r\n(auto generated)";
            // 
            // Tbx_AssignIdNum
            // 
            this.Tbx_AssignIdNum.Location = new System.Drawing.Point(13, 133);
            this.Tbx_AssignIdNum.Name = "Tbx_AssignIdNum";
            this.Tbx_AssignIdNum.PlaceholderText = "Id number";
            this.Tbx_AssignIdNum.ReadOnly = true;
            this.Tbx_AssignIdNum.Size = new System.Drawing.Size(246, 31);
            this.Tbx_AssignIdNum.TabIndex = 14;
            // 
            // Lbl_AddNewAssign
            // 
            this.Lbl_AddNewAssign.AutoSize = true;
            this.Lbl_AddNewAssign.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AddNewAssign.Location = new System.Drawing.Point(17, 23);
            this.Lbl_AddNewAssign.Name = "Lbl_AddNewAssign";
            this.Lbl_AddNewAssign.Size = new System.Drawing.Size(231, 30);
            this.Lbl_AddNewAssign.TabIndex = 0;
            this.Lbl_AddNewAssign.Text = "Add a new assignment";
            // 
            // AssignmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AssignmentView";
            this.Text = "AssignmentView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AssignmentTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_ModuleList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_AddAssign;
        private System.Windows.Forms.Label Lbl_AssignDueDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Label Lbl_AssignName;
        private System.Windows.Forms.TextBox Tbx_AssignName;
        private System.Windows.Forms.Label Lbl_AssignIdNum;
        private System.Windows.Forms.TextBox Tbx_AssignIdNum;
        private System.Windows.Forms.Label Lbl_AddNewAssign;
        private System.Windows.Forms.Label Lbl_AssignMainTitle;
        private System.Windows.Forms.Button Btn_EditAssign;
        private System.Windows.Forms.Button Btn_DeleteAssign;
        private System.Windows.Forms.Button Btn_ExitAssignView;
        private System.Windows.Forms.TextBox Tbx_ModuleIdNum;
        private System.Windows.Forms.Label Lbl_AssignTrimester;
        private System.Windows.Forms.ListBox Lbx_ModuleList;
        private System.Windows.Forms.Label Lbl_Info1;
        private System.Windows.Forms.Label Lbl_DisplayIdNum;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}