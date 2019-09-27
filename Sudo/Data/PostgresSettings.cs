using LinqToDB.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sudo.Data
{
    //https://linq2db.github.io/
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }
    public class PostgresSettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "PostgresSQL";
        public string DefaultDataProvider => "PostgresSQL";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Postgres",
                        ProviderName = "PostgresSQL",
                        ConnectionString = @"Server=localhost;Port=5432;Database=sudonet;User Id=sudoUser;Password=sudoPassword;Pooling=true;MinPoolSize=10;MaxPoolSize=100;Protocol=3;"
                    };
            }
        }
    }
}
