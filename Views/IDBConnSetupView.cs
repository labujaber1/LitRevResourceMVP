using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public interface IDBConnSetupView
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string SqlName { get; set; }
        string DataSource { get; set; }
        string DBName { get; set; }
        string IntSec { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

        void Show();

        event EventHandler SaveEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler TestConnEvent;
        void SetConnectionFileBindingSource(BindingSource connectionFile);


    }
}
