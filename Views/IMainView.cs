using System;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Main view/menu interface 
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// Display resource view event handler
        /// </summary>
        event EventHandler ShowResourceView;
        /// <summary>
        /// Display assignment view event handler
        /// </summary>
        event EventHandler ShowAssignmentView;
        /// <summary>
        /// Display module view event handler
        /// </summary>
        event EventHandler ShowModuleView;
        /// <summary>
        /// Display DB connection view event handler
        /// </summary>
        event EventHandler ShowDBConnSetupView;
        /// <summary>
        /// Display connection wizard view event handler
        /// </summary>
        event EventHandler ShowConnWizard;
        //others
    }
}
