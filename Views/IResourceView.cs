using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Resource view interface 
    /// </summary>
    public interface IResourceView
    {
        /// <summary>
        /// Resource ID: Tbx_IdNum.Text
        /// </summary>
        string ResIdNum { get; set; }
        /// <summary>
        /// Resource web address: Tbx_WebLink.Text
        /// </summary>
        string ResWebLink { get; set; }
        /// <summary>
        /// Resource website link label: Lklbl_WebLink
        /// </summary>
        LinkLabel ActiveWebLink { get; set; }
        /// <summary>
        /// Resource type:Tbx_Type.Text
        /// </summary>
        string ResType { get; set; }
        /// <summary>
        /// Resource search term: Tbx_SearchTerm.Text
        /// </summary>
        string ResSearchTerm { get; set; }
        /// <summary>
        /// Resource DOI number: Tbx_DoiNum.Text
        /// </summary>
        string ResDoiNum { get; set; }
        /// <summary>
        /// Resource accessed date: dateTimePicker1.Value.Date
        /// </summary>
        DateTime ResDateAccessed { get; set; }
        /// <summary>
        /// Resource referenced in file: Tbx_RefInFile.Text
        /// </summary>
        string ResRefInFile { get; set; }
        /// <summary>
        /// Resource category: Tbx_NewCategory.Text
        /// </summary>
        string ResCategory { get; set; }
        /// <summary>
        /// Resource pasted/self written reference: Tbx_Reference.Text
        /// </summary>
        string ResReference { get; set; }
        /// <summary>
        /// Resource main point text max 2000 chars:
        /// Rtbx_MainPoint.Text
        /// </summary>
        string ResMainPoint { get; set; }
        /// <summary>
        /// Resource additional notes max 3000 chars:
        /// Rtbx_Notes.Text
        /// </summary>
        string ResNotes { get; set; }
        /// <summary>
        /// Assignment ID (FK): Tbx_AssignIdNum.Text
        /// </summary>
        string AssignIdNum { get; set; }
        /// <summary>
        /// Resource ID or category search value:
        /// Tbx_Search.Text
        /// </summary>
        string SearchValue { get; set; }
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

        //used in tab4 which is first seen to choose assignment fir tab1 to open
        /// <summary>
        /// View resources event handler
        /// </summary>
        event EventHandler ViewResourcesEvent;

        //used in tab1 main resource view
        /// <summary>
        /// Search resource event handler
        /// </summary>
        event EventHandler SearchEvent;
        /// <summary>
        /// Add new resource event handler
        /// </summary>
        event EventHandler AddNewEvent;
        /// <summary>
        /// Edit resource event handler
        /// </summary>
        event EventHandler EditEvent;
        /// <summary>
        /// Delete resource event handler
        /// </summary>
        event EventHandler DeleteEvent;

        //used in tab2 add/edit resource
        /// <summary>
        /// Create reference event handler
        /// </summary>
        event EventHandler CreateReferenceEvent;
        /// <summary>
        /// Save resource event handler
        /// </summary>
        event EventHandler SaveEvent;
        /// <summary>
        /// Cancel new resource event handler
        /// </summary>
        event EventHandler CancelEvent;
        /// <summary>
        /// Display website as a link event
        /// </summary>
        event LinkLabelLinkClickedEventHandler LinkLabelEvent;
        /// <summary>
        /// View total characters used
        /// </summary>
        event EventHandler MainCharLenEvent;
        /// <summary>
        /// View total characters used
        /// </summary>
        event EventHandler NotesCharLenEvent;
        /// <summary>
        /// Binds assignment datagridview to assignData source
        /// </summary>
        /// <param name="assignData"></param>
        void SetAssignmentListBindingSource(BindingSource assignData);

        /// <summary>
        /// Binds resource datagridview to resourceData source
        /// </summary>
        /// <param name="resourceData"></param>
        void SetResourceListBindingSource(BindingSource resourceData);

        /// <summary>
        /// Binds category list box to categoryList source
        /// </summary>
        /// <param name="categoryList"></param>
        void SetCategoryListBindingSource(BindingSource categoryList);
        
        /// <summary>
        /// 
        /// </summary>
        void Show();
        
    }
}
