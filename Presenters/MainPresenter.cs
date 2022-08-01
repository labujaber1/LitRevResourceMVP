using System;
using LitRevResourceMVP.Views;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Repositories;


namespace LitRevResourceMVP.Presenters
{
    /// <summary>
    /// Module presenter to invoke view events of each form identified by buttons in the side bar.
    /// </summary>
    public class MainPresenter
    {
        
        private readonly IMainView imainView;
        private readonly string sqlConnectionString;
        /// <summary>
        /// Setup events args to event handlers and module bindings source.
        /// </summary>
        /// <param name="mainView"></param>
        /// <param name="sqlConnectionString"></param>
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            imainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            imainView.ShowResourceView += ShowResourcesView;
            imainView.ShowAssignmentView += ShowAssignmentView;
            imainView.ShowModuleView += ShowModuleView;
            imainView.ShowDBConnSetupView += ShowDBConnSetupView;
            imainView.ShowConnWizard += ShowConnWizard;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowConnWizard(object sender, EventArgs e)
        {
            ConnectionWizard.Form1 f1 = new();
            f1.Show();

        }

        /// <summary>
        /// Passes in a singleton instance of the DbConnSetup view and the sql connection string to the presenter  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDBConnSetupView(object sender, EventArgs e)
        {
            IDBConnSetupView view = DBConnSetupView.GetInstance((MainView)imainView);
            IDBConnSetupRepository repository = new DBConnSetupRepository(sqlConnectionString);
            _ = new DBConnSetupPresenter(view, repository);
        }

        /// <summary>
        /// Passes in a singleton instance of the resource view and the sql connection string to the presenter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowResourcesView(object sender, EventArgs e)
        {
            IResourceView view = ResourceView.GetInstance((MainView)imainView);
            IResourceRepository repository = new ResourceRepository(sqlConnectionString);
            _ = new ResourcePresenter(view, repository);
            
        }
        /// <summary>
        /// Passes in a singleton instance of the assignment view and the sql connection string to the presenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAssignmentView(object sender, EventArgs e)
        {
            IAssignmentView view = AssignmentView.GetInstance((MainView)imainView);
            IAssignmentRepository repository = new AssignmentRepository(sqlConnectionString);
            _ = new AssignmentPresenter(view, repository);

        }
        /// <summary>
        /// Passes in a singleton instance of the module view and the sql connection string to the presenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowModuleView(object sender, EventArgs e)
        {
            IModuleView view = ModuleView.GetInstance((MainView)imainView);
            IModuleRepository repository = new ModuleRepository(sqlConnectionString);
            _ = new ModulePresenter(view, repository);

        }
    }
}
