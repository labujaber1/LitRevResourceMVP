using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Assignment view class
    /// </summary>
    public partial class AssignmentView : Form, IAssignmentView
    {
        /// <summary>
        /// Initialises components and events.
        /// </summary>
        public AssignmentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        /// <summary>
        /// fields
        /// </summary>
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        /// <summary>
        /// Save assignment event handler
        /// </summary>
        public event EventHandler SaveAssignEvent;
        /// <summary>
        /// Delete assignment event handler
        /// </summary>
        public event EventHandler DeleteAssignEvent;
        /// <summary>
        /// Edit assignment event handler
        /// </summary>
        public event EventHandler EditAssignEvent;
        /// <summary>
        /// Display module ID event handler
        /// </summary>
        public event EventHandler DisplayModIdNumEvent;
       
        /// <summary>
        /// Invokes CRUD events on assignments.
        /// </summary>
        private void AssociateAndRaiseViewEvents()
        {
            //buttons click events
            Btn_AddAssign.Click += delegate
            {
                SaveAssignEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            Btn_DeleteAssign.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the assignment? This will also delete the associated resources.", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteAssignEvent?.Invoke(this, EventArgs.Empty);
                    
                }
                MessageBox.Show(Message);
            };

            Btn_EditAssign.Click += delegate
            {
                EditAssignEvent?.Invoke(this, EventArgs.Empty);
                
            };

           
            Lbx_ModuleList.Click += delegate
            {
                DisplayModIdNumEvent?.Invoke(this, EventArgs.Empty);
            };
                        
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
        /// <summary>
        /// Assignment ID: Tbx_AssignIdNum.Text
        /// </summary>        
        public string AssignIdNum 
        {
            get { return Tbx_AssignIdNum.Text; } 
            set { Tbx_AssignIdNum.Text = value; } 
        }
        /// <summary>
        /// Assignment name:Tbx_AssignName.Text
        /// </summary>
        public string AssignName
        {
            get { return Tbx_AssignName.Text; }
            set { Tbx_AssignName.Text = value; }
        }
        /// <summary>
        /// Assignment due date: DateTimePicker2.Value.Date
        /// </summary>
        public DateTime DueDate 
        {
            get { return DateTimePicker2.Value.Date; }
            set { DateTimePicker2.Value = value.Date; } 
        }
        /// <summary>
        /// Assignment trimester fixed range 0-2: numericUpDown1.Value
        /// </summary>
        public Decimal Trimester
        {
            get { return numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        /// <summary>
        /// Selected module name: Lbx_ModuleList.SelectedItem.ToString()
        /// </summary>
        public string SelectedModName
        {
            get { return Lbx_ModuleList.SelectedItem.ToString(); }
            set { Lbx_ModuleList.SelectedItem = value; }
        }
        /// <summary>
        /// Module ID: Tbx_ModuleIdNum.Text
        /// </summary>
        public string ModIdNum
        {
            get { return Tbx_ModuleIdNum.Text; }
            set { Tbx_ModuleIdNum.Text = value; }
        }

        /// <summary>
        /// Closes instance of assignment view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ExitAssignView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Binds listbox to module name list.
        /// </summary>
        /// <param name="moduleNameList"></param>
        public void SetModuleNameListBindingSource(BindingSource moduleNameList)
        {
            Lbx_ModuleList.DataSource = moduleNameList;
        }
        /// <summary>
        /// Binds datagridview1 to assignment list.
        /// </summary>
        /// <param name="assignmentList"></param>
        public void SetAssignmentListBindingSource(BindingSource assignmentList)
        {
            dataGridView1.DataSource = assignmentList;
        }


        
        private static AssignmentView instance;
        /// <summary>
        /// Open a single assignment form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>AssignmentView instance</returns>
        public static AssignmentView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AssignmentView();
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
    }
}
