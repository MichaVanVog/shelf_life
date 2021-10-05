using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shelf_life_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dateToday = DateTime.Now;
            thirtyDaysLabel.Text = $"90 дней: {dateToday.AddDays(-90)}";
            threeMonthsLabel.Text = $"3 месяца: {dateToday.AddMonths(-3)}";
            oneHundredThirtyFiveDaysLabel.Text = $"135 дней: {dateToday.AddDays(-135)}";
            oneHundredFiftyDaysLabel.Text = $"150 дней: {dateToday.AddDays(-150)}";
            oneHundredEightyDaysLabel.Text = $"180 дней: {dateToday.AddDays(-180)}";
            sixMonthsLabel.Text = $"6 месяцев: {dateToday.AddMonths(-6)}";
            BirthdaysLabel.Text = $"{dateToday.AddDays(1).AddYears(-18).ToLongDateString()}";
        }
    }
}
