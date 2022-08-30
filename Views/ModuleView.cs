using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Module view class
    /// </summary>
    public partial class ModuleView : Form, IModuleView
    {
        /// <summary>
        /// Initialises components and events.
        /// </summary>
        public ModuleView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            
        }
        //fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        /// <summary>
        /// Add module event handler
        /// </summary>
        public event EventHandler AddModEvent;
        /// <summary>
        /// Delete module event handler
        /// </summary>
        public event EventHandler DeleteModEvent;
        /// <summary>
        /// Edit module event handler
        /// </summary>
        public event EventHandler EditModEvent;

        /// <summary>
        /// Invokes CRUD events on modules.
        /// </summary>
        private void AssociateAndRaiseViewEvents()
        {
            //buttons events
            Btn_AddModule.Click += delegate
            {
                AddModEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            Btn_DeleteMod.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the module? \nCheck if assignments and resources are deleted first.", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteModEvent?.Invoke(this, EventArgs.Empty);
                    
                }
                MessageBox.Show(Message);
            };

            Btn_EditMod.Click += delegate
            {
                EditModEvent?.Invoke(this, EventArgs.Empty);
                
            };

        }

        /// <summary>
        /// Binds module datagridview to module list.
        /// </summary>
        /// <param name="moduleList"></param>
        public void SetModuleListBindingSource(BindingSource moduleList)
        {
            dataGridView3.DataSource = moduleList;
        }

        /// <summary>
        /// Module ID: Tbx_ModIdNum.Text
        /// </summary>
        public string ModIdNum 
        {
            get { return Tbx_ModIdNum.Text; }
            set { Tbx_ModIdNum.Text = value; } 
        }
        /// <summary>
        /// Module name: Tbx_AddModule.Text
        /// </summary>
        public string ModName 
        {
            get { return Tbx_AddModule.Text; }
            set { Tbx_AddModule.Text = value; } 
        }
        /// <summary>
        /// Module year fixed range 2020-2050: Tbx_DateYear.Text
        /// </summary>
        public string ModDateYear
        {
            get { return Tbx_DateYear.Text; }
            set { Tbx_DateYear.Text = value; }
        }
        /// <summary>
        /// Bool edit flag
        /// </summary>
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; } 
        }
        /// <summary>
        /// Bool successful flag
        /// </summary>
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        /// <summary>
        /// Returns stated message
        /// </summary>
        public string Message 
        {
            get { return message; }
            set { message = value; } 
        }

        
        private static ModuleView instance;
        /// <summary>
        /// Open a single module form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>ModuleView instance</returns>
        public static ModuleView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ModuleView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
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

        /// <summary>
        /// Closes module instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CloseMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
