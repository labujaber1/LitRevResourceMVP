using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Models
{
    public interface IModuleRepository
    {
        void Add(ModuleModel moduleModel);
        void Delete(int modIdNum);
        void Edit(ModuleModel moduleModel);
        IEnumerable<ModuleModel> GetAllModules();
    }
}
