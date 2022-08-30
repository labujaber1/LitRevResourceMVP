using System;
using System.Windows.Forms;

namespace LitRevResourceMVP.Views
{
    /// <summary>
    /// Database view setup interface 
    /// </summary>
    public interface IDBConnSetupView
    {
        /// <summary>
        /// Bool successful flag
        /// </summary>
        bool IsSuccessful { get; set; }
        /// <summary>
        /// Returns stated message
        /// </summary>
        string Message { get; set; }
        /// <summary>
        /// Connection name: Tbx_SqlName.Text
        /// </summary>
        string SqlName { get; set; }
        /// <summary>
        /// Connection provider name: Tbx_Provider.Text
        /// </summary>
        string ProviderName { get; set; }
        /// <summary>
        /// Returns connection string used to test connection:
        /// dataGridView1.CurrentCell.Value.ToString()
        /// </summary>
        string ConnectionString { get; set; }
        /// <summary>
        /// Connection data source: Tbx_DataSource.Text
        /// </summary>
        string DataSource { get; set; }
        /// <summary>
        /// Connection initial category: Tbx_InitCat.Text
        /// </summary>
        string InitCat { get; set; }
        /// <summary>
        /// Connection integrated security: Convert.ToBoolean(Tbx_IntegSec.Text)
        /// </summary>
        bool IntegSec { get; set; }
        /// <summary>
        /// Connection security user name: Tbx_UserName.Text
        /// </summary>
        string UserId { get; set; }
        /// <summary>
        /// Connection security password: Tbx_Password.Text
        /// </summary>
        string Password { get; set; }
        /// <summary>
        /// Returns index of selected item: 
        /// dataGridView1.CurrentCell.RowIndex
        /// </summary>
        int IndexRow { get; set; }
        /// <summary>
        /// Deletes row in datagridview by index of selected cell
        /// </summary>
        void DeleteDataGridRow();
        /// <summary>
        /// 
        /// </summary>
        void Show();
        /// <summary>
        /// Save connection string event handler
        /// </summary>
        event EventHandler SaveEvent;
        /// <summary>
        /// Edit connection string event handler
        /// </summary>
        event EventHandler EditEvent;
        /// <summary>
        /// Delete connection string event handler
        /// </summary>
        event EventHandler DeleteEvent;
        /// <summary>
        /// Test connection string event handler
        /// </summary>
        event EventHandler TestConnEvent;
        /// <summary>
        /// Used to bind db model list to datagridview
        /// </summary>
        /// <param name="connectionFile"></param>
        void SetConnectionFileBindingSource(BindingSource connectionFile);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saveToConnFile"></param>
        void SetSaveConnToFileBindingSource(BindingSource saveToConnFile);

    }
}
