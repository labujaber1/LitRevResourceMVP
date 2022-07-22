using System;
using LitRevResourceMVP.Views;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Repositories;


namespace LitRevResourceMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView imainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.imainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.imainView.ShowResourceView += ShowResourcesView;
            this.imainView.ShowAssignmentView += ShowAssignmentView;
            this.imainView.ShowModuleView += ShowModuleView;
            this.imainView.ShowDBConnSetupView += ShowDBConnSetupView;
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
            new DBConnSetupPresenter(view, repository);
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
            new ResourcePresenter(view, repository);
            
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
            new AssignmentPresenter(view, repository);

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
            new ModulePresenter(view, repository);

        }
    }
}
