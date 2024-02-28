
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
            Btn_CloseDBConnSetup = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            Lbl_DBConnSetupTitle = new System.Windows.Forms.Label();
            Btn_AddToList = new System.Windows.Forms.Button();
            Tbx_Password = new System.Windows.Forms.TextBox();
            Lbl_UserName = new System.Windows.Forms.Label();
            Tbx_UserName = new System.Windows.Forms.TextBox();
            Lbl_Password = new System.Windows.Forms.Label();
            Btn_DeleteList = new System.Windows.Forms.Button();
            Btn_EditList = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            Btn_ConnTest = new System.Windows.Forms.Button();
            Tbx_SqlName = new System.Windows.Forms.TextBox();
            Lbl_SqlName = new System.Windows.Forms.Label();
            Lbl_ConnectionString = new System.Windows.Forms.Label();
            Lbl_Provider = new System.Windows.Forms.Label();
            Tbx_Provider = new System.Windows.Forms.TextBox();
            Tbx_DataSource = new System.Windows.Forms.TextBox();
            Tbx_InitCat = new System.Windows.Forms.TextBox();
            Tbx_IntegSec = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_CloseDBConnSetup
            // 
            Btn_CloseDBConnSetup.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Btn_CloseDBConnSetup.BackColor = System.Drawing.Color.OrangeRed;
            Btn_CloseDBConnSetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Btn_CloseDBConnSetup.Location = new System.Drawing.Point(480, 10);
            Btn_CloseDBConnSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_CloseDBConnSetup.Name = "Btn_CloseDBConnSetup";
            Btn_CloseDBConnSetup.Size = new System.Drawing.Size(134, 58);
            Btn_CloseDBConnSetup.TabIndex = 0;
            Btn_CloseDBConnSetup.Text = "Close";
            Btn_CloseDBConnSetup.UseVisualStyleBackColor = false;
            Btn_CloseDBConnSetup.Click += Btn_CloseDBConnSetup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumPurple;
            panel1.Controls.Add(Lbl_DBConnSetupTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(643, 54);
            panel1.TabIndex = 1;
            // 
            // Lbl_DBConnSetupTitle
            // 
            Lbl_DBConnSetupTitle.AutoSize = true;
            Lbl_DBConnSetupTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl_DBConnSetupTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Lbl_DBConnSetupTitle.Location = new System.Drawing.Point(150, 7);
            Lbl_DBConnSetupTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_DBConnSetupTitle.Name = "Lbl_DBConnSetupTitle";
            Lbl_DBConnSetupTitle.Size = new System.Drawing.Size(410, 37);
            Lbl_DBConnSetupTitle.TabIndex = 0;
            Lbl_DBConnSetupTitle.Text = "Database Connection setup page";
            // 
            // Btn_AddToList
            // 
            Btn_AddToList.BackColor = System.Drawing.Color.PaleGreen;
            Btn_AddToList.Location = new System.Drawing.Point(462, 103);
            Btn_AddToList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_AddToList.Name = "Btn_AddToList";
            Btn_AddToList.Size = new System.Drawing.Size(148, 53);
            Btn_AddToList.TabIndex = 2;
            Btn_AddToList.Text = "Add (to app config)";
            Btn_AddToList.UseVisualStyleBackColor = false;
            // 
            // Tbx_Password
            // 
            Tbx_Password.BackColor = System.Drawing.SystemColors.MenuBar;
            Tbx_Password.Location = new System.Drawing.Point(233, 122);
            Tbx_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_Password.Name = "Tbx_Password";
            Tbx_Password.PlaceholderText = "Leave blank if not required";
            Tbx_Password.Size = new System.Drawing.Size(218, 27);
            Tbx_Password.TabIndex = 3;
            Tbx_Password.Visible = false;
            // 
            // Lbl_UserName
            // 
            Lbl_UserName.AutoSize = true;
            Lbl_UserName.Location = new System.Drawing.Point(14, 99);
            Lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_UserName.Name = "Lbl_UserName";
            Lbl_UserName.Size = new System.Drawing.Size(79, 20);
            Lbl_UserName.TabIndex = 0;
            Lbl_UserName.Text = "User name";
            Lbl_UserName.Visible = false;
            // 
            // Tbx_UserName
            // 
            Tbx_UserName.BackColor = System.Drawing.SystemColors.MenuBar;
            Tbx_UserName.Location = new System.Drawing.Point(14, 122);
            Tbx_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_UserName.Name = "Tbx_UserName";
            Tbx_UserName.PlaceholderText = "Leave blank if not required";
            Tbx_UserName.Size = new System.Drawing.Size(207, 27);
            Tbx_UserName.TabIndex = 2;
            Tbx_UserName.Visible = false;
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Location = new System.Drawing.Point(233, 99);
            Lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new System.Drawing.Size(70, 20);
            Lbl_Password.TabIndex = 1;
            Lbl_Password.Text = "Password";
            Lbl_Password.Visible = false;
            // 
            // Btn_DeleteList
            // 
            Btn_DeleteList.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Btn_DeleteList.BackColor = System.Drawing.Color.OrangeRed;
            Btn_DeleteList.Location = new System.Drawing.Point(24, 10);
            Btn_DeleteList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_DeleteList.Name = "Btn_DeleteList";
            Btn_DeleteList.Size = new System.Drawing.Size(90, 58);
            Btn_DeleteList.TabIndex = 4;
            Btn_DeleteList.Text = "Delete row";
            Btn_DeleteList.UseVisualStyleBackColor = false;
            // 
            // Btn_EditList
            // 
            Btn_EditList.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Btn_EditList.BackColor = System.Drawing.Color.PaleGreen;
            Btn_EditList.Location = new System.Drawing.Point(266, 10);
            Btn_EditList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_EditList.Name = "Btn_EditList";
            Btn_EditList.Size = new System.Drawing.Size(185, 58);
            Btn_EditList.TabIndex = 3;
            Btn_EditList.Text = "Save table (to app.config)";
            Btn_EditList.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.MediumPurple;
            panel4.Controls.Add(Btn_CloseDBConnSetup);
            panel4.Controls.Add(Btn_ConnTest);
            panel4.Controls.Add(Btn_EditList);
            panel4.Controls.Add(Btn_DeleteList);
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(0, 465);
            panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(643, 80);
            panel4.TabIndex = 4;
            // 
            // Btn_ConnTest
            // 
            Btn_ConnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Btn_ConnTest.BackColor = System.Drawing.Color.SandyBrown;
            Btn_ConnTest.Location = new System.Drawing.Point(118, 10);
            Btn_ConnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_ConnTest.Name = "Btn_ConnTest";
            Btn_ConnTest.Size = new System.Drawing.Size(142, 58);
            Btn_ConnTest.TabIndex = 1;
            Btn_ConnTest.Text = "Test connection";
            Btn_ConnTest.UseVisualStyleBackColor = false;
            // 
            // Tbx_SqlName
            // 
            Tbx_SqlName.Location = new System.Drawing.Point(14, 42);
            Tbx_SqlName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_SqlName.Name = "Tbx_SqlName";
            Tbx_SqlName.Size = new System.Drawing.Size(280, 27);
            Tbx_SqlName.TabIndex = 0;
            // 
            // Lbl_SqlName
            // 
            Lbl_SqlName.AutoSize = true;
            Lbl_SqlName.Location = new System.Drawing.Point(14, 18);
            Lbl_SqlName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_SqlName.Name = "Lbl_SqlName";
            Lbl_SqlName.Size = new System.Drawing.Size(49, 20);
            Lbl_SqlName.TabIndex = 4;
            Lbl_SqlName.Text = "Name";
            // 
            // Lbl_ConnectionString
            // 
            Lbl_ConnectionString.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Lbl_ConnectionString.AutoSize = true;
            Lbl_ConnectionString.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Lbl_ConnectionString.Location = new System.Drawing.Point(14, 26);
            Lbl_ConnectionString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_ConnectionString.Name = "Lbl_ConnectionString";
            Lbl_ConnectionString.Size = new System.Drawing.Size(509, 20);
            Lbl_ConnectionString.TabIndex = 5;
            Lbl_ConnectionString.Text = "Edit table directly and then save. SqlConnection coded in program.cs as name. ";
            // 
            // Lbl_Provider
            // 
            Lbl_Provider.AutoSize = true;
            Lbl_Provider.Location = new System.Drawing.Point(324, 18);
            Lbl_Provider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_Provider.Name = "Lbl_Provider";
            Lbl_Provider.Size = new System.Drawing.Size(104, 20);
            Lbl_Provider.TabIndex = 8;
            Lbl_Provider.Text = "ProviderName";
            // 
            // Tbx_Provider
            // 
            Tbx_Provider.Location = new System.Drawing.Point(324, 42);
            Tbx_Provider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_Provider.Name = "Tbx_Provider";
            Tbx_Provider.Size = new System.Drawing.Size(287, 27);
            Tbx_Provider.TabIndex = 9;
            // 
            // Tbx_DataSource
            // 
            Tbx_DataSource.Location = new System.Drawing.Point(61, 72);
            Tbx_DataSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_DataSource.Name = "Tbx_DataSource";
            Tbx_DataSource.PlaceholderText = "Enter data source";
            Tbx_DataSource.Size = new System.Drawing.Size(190, 27);
            Tbx_DataSource.TabIndex = 10;
            // 
            // Tbx_InitCat
            // 
            Tbx_InitCat.Location = new System.Drawing.Point(256, 72);
            Tbx_InitCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_InitCat.Name = "Tbx_InitCat";
            Tbx_InitCat.PlaceholderText = "Enter initial catalog";
            Tbx_InitCat.Size = new System.Drawing.Size(212, 27);
            Tbx_InitCat.TabIndex = 11;
            // 
            // Tbx_IntegSec
            // 
            Tbx_IntegSec.Location = new System.Drawing.Point(472, 73);
            Tbx_IntegSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Tbx_IntegSec.Name = "Tbx_IntegSec";
            Tbx_IntegSec.PlaceholderText = "Integrated security";
            Tbx_IntegSec.Size = new System.Drawing.Size(139, 27);
            Tbx_IntegSec.TabIndex = 12;
            Tbx_IntegSec.Text = "True";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 73);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 20);
            label1.TabIndex = 13;
            label1.Text = "OR";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(14, 49);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(601, 150);
            dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            groupBox1.Controls.Add(Tbx_Provider);
            groupBox1.Controls.Add(Tbx_SqlName);
            groupBox1.Controls.Add(Btn_AddToList);
            groupBox1.Controls.Add(Lbl_SqlName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Tbx_UserName);
            groupBox1.Controls.Add(Tbx_Password);
            groupBox1.Controls.Add(Lbl_UserName);
            groupBox1.Controls.Add(Lbl_Password);
            groupBox1.Controls.Add(Lbl_Provider);
            groupBox1.Controls.Add(Tbx_IntegSec);
            groupBox1.Controls.Add(Tbx_DataSource);
            groupBox1.Controls.Add(Tbx_InitCat);
            groupBox1.Location = new System.Drawing.Point(10, 59);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Size = new System.Drawing.Size(623, 171);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add a new connection";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(Lbl_ConnectionString);
            groupBox2.Location = new System.Drawing.Point(10, 234);
            groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox2.Size = new System.Drawing.Size(624, 226);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Connection string(s) in debug/app.config or .dll.config when live ";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 204);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(512, 15);
            label2.TabIndex = 17;
            label2.Text = "* Connection name is readonly, to edit a new connection must be added and the old one deleted.";
            // 
            // DBConnSetupView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightGray;
            ClientSize = new System.Drawing.Size(643, 545);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "DBConnSetupView";
            Text = "DBConnSetupView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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