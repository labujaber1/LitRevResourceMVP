using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Models
{
    public interface IResourceRepository
    {
        void Add(ResourceModel resourceModel);
        void Delete(int idNum);
        void Edit(ResourceModel resourceModel);
        
        IEnumerable<string> GetAllCategories();
        IEnumerable<ResourceModel> GetAllResources(int IdNum);
        IEnumerable<ResourceModel> GetByValue(string value);
        IEnumerable<AssignmentModel> GetAllAssignments();
    }
}
