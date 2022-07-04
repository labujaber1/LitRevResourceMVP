using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            Btn_MainResource.Click += delegate { ShowResourceView?.Invoke(this, EventArgs.Empty); };
            Btn_MainAssignments.Click += delegate { ShowAssignmentView?.Invoke(this, EventArgs.Empty); };
            Btn_MainModule.Click += delegate { ShowModuleView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowResourceView;
        public event EventHandler ShowAssignmentView;
        public event EventHandler ShowModuleView;

        private void Btn_ExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
