using System.Collections.Generic;

namespace LitRevResourceMVP.Models
{
    /// <summary>
    /// DB connection setup repository interface: CRUD functionality to config.app file
    /// </summary>
    public interface IDBConnSetupRepository
    {
        //IEnumerable<string> GetConnString();

        /// <summary>
        /// Retieves configuration connection strings from a set to a model list to be viewed in datagridview.
        /// </summary>
        /// <returns>DBConnSetupModel connString</returns>
        IEnumerable<DBConnSetupModel> GetConnString();

        /// <summary>
        /// Saves constructed connection string and name to the app.config file at runtime.
        /// Code courtesy of h ttps://makolyte.com/how-to-modify-app-config-at-runtime/
        /// Used in presenter saveconn event to add new connstring
        /// </summary>
        /// <param name="name"></param>
        /// <param name="providerName"></param>
        /// <param name="connectionString"></param>
        void AddConnString(string name, string connectionString, string providerName);

        /// <summary>
        /// Edits constructed connection string and providername to the app.config file at runtime.
        /// Code courtesy of h ttps://makolyte.com/how-to-modify-app-config-at-runtime/.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="connectionString"></param>
        /// <param name="providerName"></param>
        void EditConnString(string name, string connectionString, string providerName);

        /// <summary>
        /// Attempt tp open a database connection using passed in connection string.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns>Bool true if opens connection else false</returns>
        bool TestConnString(string connectionString);

        /// <summary>
        /// Delete connectionstring row from app.config
        /// </summary>
        /// <param name="num"></param>
        void DeleteConnString(int num);

        /// <summary>
        /// Refresh connection string section called at end of presenter.EditConn method
        /// </summary>
        void SaveRefreshConfig();
    }
}
