using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FrmPersonnel : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "serveur=localhost;user id=root;database=bddpro; SslMode=none";
        public FrmPersonnel()
        {
            InitializeComponent();
            InitConnection();
            RecupProfils();
        }
        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }catch(MySqlException e)
            {
                Console.Write(e.Message);
                Environment.Exit(0);
            }

        }
        private void RecupProfils()
        {
            string query = "select * from profil";
            command = new MySqlCommand(query, connection);
            command.Prepare();
            reader = command.ExecuteReader();
            lstPersonnel.Items.Clear();
            while (reader.Read())
            {
                lstPersonnel.Items.Add(reader["nom"]);
            }
            reader.Close();
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex != -1)
            {
                // construction de la requête
                string query = "delete from profil where nom = @nom";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", lstPersonnel.SelectedItem);
                //exécution de la requête
                command = new MySqlCommand(query, connection);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();
                // met à jour liste
                RecupProfils();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtxtPersonnel_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
