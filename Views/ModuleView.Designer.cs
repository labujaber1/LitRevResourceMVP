
namespace LitRevResourceMVP.Views
{
    partial class ModuleView
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
            this.Lbl_ModuleTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddModule = new System.Windows.Forms.Button();
            this.Tbx_AddModule = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_EditMod = new System.Windows.Forms.Button();
            this.Btn_DeleteMod = new System.Windows.Forms.Button();
            this.Tbx_ModIdNum = new System.Windows.Forms.TextBox();
            this.Lbl_ModIdNum = new System.Windows.Forms.Label();
            this.Lbl_ModName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tbx_DateYear = new System.Windows.Forms.TextBox();
            this.Lbl_DateYear = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Btn_CloseMod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ModuleTitle
            // 
            this.Lbl_ModuleTitle.AutoSize = true;
            this.Lbl_ModuleTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ModuleTitle.Location = new System.Drawing.Point(317, 48);
            this.Lbl_ModuleTitle.Name = "Lbl_ModuleTitle";
            this.Lbl_ModuleTitle.Size = new System.Drawing.Size(293, 45);
            this.Lbl_ModuleTitle.TabIndex = 0;
            this.Lbl_ModuleTitle.Text = "Module Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_ModuleTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 150);
            this.panel1.TabIndex = 1;
            // 
            // Btn_AddModule
            // 
            this.Btn_AddModule.Location = new System.Drawing.Point(30, 428);
            this.Btn_AddModule.Name = "Btn_AddModule";
            this.Btn_AddModule.Size = new System.Drawing.Size(169, 64);
            this.Btn_AddModule.TabIndex = 5;
            this.Btn_AddModule.Text = "Add new/save module";
            this.Btn_AddModule.UseVisualStyleBackColor = true;
            // 
            // Tbx_AddModule
            // 
            this.Tbx_AddModule.Location = new System.Drawing.Point(30, 256);
            this.Tbx_AddModule.Multiline = true;
            this.Tbx_AddModule.Name = "Tbx_AddModule";
            this.Tbx_AddModule.PlaceholderText = "Add new module";
            this.Tbx_AddModule.Size = new System.Drawing.Size(250, 46);
            this.Tbx_AddModule.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 150);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Btn_EditMod
            // 
            this.Btn_EditMod.Location = new System.Drawing.Point(16, 29);
            this.Btn_EditMod.Name = "Btn_EditMod";
            this.Btn_EditMod.Size = new System.Drawing.Size(112, 34);
            this.Btn_EditMod.TabIndex = 7;
            this.Btn_EditMod.Text = "Edit";
            this.Btn_EditMod.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteMod
            // 
            this.Btn_DeleteMod.Location = new System.Drawing.Point(168, 29);
            this.Btn_DeleteMod.Name = "Btn_DeleteMod";
            this.Btn_DeleteMod.Size = new System.Drawing.Size(112, 34);
            this.Btn_DeleteMod.TabIndex = 8;
            this.Btn_DeleteMod.Text = "Delete";
            this.Btn_DeleteMod.UseVisualStyleBackColor = true;
            // 
            // Tbx_ModIdNum
            // 
            this.Tbx_ModIdNum.Location = new System.Drawing.Point(30, 171);
            this.Tbx_ModIdNum.Name = "Tbx_ModIdNum";
            this.Tbx_ModIdNum.PlaceholderText = "Id Number";
            this.Tbx_ModIdNum.ReadOnly = true;
            this.Tbx_ModIdNum.Size = new System.Drawing.Size(189, 31);
            this.Tbx_ModIdNum.TabIndex = 9;
            // 
            // Lbl_ModIdNum
            // 
            this.Lbl_ModIdNum.AutoSize = true;
            this.Lbl_ModIdNum.Location = new System.Drawing.Point(34, 136);
            this.Lbl_ModIdNum.Name = "Lbl_ModIdNum";
            this.Lbl_ModIdNum.Size = new System.Drawing.Size(94, 25);
            this.Lbl_ModIdNum.TabIndex = 10;
            this.Lbl_ModIdNum.Text = "Module Id";
            // 
            // Lbl_ModName
            // 
            this.Lbl_ModName.AutoSize = true;
            this.Lbl_ModName.Location = new System.Drawing.Point(30, 228);
            this.Lbl_ModName.Name = "Lbl_ModName";
            this.Lbl_ModName.Size = new System.Drawing.Size(122, 25);
            this.Lbl_ModName.TabIndex = 11;
            this.Lbl_ModName.Text = "Module name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tbx_DateYear);
            this.panel2.Controls.Add(this.Lbl_DateYear);
            this.panel2.Controls.Add(this.Lbl_ModIdNum);
            this.panel2.Controls.Add(this.Btn_DeleteMod);
            this.panel2.Controls.Add(this.Lbl_ModName);
            this.panel2.Controls.Add(this.Btn_EditMod);
            this.panel2.Controls.Add(this.Tbx_AddModule);
            this.panel2.Controls.Add(this.Btn_AddModule);
            this.panel2.Controls.Add(this.Tbx_ModIdNum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(545, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 531);
            this.panel2.TabIndex = 12;
            // 
            // Tbx_DateYear
            // 
            this.Tbx_DateYear.Location = new System.Drawing.Point(30, 362);
            this.Tbx_DateYear.Name = "Tbx_DateYear";
            this.Tbx_DateYear.PlaceholderText = "Enter year (yyyy)";
            this.Tbx_DateYear.Size = new System.Drawing.Size(250, 31);
            this.Tbx_DateYear.TabIndex = 15;
            // 
            // Lbl_DateYear
            // 
            this.Lbl_DateYear.AutoSize = true;
            this.Lbl_DateYear.Location = new System.Drawing.Point(30, 324);
            this.Lbl_DateYear.Name = "Lbl_DateYear";
            this.Lbl_DateYear.Size = new System.Drawing.Size(128, 25);
            this.Lbl_DateYear.TabIndex = 14;
            this.Lbl_DateYear.Text = "Date year yyyy";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 364);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(539, 225);
            this.dataGridView3.TabIndex = 13;
            // 
            // Btn_CloseMod
            // 
            this.Btn_CloseMod.Location = new System.Drawing.Point(72, 623);
            this.Btn_CloseMod.Name = "Btn_CloseMod";
            this.Btn_CloseMod.Size = new System.Drawing.Size(112, 46);
            this.Btn_CloseMod.TabIndex = 14;
            this.Btn_CloseMod.Text = "Close";
            this.Btn_CloseMod.UseVisualStyleBackColor = true;
            this.Btn_CloseMod.Click += new System.EventHandler(this.Btn_CloseMod_Click);
            // 
            // ModuleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 681);
            this.Controls.Add(this.Btn_CloseMod);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ModuleView";
            this.Text = "ModuleView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ModuleTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddModule;
        private System.Windows.Forms.TextBox Tbx_AddModule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_EditMod;
        private System.Windows.Forms.Button Btn_DeleteMod;
        private System.Windows.Forms.TextBox Tbx_ModIdNum;
        private System.Windows.Forms.Label Lbl_ModIdNum;
        private System.Windows.Forms.Label Lbl_ModName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox Tbx_DateYear;
        private System.Windows.Forms.Label Lbl_DateYear;
        private System.Windows.Forms.Button Btn_CloseMod;
    }
}