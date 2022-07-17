using System;
using System.Collections.Generic;
using System.Data;

namespace LitRevResourceMVP.Models
{
    public interface IResourceRepository
    {
        void Add(ResourceModel resourceModel, DataSet AssignResDataSet);
        void Delete(int idNum, DataSet AssignResDataSet);
        void Edit(int idNum,ResourceModel resourceModel, DataSet AssignResDataSet);
        IEnumerable<ResourceModel> GetByValue(string value);
        IEnumerable<string> GetAllCategories();
        void UpdateDBFromDataTable(DataSet AssignResDataSet);
        
        //used to create assignment dataset and CRUD from that
        DataSet GetDataSet(); //return dataset of assignment[0] and resources[1] details
        
    }
}
