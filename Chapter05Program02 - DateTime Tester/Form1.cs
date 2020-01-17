using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05Program02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateDateInfo();
        }

        private void updateDateInfo()
        {
            int days;
            DateTime myDate = new DateTime();
            myDate = DateTime.Now;

            DateTime newYear = new DateTime(myDate.Year, 12, 31);

            txtFullDateTime.Text = myDate.ToString("f");
            txtLongDate.Text = myDate.ToString("D");
            txtShortDate.Text = myDate.ToString("d");
            txtGeneralDateTime.Text = myDate.ToString("g");
            txtLongtime.Text = myDate.ToString("T");
            txtShortTime.Text = myDate.ToString("t");
            days = newYear.DayOfYear - myDate.DayOfYear;
            txtDaysUntilNewYear.Text = days.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            updateDateInfo();
        }
    }
}
