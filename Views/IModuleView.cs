using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Module view interface 
    /// </summary>
    public interface IModuleView
    {
        /// <summary>
        /// Module ID: Tbx_ModIdNum.Text
        /// </summary>
        string ModIdNum { get; set; }
        /// <summary>
        /// Module name: Tbx_AddModule.Text
        /// </summary>
        string ModName { get; set; }
        /// <summary>
        /// Module year fixed range 2020-2050: Tbx_DateYear.Text
        /// </summary>
        string ModDateYear { get; set; }
        /// <summary>
        /// Add module event handler
        /// </summary>
        event EventHandler AddModEvent;
        /// <summary>
        /// Delete module event handler
        /// </summary>
        event EventHandler DeleteModEvent;
        /// <summary>
        /// Edit module event handler
        /// </summary>
        event EventHandler EditModEvent;
        /// <summary>
        /// Bool edit flag
        /// </summary>
        bool IsEdit { get; set; }
        /// <summary>
        /// Bool successful flag
        /// </summary>
        bool IsSuccessful { get; set; }
        /// <summary>
        /// Returns stated message
        /// </summary>
        string Message { get; set; }
        /// <summary>
        /// Binds module datagridview to module list.
        /// </summary>
        /// <param name="moduleList"></param>
        void SetModuleListBindingSource(BindingSource moduleList);
        /// <summary>
        /// 
        /// </summary>
        void Show();
    }
}
