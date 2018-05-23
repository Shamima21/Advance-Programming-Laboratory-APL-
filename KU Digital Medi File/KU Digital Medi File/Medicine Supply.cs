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
    public partial class Medicine_Supply : Form
    {
        public Medicine_Supply()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "select * from database.medicine ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                //MessageBox.Show("Saved");
                //stdid.Clear();
                // stdname.Clear();
                // stddis.Clear();
                // stdgen.Clear();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("Name");
                    comboBox1.Items.Add(sName);
                }
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_medinsert_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "insert into database.medicine (Name,Quantity) values ('" + this.medname.Text + "', '" + this.quantity.Text + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                medname.Clear();
                quantity.Clear();

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

        private void btn_medupdate_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "update database.medicine set Name='" + this.medname.Text + "', Quantity='" + this.quantity.Text + "' where Name='" + this.medname.Text + "' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                medname.Clear();
                quantity.Clear();// int count = 0;
                while (myReader.Read())
                {
                    //count = count + 1;
                }
                //if (count == 1)               

                conDatabase.Close();
                // conDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Credentials uc = new Update_Credentials();
            uc.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "select * from database.medicine where Name = '" + comboBox1.Text + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                //MessageBox.Show("Saved");
                //stdid.Clear();
                // stdname.Clear();
                // stddis.Clear();
                // stdgen.Clear();

                while (myReader.Read())
                {
                    
                    string sName = myReader.GetString("Name");
                    string quan = myReader.GetString("Quantity");

                    medname.Text = sName;
                    quantity.Text = quan;
                }
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "select * from database.medicine where Name = '" + comboBox1.Text + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                //MessageBox.Show("Saved");
                //stdid.Clear();
                // stdname.Clear();
                // stddis.Clear();
                // stdgen.Clear();

                while (myReader.Read())
                {

                    string sName = myReader.GetString("Name");
                    string quan = myReader.GetString("Quantity");

                    medname.Text = sName;
                    quantity.Text = quan;
                }
                if (medname.Text == "")
                    MessageBox.Show("Not Available");
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
