using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

// Не трогать!!!

namespace ADB
{
    partial class cSystem
    {
        public System.Data.OleDb.OleDbConnection _Connection;
        public cSystem()
        {

        }

        ~cSystem()
        {

        }

        partial void OpenDB()
        {
            using (System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection()) {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data source= ADB.mdb"; // Пока только пример. Надо будет менять путь.
                _Connection = connection;
            }
        }
    }
}
