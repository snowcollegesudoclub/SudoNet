using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sudo.Data
{
    public class DBIntelligo : DataConnection
    {
        public DBIntelligo() : base("Postgres")
        {

        }
    }
}
