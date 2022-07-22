using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Models
{
    public interface IDBConnSetupRepository
    {
        IEnumerable<string> GetConnString();

    }
}
