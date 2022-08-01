using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Assignment view interface 
    /// </summary>
    public interface IAssignmentView
    {
        /// <summary>
        /// Assignment ID: Tbx_AssignIdNum.Text
        /// </summary>
        string AssignIdNum { get; set; }
        /// <summary>
        /// Assignment name: Tbx_AssignName.Text
        /// </summary>
        string AssignName { get; set; }
        /// <summary>
        /// Assignment due date: DateTimePicker2.Value.Date
        /// </summary>
        DateTime DueDate { get; set; }
        /// <summary>
        /// Assignment trimester fixed range 0-2: numericUpDown1.Value
        /// </summary>
        Decimal Trimester { get; set; }
        /// <summary>
        /// Module ID: Tbx_ModuleIdNum.Text
        /// </summary>
        string ModIdNum { get; set; }
        /// <summary>
        /// Selected module name: Lbx_ModuleList.SelectedItem.ToString()
        /// </summary>
        string SelectedModName { get; set; }
        /// <summary>
        /// Save assignment event handler
        /// </summary>
        event EventHandler SaveAssignEvent;
        /// <summary>
        /// Delete assignment event handler
        /// </summary>
        event EventHandler DeleteAssignEvent;
        /// <summary>
        /// Edit assignment event handler
        /// </summary>
        event EventHandler EditAssignEvent;
        /// <summary>
        /// Display module ID event handler
        /// </summary>
        event EventHandler DisplayModIdNumEvent;

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
        /// Binds datagridview1 to assignment list.
        /// </summary>
        /// <param name="assignmentList"></param>
        void SetAssignmentListBindingSource(BindingSource assignmentList);

        /// <summary>
        /// Binds listbox to module name list.
        /// </summary>
        /// <param name="moduleNameList"></param>
        void SetModuleNameListBindingSource(BindingSource moduleNameList);

        /// <summary>
        /// 
        /// </summary>
        void Show();
    }
}
