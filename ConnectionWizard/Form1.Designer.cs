
namespace LitRevResourceMVP.ConnectionWizard
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindServers = new System.Windows.Forms.Button();
            this.cmbServers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBlankPassAllowed = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkUseWindowsSecurity = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFindDatabases = new System.Windows.Forms.Button();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindServers);
            this.groupBox1.Controls.Add(this.cmbServers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select SQL Server";
            // 
            // btnFindServers
            // 
            this.btnFindServers.Location = new System.Drawing.Point(219, 17);
            this.btnFindServers.Name = "btnFindServers";
            this.btnFindServers.Size = new System.Drawing.Size(35, 23);
            this.btnFindServers.TabIndex = 1;
            this.btnFindServers.Text = "...";
            this.btnFindServers.UseVisualStyleBackColor = true;
            this.btnFindServers.Click += new System.EventHandler(this.btnFindServers_Click);
            // 
            // cmbServers
            // 
            this.cmbServers.FormattingEnabled = true;
            this.cmbServers.Location = new System.Drawing.Point(6, 19);
            this.cmbServers.Name = "cmbServers";
            this.cmbServers.Size = new System.Drawing.Size(207, 21);
            this.cmbServers.TabIndex = 0;
            this.cmbServers.SelectedValueChanged += new System.EventHandler(this.cmbServers_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBlankPassAllowed);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.chkUseWindowsSecurity);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Windows Security";
            // 
            // chkBlankPassAllowed
            // 
            this.chkBlankPassAllowed.AutoSize = true;
            this.chkBlankPassAllowed.Location = new System.Drawing.Point(7, 68);
            this.chkBlankPassAllowed.Name = "chkBlankPassAllowed";
            this.chkBlankPassAllowed.Size = new System.Drawing.Size(142, 17);
            this.chkBlankPassAllowed.TabIndex = 9;
            this.chkBlankPassAllowed.Text = "Blank Password Allowed";
            this.chkBlankPassAllowed.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(65, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(72, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "User Name";
            // 
            // chkUseWindowsSecurity
            // 
            this.chkUseWindowsSecurity.AutoSize = true;
            this.chkUseWindowsSecurity.Checked = true;
            this.chkUseWindowsSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseWindowsSecurity.Location = new System.Drawing.Point(6, 19);
            this.chkUseWindowsSecurity.Name = "chkUseWindowsSecurity";
            this.chkUseWindowsSecurity.Size = new System.Drawing.Size(133, 17);
            this.chkUseWindowsSecurity.TabIndex = 6;
            this.chkUseWindowsSecurity.Text = "Use Windows Security";
            this.chkUseWindowsSecurity.UseVisualStyleBackColor = true;
            this.chkUseWindowsSecurity.CheckStateChanged += new System.EventHandler(this.chkUseWindowsSecurity_CheckStateChanged);
            this.chkUseWindowsSecurity.CheckedChanged += new System.EventHandler(this.chkUseWindowsSecurity_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFindDatabases);
            this.groupBox3.Controls.Add(this.cmbDatabases);
            this.groupBox3.Location = new System.Drawing.Point(13, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Database";
            // 
            // btnFindDatabases
            // 
            this.btnFindDatabases.Location = new System.Drawing.Point(218, 17);
            this.btnFindDatabases.Name = "btnFindDatabases";
            this.btnFindDatabases.Size = new System.Drawing.Size(35, 23);
            this.btnFindDatabases.TabIndex = 1;
            this.btnFindDatabases.Text = "...";
            this.btnFindDatabases.UseVisualStyleBackColor = true;
            this.btnFindDatabases.Click += new System.EventHandler(this.btnFindDatabases_Click);
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(5, 19);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(207, 21);
            this.cmbDatabases.TabIndex = 0;
            this.cmbDatabases.TextChanged += new System.EventHandler(this.cmbDatabases_TextChanged);
            this.cmbDatabases.Click += new System.EventHandler(this.cmbDatabases_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(13, 300);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(119, 23);
            this.btnTestConnection.TabIndex = 3;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(200, 300);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(72, 23);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Connection Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindServers;
        private System.Windows.Forms.ComboBox cmbServers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.CheckBox chkBlankPassAllowed;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkUseWindowsSecurity;
        private System.Windows.Forms.Button btnFindDatabases;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnFinish;
    }
}