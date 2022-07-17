using System;
using System.Data;
using System.Windows.Forms;


namespace LitRevResourceMVP.Views
{
    public partial class ResourceView : Form, IResourceView
    {
        //fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //events
        //used in tab1 main resource view
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SelectChangeEvent;
        //used in tab2 add/edit resource
        public event EventHandler CreateReferenceEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event LinkLabelLinkClickedEventHandler LinkLabelEvent;

        //used in tab4 main view to select assignment for tab1
        public event EventHandler ViewResourcesEvent;


        //constructor
        public ResourceView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            Tbcl_ResourceList.TabPages.Remove(tabPage2);    //edit resource
            Tbcl_ResourceList.TabPages.Remove(tabPage3);    //add reference (may not develope here but add as seperate app)

        }


        private void AssociateAndRaiseViewEvents()
        {
            //used in tab1 select resource
            dataGridViewAssign.SelectionChanged += delegate
            {
                SelectChangeEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            Tbx_Search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_AddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                Tbcl_ResourceList.TabPages.Remove(tabPage1);
                Tbcl_ResourceList.TabPages.Add(tabPage2);

            };

            Btn_Delete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the resource?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            Btn_Edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                Tbcl_ResourceList.TabPages.Remove(tabPage1);
                Tbcl_ResourceList.TabPages.Add(tabPage2);
            };

            ////used in tab2 add/edit resource
            Lklbl_WebLink.Click += delegate
            {
                LinkLabelEvent?.DynamicInvoke(this, LinkLabelLinkClickedEventArgs.Empty); //error expecting eventargs
                //ActiveWebLinkEvent?.Invoke(this, EventArgs.Empty);
            };


            Btn_CreateAddRef.Click += delegate
            {
                CreateReferenceEvent?.Invoke(this, EventArgs.Empty);
                Tbcl_ResourceList.TabPages.Remove(tabPage2);
                Tbcl_ResourceList.TabPages.Add(tabPage3);
            };


            Btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    Tbcl_ResourceList.TabPages.Remove(tabPage2);
                    Tbcl_ResourceList.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };

            Btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                Tbcl_ResourceList.TabPages.Remove(tabPage2);
                Tbcl_ResourceList.TabPages.Add(tabPage1);
            };

        }

        //properties
        public string ResIdNum
        {
            get { return Tbx_IdNum.Text; }
            set { Tbx_IdNum.Text = value; }
        }
        public string ResWebLink
        {
            get { return Tbx_WebLink.Text; }
            set { Tbx_WebLink.Text = value; }
        }
        public LinkLabel ActiveWebLink
        {
            get { return Lklbl_WebLink; }
            set { Lklbl_WebLink = value; }
        }
        public string ResType
        {
            get { return Tbx_Type.Text; }
            set { Tbx_Type.Text = value; }
        }
        public string ResDoiNum
        {
            get { return Tbx_DoiNum.Text; }
            set { Tbx_DoiNum.Text = value; }
        }
        public string ResDateAccessed
        {
            get { return dateTimePicker1.Text; }
            set { dateTimePicker1.Text = value; }
        }
        public string ResCategory
        {
            get { return Tbx_NewCategory.Text; }
            set { Tbx_NewCategory.Text = value; }
        }
        public string ResReference
        {
            get { return Tbx_Reference.Text; }
            set { Tbx_Reference.Text = value; }
        }
        public string ResMainPoint
        {
            get { return Rtbx_MainPoint.Text; }
            set { Rtbx_MainPoint.Text = value; }
        }
        public string ResNotes
        {
            get { return Rtbx_Notes.Text; }
            set { Rtbx_Notes.Text = value; }
        }

        public string AssignIdNum
        {
            get { return Tbx_AssignIdNum.Text; }
            set { Tbx_AssignIdNum.Text = value; }
        }

        public string SearchValue
        {
            get { return Tbx_Search.Text; }
            set { Tbx_Search.Text = value; }
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


        private void dataGridViewAssign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = this.dataGridViewAssign.CurrentRow.DataBoundItem as DataRowView;
            if (drv != null)
            {
                AssignIdNum = drv[0].ToString();
                ViewResourcesEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        //public void SetAssignmentListBindingSource(BindingSource assignmentList)
        public void SetAssignmentListBindingSource(BindingSource assignData)
        {
            dataGridViewAssign.DataSource = assignData;
        }

        public void SetResourceListBindingSource(BindingSource resourceData)
        {
            dataGridViewResource.DataSource = resourceData;
        }

        public void SetCategoryListBindingSource(BindingSource categoryList)
        {
            Lbx_ListOfCategories.DataSource = categoryList;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Open a single form using a singleton pattern
        private static ResourceView instance;
        public static ResourceView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ResourceView();
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
