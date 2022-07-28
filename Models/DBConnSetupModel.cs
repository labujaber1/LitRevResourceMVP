using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitRevResourceMVP.Models
{
    public class DBConnSetupModel
    {
        private string name;
        private string connectionString;
        private string providerName;

        //private string dataSource;
        //private string initialCatalog;
        //private string integratedSecurity;
        //private string timeOut;

        //private string userName;
        //private string password;

        [DisplayName("Connection name")]
        [ReadOnly(true)]
        public string Name { get => name; set => name = value; }
        [DisplayName("Full connectionString")]
        public string Connection_string { get => connectionString; set => connectionString = value; }
        [DisplayName("Provider name")]
        public string Provider_Name { get => providerName; set => providerName = value; }

        //[DisplayName("Data source path")]
        //public string Data_Source { get => dataSource; set => dataSource = value; }
        //[DisplayName("Database name")]
        //public string Initial_catalog { get => initialCatalog; set => initialCatalog = value; }
        //[DisplayName("Set integrated security")]
        //public string Integrated_Security { get => integratedSecurity; set => integratedSecurity = value; }
        //[DisplayName("Connection timeout")]
        //public string Time_out { get => timeOut; set => timeOut = value; }

        //[DisplayName("User name")]
        //public string User_name { get => userName; set => userName = value; }
        //[DisplayName("Connection password")]
        //public string Password { get => password; set => password = value; }

    }


}
