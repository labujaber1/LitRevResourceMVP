using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Views
{
    public interface IMainView
    {
        event EventHandler ShowResourceView;
        event EventHandler ShowAssignmentView;
        event EventHandler ShowModuleView;
        //others
    }
}
