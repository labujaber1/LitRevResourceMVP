using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Models
{
    public interface IAssignmentRepository
    {
        void Add(AssignmentModel assignmentModel);
        void Delete(int assignIdNum);
        void Edit(AssignmentModel assignmentModel);
        int GetModIdNum(string name);
        //DataSet GetModAssignData();
        IEnumerable<string> GetAllModules();
        IEnumerable<AssignmentModel> GetAllAssignments(int IdNum);
        
    }
}
