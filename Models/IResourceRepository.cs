using System;
using System.Collections.Generic;
using System.Data;

namespace LitRevResourceMVP.Models
{
    /// <summary>
    /// Resource repository interface: SQL queries called from presenter for CRUD functionality.
    /// </summary>
    public interface IResourceRepository
    {
        /// <summary>
        /// Adds a new row of resources data to table1 in dataset ("AssignResDataSet").
        /// </summary>
        /// <param name="resourceModel"></param>
        /// <param name="AssignResDataSet"></param>
        void Add(ResourceModel resourceModel, DataSet AssignResDataSet);

        /// <summary>
        /// Deletes a row of resources data from table1 in dataset ("AssignResDataSet"). Passes idnum for selection. 
        /// </summary>
        /// <param name="idNum"></param>
        /// <param name="AssignResDataSet"></param>
        void Delete(int idNum, DataSet AssignResDataSet);

        /// <summary>
        /// Edits a row of resources data from table1 in dataset ("AssignResDataSet"). Passes idnum for selection.
        /// </summary>
        /// <param name="idNum"></param>
        /// <param name="resourceModel"></param>
        /// <param name="AssignResDataSet"></param>
        void Edit(int idNum,ResourceModel resourceModel, DataSet AssignResDataSet);

        /// <summary>
        /// SQL query SELECT: retrieves data from a search method by using either an id number or category request.
        /// This is called to display results in a datagridview.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="assignId"></param>
        /// <returns>Resource list</returns>
        IEnumerable<ResourceModel> GetByValue(string value,int assignId);

        /// <summary>
        /// SQL query DISTINCT: retrieves distinct category names and returns in a list to display in a textbox for user reference. 
        /// Each resource includes this field which may be used to group resources together in a search event.
        /// The categories are not preset but taken from resource creation.
        /// </summary>
        /// <returns>Category list</returns>
        IEnumerable<string> GetAllCategories(int idNum);

        /// <summary>
        /// Updates sql database with ammended/new rows of resources data in table1.
        /// </summary>
        /// <param name="AssignResDataSet"></param>
        void UpdateDBFromDataTable(DataSet AssignResDataSet);



        //used to create assignment dataset and CRUD from that
        //return dataset of assignment[0] and resources[1] details
        //call at start of presenter to display assignments and resources tables in both datagridviews
        /// <summary>
        /// Adds assignment and resources tables to dataset using sqlDataAdapter 
        /// </summary>
        /// <returns>Dataset AssignResDataSet</returns>
        DataSet GetDataSet(); 
        
    }
}
