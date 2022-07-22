
namespace LitRevResourceMVP.Views
{
    partial class DBConnSetupView
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
            this.Btn_CloseDBConnSetup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_DBConnSetupTitle = new System.Windows.Forms.Label();
            this.Btn_ConnTest = new System.Windows.Forms.Button();
            this.Btn_AddToList = new System.Windows.Forms.Button();
            this.Lbx_ConnStringFromFile = new System.Windows.Forms.ListBox();
            this.Tbx_SqlName = new System.Windows.Forms.TextBox();
            this.Tbx_DataSource = new System.Windows.Forms.TextBox();
            this.Tbx_InitCat = new System.Windows.Forms.TextBox();
            this.Tbx_IntegSec = new System.Windows.Forms.TextBox();
            this.Lbl_SqlName = new System.Windows.Forms.Label();
            this.Lbl_DataSource = new System.Windows.Forms.Label();
            this.Lbl_InitialCatalogue = new System.Windows.Forms.Label();
            this.Lbl_IntegSecurity = new System.Windows.Forms.Label();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Tbx_UserName = new System.Windows.Forms.TextBox();
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.Btn_EditList = new System.Windows.Forms.Button();
            this.Btn_DeleteList = new System.Windows.Forms.Button();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.Lbl_2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_CloseDBConnSetup
            // 
            this.Btn_CloseDBConnSetup.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_CloseDBConnSetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_CloseDBConnSetup.Location = new System.Drawing.Point(542, 14);
            this.Btn_CloseDBConnSetup.Name = "Btn_CloseDBConnSetup";
            this.Btn_CloseDBConnSetup.Size = new System.Drawing.Size(168, 72);
            this.Btn_CloseDBConnSetup.TabIndex = 0;
            this.Btn_CloseDBConnSetup.Text = "Close";
            this.Btn_CloseDBConnSetup.UseVisualStyleBackColor = false;
            this.Btn_CloseDBConnSetup.Click += new System.EventHandler(this.Btn_CloseDBConnSetup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.Lbl_DBConnSetupTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 86);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.Lbl_1);
            this.panel3.Controls.Add(this.Btn_DeleteList);
            this.panel3.Controls.Add(this.Btn_EditList);
            this.panel3.Controls.Add(this.Btn_AddToList);
            this.panel3.Location = new System.Drawing.Point(442, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 485);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Controls.Add(this.Btn_ConnTest);
            this.panel4.Controls.Add(this.Btn_CloseDBConnSetup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 583);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 98);
            this.panel4.TabIndex = 4;
            // 
            // Lbl_DBConnSetupTitle
            // 
            this.Lbl_DBConnSetupTitle.AutoSize = true;
            this.Lbl_DBConnSetupTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DBConnSetupTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_DBConnSetupTitle.Location = new System.Drawing.Point(163, 21);
            this.Lbl_DBConnSetupTitle.Name = "Lbl_DBConnSetupTitle";
            this.Lbl_DBConnSetupTitle.Size = new System.Drawing.Size(491, 45);
            this.Lbl_DBConnSetupTitle.TabIndex = 0;
            this.Lbl_DBConnSetupTitle.Text = "Database Connection setup page";
            // 
            // Btn_ConnTest
            // 
            this.Btn_ConnTest.BackColor = System.Drawing.Color.Orange;
            this.Btn_ConnTest.Location = new System.Drawing.Point(163, 14);
            this.Btn_ConnTest.Name = "Btn_ConnTest";
            this.Btn_ConnTest.Size = new System.Drawing.Size(186, 72);
            this.Btn_ConnTest.TabIndex = 1;
            this.Btn_ConnTest.Text = "Test connection";
            this.Btn_ConnTest.UseVisualStyleBackColor = false;
            // 
            // Btn_AddToList
            // 
            this.Btn_AddToList.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_AddToList.Location = new System.Drawing.Point(110, 346);
            this.Btn_AddToList.Name = "Btn_AddToList";
            this.Btn_AddToList.Size = new System.Drawing.Size(210, 72);
            this.Btn_AddToList.TabIndex = 2;
            this.Btn_AddToList.Text = "Save (to file)";
            this.Btn_AddToList.UseVisualStyleBackColor = false;
            // 
            // Lbx_ConnStringFromFile
            // 
            this.Lbx_ConnStringFromFile.BackColor = System.Drawing.Color.Yellow;
            this.Lbx_ConnStringFromFile.FormattingEnabled = true;
            this.Lbx_ConnStringFromFile.ItemHeight = 25;
            this.Lbx_ConnStringFromFile.Location = new System.Drawing.Point(43, 129);
            this.Lbx_ConnStringFromFile.Name = "Lbx_ConnStringFromFile";
            this.Lbx_ConnStringFromFile.Size = new System.Drawing.Size(771, 54);
            this.Lbx_ConnStringFromFile.TabIndex = 6;
            // 
            // Tbx_SqlName
            // 
            this.Tbx_SqlName.Location = new System.Drawing.Point(43, 223);
            this.Tbx_SqlName.Name = "Tbx_SqlName";
            this.Tbx_SqlName.Size = new System.Drawing.Size(347, 31);
            this.Tbx_SqlName.TabIndex = 0;
            // 
            // Tbx_DataSource
            // 
            this.Tbx_DataSource.Location = new System.Drawing.Point(43, 285);
            this.Tbx_DataSource.Name = "Tbx_DataSource";
            this.Tbx_DataSource.Size = new System.Drawing.Size(347, 31);
            this.Tbx_DataSource.TabIndex = 1;
            // 
            // Tbx_InitCat
            // 
            this.Tbx_InitCat.Location = new System.Drawing.Point(43, 353);
            this.Tbx_InitCat.Name = "Tbx_InitCat";
            this.Tbx_InitCat.Size = new System.Drawing.Size(347, 31);
            this.Tbx_InitCat.TabIndex = 2;
            // 
            // Tbx_IntegSec
            // 
            this.Tbx_IntegSec.Location = new System.Drawing.Point(43, 415);
            this.Tbx_IntegSec.Name = "Tbx_IntegSec";
            this.Tbx_IntegSec.Size = new System.Drawing.Size(347, 31);
            this.Tbx_IntegSec.TabIndex = 3;
            this.Tbx_IntegSec.Text = "true";
            // 
            // Lbl_SqlName
            // 
            this.Lbl_SqlName.AutoSize = true;
            this.Lbl_SqlName.Location = new System.Drawing.Point(43, 195);
            this.Lbl_SqlName.Name = "Lbl_SqlName";
            this.Lbl_SqlName.Size = new System.Drawing.Size(89, 25);
            this.Lbl_SqlName.TabIndex = 4;
            this.Lbl_SqlName.Text = "Sql Name";
            // 
            // Lbl_DataSource
            // 
            this.Lbl_DataSource.AutoSize = true;
            this.Lbl_DataSource.Location = new System.Drawing.Point(43, 257);
            this.Lbl_DataSource.Name = "Lbl_DataSource";
            this.Lbl_DataSource.Size = new System.Drawing.Size(106, 25);
            this.Lbl_DataSource.TabIndex = 5;
            this.Lbl_DataSource.Text = "Data source";
            // 
            // Lbl_InitialCatalogue
            // 
            this.Lbl_InitialCatalogue.AutoSize = true;
            this.Lbl_InitialCatalogue.Location = new System.Drawing.Point(43, 324);
            this.Lbl_InitialCatalogue.Name = "Lbl_InitialCatalogue";
            this.Lbl_InitialCatalogue.Size = new System.Drawing.Size(215, 25);
            this.Lbl_InitialCatalogue.TabIndex = 6;
            this.Lbl_InitialCatalogue.Text = "Initial catalogue/DB name";
            // 
            // Lbl_IntegSecurity
            // 
            this.Lbl_IntegSecurity.AutoSize = true;
            this.Lbl_IntegSecurity.Location = new System.Drawing.Point(43, 387);
            this.Lbl_IntegSecurity.Name = "Lbl_IntegSecurity";
            this.Lbl_IntegSecurity.Size = new System.Drawing.Size(238, 25);
            this.Lbl_IntegSecurity.TabIndex = 7;
            this.Lbl_IntegSecurity.Text = "Integrated security true/false";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(45, 451);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(96, 25);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "User name";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(45, 518);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(87, 25);
            this.Lbl_Password.TabIndex = 1;
            this.Lbl_Password.Text = "Password";
            // 
            // Tbx_UserName
            // 
            this.Tbx_UserName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tbx_UserName.Location = new System.Drawing.Point(45, 479);
            this.Tbx_UserName.Name = "Tbx_UserName";
            this.Tbx_UserName.PlaceholderText = "Leave blank if not required";
            this.Tbx_UserName.Size = new System.Drawing.Size(345, 31);
            this.Tbx_UserName.TabIndex = 2;
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tbx_Password.Location = new System.Drawing.Point(45, 546);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PlaceholderText = "Leave blank if not required";
            this.Tbx_Password.Size = new System.Drawing.Size(345, 31);
            this.Tbx_Password.TabIndex = 3;
            // 
            // Btn_EditList
            // 
            this.Btn_EditList.BackColor = System.Drawing.Color.Orange;
            this.Btn_EditList.Location = new System.Drawing.Point(110, 256);
            this.Btn_EditList.Name = "Btn_EditList";
            this.Btn_EditList.Size = new System.Drawing.Size(210, 70);
            this.Btn_EditList.TabIndex = 3;
            this.Btn_EditList.Text = "Edit";
            this.Btn_EditList.UseVisualStyleBackColor = false;
            // 
            // Btn_DeleteList
            // 
            this.Btn_DeleteList.BackColor = System.Drawing.Color.Red;
            this.Btn_DeleteList.Location = new System.Drawing.Point(110, 165);
            this.Btn_DeleteList.Name = "Btn_DeleteList";
            this.Btn_DeleteList.Size = new System.Drawing.Size(210, 68);
            this.Btn_DeleteList.TabIndex = 4;
            this.Btn_DeleteList.Text = "Delete";
            this.Btn_DeleteList.UseVisualStyleBackColor = false;
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Location = new System.Drawing.Point(111, 120);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(176, 25);
            this.Lbl_1.TabIndex = 5;
            this.Lbl_1.Text = "* Select from list to...";
            // 
            // Lbl_2
            // 
            this.Lbl_2.AutoSize = true;
            this.Lbl_2.Location = new System.Drawing.Point(43, 101);
            this.Lbl_2.Name = "Lbl_2";
            this.Lbl_2.Size = new System.Drawing.Size(199, 25);
            this.Lbl_2.TabIndex = 8;
            this.Lbl_2.Text = "Connection string in file";
            // 
            // DBConnSetupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(849, 681);
            this.Controls.Add(this.Lbl_2);
            this.Controls.Add(this.Lbl_IntegSecurity);
            this.Controls.Add(this.Tbx_Password);
            this.Controls.Add(this.Lbx_ConnStringFromFile);
            this.Controls.Add(this.Tbx_UserName);
            this.Controls.Add(this.Lbl_InitialCatalogue);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Lbl_DataSource);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Lbl_SqlName);
            this.Controls.Add(this.Tbx_IntegSec);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Tbx_InitCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tbx_DataSource);
            this.Controls.Add(this.Tbx_SqlName);
            this.Name = "DBConnSetupView";
            this.Text = "DBConnSetupView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CloseDBConnSetup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_DBConnSetupTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_AddToList;
        private System.Windows.Forms.Button Btn_ConnTest;
        private System.Windows.Forms.ListBox Lbx_ConnStringFromFile;
        private System.Windows.Forms.Label Lbl_SqlName;
        private System.Windows.Forms.TextBox Tbx_IntegSec;
        private System.Windows.Forms.TextBox Tbx_InitCat;
        private System.Windows.Forms.TextBox Tbx_DataSource;
        private System.Windows.Forms.TextBox Tbx_SqlName;
        private System.Windows.Forms.Label Lbl_DataSource;
        private System.Windows.Forms.Label Lbl_InitialCatalogue;
        private System.Windows.Forms.Label Lbl_IntegSecurity;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Tbx_UserName;
        private System.Windows.Forms.TextBox Tbx_Password;
        private System.Windows.Forms.Button Btn_DeleteList;
        private System.Windows.Forms.Button Btn_EditList;
        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.Label Lbl_2;
    }
}