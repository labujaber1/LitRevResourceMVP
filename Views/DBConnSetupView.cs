using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public partial class DBConnSetupView : Form, IDBConnSetupView
    {
        /// <summary>
        /// Initialises components and events.
        /// </summary>
        public DBConnSetupView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            
        }

        //fields
        private string message;
        private bool isSuccessful;

        //public event EventHandler
        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler TestConnEvent;
        
        /// <summary>
        /// Invokes events on DBConn setup.
        /// </summary>
        private void AssociateAndRaiseViewEvents()
        {
            Btn_AddToList.Click += delegate
            {
                var result = MessageBox.Show("Please check the name entered as this is an uneditable field, do you want to continue?", "Warning",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            Btn_DeleteList.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete this?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            Btn_EditList.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_ConnTest.Click += delegate
            {
                TestConnEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        
        private void Btn_CloseDBConnSetup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        
        public string SqlName
        {
            get { return Tbx_SqlName.Text; }
            set { Tbx_SqlName.Text = value; }
        }

        public string ProviderName
        {
            get { return Tbx_Provider.Text; }
            set { Tbx_Provider.Text = value; }
        }
        
        public string DataSource
        {
            get { return Tbx_DataSource.Text; }
            set { Tbx_DataSource.Text = value; }
        }

        public string InitCat
        {
            get { return Tbx_InitCat.Text; }
            set { Tbx_InitCat.Text = value; }
        }

        public bool IntegSec
        {
            get { return Convert.ToBoolean(Tbx_IntegSec.Text); }
            set { Tbx_IntegSec.Text = value.ToString(); }
        }

        public string UserName
        {
            get { return Tbx_UserName.Text; }
            set { Tbx_UserName.Text = value; }
        }

        public string Password
        {
            get { return Tbx_Password.Text; }
            set { Tbx_Password.Text = value; }
        }

        //returns connection string used to test connection
        public string ConnectionString
        {
            get { return dataGridView1.CurrentCell.Value.ToString(); }
            set { value = dataGridView1.CurrentCell.Value.ToString(); }
        }

        //returns index of selected item
        public int IndexRow 
        {
            get { return dataGridView1.CurrentCell.RowIndex;  }
            set { value=dataGridView1.CurrentCell.RowIndex; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionFile"></param>
        public void SetConnectionFileBindingSource(BindingSource connectionFile)
        {
            dataGridView1.DataSource = connectionFile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saveToConnFile"></param>
        public void SetSaveConnToFileBindingSource(BindingSource saveToConnFile)
        {
            saveToConnFile.DataSource = dataGridView1;
        }

        /// <summary>
        /// Deletes row in datagridview by index of selected cell
        /// </summary>
        public void deleteDataGridRow()
        {
            //dataGridView1.Rows.Remove(dataGridView1.CurrentCell.OwningRow);
            int index = IndexRow;
            dataGridView1.Rows.RemoveAt(index) ;
        }


        private static DBConnSetupView instance;
        /// <summary>
        /// Open a single DBConn setup form using a singleton pattern
        /// </summary>
        /// <param name="parentContainer"></param>
        /// <returns>DBConnSetupView instance</returns>
        public static DBConnSetupView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DBConnSetupView();
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
