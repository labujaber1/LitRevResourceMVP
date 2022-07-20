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
    public partial class AssignmentView : Form, IAssignmentView
    {
        public AssignmentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        //fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
       
        public event EventHandler SaveAssignEvent;
        public event EventHandler DeleteAssignEvent;
        public event EventHandler EditAssignEvent;
        public event EventHandler DisplayModIdNumEvent;
       

        private void AssociateAndRaiseViewEvents()
        {
            //buttons click events
            Btn_AddAssign.Click += delegate
            {
                SaveAssignEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_DeleteAssign.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the assignment? This will also delete the associated resources.", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteAssignEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
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
                
        public string AssignIdNum 
        {
            get { return Tbx_AssignIdNum.Text; } 
            set { Tbx_AssignIdNum.Text = value; } 
        }
        public string AssignName
        {
            get { return Tbx_AssignName.Text; }
            set { Tbx_AssignName.Text = value; }
        }
        public DateTime DueDate 
        {
            get { return DateTimePicker2.Value.Date; }
            set { DateTimePicker2.Value = value.Date; } 
        }
        public Decimal Trimester
        {
            get { return numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        
        public string SelectedModName
        {
            get { return Lbx_ModuleList.SelectedItem.ToString(); }
            set { Lbx_ModuleList.SelectedItem = value; }
        }
        public string ModIdNum
        {
            get { return Tbx_ModuleIdNum.Text; }
            set { Tbx_ModuleIdNum.Text = value; }
        }

        private void Btn_ExitAssignView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetModuleNameListBindingSource(BindingSource moduleNameList)
        {
            Lbx_ModuleList.DataSource = moduleNameList;

        }
        public void SetAssignmentListBindingSource(BindingSource assignmentList)
        {
            dataGridView1.DataSource = assignmentList;
        }

      
        //Open a single form using a singleton pattern
        private static AssignmentView instance;
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
