using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Main view/menu class to display other form views
    /// </summary>
    public partial class MainView : Form, IMainView
    {
        /// <summary>
        /// Events to get an instance of each view of module, assignment, and resource when required.
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            Btn_MainResource.Click += delegate { ShowResourceView?.Invoke(this, EventArgs.Empty); };
            Btn_MainAssignments.Click += delegate { ShowAssignmentView?.Invoke(this, EventArgs.Empty); };
            Btn_MainModule.Click += delegate { ShowModuleView?.Invoke(this, EventArgs.Empty); };
            Btn_DBConnSetup.Click += delegate { ShowDBConnSetupView?.Invoke(this, EventArgs.Empty); };
            Btn_ConnWizard.Click += delegate { ShowConnWizard?.Invoke(this, EventArgs.Empty); };
        }
        /// <summary>
        /// Display resource view event handler
        /// </summary>
        public event EventHandler ShowResourceView;
        /// <summary>
        /// Display assignment view event handler
        /// </summary>
        public event EventHandler ShowAssignmentView;
        /// <summary>
        /// Display module view event handler
        /// </summary>
        public event EventHandler ShowModuleView;
        /// <summary>
        /// Display DB connection view event handler
        /// </summary>
        public event EventHandler ShowDBConnSetupView;
        /// <summary>
        /// Display connection wizard view event handler
        /// </summary>
        public event EventHandler ShowConnWizard;
        /// <summary>
        /// Exit from system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
