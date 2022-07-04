using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public interface IAssignmentView
    {
        string AssignIdNum { get; set; }
        string AssignName { get; set; }
        DateTime DueDate { get; set; }
        string Trimester { get; set; }
        string ModIdNum { get; set; }
        string SelectedModName { get; set; }

        event EventHandler SaveAssignEvent;
        event EventHandler DeleteAssignEvent;
        event EventHandler EditAssignEvent;
        event EventHandler DisplayModIdNumEvent;
        

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        

        void SetAssignmentListBindingSource(BindingSource assignmentList);
        void SetModuleNameListBindingSource(BindingSource moduleNameList);
        void Show();
    }
}
