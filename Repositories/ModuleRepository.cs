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
    public class ModuleRepository : BaseRepository, IModuleRepository
    { 
        public ModuleRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //int modIdNum;
        //string modName;

        /// <summary>
        ///  SQL query INSERT: used to add the module data model to the database
        /// </summary>
        /// <param name="moduleModel"></param>
        public void Add(ModuleModel moduleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Module_table (Mod_Name,Mod_DateYear) VALUES (@modname,@moddateyear)";
                command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = moduleModel.Mod_Name;
                command.Parameters.AddWithValue("@moddateyear", SqlDbType.VarChar).Value = moduleModel.Mod_DateYear;
                command.ExecuteNonQuery();
            };
        }

        /// <summary>
        /// SQL query DELETE: used to delete the module data model based on id number from the database
        /// </summary>
        /// <param name="modIdNum"></param>
        public void Delete(int modIdNum)
        {
            //will auto close connection when using 'using'.
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Module_table WHERE Mod_IdNum=@modidnum";
                command.Parameters.AddWithValue("@modidnum", SqlDbType.Int).Value = modIdNum;
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// SQL query UPDATE: used to edit module data in the database using the data model 
        /// </summary>
        /// <param name="moduleModel"></param>
        public void Edit(ModuleModel moduleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                //Mod_IdNum=@modidnum,
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Module_table SET" +
                    " Mod_Name=@modname, Mod_DateYear=@moddateyear WHERE Mod_IdNum=@modidnum";
                command.Parameters.AddWithValue("@modidnum", SqlDbType.Int).Value = moduleModel.Mod_IdNum;
                command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = moduleModel.Mod_Name;
                command.Parameters.AddWithValue("@moddateyear", SqlDbType.VarChar).Value = moduleModel.Mod_DateYear;
                
                command.ExecuteNonQuery();
            };
        }

        /// <summary>
        /// SQL query SELECT: retrieves module data from the database and return in a module list.
        /// This is called to display in a datagridview
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ModuleModel> GetAllModules()
        {
            var moduleList = new List<ModuleModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Module_table";

                using (var reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            var moduleModel = new ModuleModel();
                            moduleModel.Mod_IdNum = (int)reader[0];
                            moduleModel.Mod_Name = reader[1].ToString();
                            moduleModel.Mod_DateYear = reader[2].ToString();
                            moduleList.Add(moduleModel);
                        }
                    }
                    catch (Exception ex)
                    {
                        string title = "Reading data from Module table";
                        MessageBox.Show("Error = " + ex.Message, title);
                    }
                }

            }
            return moduleList;
        }
    }
}
