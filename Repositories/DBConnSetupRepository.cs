using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using LitRevResourceMVP.Models;
using System.Windows.Forms;
using System.Diagnostics;

namespace LitRevResourceMVP.Repositories
{
    public class DBConnSetupRepository : BaseRepository,IDBConnSetupRepository
    {
        public DBConnSetupRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Attempt tp open a database connection using passed in connection string.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns>Bool true if opens connection else false</returns>
        public bool TestConnString(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        Cursor cursor = Cursor.Current;
                        Cursor.Current = Cursors.WaitCursor;
                        conn.Open();
                        Cursor.Current = Cursors.Default;
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    return false;
                }
            }
        }

        /// <summary>
        /// Retieves configuration connection strings from a set to a model list to be viewed in datagridview.
        /// </summary>
        /// <returns>DBConnSetupModel connString</returns>
        public IEnumerable<DBConnSetupModel> GetConnString()
        {
            var connString = new List<DBConnSetupModel>();
            //get all details and add to list
            ConnectionStringSettingsCollection set = ConfigurationManager.ConnectionStrings;
            if (set != null)
            {
                foreach (ConnectionStringSettings cs in set)
                {
                    var connModel = new DBConnSetupModel();
                    connModel.Name = cs.Name;
                    connModel.Connection_string = cs.ConnectionString;
                    connModel.Provider_Name = cs.ProviderName;
                    connString.Add(connModel);
                }
            }
            //and return list 
            return connString;
        }

        /// <summary>
        /// Saves constructed connection string and name to the app.config file at runtime.
        /// Code courtesy of h ttps://makolyte.com/how-to-modify-app-config-at-runtime/
        /// Used in presenter saveconn event to add new connstring
        /// </summary>
        /// <param name="name"></param>
        /// <param name="connectionString"></param>
        public void AddConnString(string name, string connectionString, string providerName)
        {
            var conStringSetting = new ConnectionStringSettings(name, connectionString, providerName);
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(conStringSetting);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        /// <summary>
        /// Edits constructed connection string and providername to the app.config file at runtime.
        /// Code courtesy of h ttps://makolyte.com/how-to-modify-app-config-at-runtime/.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="connectionString"></param>
        public void EditConnString(string name, string connectionString, string providerName)
        {
            //tried using index num passed in to substitute [name],[connectionString],[providerName] to no effect
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var section = (ConnectionStringsSection)config.GetSection("connectionStrings");
            section.ConnectionStrings[name].Name = name;
            section.ConnectionStrings[name].ConnectionString = connectionString;
            section.ConnectionStrings[name].ProviderName = providerName;
            Debug.WriteLine("Added conn string");
            config.Save(ConfigurationSaveMode.Modified);
            Debug.WriteLine("config.save ran");
        }

        /// <summary>
        /// Refresh connection string section called at end of presenter.EditConn method
        /// </summary>
        public void SaveRefreshConfig()
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            Debug.WriteLine("refresh section ran");
        }

        /// <summary>
        /// Delete connectionstring row from app.config
        /// </summary>
        /// <param name="name"></param>
        /// <param name="connectionString"></param>
        /// <param name="providerName"></param>
        /// <param name="num"></param>
        public void DeleteConnString(int num)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var section = (ConnectionStringsSection)config.GetSection("connectionStrings");
            config.ConnectionStrings.ConnectionStrings.RemoveAt(num);
            Debug.WriteLine("Delete conn string row ran");
            config.Save(ConfigurationSaveMode.Modified, true); //error access denied to update .dll
            Debug.WriteLine("config.save ran");
            ConfigurationManager.RefreshSection("connectionStrings");
            Debug.WriteLine("refresh section ran");
        }
    }
}
