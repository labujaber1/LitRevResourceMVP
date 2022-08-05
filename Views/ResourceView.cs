using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Resource view class
    /// </summary>
    public partial class ResourceView : Form, IResourceView
    {
        //fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        //events
        //used in tab1 main resource view
        /// <summary>
        /// Search resource event handler
        /// </summary>
        public event EventHandler SearchEvent;
        /// <summary>
        /// Add new resource event handler
        /// </summary>
        public event EventHandler AddNewEvent;
        /// <summary>
        /// Delete resource event handler
        /// </summary>
        public event EventHandler DeleteEvent;
        /// <summary>
        /// Edit resource event handler
        /// </summary>
        public event EventHandler EditEvent;

        //used in tab2 add/edit resource
        /// <summary>
        /// Create reference event handler
        /// </summary>
        public event EventHandler CreateReferenceEvent;
        /// <summary>
        /// Save resource event handler
        /// </summary>
        public event EventHandler SaveEvent;
        /// <summary>
        /// Cancel new resource event handler
        /// </summary>
        public event EventHandler CancelEvent;
        /// <summary>
        /// View total characters used
        /// </summary>
        public event EventHandler MainCharLenEvent;
        /// <summary>
        /// View total characters used
        /// </summary>
        public event EventHandler NotesCharLenEvent;
        /// <summary>
        /// Display website as a link event
        /// </summary>
        public event LinkLabelLinkClickedEventHandler LinkLabelEvent;
        /// <summary>
        /// View resources event handler
        /// </summary>
        public event EventHandler ViewResourcesEvent;


        /// <summary>
        /// Initialises components, events, and removes tab2 and 3 so main tab is viewed.
        /// </summary>
        public ResourceView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            Tbcl_ResourceList.TabPages.Remove(tabPage2);
            //Create reference #currently not in use, to dev.
            Tbcl_ResourceList.TabPages.Remove(tabPage3);    
        }

        /// <summary>
        /// Invokes CRUD events on resources.
        /// </summary>
        private void AssociateAndRaiseViewEvents()
        {
            //used in tab1 select resource
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

           Btn_CreateAddRef.Click += delegate
            {
                CreateReferenceEvent?.Invoke(this, EventArgs.Empty);
                //Tbcl_ResourceList.TabPages.Remove(tabPage2);
                //Tbcl_ResourceList.TabPages.Add(tabPage3);
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

            Btn_MainCharLength.Click += delegate
            {
                MainCharLenEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_NoteCharLength.Click += delegate
            {
                NotesCharLenEvent?.Invoke(this, EventArgs.Empty);

            };
        }

        //properties
        /// <summary>
        /// Resource ID: Tbx_IdNum.Text
        /// </summary>
        public string ResIdNum
        {
            get { return Tbx_IdNum.Text; }
            set { Tbx_IdNum.Text = value; }
        }
        /// <summary>
        /// Resource web address: Tbx_WebLink.Text
        /// </summary>
        public string ResWebLink
        {
            get { return Tbx_WebLink.Text; }
            set { Tbx_WebLink.Text = value; }
        }
        /// <summary>
        /// Resource website link label: Lklbl_WebLink
        /// </summary>
        public LinkLabel ActiveWebLink
        {
            get { return Lklbl_WebLink; }
            set { Lklbl_WebLink = value; }
        }
        /// <summary>
        /// Resource type:Tbx_Type.Text
        /// </summary>
        public string ResType
        {
            get { return Tbx_Type.Text; }
            set { Tbx_Type.Text = value; }
        }
        /// <summary>
        /// Resource DOI number: Tbx_DoiNum.Text
        /// </summary>
        public string ResDoiNum
        {
            get { return Tbx_DoiNum.Text; }
            set { Tbx_DoiNum.Text = value; }
        }
        /// <summary>
        /// Resource accessed date: dateTimePicker1.Value.Date
        /// </summary>
        public DateTime ResDateAccessed
        {
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Value = value; }
        }
        /// <summary>
        /// Resource category: Tbx_NewCategory.Text
        /// </summary>
        public string ResCategory
        {
            get { return Tbx_NewCategory.Text; }
            set { Tbx_NewCategory.Text = value; }
        }
        /// <summary>
        /// Resource pasted/self written reference: Tbx_Reference.Text
        /// </summary>
        public string ResReference
        {
            get { return Tbx_Reference.Text; }
            set { Tbx_Reference.Text = value; }
        }
        /// <summary>
        /// Resource main point text max 2000 chars:
        /// Rtbx_MainPoint.Text
        /// </summary>
        public string ResMainPoint
        {
            get { return Rtbx_MainPoint.Text; }
            set { Rtbx_MainPoint.Text = value; }
        }
        /// <summary>
        /// Resource additional notes max 3000 chars:
        /// Rtbx_Notes.Text
        /// </summary>
        public string ResNotes
        {
            get { return Rtbx_Notes.Text; }
            set { Rtbx_Notes.Text = value; }
        }
        /// <summary>
        /// Assignment ID (FK): Tbx_AssignIdNum.Text
        /// </summary>
        public string AssignIdNum
        {
            get { return Tbx_AssignIdNum.Text; }
            set { Tbx_AssignIdNum.Text = value; }
        }
        /// <summary>
        /// Resource ID or category search value:
        /// Tbx_Search.Text
        /// </summary>
        public string SearchValue
        {
            get { return Tbx_Search.Text; }
            set { Tbx_Search.Text = value; }
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
        /// Invokes LinkLabelEvent in presenter class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lklbl_WebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                LinkLabelEvent?.Invoke(sender,e);
        }

        /// <summary>
        /// Invokes viewResources event when cell clicked in the assign datagridview. 
        /// Adds the assignment number in the selected row to textbox for viewing and retrieval.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewAssign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewAssign.CurrentRow.DataBoundItem is DataRowView drv)
            {
                AssignIdNum = drv[0].ToString();
                ViewResourcesEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets the resource data for the current selected row in the resource datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewResource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridViewResource;
            if (dgv != null)
            {
                ResIdNum = dgv.CurrentRow.Cells[0].Value.ToString();
                ResWebLink = dgv.CurrentRow.Cells[1].Value.ToString();
                ResType = dgv.CurrentRow.Cells[2].Value.ToString();
                ResDoiNum = dgv.CurrentRow.Cells[3].Value.ToString();
                ResDateAccessed = (DateTime)dgv.CurrentRow.Cells[4].Value;
                ResCategory = dgv.CurrentRow.Cells[5].Value.ToString();
                ResReference = dgv.CurrentRow.Cells[6].Value.ToString();
                ResMainPoint = dgv.CurrentRow.Cells[7].Value.ToString();
                ResNotes = dgv.CurrentRow.Cells[8].Value.ToString();
            }
        }

        /// <summary>
        /// Binds assignment datagridview to assignData source
        /// </summary>
        /// <param name="assignData"></param>
        public void SetAssignmentListBindingSource(BindingSource assignData)
        {
            dataGridViewAssign.DataSource = assignData;
        }

        /// <summary>
        /// Binds resource datagridview to resourceData source
        /// </summary>
        /// <param name="resourceData"></param>
        public void SetResourceListBindingSource(BindingSource resourceData)
        {
            dataGridViewResource.DataSource = resourceData;
        }

        /// <summary>
        /// Binds category list box to categoryList source
        /// </summary>
        /// <param name="categoryList"></param>
        public void SetCategoryListBindingSource(BindingSource categoryList)
        {
            Lbx_ListOfCategories.DataSource = categoryList;
            Lbx_ViewResCategories.DataSource = categoryList;
        }

        /// <summary>
        /// Closes instance of resource view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Closes reference tab and opens resource details tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_RefBack_Click(object sender, EventArgs e)
        {
            Tbcl_ResourceList.TabPages.Remove(tabPage3);
            Tbcl_ResourceList.TabPages.Add(tabPage2);
        }
        
        private static ResourceView instance;
        /// <summary>
        /// Open a single resource form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>ResourceView instance</returns>
        public static ResourceView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ResourceView
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
    }
}
