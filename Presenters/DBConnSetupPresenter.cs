using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Views;

namespace LitRevResourceMVP.Presenters
{
    /// <summary>
    /// Database setup presenter to invoke view events and action repository business logic
    /// </summary>
    public class DBConnSetupPresenter
    {
        private IDBConnSetupView view;
        private IDBConnSetupRepository repository;
        private BindingSource connectionFileBindingSource;
        private BindingSource saveToConnFileBindingSource;
        private IEnumerable<DBConnSetupModel> connStringFromModelFile;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repository"></param>
        public DBConnSetupPresenter(IDBConnSetupView view, IDBConnSetupRepository repository)
        {
            this.connectionFileBindingSource = new BindingSource();
            this.saveToConnFileBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.DeleteEvent += DeleteConn;
            this.view.EditEvent += EditConn;
            this.view.SaveEvent += SaveConn;
            this.view.TestConnEvent += TestConn;
            
            this.view.SetConnectionFileBindingSource(connectionFileBindingSource);
            this.view.SetSaveConnToFileBindingSource(saveToConnFileBindingSource);
            LoadConnectionFile();
            this.view.Show();
        }

        /// <summary>
        /// Binding source to load connection strings from app.config to datagridview
        /// </summary>
        private void LoadConnectionFile()
        {
            connStringFromModelFile = repository.GetConnString();
            connectionFileBindingSource.DataSource = connStringFromModelFile;
        }

        /// <summary>
        /// Delete selected connection row in datagridview and app.config
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteConn(object sender, EventArgs e)
        {
            try
            {
                int num = view.IndexRow;
                repository.DeleteConnString(num);   //app.config
                view.DeleteDataGridRow();         //datagridview
                view.IsSuccessful = true;
                view.Message = "Deleted successfully";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not perform the delete request due to an error. "+ex.Message;
            }
        }

        //save entire datagridview contents to model and call repo method to add to app.config, rename to saveedit
        /// <summary>
        /// Save edited data in datagridview to app.config using model list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditConn(object sender, EventArgs e)
        {
            try
            {
                saveToConnFileBindingSource.DataSource = connStringFromModelFile;
                var model = connStringFromModelFile;
                if (model != null)
                {
                    foreach (DBConnSetupModel item in model)
                    {
                        string name = item.Name;
                        string connectionString = item.Connection_string;
                        string providerName = item.Provider_Name;
                        repository.EditConnString(name, connectionString, providerName);
                        //Debug.WriteLine("Foreach loop ==> \nName = " + name + "\nConn String = " + connectionString + "\nProvider = " + providerName);
                    }
                    repository.SaveRefreshConfig();
                    view.IsSuccessful = true;
                    view.Message = "Edit save was success";
                    
                }
                else { view.Message = "Something went wrong as theres no data so failed to update app.config"; }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not perform the edit save request due to an error. " + ex.Message;
            }
            
        }

        

        /// <summary>
        /// Constructs a connection string in correct format and passes it to SaveConnString method to 
        /// save to app.config file at runtime. Reloads listbox with app.config data and clears all textbox controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveConn(object sender, EventArgs e)
        {
            string name = view.SqlName;
            string providerName = view.ProviderName;
            try
            {
                var sqlConBuilder = new SqlConnectionStringBuilder()
                {
                    InitialCatalog = view.InitCat,
                    DataSource = view.DataSource,
                    IntegratedSecurity = view.IntegSec
                };
                repository.AddConnString(name, sqlConBuilder.ConnectionString, providerName);
                view.IsSuccessful = true;
                view.Message = "Save was success";
                LoadConnectionFile();
                ClearTextFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not perform the save request due to an error. " + ex.Message;
            }
        }

        /// <summary>
        /// Test connection string event to open database connection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestConn(object sender, EventArgs e)
        {
            string title = "Connection test";
            if (view.ConnectionString.Length > 30)
            {
               bool res = repository.TestConnString(view.ConnectionString);
                
                if (res == true)
                    MessageBox.Show("Connection successful",title);
                else
                    MessageBox.Show("Connection failed",title);
                ClearTextFields();
            }
        }

        /// <summary>
        /// Reset textbox fields to empty
        /// </summary>
        private void ClearTextFields()
        {
            view.SqlName = "";
            view.ProviderName = "";
            view.ConnectionString = "";
            view.DataSource = "";
            view.InitCat = "";
            view.UserId = "";
            view.Password = "";
        }
    }
}
