using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KU_Digital_Medi_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btn_stdentry_Click(object sender, EventArgs e)
        {
            student_entry se = new student_entry();
            se.ShowDialog();
        }

        private void studentDatabaseUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Medi_Store_button_Click(object sender, EventArgs e)
        {
            Medi_Store ms = new Medi_Store();
            ms.ShowDialog();
        }

        private void Doctors_Advice_button_Click(object sender, EventArgs e)
        {
            Doctor_s_Advice da = new Doctor_s_Advice();
            da.ShowDialog();
        }

        private void updateStudentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Student_Database usd = new Update_Student_Database();
            usd.ShowDialog();
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            Schedule sc = new Schedule();
            sc.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.date_lbl1.Text = dateTime.Day.ToString()+"/"+dateTime.Month.ToString()+"/"+dateTime.Year.ToString();
            this.day_lbl.Text = dateTime.DayOfWeek.ToString();
            this.time_lbl.Text = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString()+":" + dateTime.Second.ToString() ;
        }
  
        
    }
}
