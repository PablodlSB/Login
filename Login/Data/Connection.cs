using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Login.Data
{
    internal static class Connection
    {
        public static string server = "127.0.0.1";
        public static string dataBase = "login";
        public static string user = "root";
        public static string psw = "pablo2004";

        public static MySqlConnection connMaster = new MySqlConnection();

        public static void OpenConnection()
        {
            // Utilizamos la cadena de conexión
            string ConnectionString = $"server={server};database={dataBase};user={user};password={psw}";

            connMaster = new MySqlConnection(ConnectionString);
            connMaster.Open();

            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión establecida.");
            }

            else
            {
                MessageBox.Show("No se ha podido establecer conexión.");
            }
        }
        public static void CloseConnection() 
        {
            
        }
    }
}
