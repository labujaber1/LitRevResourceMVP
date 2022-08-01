using System;
using System.Collections.Generic;


namespace LitRevResourceMVP.Models
{
    /// <summary>
    /// Module repository interface: SQL queries called by presenter for CRUD functionality.
    /// </summary>
    public interface IModuleRepository
    {
        /// <summary>
        ///  SQL query INSERT: used to add the module data model to the database directly, opens and closes connection.
        /// </summary>
        /// <param name="moduleModel"></param>
        void Add(ModuleModel moduleModel);

        /// <summary>
        /// SQL query DELETE: used to delete the module data model based on id number from the database directly, opens and closes connection.
        /// </summary>
        /// <param name="modIdNum"></param>
        void Delete(int modIdNum);

        /// <summary>
        /// SQL query UPDATE: used to edit module data in the database using the data model, opens and closes connection. 
        /// </summary>
        /// <param name="moduleModel"></param>
        void Edit(ModuleModel moduleModel);

        /// <summary>
        /// SQL query SELECT: retrieves module data from the database and return in a module list, opens and closes connection. 
        /// This is called to display in a datagridview.
        /// </summary>
        /// <returns>Module list</returns>
        IEnumerable<ModuleModel> GetAllModules();

    }
}
