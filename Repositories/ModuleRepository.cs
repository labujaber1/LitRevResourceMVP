using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using LitRevResourceMVP.Models;


namespace LitRevResourceMVP.Repositories
{
    /// <summary>
    /// SQL queries called by presenter for CRUD functionality. 
    /// </summary>
    public class ModuleRepository : BaseRepository, IModuleRepository
    { 
        /// <summary>
        ///  
        /// </summary>
        /// <param name="connectionString"></param>
        public ModuleRepository(string connectionString)
        {
            this.connectionString = connectionString;
            //Debug.WriteLine("Connection string = " + connectionString);
        }

        /// <summary>
        ///  SQL query INSERT: used to add the module data model to the database directly, opens and closes connection.
        /// </summary>
        /// <param name="moduleModel"></param>
        public void Add(ModuleModel moduleModel)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                moduleModel = new ModuleModel { Mod_Name = moduleModel.Mod_Name, Mod_DateYear = moduleModel.Mod_DateYear };
                conn.Execute("dbo.AddModule @Mod_Name, @Mod_DateYear", moduleModel);
            }

            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    connection.Open();
            //    command.Connection = connection;
            //    command.CommandText = "INSERT INTO Module_table (Mod_Name,Mod_DateYear) VALUES (@modname,@moddateyear)";
            //    command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = moduleModel.Mod_Name;
            //    command.Parameters.AddWithValue("@moddateyear", SqlDbType.VarChar).Value = moduleModel.Mod_DateYear;
            //    command.ExecuteNonQuery();
            //};
        }

        /// <summary>
        /// SQL query DELETE: used to delete the module data model based on id number from the database directly, opens and closes connection.
        /// </summary>
        /// <param name="modIdNum"></param>
        public void Delete(int modIdNum)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                conn.Execute("dbo.DeleteModule @ModIdNum", new { ModIdNum = modIdNum });
            }

            //will auto close connection when using 'using'.
            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    connection.Open();
            //    command.Connection = connection;
            //    command.CommandText = "DELETE FROM Module_table WHERE Mod_IdNum=@modidnum";
            //    command.Parameters.AddWithValue("@modidnum", SqlDbType.Int).Value = modIdNum;
            //    command.ExecuteNonQuery();
            //}
        }

        /// <summary>
        /// SQL query UPDATE: used to edit module data in the database using the data model, opens and closes connection. 
        /// </summary>
        /// <param name="moduleModel"></param>
        public void Edit(ModuleModel moduleModel)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                moduleModel = new ModuleModel { Mod_Name = moduleModel.Mod_Name, Mod_DateYear = moduleModel.Mod_DateYear, Mod_IdNum = moduleModel.Mod_IdNum };
                conn.Execute("dbo.EditModule @Mod_Name,@Mod_DateYear,@Mod_IdNum", moduleModel);
            }

            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    //Mod_IdNum=@modidnum,
            //    connection.Open();
            //    command.Connection = connection;
            //    command.CommandText = "UPDATE Module_table SET" +
            //        " Mod_Name=@modname, Mod_DateYear=@moddateyear WHERE Mod_IdNum=@modidnum";
            //    command.Parameters.AddWithValue("@modidnum", SqlDbType.Int).Value = moduleModel.Mod_IdNum;
            //    command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = moduleModel.Mod_Name;
            //    command.Parameters.AddWithValue("@moddateyear", SqlDbType.VarChar).Value = moduleModel.Mod_DateYear;

            //    command.ExecuteNonQuery();
            //};
        }

        /// <summary>
        /// SQL query SELECT: retrieves module data from the database and return in a module list, opens and closes connection. 
        /// This is called to display in a datagridview.
        /// </summary>
        /// <returns>Module list</returns>
        public IEnumerable<ModuleModel> GetAllModules()
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                
               //conn.Query<ModuleModel>("Select * from Module_table").ToList();
               //var output = conn.Query<ModuleModel>($"Select * from Module_table").AsList();
               //using stored procedure without parameter..IEnum = aslist, List = tolist
                var output = conn.Query<ModuleModel>("dbo.GetAllModules").AsList();
               //..with parameters
               //var output = conn.Query<ModuleModel>("dbo.GetModAssignments @idNum", new { Mod_IdNum = idNum }).AsList();
                return output;
            }


                //var moduleList = new List<ModuleModel>();
                //using (var connection = new SqlConnection(connectionString))
                //using (var command = new SqlCommand())
                //{
                //    connection.Open();
                //    command.Connection = connection;
                //    command.CommandText = "Select * from Module_table";

                //    using (var reader = command.ExecuteReader())
                //    {
                //        try
                //        {
                //            while (reader.Read())
                //            {
                //                var moduleModel = new ModuleModel();
                //                moduleModel.Mod_IdNum = (int)reader[0];
                //                moduleModel.Mod_Name = reader[1].ToString();
                //                moduleModel.Mod_DateYear = reader[2].ToString();
                //                moduleList.Add(moduleModel);
                //            }
                //        }
                //        catch (Exception ex)
                //        {
                //            string title = "Reading data from Module table";
                //            MessageBox.Show("Error = " + ex.Message, title);
                //        }
                //    }

                //}
                //return moduleList;
        }
    }
}
