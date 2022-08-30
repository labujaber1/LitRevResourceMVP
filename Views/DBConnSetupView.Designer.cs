
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
            this.Lbl_DBConnSetupTitle = new System.Windows.Forms.Label();
            this.Btn_AddToList = new System.Windows.Forms.Button();
            this.Tbx_Password = new System.Windows.Forms.TextBox();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Tbx_UserName = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Btn_DeleteList = new System.Windows.Forms.Button();
            this.Btn_EditList = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_ConnTest = new System.Windows.Forms.Button();
            this.Tbx_SqlName = new System.Windows.Forms.TextBox();
            this.Lbl_SqlName = new System.Windows.Forms.Label();
            this.Lbl_ConnectionString = new System.Windows.Forms.Label();
            this.Lbl_Provider = new System.Windows.Forms.Label();
            this.Tbx_Provider = new System.Windows.Forms.TextBox();
            this.Tbx_DataSource = new System.Windows.Forms.TextBox();
            this.Tbx_InitCat = new System.Windows.Forms.TextBox();
            this.Tbx_IntegSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_CloseDBConnSetup
            // 
            this.Btn_CloseDBConnSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CloseDBConnSetup.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_CloseDBConnSetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_CloseDBConnSetup.Location = new System.Drawing.Point(600, 24);
            this.Btn_CloseDBConnSetup.Name = "Btn_CloseDBConnSetup";
            this.Btn_CloseDBConnSetup.Size = new System.Drawing.Size(168, 51);
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
            this.panel1.Size = new System.Drawing.Size(804, 68);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_DBConnSetupTitle
            // 
            this.Lbl_DBConnSetupTitle.AutoSize = true;
            this.Lbl_DBConnSetupTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DBConnSetupTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_DBConnSetupTitle.Location = new System.Drawing.Point(187, 9);
            this.Lbl_DBConnSetupTitle.Name = "Lbl_DBConnSetupTitle";
            this.Lbl_DBConnSetupTitle.Size = new System.Drawing.Size(491, 45);
            this.Lbl_DBConnSetupTitle.TabIndex = 0;
            this.Lbl_DBConnSetupTitle.Text = "Database Connection setup page";
            // 
            // Btn_AddToList
            // 
            this.Btn_AddToList.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_AddToList.Location = new System.Drawing.Point(578, 132);
            this.Btn_AddToList.Name = "Btn_AddToList";
            this.Btn_AddToList.Size = new System.Drawing.Size(185, 51);
            this.Btn_AddToList.TabIndex = 2;
            this.Btn_AddToList.Text = "Add (to app config)";
            this.Btn_AddToList.UseVisualStyleBackColor = false;
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tbx_Password.Location = new System.Drawing.Point(291, 152);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PlaceholderText = "Leave blank if not required";
            this.Tbx_Password.Size = new System.Drawing.Size(272, 31);
            this.Tbx_Password.TabIndex = 3;
            this.Tbx_Password.Visible = false;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(18, 124);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(96, 25);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "User name";
            this.Lbl_UserName.Visible = false;
            // 
            // Tbx_UserName
            // 
            this.Tbx_UserName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tbx_UserName.Location = new System.Drawing.Point(18, 152);
            this.Tbx_UserName.Name = "Tbx_UserName";
            this.Tbx_UserName.PlaceholderText = "Leave blank if not required";
            this.Tbx_UserName.Size = new System.Drawing.Size(258, 31);
            this.Tbx_UserName.TabIndex = 2;
            this.Tbx_UserName.Visible = false;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(291, 124);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(87, 25);
            this.Lbl_Password.TabIndex = 1;
            this.Lbl_Password.Text = "Password";
            this.Lbl_Password.Visible = false;
            // 
            // Btn_DeleteList
            // 
            this.Btn_DeleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_DeleteList.BackColor = System.Drawing.Color.Red;
            this.Btn_DeleteList.Location = new System.Drawing.Point(30, 24);
            this.Btn_DeleteList.Name = "Btn_DeleteList";
            this.Btn_DeleteList.Size = new System.Drawing.Size(112, 51);
            this.Btn_DeleteList.TabIndex = 4;
            this.Btn_DeleteList.Text = "Delete row";
            this.Btn_DeleteList.UseVisualStyleBackColor = false;
            // 
            // Btn_EditList
            // 
            this.Btn_EditList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_EditList.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_EditList.Location = new System.Drawing.Point(332, 24);
            this.Btn_EditList.Name = "Btn_EditList";
            this.Btn_EditList.Size = new System.Drawing.Size(231, 51);
            this.Btn_EditList.TabIndex = 3;
            this.Btn_EditList.Text = "Save table (to app.config)";
            this.Btn_EditList.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Controls.Add(this.Btn_CloseDBConnSetup);
            this.panel4.Controls.Add(this.Btn_ConnTest);
            this.panel4.Controls.Add(this.Btn_EditList);
            this.panel4.Controls.Add(this.Btn_DeleteList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 581);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 100);
            this.panel4.TabIndex = 4;
            // 
            // Btn_ConnTest
            // 
            this.Btn_ConnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_ConnTest.BackColor = System.Drawing.Color.Orange;
            this.Btn_ConnTest.Location = new System.Drawing.Point(148, 24);
            this.Btn_ConnTest.Name = "Btn_ConnTest";
            this.Btn_ConnTest.Size = new System.Drawing.Size(178, 51);
            this.Btn_ConnTest.TabIndex = 1;
            this.Btn_ConnTest.Text = "Test connection";
            this.Btn_ConnTest.UseVisualStyleBackColor = false;
            // 
            // Tbx_SqlName
            // 
            this.Tbx_SqlName.Location = new System.Drawing.Point(17, 53);
            this.Tbx_SqlName.Name = "Tbx_SqlName";
            this.Tbx_SqlName.Size = new System.Drawing.Size(349, 31);
            this.Tbx_SqlName.TabIndex = 0;
            // 
            // Lbl_SqlName
            // 
            this.Lbl_SqlName.AutoSize = true;
            this.Lbl_SqlName.Location = new System.Drawing.Point(17, 22);
            this.Lbl_SqlName.Name = "Lbl_SqlName";
            this.Lbl_SqlName.Size = new System.Drawing.Size(59, 25);
            this.Lbl_SqlName.TabIndex = 4;
            this.Lbl_SqlName.Text = "Name";
            // 
            // Lbl_ConnectionString
            // 
            this.Lbl_ConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ConnectionString.AutoSize = true;
            this.Lbl_ConnectionString.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ConnectionString.Location = new System.Drawing.Point(18, 33);
            this.Lbl_ConnectionString.Name = "Lbl_ConnectionString";
            this.Lbl_ConnectionString.Size = new System.Drawing.Size(631, 25);
            this.Lbl_ConnectionString.TabIndex = 5;
            this.Lbl_ConnectionString.Text = "Edit table directly and then save. SqlConnection coded in program.cs as name. ";
            // 
            // Lbl_Provider
            // 
            this.Lbl_Provider.AutoSize = true;
            this.Lbl_Provider.Location = new System.Drawing.Point(405, 22);
            this.Lbl_Provider.Name = "Lbl_Provider";
            this.Lbl_Provider.Size = new System.Drawing.Size(125, 25);
            this.Lbl_Provider.TabIndex = 8;
            this.Lbl_Provider.Text = "ProviderName";
            // 
            // Tbx_Provider
            // 
            this.Tbx_Provider.Location = new System.Drawing.Point(405, 53);
            this.Tbx_Provider.Name = "Tbx_Provider";
            this.Tbx_Provider.Size = new System.Drawing.Size(358, 31);
            this.Tbx_Provider.TabIndex = 9;
            // 
            // Tbx_DataSource
            // 
            this.Tbx_DataSource.Location = new System.Drawing.Point(76, 90);
            this.Tbx_DataSource.Name = "Tbx_DataSource";
            this.Tbx_DataSource.PlaceholderText = "Enter data source";
            this.Tbx_DataSource.Size = new System.Drawing.Size(237, 31);
            this.Tbx_DataSource.TabIndex = 10;
            // 
            // Tbx_InitCat
            // 
            this.Tbx_InitCat.Location = new System.Drawing.Point(320, 90);
            this.Tbx_InitCat.Name = "Tbx_InitCat";
            this.Tbx_InitCat.PlaceholderText = "Enter initial catalog";
            this.Tbx_InitCat.Size = new System.Drawing.Size(264, 31);
            this.Tbx_InitCat.TabIndex = 11;
            // 
            // Tbx_IntegSec
            // 
            this.Tbx_IntegSec.Location = new System.Drawing.Point(590, 91);
            this.Tbx_IntegSec.Name = "Tbx_IntegSec";
            this.Tbx_IntegSec.PlaceholderText = "Integrated security";
            this.Tbx_IntegSec.Size = new System.Drawing.Size(173, 31);
            this.Tbx_IntegSec.TabIndex = 12;
            this.Tbx_IntegSec.Text = "True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "OR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 187);
            this.dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.Tbx_Provider);
            this.groupBox1.Controls.Add(this.Tbx_SqlName);
            this.groupBox1.Controls.Add(this.Btn_AddToList);
            this.groupBox1.Controls.Add(this.Lbl_SqlName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tbx_UserName);
            this.groupBox1.Controls.Add(this.Tbx_Password);
            this.groupBox1.Controls.Add(this.Lbl_UserName);
            this.groupBox1.Controls.Add(this.Lbl_Password);
            this.groupBox1.Controls.Add(this.Lbl_Provider);
            this.groupBox1.Controls.Add(this.Tbx_IntegSec);
            this.groupBox1.Controls.Add(this.Tbx_DataSource);
            this.groupBox1.Controls.Add(this.Tbx_InitCat);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 200);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.Lbl_ConnectionString);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 283);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection string(s) in debug/app.config or .dll.config when live ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "* Connection name is readonly, to edit a new connection must be added and the old" +
    " one deleted.";
            // 
            // DBConnSetupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(804, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "DBConnSetupView";
            this.Text = "DBConnSetupView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_CloseDBConnSetup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_DBConnSetupTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_AddToList;
        private System.Windows.Forms.Button Btn_ConnTest;
        private System.Windows.Forms.Label Lbl_SqlName;
        private System.Windows.Forms.TextBox Tbx_SqlName;
        private System.Windows.Forms.Label Lbl_ConnectionString;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Tbx_UserName;
        private System.Windows.Forms.TextBox Tbx_Password;
        private System.Windows.Forms.Button Btn_DeleteList;
        private System.Windows.Forms.Button Btn_EditList;
        private System.Windows.Forms.Label Lbl_Provider;
        private System.Windows.Forms.TextBox Tbx_Provider;
        private System.Windows.Forms.TextBox Tbx_DataSource;
        private System.Windows.Forms.TextBox Tbx_InitCat;
        private System.Windows.Forms.TextBox Tbx_IntegSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}