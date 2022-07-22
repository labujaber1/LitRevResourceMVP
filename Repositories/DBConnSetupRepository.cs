using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LitRevResourceMVP.Models;
using System.Windows.Forms;

namespace LitRevResourceMVP.Repositories
{
    public class DBConnSetupRepository : BaseRepository,IDBConnSetupRepository
    {
        public DBConnSetupRepository(string connectionString) //????? to test
        {
            this.connectionString = connectionString;

        }

        /// <summary>
        /// Retrieves connection string from file and returns in a list to load in listbox
        /// </summary>
        /// <returns>List connString</returns>
        public IEnumerable<string> GetConnString()
        {
            var connString = new List<string>();
            //get conn file,


            //read to list,


            //and return list 
            return connString;
        }

        //save list string to file
    }
}
