using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp4.Connexion
{
    class ConnexionBDD
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id root;database=bddpro;SslMode=none";
    }
    
}
