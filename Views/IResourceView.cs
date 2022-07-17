using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    public interface IResourceView
    {
        string ResIdNum { get; set; }
        string ResWebLink { get; set; }
        LinkLabel ActiveWebLink { get; set; }
        string ResType { get; set; }
        string ResDoiNum { get; set; }
        string ResDateAccessed { get; set; }
        string ResCategory { get; set; }
        string ResReference { get; set; }
        string ResMainPoint { get; set; }
        string ResNotes { get; set; }
        string AssignIdNum { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //used in tab4 which is first seen to choose assignment fir tab1 to open
        event EventHandler ViewResourcesEvent;

        //used in tab1 main resource view
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SelectChangeEvent;

        //used in tab2 add/edit resource
        event EventHandler CreateReferenceEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event LinkLabelLinkClickedEventHandler LinkLabelEvent;

        void SetAssignmentListBindingSource(BindingSource assignData);
        void SetResourceListBindingSource(BindingSource resourceData);
        void SetCategoryListBindingSource(BindingSource categoryList);
        

        void Show();
        
    }
}
