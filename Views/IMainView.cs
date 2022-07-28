using System;

namespace LitRevResourceMVP.Views
{
    public interface IMainView
    {
        event EventHandler ShowResourceView;
        event EventHandler ShowAssignmentView;
        event EventHandler ShowModuleView;
        event EventHandler ShowDBConnSetupView;
        event EventHandler ShowConnWizard;
        //others
    }
}
