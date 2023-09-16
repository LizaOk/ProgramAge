using System;
using System.Windows.Forms;
 

namespace ProgramAge
{
    public partial class Form1 : Form
    {
        
        public void CalculateYears ()
        {
            string text = textBoxYear.Text;  
            int year = Convert.ToInt32(text);

            int answer1 = DateTime.Now.Year - year;

            textBoxAnswer1.Text += answer1;
        }

        public void CalculateMonths()
        {
            int year = Convert.ToInt32(textBoxYear.Text);
            int day = Convert.ToInt32(textBoxDay.Text);
            int month = Convert.ToInt32(textBoxMonth.Text);

            DateTime date1 = new DateTime(year, month, day);
            DateTime date2 = new DateTime(2023, 9, 16);

            TimeSpan difference = date2 - date1;
            int daysDifference = difference.Days;

            textBoxAnswer2.Text += daysDifference;
        }

            public void CalculateDays()
        {
            int year = Convert.ToInt32(textBoxYear.Text);
            int day = Convert.ToInt32(textBoxDay.Text);
            int month = Convert.ToInt32(textBoxMonth.Text);

            DateTime date1 = new DateTime(year, month, day);
            DateTime date2 = new DateTime(2023, 9, 16);

            int monthsDifference = ((date2.Year - date1.Year) * 12) + date2.Month - date1.Month;

            textBoxAnswer3.Text += monthsDifference;
        }
        public void CalculateComingOfAge()
        {
            string text = textBoxYear.Text;
            int year = Convert.ToInt32(text);

            int answer4 = year + 18;

            textBoxAnswer4.Text += answer4;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            CalculateYears();
            CalculateDays();
            CalculateMonths();
            CalculateComingOfAge();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelYear_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMonth_Click(object sender, EventArgs e)
        {

        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
