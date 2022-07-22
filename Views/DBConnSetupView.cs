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
                SaveEvent?.Invoke(this, EventArgs.Empty);
            };

            Btn_DeleteList.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
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

        public string DataSource
        {
            get { return Tbx_DataSource.Text; }
            set { Tbx_DataSource.Text = value; }
        }

        public string DBName
        {
            get { return Tbx_InitCat.Text; }
            set { Tbx_InitCat.Text = value; }
        }

        public string IntSec
        {
            get { return Tbx_IntegSec.Text; }
            set { Tbx_IntegSec.Text = value; }
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

        public void SetConnectionFileBindingSource(BindingSource connectionFile)
        {
            Lbx_ConnStringFromFile.DataSource = connectionFile;
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
