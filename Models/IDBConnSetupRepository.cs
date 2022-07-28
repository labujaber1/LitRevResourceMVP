using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Models
{
    public interface IDBConnSetupRepository
    {
        //IEnumerable<string> GetConnString();
        IEnumerable<DBConnSetupModel> GetConnString();
        void AddConnString(string name, string connectionString, string providerName);
        void EditConnString(string name, string connectionString, string providerName);
        bool TestConnString(string connectionString);
        void DeleteConnString(int num);
        void SaveRefreshConfig();
    }
}
