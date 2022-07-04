using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public interface IModuleView
    {
        string ModIdNum { get; set; }
        string ModName { get; set; }
        string ModDateYear { get; set; }

        event EventHandler AddModEvent;
        event EventHandler DeleteModEvent;
        event EventHandler EditModEvent;

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        void SetModuleListBindingSource(BindingSource moduleList);
        void Show();
    }
}
