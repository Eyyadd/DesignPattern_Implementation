using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private DatabaseConnection()
        {
            Console.WriteLine("Connection to database");
        }

        public static DatabaseConnection GetInstace()
        {
            if (instance is null)
                instance = new DatabaseConnection();

            return instance;
        }
    }
}
