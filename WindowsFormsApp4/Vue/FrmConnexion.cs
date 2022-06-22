﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4.Vue
{
    public partial class FrmConnexion : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id root;database=bddpro;SslMode=none";
        public FrmConnexion()
        {
            InitializeComponent();
            InitConnection();
          
        }
        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }



        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals(""))
            {
                // construction de la requête
                string query = "insert into profil (nom) values (@nom)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", txtLogin.Text);
                //exécution de la requête
                command = new MySqlCommand(query, connection);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();
                // met à jour liste
               
                txtLogin.Text = "";
            }
        }

    }
}

