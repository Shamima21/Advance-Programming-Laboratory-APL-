using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KU_Digital_Medi_File
{
    public partial class Update_Credentials : Form
    {
        public Update_Credentials()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "update database.credentials set Username='" + this.username.Text + "', Password='" + this.password.Text + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                username.Clear();
                password.Clear();

                while (myReader.Read())
                {

                }
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Update_Credentials_Load(object sender, EventArgs e)
        {

        }
    }
}
