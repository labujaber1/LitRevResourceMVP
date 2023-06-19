
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
            Btn_MainModule = new System.Windows.Forms.Button();
            Btn_MainAssignments = new System.Windows.Forms.Button();
            Btn_MainResource = new System.Windows.Forms.Button();
            Lbl_MainMenu = new System.Windows.Forms.Label();
            Btn_ExitSystem = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            Btn_ConnWizard = new System.Windows.Forms.Button();
            Btn_DBConnSetup = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_MainModule
            // 
            Btn_MainModule.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_MainModule.BackColor = System.Drawing.SystemColors.Menu;
            Btn_MainModule.Location = new System.Drawing.Point(15, 261);
            Btn_MainModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_MainModule.Name = "Btn_MainModule";
            Btn_MainModule.Size = new System.Drawing.Size(146, 50);
            Btn_MainModule.TabIndex = 2;
            Btn_MainModule.Text = "Module";
            Btn_MainModule.UseVisualStyleBackColor = false;
            // 
            // Btn_MainAssignments
            // 
            Btn_MainAssignments.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_MainAssignments.BackColor = System.Drawing.SystemColors.Menu;
            Btn_MainAssignments.Location = new System.Drawing.Point(15, 190);
            Btn_MainAssignments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_MainAssignments.Name = "Btn_MainAssignments";
            Btn_MainAssignments.Size = new System.Drawing.Size(146, 50);
            Btn_MainAssignments.TabIndex = 1;
            Btn_MainAssignments.Text = "Assignment";
            Btn_MainAssignments.UseVisualStyleBackColor = false;
            // 
            // Btn_MainResource
            // 
            Btn_MainResource.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_MainResource.BackColor = System.Drawing.SystemColors.Menu;
            Btn_MainResource.Location = new System.Drawing.Point(15, 125);
            Btn_MainResource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_MainResource.Name = "Btn_MainResource";
            Btn_MainResource.Size = new System.Drawing.Size(146, 50);
            Btn_MainResource.TabIndex = 0;
            Btn_MainResource.Text = "Resources";
            Btn_MainResource.UseVisualStyleBackColor = false;
            // 
            // Lbl_MainMenu
            // 
            Lbl_MainMenu.AutoSize = true;
            Lbl_MainMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl_MainMenu.Location = new System.Drawing.Point(10, 30);
            Lbl_MainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Lbl_MainMenu.Name = "Lbl_MainMenu";
            Lbl_MainMenu.Size = new System.Drawing.Size(169, 41);
            Lbl_MainMenu.TabIndex = 1;
            Lbl_MainMenu.Text = "Main Menu";
            // 
            // Btn_ExitSystem
            // 
            Btn_ExitSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_ExitSystem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            Btn_ExitSystem.Location = new System.Drawing.Point(29, 509);
            Btn_ExitSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_ExitSystem.Name = "Btn_ExitSystem";
            Btn_ExitSystem.Size = new System.Drawing.Size(118, 50);
            Btn_ExitSystem.TabIndex = 2;
            Btn_ExitSystem.Text = "Exit system";
            Btn_ExitSystem.UseVisualStyleBackColor = false;
            Btn_ExitSystem.Click += Btn_ExitSystem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            panel1.Controls.Add(Btn_ConnWizard);
            panel1.Controls.Add(Btn_DBConnSetup);
            panel1.Controls.Add(Btn_ExitSystem);
            panel1.Controls.Add(Lbl_MainMenu);
            panel1.Controls.Add(Btn_MainModule);
            panel1.Controls.Add(Btn_MainAssignments);
            panel1.Controls.Add(Btn_MainResource);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(174, 607);
            panel1.TabIndex = 3;
            // 
            // Btn_ConnWizard
            // 
            Btn_ConnWizard.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_ConnWizard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            Btn_ConnWizard.Location = new System.Drawing.Point(14, 364);
            Btn_ConnWizard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_ConnWizard.Name = "Btn_ConnWizard";
            Btn_ConnWizard.Size = new System.Drawing.Size(146, 44);
            Btn_ConnWizard.TabIndex = 4;
            Btn_ConnWizard.Text = "Connection wizard";
            Btn_ConnWizard.UseVisualStyleBackColor = false;
            Btn_ConnWizard.Visible = false;
            // 
            // Btn_DBConnSetup
            // 
            Btn_DBConnSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_DBConnSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            Btn_DBConnSetup.Location = new System.Drawing.Point(15, 413);
            Btn_DBConnSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Btn_DBConnSetup.Name = "Btn_DBConnSetup";
            Btn_DBConnSetup.Size = new System.Drawing.Size(146, 53);
            Btn_DBConnSetup.TabIndex = 3;
            Btn_DBConnSetup.Text = "DB connection setup";
            Btn_DBConnSetup.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(897, 607);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "MainView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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