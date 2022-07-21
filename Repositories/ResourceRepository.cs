using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using LitRevResourceMVP.Models;
using System.Windows.Forms;

namespace LitRevResourceMVP.Repositories
{
    public class ResourceRepository : BaseRepository, IResourceRepository
    {
        
        //constructor
        public ResourceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //call at start of presenter to display assignments and resources tables in both datagridviews
        /// <summary>
        /// Adds assignment and resources tables to dataset using sqlDataAdapter 
        /// </summary>
        /// <returns>Dataset AssignResDataSet</returns>
        public DataSet GetDataSet()
        {
            DataSet ds;
            using (var connection = new SqlConnection(connectionString))
            using (SqlCommand comm = new SqlCommand())
            {
                connection.Open();
                comm.Connection = connection;
                comm.CommandText = "SELECT * from Assignment_table;SELECT * from Resource_table";

                using (SqlDataAdapter sqlda = new SqlDataAdapter(comm))
                using (ds = new DataSet("AssignResDataSet"))
                {
                    sqlda.Fill(ds);
                }
            }
            return ds;
        }

        /// <summary>
        /// Adds a new row of resources data to table1 in dataset ("AssignResDataSet").
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <param name="AssignResDataSet"></param>
        public void Add(ResourceModel resourceModel, DataSet AssignResDataSet)
        {
            if (AssignResDataSet.Tables[1] != null)
            { 
                DataRow dr = AssignResDataSet.Tables[1].NewRow();
                dr["Res_Weblink"] = resourceModel.Web_Link;
                dr["Res_Type"] = resourceModel.Resource_Type;
                dr["Res_DoiNum"] = resourceModel.DOI_Num;
                dr["Res_DateAccessed"] = resourceModel.Date_Accessed;
                dr["Res_Category"] = resourceModel.Category;
                dr["Res_Reference"] = resourceModel.Reference;
                dr["Res_MainPoint"] = resourceModel.Main_Point;
                dr["Res_Notes"] = resourceModel.Main_Notes;
                dr["Assign_IdNum"] = resourceModel.Assign_IdNum;
                AssignResDataSet.Tables[1].Rows.Add(dr);
            }
        }

        /// <summary>
        /// Deletes a row of resources data from table1 in dataset ("AssignResDataSet"). Passes idnum for selection. 
        /// </summary>
        /// <param name="idNum"></param>
        /// <param name="AssignResDataSet"></param>
        public void Delete(int idNum, DataSet AssignResDataSet)
        {
            DataTable dt = AssignResDataSet.Tables[1];
            DataRow[] dr = dt.Select("Res_IdNum = '"+ idNum +"'");
            for (int i = 0;i< dr.Length;i++)
            {
                dr[i].Delete(); //mark row as delete, dt.AcceptChanges() 
            }
        }

        /// <summary>
        /// Edits a row of resources data from table1 in dataset ("AssignResDataSet"). Passes idnum for selection.
        /// </summary>
        /// <param name="idNum"></param>
        /// <param name="resourceModel"></param>
        /// <param name="AssignResDataSet"></param>
        public void Edit(int idNum,ResourceModel resourceModel, DataSet AssignResDataSet)
        {
            DataTable dt = AssignResDataSet.Tables[1];
            DataRow dr = dt.Select("Res_IdNum = '" + idNum + "'").FirstOrDefault();
            if (dr != null)
            {
                dr["Res_Weblink"] = resourceModel.Web_Link;
                dr["Res_Type"] = resourceModel.Resource_Type;
                dr["Res_DoiNum"] = resourceModel.DOI_Num;
                dr["Res_DateAccessed"] = resourceModel.Date_Accessed;
                dr["Res_Category"] = resourceModel.Category;
                dr["Res_Reference"] = resourceModel.Reference;
                dr["Res_MainPoint"] = resourceModel.Main_Point;
                dr["Res_Notes"] = resourceModel.Main_Notes;
                dr["Assign_IdNum"] = resourceModel.Assign_IdNum;
            }
        }

        /// <summary>
        /// Updates sql database with ammended/new rows of resources data in table1.
        /// </summary>
        /// <param name="AssignResDataSet"></param>
        public void UpdateDBFromDataTable(DataSet AssignResDataSet)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var adapter = new SqlDataAdapter("SELECT * from Resource_table", connection))
            using (new SqlCommandBuilder(adapter))
            {
                //adapter.Fill(AssignResDataSet.Tables[1]);
                connection.Open();
                adapter.Update(AssignResDataSet.Tables[1]);
            }
            MessageBox.Show(AssignResDataSet.DataSetName + " updated database successfully.");
        }
 
        /// <summary>
        /// SQL query SELECT: retrieves data from a search method by using either an id number or category request.
        /// This is called to display results in a datagridview.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Resource list</returns>
        public IEnumerable<ResourceModel> GetByValue(string value,int assignId)
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
                        "Where Res_IdNum = @idnum or Res_Category like @category+'%' and Assign_IdNum = @assignId " +
                        "order by Res_IdNum ";
                    command.Parameters.AddWithValue("@assignId", SqlDbType.Int).Value = assignId;
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
                }
                catch (Exception ex)
                {
                    string title = "Getting by category";
                    MessageBox.Show("Error = " + ex.Message, title);
                }
            }
            return resourceList;
        }

        /// <summary>
        /// SQL query DISTINCT: retrieves distinct category names and returns in a list to display in a textbox for user reference. 
        /// Each resource includes this field which may be used to group resources together in a search event.
        /// The categories are not preset but taken from resource creation.
        /// </summary>
        /// <returns>Category list</returns>
        public IEnumerable<string> GetAllCategories(int idNum)
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
                    command.CommandText = "SELECT DISTINCT Res_Category FROM Resource_table WHERE Assign_IdNum = @idNum " +
                        "order by Res_Category";
                    command.Parameters.AddWithValue("@category", SqlDbType.VarChar).Value = resCategory;
                    command.Parameters.AddWithValue("@idNum", SqlDbType.Int).Value = idNum;
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
    }
}
