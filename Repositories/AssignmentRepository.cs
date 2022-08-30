using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using LitRevResourceMVP.Models;
using System.Windows.Forms;
using System.Diagnostics;

namespace LitRevResourceMVP.Repositories
{
    /// <summary>
    /// SQL queries called by presenter for CRUD functionality.
    /// </summary>
    public class AssignmentRepository : BaseRepository,IAssignmentRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public AssignmentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        ///  SQL query INSERT: used to add the assignment data model to the database
        /// </summary>
        /// <param name="assignmentModel"></param>
        public void Add(AssignmentModel assignmentModel)
        {
            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    connection.Open();
            //    command.Connection = connection;
            //    command.CommandText = "INSERT INTO Assignment_table (Assign_Name,Assign_DueDate,Assign_Trimester,Mod_IdNum) VALUES (@assignname,@duedate,@trimester,@modIdNum)";
            //    command.Parameters.AddWithValue("@assignname", SqlDbType.VarChar).Value = assignmentModel.Assign_Name;
            //    command.Parameters.AddWithValue("@duedate", SqlDbType.VarChar).Value = assignmentModel.Due_Date;
            //    command.Parameters.AddWithValue("@trimester", SqlDbType.Int).Value = assignmentModel.Assign_Trimester;
            //    command.Parameters.AddWithValue("@modIdNum", SqlDbType.Int).Value = assignmentModel.Mod_IdNum;
            //    command.ExecuteNonQuery();
            //}
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                string queryAdd = "INSERT INTO Assignment_table (Assign_Name,Assign_DueDate,Assign_Trimester,Mod_IdNum) VALUES (@Assign_Name,@Due_Date,@Assign_Trimester,@Mod_IdNum)";
                assignmentModel = new AssignmentModel { Assign_Name = assignmentModel.Assign_Name, Due_Date = assignmentModel.Due_Date, Assign_Trimester = assignmentModel.Assign_Trimester, Mod_IdNum = assignmentModel.Mod_IdNum };
                conn.Execute(queryAdd, assignmentModel);
            }
        }

        /// <summary>
        /// SQL query DELETE: used to delete the assignment data model based on id number from the database
        /// </summary>
        /// <param name="assignIdNum"></param>
        public void Delete(int assignIdNum)
        {
            //will auto close connection when using 'using'.
            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    connection.Open();
            //    command.Connection = connection;
            //    command.CommandText = "DELETE FROM Assignment_table WHERE Assign_IdNum=@assignidnum";
            //    command.Parameters.AddWithValue("@assignidnum", SqlDbType.Int).Value = assignIdNum;
            //    command.ExecuteNonQuery();
            //}

            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                string queryDelete = "DELETE FROM Assignment_table WHERE Assign_IdNum = @assignidnum";
                //Debug.WriteLine("id number = "+ assignIdNum);
                conn.Execute(queryDelete, new { assignidnum = assignIdNum });
            }
        }

        /// <summary>
        /// SQL query UPDATE: used to edit assignment data in the database using the data model 
        /// </summary>
        /// <param name="assignmentModel"></param>
        public void Edit(AssignmentModel assignmentModel)
        {
            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    connection.Open();
            //    command.Connection = connection;
            //    command.CommandText = "UPDATE Assignment_table SET" +
            //        " Assign_Name=@assignname, Assign_DueDate=@duedate, Assign_Trimester=@trimester WHERE Assign_IdNum=@assignidnum";

            //    command.Parameters.AddWithValue("@assignidnum", SqlDbType.Int).Value = assignmentModel.Assign_IdNum;
            //    command.Parameters.AddWithValue("@assignname", SqlDbType.VarChar).Value = assignmentModel.Assign_Name;
            //    command.Parameters.AddWithValue("@duedate", SqlDbType.Date).Value = assignmentModel.Due_Date;
            //    command.Parameters.AddWithValue("@trimester", SqlDbType.Int).Value = assignmentModel.Assign_Trimester;
            //    command.Parameters.AddWithValue("@modidnum", SqlDbType.Int).Value = assignmentModel.Mod_IdNum;
            //    command.ExecuteNonQuery();
            //}
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                string queryEdit = "UPDATE Assignment_table SET Assign_Name=@assignname, Assign_DueDate=@duedate, Assign_Trimester=@trimester " +
                    "WHERE Assign_IdNum=@assignidnum";
                conn.Execute(queryEdit, param:new { 
                    assignname = assignmentModel.Assign_Name, 
                    duedate = assignmentModel.Due_Date, 
                    trimester = assignmentModel.Assign_Trimester, 
                    assignidnum = assignmentModel.Assign_IdNum }); 
               
            }
        }


        /// <summary>
        /// SQL query SELECT: retrieves assignment data from the database and return in an assignment list.
        /// This is called to display in a datagridview
        /// </summary>
        /// <param name="IdNum"></param>
        /// <returns>Assignment list</returns>
        public IEnumerable<AssignmentModel> GetAllAssignments(int IdNum)
        {
            //not pulling back date replaces with 01/01/0001 which throws exception but displays as blank in datagridview!!!
            //hover cursor and shows 01/01/0001
            //something to do with data type dapper mapping..cannot find solution so use sql
            //using (IDbConnection conn = new SqlConnection(connectionString))
            //{
            //    var output = conn.Query<AssignmentModel>("exec dbo.GetModAssignments_idNum @idNum", new { idNum = IdNum }).AsList();
            //    return output;
            //}
            var assignmentList = new List<AssignmentModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * from Assignment_table WHERE Mod_IdNum=@idNum ";
                command.Parameters.AddWithValue("@idnum", SqlDbType.Int).Value = IdNum;
                using (var reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            var assignmentModel = new AssignmentModel();
                            assignmentModel.Assign_IdNum = (int)reader[0];
                            assignmentModel.Assign_Name = reader[1].ToString();
                            assignmentModel.Due_Date = (DateTime)reader[2];
                            assignmentModel.Assign_Trimester = (int)reader[3];
                            assignmentModel.Mod_IdNum = (int)reader[4];
                            assignmentList.Add(assignmentModel);
                        }
                    }
                    catch (Exception ex)
                    {
                        string title = "Reading data from Assignment table";
                        MessageBox.Show("Error = " + ex.Message, title);
                    }
                }

            }
            return assignmentList;
        }

        /// <summary>
        /// SQL query SELECT: to retrieve distinct module names and display in a combobox for a user to select.
        /// Used to display assignments in a datagridview for the module selected.
        /// </summary>
        /// <returns>ModuleNameList</returns>
        public IEnumerable<string> GetAllModules()
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                var output = conn.Query<string>("exec dbo.GetModuleNames").AsList();
                return output;
            }

            //var moduleNameList = new List<string>();
            //string modname = "";
            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    try
            //    {
            //        connection.Open();
            //        command.Connection = connection;
            //        command.CommandText = "SELECT Mod_Name from Module_table order by Mod_Name desc";
            //        command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = modname;

            //        using (var reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                moduleNameList.Add(reader[0].ToString());
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        string title = "Reading data from Module table";
            //        MessageBox.Show("Error = " + ex.Message, title);
            //    }
            //}
            //return moduleNameList;
        }

        /// <summary>
        /// Retrieves id number of module from database where sql matches module name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>int idNum</returns>
        public int GetModIdNum(string name)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                int idnum = 0;
                string command = "SELECT Mod_IdNum from Module_table WHERE Mod_Name=@name";
                idnum = conn.ExecuteScalar<int>(command, param: new { name });
                return idnum;
            }

            //using (var connection = new SqlConnection(connectionString))
            //using (var command = new SqlCommand())
            //{
            //    try
            //    {
            //        connection.Open();
            //        command.Connection = connection;
            //        command.CommandText = "SELECT Mod_IdNum from Module_table WHERE Mod_Name=@modname";
            //        command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = name;

            //        using (var reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                idnum = (int) reader[0];
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        string title = "Reading data from Module table";
            //        MessageBox.Show("Error = " + ex.Message, title);
            //    }
            //}

            //return idnum;
        }
    }
}
