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
    public class CopyResourceRepository : BaseRepository, IResourceRepository
    {
        //create instance of dataset: represents complete set of data including tables,relationships and is independant
        //of datasource. Can also include data local to app and from multiple sources.
        //Dataset [name ie resources] = new Dataset("name ie Resources");
        //interaction to existing data source controlled via DataAdapter
        //SelectCommand gets data from datasource, fill method populates dataset using selectcommand, uses datareader
        //
        //Also InsertCommand,UpdateCommand,DeleteCommand 

        //constructor
        public CopyResourceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        /// <summary>
        /// SQL query INSERT: used to add the resource data model to the database
        /// </summary>
        /// <param name="resourceModel"></param>
        public void Add(ResourceModel resourceModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Resource_table " +
                    "(Res_Weblink,Res_Type,Res_DateAccessed,Res_Category, Res_Reference,Res_MainPoint,Res_Notes,Assign_IdNum)" +
                    " VALUES (@weblink,@restype,@doinum,@dateaccessed,@category,@reference,@mainpoint,@notes,@assignIdNum)" +
                    "WHERE Assign_IdNum=@assignIdNum";
                command.Parameters.AddWithValue("@weblink", SqlDbType.VarChar).Value = resourceModel.Web_Link;
                command.Parameters.AddWithValue("@restype", SqlDbType.VarChar).Value = resourceModel.Resource_Type;
                command.Parameters.AddWithValue("@doinum", SqlDbType.VarChar).Value = resourceModel.DOI_Num;
                command.Parameters.AddWithValue("@dateaccessed", SqlDbType.VarChar).Value = resourceModel.Date_Accessed;
                command.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = resourceModel.Category;
                command.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = resourceModel.Reference;
                command.Parameters.AddWithValue("@mainpoint", SqlDbType.VarChar).Value = resourceModel.Main_Point;
                command.Parameters.AddWithValue("@notes", SqlDbType.VarChar).Value = resourceModel.Main_Notes;
                command.Parameters.AddWithValue("@assignIdNum", SqlDbType.VarChar).Value = resourceModel.Assign_IdNum;
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// SQL query DELETE: used to delete the resource data model based on id number from the database
        /// </summary>
        /// <param name="idNum"></param>
        public void Delete(int idNum)
        {
            //will auto close connection when using 'using'.
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Resource_table WHERE Res_IdNum=@residnum";
                command.Parameters.AddWithValue("@residnum", SqlDbType.Int).Value = idNum;
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// SQL query UPDATE: used to edit resource data in the database using the data model 
        /// </summary>
        /// <param name="resourceModel"></param>
        public void Edit(ResourceModel resourceModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Resource_table SET" +
                    " Res_WebLink=@weblink, Res_Type=@restype, Res_DoiNum=@doinum, Res_DateAccessed=@dateaccessed," +
                    "Res_Category=@category, Res_Reference=@reference, Res_MainPoint=@mainpoint, Res_Notes=@notes " +
                    "WHERE Res_IdNum=@idnum";
                command.Parameters.AddWithValue("@idnum", SqlDbType.Int).Value = resourceModel.ID_Num;
                command.Parameters.AddWithValue("@weblink", SqlDbType.VarChar).Value = resourceModel.Web_Link;
                command.Parameters.AddWithValue("@restype", SqlDbType.VarChar).Value = resourceModel.Resource_Type;
                command.Parameters.AddWithValue("@doinum", SqlDbType.VarChar).Value = resourceModel.DOI_Num;
                command.Parameters.AddWithValue("@dateaccessed", SqlDbType.DateTime).Value = resourceModel.Date_Accessed;
                command.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = resourceModel.Category;
                command.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = resourceModel.Reference;
                command.Parameters.AddWithValue("@mainpoint", SqlDbType.VarChar).Value = resourceModel.Main_Point;
                command.Parameters.AddWithValue("@notes", SqlDbType.VarChar).Value = resourceModel.Main_Notes;
                command.Parameters.AddWithValue("@assignIdNum", SqlDbType.VarChar).Value = resourceModel.Assign_IdNum;
                command.ExecuteNonQuery();
            }
        }

        
        
        public IEnumerable<AssignmentModel> GetAllAssignmentsList()
        {
            var assignmentList = new List<AssignmentModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * from Assignment_table  ";
                
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
                        MessageBox.Show( "Error = " + ex.Message, title);
                    }
                }

            }
            return assignmentList;

        }
        
        /// <summary>
        /// SQL query SELECT: retrieves resource data from the database and return in a resource list.
        /// This is called to display in a datagridview
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ResourceModel> GetAllResources(int IdNum)
        {
            var resourceList = new List<ResourceModel>();
            using (var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Resource_table WHERE Assign_IdNum=@idNum";
                command.Parameters.AddWithValue("@idnum", SqlDbType.Int).Value = IdNum;
                using (var reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            var resourceModel = new ResourceModel();
                            resourceModel.ID_Num = (int)reader[0];
                            resourceModel.Web_Link = reader[1].ToString();
                            resourceModel.Resource_Type = reader[2].ToString();
                            resourceModel.DOI_Num = reader[3].ToString();
                            resourceModel.Date_Accessed = (DateTime)reader[4];
                            resourceModel.Category = reader[5].ToString();
                            resourceModel.Reference = reader[6].ToString();
                            resourceModel.Main_Point = reader[7].ToString();
                            resourceModel.Main_Notes = reader[8].ToString();
                            resourceModel.Assign_IdNum = (int)reader[9];
                            resourceList.Add(resourceModel);
                        }
                    }
                    catch (Exception ex)
                    {
                        string title = "Reading data from Resource table";
                        MessageBox.Show("Error = " + ex.Message, title);
                    }
                }
                
            }
            return resourceList;
        }

        /// <summary>
        /// SQL query SELECT: retrieves data from a search method by using either an id number or category request.
        /// This is called to display in a datagridview
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IEnumerable<ResourceModel> GetByValue(string value)
        {
            var resourceList = new List<ResourceModel>();
            int resIdNum = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string resCategory = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Select * from Resource_table " +
                        "Where Res_IdNum = @idnum or Res_Category like @category+'%'" +
                        "order by Res_Category desc";
                    command.Parameters.AddWithValue("@idnum", SqlDbType.Int).Value = resIdNum;
                    command.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = resCategory;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var resourceModel = new ResourceModel();
                            resourceModel.ID_Num = (int)reader[0];
                            resourceModel.Web_Link = reader[1].ToString();
                            resourceModel.Resource_Type = reader[2].ToString();
                            resourceModel.DOI_Num = reader[3].ToString();
                            resourceModel.Date_Accessed = (DateTime)reader[4];
                            resourceModel.Category = reader[5].ToString();
                            resourceModel.Reference = reader[6].ToString();
                            resourceModel.Main_Point = reader[7].ToString();
                            resourceModel.Main_Notes = reader[8].ToString();
                            resourceModel.Assign_IdNum = (int)reader[9];
                            resourceList.Add(resourceModel);
                        }
                    }
                }catch (Exception ex)
                {
                    string title = "Getting by category";
                    MessageBox.Show("Error = "+ex.Message,title);
                }
            }
            return resourceList;
        }

        /// <summary>
        /// SQL query DISTINCT: retrieves distinct category names and returns in a list to display in a textbox for user reference. 
        /// Each resource includes this field which may be used to group resources together in a search event.
        /// The categories are not preset but taken from resource creation.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllCategories()
        {
            var categoryList = new List<string>();
            string resCategory = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT DISTINCT Res_Category FROM Resource_table " +
                        "order by Res_Category desc";
                    command.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = resCategory;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryList.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    string title = "Getting list of categories";
                    MessageBox.Show("Error = " + ex.Message, title);
                }
            }
            return categoryList;
        }

        // ######### CHANGED TO DATASET RATHER THAN ILIST AS ABOVE #############

        //call at start of presenter and use in methods to add,edit,delete,display
        public DataSet GetAllAssignmentsData()
        {
            DataSet ds;
            using (var connection = new SqlConnection(connectionString))
            using (SqlCommand comm = new SqlCommand())
            {
                connection.Open();
                comm.Connection = connection;
                comm.CommandText = "SELECT * from Assignment_table;SELECT * from Resource_table";

                using (SqlDataAdapter sqlda = new SqlDataAdapter(comm))
                {
                    sqlda.TableMappings.Add("Assign_table", "Assignments");
                    sqlda.TableMappings.Add("Resource_table", "Resources");

                    using (ds = new DataSet())
                    {
                        sqlda.Fill(ds);
                    }
                }
            }
            return ds;
        }
    }
}
