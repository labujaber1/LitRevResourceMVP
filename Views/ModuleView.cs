using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public partial class ModuleView : Form, IModuleView
    {
        public ModuleView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            
        }
        //fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public event EventHandler AddModEvent;
        public event EventHandler DeleteModEvent;
        public event EventHandler EditModEvent;

        private void AssociateAndRaiseViewEvents()
        {
            //buttons events
            Btn_AddModule.Click += delegate
            {
                AddModEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_DeleteMod.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the module? This will also delete the associated assignments and resources.", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteModEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            Btn_EditMod.Click += delegate
            {
                EditModEvent?.Invoke(this, EventArgs.Empty);
            };

        }

        public void SetModuleListBindingSource(BindingSource moduleList)
        {
            dataGridView3.DataSource = moduleList;
        }

        
        public string ModIdNum 
        {
            get { return Tbx_ModIdNum.Text; }
            set { Tbx_ModIdNum.Text = value; } 
        }

        public string ModName 
        {
            get { return Tbx_AddModule.Text; }
            set { Tbx_AddModule.Text = value; } 
        }
        public string ModDateYear
        {
            get { return Tbx_DateYear.Text; }
            set { Tbx_DateYear.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; } 
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; } 
        }

        //Open a single form using a singleton pattern
        private static ModuleView instance;
        public static ModuleView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ModuleView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void Btn_CloseMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
