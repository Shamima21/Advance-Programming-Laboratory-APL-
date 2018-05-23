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
    public partial class Medi_Store : Form
    {
        public Medi_Store()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;port =3306;username=root;password=connect";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select *from database.credentials where Username='" + this.username.Text + "' and Password = '" + this.password.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    // MessageBox.Show("Correct");
                    this.Hide();
                    Medicine_Supply medsup = new Medicine_Supply();
                    medsup.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
                //myConn.Close();
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
    }
}
