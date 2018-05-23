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
    public partial class Update_Student_Database : Form
    {
        public Update_Student_Database()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "insert into database.student_database (Student_Id,Student_Name,Discipline,Gender) values ('" + this.id.Text + "', '" + this.name.Text + "', '" + dis.Text + "', '" + gen.Text + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                id.Clear();
                name.Clear();
                dis.Clear();
                gen.Clear();

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "update database.student_database set Student_Id='" + this.id.Text + "', Student_Name='" + this.name.Text + "', Discipline='" + this.dis.Text + "', Gender= '" + this.gen.Text + "' where Student_Id='" + this.id.Text + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                id.Clear();
                name.Clear();
                dis.Clear();
                gen.Clear();

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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "delete from database.student_database where Student_Id='" + this.id.Text + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                if (id.Text != null)
                {
                    conDatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Deleted");
                    id.Clear();
                    name.Clear();
                    dis.Clear();
                    gen.Clear();

                    while (myReader.Read())
                    {

                    }
                    conDatabase.Close();
                }
                else MessageBox.Show("See Help Tab");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Delete Just Enter The Student Id");
        }

        private void Update_Student_Database_Load(object sender, EventArgs e)
        {

        }
    }
}
