using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Models
{
    /// <summary>
    /// Assignment repository interface: SQL queries used in presenter for CRUD functionality.
    /// </summary>
    public interface IAssignmentRepository

    {
        /// <summary>
        ///  SQL query INSERT: used to add the assignment data model to the database
        /// </summary>
        /// <param name="assignmentModel"></param>
        void Add(AssignmentModel assignmentModel);

        /// <summary>
        /// SQL query DELETE: used to delete the assignment data model based on id number from the database
        /// </summary>
        /// <param name="assignIdNum"></param>
        void Delete(int assignIdNum);

        /// <summary>
        /// SQL query UPDATE: used to edit assignment data in the database using the data model 
        /// </summary>
        /// <param name="assignmentModel"></param>
        void Edit(AssignmentModel assignmentModel);

        /// <summary>
        /// Retrieves id number of module from database where sql matches module name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>int idNum</returns>
        int GetModIdNum(string name);
        //DataSet GetModAssignData();

        /// <summary>
        /// SQL query SELECT: to retrieve distinct module names and display in a combobox for a user to select.
        /// Used to display assignments in a datagridview for the module selected.
        /// </summary>
        /// <returns>ModuleNameList</returns>
        IEnumerable<string> GetAllModules();

        /// <summary>
        /// SQL query SELECT: retrieves assignment data from the database and return in an assignment list.
        /// This is called to display in a datagridview
        /// </summary>
        /// <param name="IdNum"></param>
        /// <returns>Assignment list</returns>
        IEnumerable<AssignmentModel> GetAllAssignments(int IdNum);
        
    }
}
