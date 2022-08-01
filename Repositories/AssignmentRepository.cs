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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Assignment_table (Assign_Name,Assign_DueDate,Assign_Trimester,Mod_IdNum) VALUES (@assignname,@duedate,@trimester,@modIdNum)";
                command.Parameters.AddWithValue("@assignname", SqlDbType.VarChar).Value = assignmentModel.Assign_Name;
                command.Parameters.AddWithValue("@duedate", SqlDbType.VarChar).Value = assignmentModel.Due_Date;
                command.Parameters.AddWithValue("@trimester", SqlDbType.Int).Value = assignmentModel.Assign_Trimester;
                command.Parameters.AddWithValue("@modIdNum", SqlDbType.Int).Value = assignmentModel.Mod_IdNum;
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// SQL query DELETE: used to delete the assignment data model based on id number from the database
        /// </summary>
        /// <param name="assignIdNum"></param>
        public void Delete(int assignIdNum)
        {
            //will auto close connection when using 'using'.
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Assignment_table WHERE Assign_IdNum=@assignidnum";
                command.Parameters.AddWithValue("@assignidnum", SqlDbType.Int).Value = assignIdNum;
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// SQL query UPDATE: used to edit assignment data in the database using the data model 
        /// </summary>
        /// <param name="assignmentModel"></param>
        public void Edit(AssignmentModel assignmentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Assignment_table SET" +
                    " Assign_Name=@assignname, Assign_DueDate=@duedate, Assign_Trimester=@trimester WHERE Assign_IdNum=@assignidnum";

                command.Parameters.AddWithValue("@assignidnum", SqlDbType.Int).Value = assignmentModel.Assign_IdNum;
                command.Parameters.AddWithValue("@assignname", SqlDbType.VarChar).Value = assignmentModel.Assign_Name;
                command.Parameters.AddWithValue("@duedate", SqlDbType.VarChar).Value = assignmentModel.Due_Date;
                command.Parameters.AddWithValue("@trimester", SqlDbType.Int).Value = assignmentModel.Assign_Trimester;
                command.Parameters.AddWithValue("@modidnum", SqlDbType.Int).Value = assignmentModel.Mod_IdNum;
                command.ExecuteNonQuery();
            }
        }

        //public DataSet GetModAssignData()
        //{
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    DataSet data = new DataSet();
        //    try
        //    {
        //        //getting data for dataset
        //        data.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //        SqlDataAdapter moduleAdaptor = new SqlDataAdapter("SELECT * from Module_table", connection);
        //        moduleAdaptor.Fill(data, "Module_table");
        //        SqlDataAdapter assignAdaptor = new SqlDataAdapter("SELECT * from Assignment_table", connection);
        //        moduleAdaptor.Fill(data, "Assignment_table");
        //        //relationship between tables in dataset
        //        DataRelation relation = new DataRelation("ModuleAssignments",
        //            data.Tables["Module_table"].Columns["Mod_IdNum"],
        //            data.Tables["Assignment_table"].Columns["Mod_IdNum"]);
        //        data.Relations.Add(relation);

        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Sql connection error" + ex.Message,"SQL connection");
        //    }
        //    return data;
        //}

        /// <summary>
        /// SQL query SELECT: retrieves assignment data from the database and return in an assignment list.
        /// This is called to display in a datagridview
        /// </summary>
        /// <param name="IdNum"></param>
        /// <returns>Assignment list</returns>
        public IEnumerable<AssignmentModel> GetAllAssignments(int IdNum)
        {
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
            var moduleNameList = new List<string>();
            string modname = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Mod_Name from Module_table order by Mod_Name desc";
                    command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = modname;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           moduleNameList.Add(reader[0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    string title = "Reading data from Module table";
                    MessageBox.Show("Error = " + ex.Message, title);
                }
            }
            return moduleNameList;
        }

        /// <summary>
        /// Retrieves id number of module from database where sql matches module name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>int idNum</returns>
        public int GetModIdNum(string name)
        {
            int idnum = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Mod_IdNum from Module_table WHERE Mod_Name=@modname";
                    command.Parameters.AddWithValue("@modname", SqlDbType.VarChar).Value = name;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idnum = (int) reader[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    string title = "Reading data from Module table";
                    MessageBox.Show("Error = " + ex.Message, title);
                }
            }

            return idnum;
        }
    }
}
