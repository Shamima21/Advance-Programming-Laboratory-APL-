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
    public partial class student_entry : Form
    {
        public student_entry()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "select * from database.student_database ;";
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
                    string sName = myReader.GetString("Student_Id");
                    comboBox1.Items.Add(sName);
                }
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "insert into database.patient_database (Student_Id,Student_Name,Discipline,Gender,Disease) values ('" + this.stdid.Text + "', '" + this.stdname.Text + "', '"+stddis.Text+"', '"+stdgen.Text+"','"+disease.Text+"');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                stdid.Clear();
                stdname.Clear();
                stddis.Clear();
                stdgen.Clear();
                disease.Clear();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "select * from database.student_database where student_id = '"+comboBox1.Text+"';";
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
                    string sId = myReader.GetString("Student_Id");
                    string sName = myReader.GetString("Student_Name");
                    string sDis = myReader.GetString("Discipline");
                    string sGen = myReader.GetString("Gender");
                    stdid.Text = sId;
                    stdname.Text = sName;
                    stddis.Text = sDis;
                    stdgen.Text = sGen;
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
            this.Hide();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost;port =3306;username=root;password=connect";
            string Query = "select * from database.student_database where student_id = '" + comboBox1.Text + "';";
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
                    string sId = myReader.GetString("Student_Id");
                    string sName = myReader.GetString("Student_Name");
                    string sDis = myReader.GetString("Discipline");
                    string sGen = myReader.GetString("Gender");
                    stdid.Text = sId;
                    stdname.Text = sName;
                    stddis.Text = sDis;
                    stdgen.Text = sGen;
                }
                if (stdname.Text == "")
                    MessageBox.Show("Not Available");
                    
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
