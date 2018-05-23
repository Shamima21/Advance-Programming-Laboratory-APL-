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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            day.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                    monthCalendar1.SelectionStart.Month.ToString() + "/" +
                    monthCalendar1.SelectionStart.Year.ToString();
            D.Text = monthCalendar1.SelectionStart.DayOfWeek.ToString();


            if (D.Text == "Sunday" || D.Text == "Monday" || D.Text == "Tuesday" ||  D.Text == "Wednesday" || D.Text == "Thursday" )
            {
                doc_status.Text = "Doctors are available";
                doc_name.Text = "Dr.Md Aminul Islam"+" "+" (9.00 am-2.00 pm)"+Environment.NewLine+Environment.NewLine+"Dr. Sunirmol Bosu"+ " "+" (2.00 pm - 7.00 pm)";
            }
            else {
                doc_status.Text = "Not Available";
                doc_name.Text = "Public Holiday";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
