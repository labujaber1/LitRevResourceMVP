using System.ComponentModel;

namespace LitRevResourceMVP.Models
{
    /// <summary>
    /// DB connection setup model containing fields inline with database table
    /// </summary>
    public class DBConnSetupModel
    {
        private string name;
        private string connectionString;
        private string providerName;

        
        [DisplayName("Connection name")]
        [ReadOnly(true)]
        public string Name { get => name; set => name = value; }
        [DisplayName("Full connectionString")]
        public string Connection_string { get => connectionString; set => connectionString = value; }
        [DisplayName("Provider name")]
        public string Provider_Name { get => providerName; set => providerName = value; }

        
    }


}
