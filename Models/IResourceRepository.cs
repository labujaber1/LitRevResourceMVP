using System;
using System.Collections.Generic;
using System.Data;

namespace LitRevResourceMVP.Models
{
    public interface IResourceRepository
    {
        void Add(ResourceModel resourceModel);
        void Delete(int idNum);
        void Edit(ResourceModel resourceModel);
        
        //used for SQL query to lists
        IEnumerable<string> GetAllCategories();
        IEnumerable<ResourceModel> GetAllResources(int IdNum);
        IEnumerable<ResourceModel> GetByValue(string value);
        IEnumerable<AssignmentModel> GetAllAssignmentsList();


        //save
        void UpdateServerFromDataSet();
        //edit
        void EditRowInDataSet();
        //delete
        void DeleteRowInDataSet();
        //add
        void AddRowInDataSet();
      
        //used to create assignment dataset and CRUD from that
        DataSet GetAssignResDataSet(); //return dataset of assignment details
        void GetCatergoriesFromDataSet();
        void GetByValueFromDataSet();
        void GetResourcesForAssignFromDataSet();
    }
}
