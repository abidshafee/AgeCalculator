using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int date1, date2, mon1, mon2, year1, year2;
        //array of days of month in year
        int[] mon = new int[12] { 
            31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };
        int date, month, year;

        private void mon1TextBox_Enter(object sender, EventArgs e)
        {
            if (true) mon1TextBox.Clear();
        }

        private void year1TextBox_Enter(object sender, EventArgs e)
        {
            if (true) year1TextBox.Clear();
        }

        private void date2TextBox_Enter(object sender, EventArgs e)
        {
            if (true) date2TextBox.Clear();
        }

        private void mon2TextBox_Enter(object sender, EventArgs e)
        {
            if (true) mon2TextBox.Clear();
        }

        private void year2TextBox_Enter(object sender, EventArgs e)
        {
            if (true) year2TextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date2TextBox.Text = dateTimePicker1.Value.Day.ToString();
            mon2TextBox.Text = dateTimePicker1.Value.Month.ToString();
            year2TextBox.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void year1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void year1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
             
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void mon1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mon1TextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                mon1TextBox.Text = mon1TextBox.Text.Remove(mon1TextBox.Text.Length - 1);
            }
        }

        private void mon1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            mon1TextBox.MaxLength = 2;
        }

        private void date1TextBox_Enter(object sender, EventArgs e)
        {
            if (true) date1TextBox.Clear();
        }

        private void date1TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        public void inpFunc()
        {
            try
            {
                date1 = Convert.ToInt32(date1TextBox.Text);
                date2 = Convert.ToInt32(date2TextBox.Text);
                mon1 = Convert.ToInt32(mon1TextBox.Text);
                mon2 = Convert.ToInt32(mon2TextBox.Text);
                year1 = Convert.ToInt32(year1TextBox.Text);
                year2 = Convert.ToInt32(year2TextBox.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Plese input All required fields!" + "\n" + ex.Message);
            }
            
        }
        public int dayCalc()
        {
            date = date2 - date1;
            if (date2 < date1)
            {
                date2 = date2 + mon[mon1 - 1];
                date = date2 - date1;
                mon2 = mon2 - 1;
            }
            return mon2;
        }
        public int MonCalc()
        {
            month = mon2 - mon1;
            if (mon2 < mon1)
            {
                mon2 = mon2 + 12;
                month = mon2 - mon1;
                year2 = year2 - 1;
            }
            return year1;
        }
        public int yearCalc()
        {
            year = year2 - year1;
            return year;
        }

        private void ageBtn_Click(object sender, EventArgs e)
        {
            inpFunc();
            dayCalc();
            MonCalc();
            yearCalc();
            String dateResult = Convert.ToString(date);
            String monResult = Convert.ToString(month);
            String yearResult = Convert.ToString(year);
            ageTextBox.Text = (yearResult + " Years " + monResult + " Months "
                + dateResult + " Days");
        }       
    }
}