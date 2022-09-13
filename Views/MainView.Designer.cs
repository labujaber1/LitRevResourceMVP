﻿
namespace LitRevResourceMVP.Views
{
    partial class MainView
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
            this.Btn_MainModule = new System.Windows.Forms.Button();
            this.Btn_MainAssignments = new System.Windows.Forms.Button();
            this.Btn_MainResource = new System.Windows.Forms.Button();
            this.Lbl_MainMenu = new System.Windows.Forms.Label();
            this.Btn_ExitSystem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ConnWizard = new System.Windows.Forms.Button();
            this.Btn_DBConnSetup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_MainModule
            // 
            this.Btn_MainModule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_MainModule.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_MainModule.Location = new System.Drawing.Point(19, 297);
            this.Btn_MainModule.Name = "Btn_MainModule";
            this.Btn_MainModule.Size = new System.Drawing.Size(182, 63);
            this.Btn_MainModule.TabIndex = 2;
            this.Btn_MainModule.Text = "CRUD Module";
            this.Btn_MainModule.UseVisualStyleBackColor = false;
            // 
            // Btn_MainAssignments
            // 
            this.Btn_MainAssignments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_MainAssignments.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_MainAssignments.Location = new System.Drawing.Point(19, 209);
            this.Btn_MainAssignments.Name = "Btn_MainAssignments";
            this.Btn_MainAssignments.Size = new System.Drawing.Size(182, 63);
            this.Btn_MainAssignments.TabIndex = 1;
            this.Btn_MainAssignments.Text = "CRUD Assignment";
            this.Btn_MainAssignments.UseVisualStyleBackColor = false;
            // 
            // Btn_MainResource
            // 
            this.Btn_MainResource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_MainResource.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_MainResource.Location = new System.Drawing.Point(19, 127);
            this.Btn_MainResource.Name = "Btn_MainResource";
            this.Btn_MainResource.Size = new System.Drawing.Size(182, 63);
            this.Btn_MainResource.TabIndex = 0;
            this.Btn_MainResource.Text = "CRUD Resources";
            this.Btn_MainResource.UseVisualStyleBackColor = false;
            // 
            // Lbl_MainMenu
            // 
            this.Lbl_MainMenu.AutoSize = true;
            this.Lbl_MainMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MainMenu.Location = new System.Drawing.Point(12, 38);
            this.Lbl_MainMenu.Name = "Lbl_MainMenu";
            this.Lbl_MainMenu.Size = new System.Drawing.Size(200, 48);
            this.Lbl_MainMenu.TabIndex = 1;
            this.Lbl_MainMenu.Text = "Main Menu";
            // 
            // Btn_ExitSystem
            // 
            this.Btn_ExitSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ExitSystem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_ExitSystem.Location = new System.Drawing.Point(36, 566);
            this.Btn_ExitSystem.Name = "Btn_ExitSystem";
            this.Btn_ExitSystem.Size = new System.Drawing.Size(148, 63);
            this.Btn_ExitSystem.TabIndex = 2;
            this.Btn_ExitSystem.Text = "Exit system";
            this.Btn_ExitSystem.UseVisualStyleBackColor = false;
            this.Btn_ExitSystem.Click += new System.EventHandler(this.Btn_ExitSystem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Btn_ConnWizard);
            this.panel1.Controls.Add(this.Btn_DBConnSetup);
            this.panel1.Controls.Add(this.Btn_ExitSystem);
            this.panel1.Controls.Add(this.Lbl_MainMenu);
            this.panel1.Controls.Add(this.Btn_MainModule);
            this.panel1.Controls.Add(this.Btn_MainAssignments);
            this.panel1.Controls.Add(this.Btn_MainResource);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 701);
            this.panel1.TabIndex = 3;
            // 
            // Btn_ConnWizard
            // 
            this.Btn_ConnWizard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ConnWizard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_ConnWizard.Location = new System.Drawing.Point(18, 385);
            this.Btn_ConnWizard.Name = "Btn_ConnWizard";
            this.Btn_ConnWizard.Size = new System.Drawing.Size(183, 55);
            this.Btn_ConnWizard.TabIndex = 4;
            this.Btn_ConnWizard.Text = "Connection wizard";
            this.Btn_ConnWizard.UseVisualStyleBackColor = false;
            // 
            // Btn_DBConnSetup
            // 
            this.Btn_DBConnSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_DBConnSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_DBConnSetup.Location = new System.Drawing.Point(19, 446);
            this.Btn_DBConnSetup.Name = "Btn_DBConnSetup";
            this.Btn_DBConnSetup.Size = new System.Drawing.Size(182, 66);
            this.Btn_DBConnSetup.TabIndex = 3;
            this.Btn_DBConnSetup.Text = "DB connection setup";
            this.Btn_DBConnSetup.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1121, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_MainResource;
        private System.Windows.Forms.Label Lbl_MainMenu;
        private System.Windows.Forms.Button Btn_MainModule;
        private System.Windows.Forms.Button Btn_MainAssignments;
        private System.Windows.Forms.Button Btn_ExitSystem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_DBConnSetup;
        private System.Windows.Forms.Button Btn_ConnWizard;
    }
}