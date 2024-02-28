using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Database view setup class
    /// </summary>
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
        /// <summary>
        /// Save connection string event handler
        /// </summary>
        public event EventHandler SaveEvent;
        /// <summary>
        /// Edit connection string event handler
        /// </summary>
        public event EventHandler EditEvent;
        /// <summary>
        /// Delete connection string event handler
        /// </summary>
        public event EventHandler DeleteEvent;
        /// <summary>
        /// Test connection string event handler
        /// </summary>
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
                    MessageBox.Show(Message);
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
                MessageBox.Show(Message);
            };

            Btn_ConnTest.Click += delegate
            {
                TestConnEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        /// <summary>
        /// Close current instance of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CloseDBConnSetup_Click(object sender, EventArgs e)
        {
            this.Close();
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
        /// Bool successful flag
        /// </summary>
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        /// <summary>
        /// Connection name: Tbx_SqlName.Text
        /// </summary>
        public string SqlName
        {
            get { return Tbx_SqlName.Text; }
            set { Tbx_SqlName.Text = value; }
        }
        /// <summary>
        /// Connection provider name: Tbx_Provider.Text
        /// </summary>
        public string ProviderName
        {
            get { return Tbx_Provider.Text; }
            set { Tbx_Provider.Text = value; }
        }
        /// <summary>
        /// Connection data source: Tbx_DataSource.Text
        /// </summary>
        public string DataSource
        {
            get { return Tbx_DataSource.Text; }
            set { Tbx_DataSource.Text = value; }
        }
        /// <summary>
        /// Connection initial category: Tbx_InitCat.Text
        /// </summary>
        public string InitCat
        {
            get { return Tbx_InitCat.Text; }
            set { Tbx_InitCat.Text = value; }
        }
        /// <summary>
        /// Connection integrated security: Convert.ToBoolean(Tbx_IntegSec.Text)
        /// </summary>
        public bool IntegSec
        {
            get { return Convert.ToBoolean(Tbx_IntegSec.Text); }
            set { Tbx_IntegSec.Text = value.ToString(); }
        }
        /// <summary>
        /// Connection security user name: Tbx_UserName.Text
        /// </summary>
        public string UserId
        {
            get { return Tbx_UserName.Text; }
            set { Tbx_UserName.Text = value; }
        }
        /// <summary>
        /// Connection security password: Tbx_Password.Text
        /// </summary>
        public string Password
        {
            get { return Tbx_Password.Text; }
            set { Tbx_Password.Text = value; }
        }

        /// <summary>
        /// Returns connection string used to test connection:
        /// dataGridView1.CurrentCell.Value.ToString()
        /// </summary>
        public string ConnectionString
        {
            get { return dataGridView1.CurrentCell.Value.ToString(); }
            set { _ = dataGridView1.CurrentCell.Value.ToString(); }
        }

        /// <summary>
        /// Returns index of selected item: 
        /// dataGridView1.CurrentCell.RowIndex
        /// </summary>
        public int IndexRow
        {
            get { return dataGridView1.CurrentCell.RowIndex; }
            set { _ = dataGridView1.CurrentCell.RowIndex; }
        }

        /// <summary>
        /// Used to bind db model list to datagridview
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
        public void DeleteDataGridRow()
        {
            //dataGridView1.Rows.Remove(dataGridView1.CurrentCell.OwningRow);
            int index = IndexRow;
            dataGridView1.Rows.RemoveAt(index);
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
                instance = new DBConnSetupView
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
