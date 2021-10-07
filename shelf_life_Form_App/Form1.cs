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
            thirtyDaysLabel.Text = $"90 дней: {dateToday.AddDays(-90).ToLongDateString()}";
            threeMonthsLabel.Text = $"3 месяца: {dateToday.AddMonths(-3).ToLongDateString()}";
            oneHundredThirtyFiveDaysLabel.Text = $"135 дней: {dateToday.AddDays(-135).ToLongDateString()}";
            oneHundredFiftyDaysLabel.Text = $"150 дней: {dateToday.AddDays(-150).ToLongDateString()}";
            oneHundredEightyDaysLabel.Text = $"180 дней: {dateToday.AddDays(-180).ToLongDateString()}";
            sixMonthsLabel.Text = $"6 месяцев: {dateToday.AddMonths(-6).ToLongDateString()}";
            BirthdaysLabel.Text = $"{dateToday.AddDays(1).AddYears(-18).ToLongDateString()}";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dateNumbers = Convert.ToString(DateOfManufactureTextBox.Text).Split('.', ' ', ',', '-', '_', '/');
                DateTime dateFromDateNambers = new(Convert.ToInt32(dateNumbers[2]), Convert.ToInt32(dateNumbers[1]), Convert.ToInt32(dateNumbers[0]));
                var successDaysText = Double.TryParse(DaysFromManufactoringTextBox.Text, out double daysFromManufactoring);
                if (successDaysText)
                {
                    FoundDaysLabel.Text = Convert.ToString(dateFromDateNambers.AddDays(daysFromManufactoring).ToShortDateString());
                }
                var successMonthsText = Int32.TryParse(MonthsFromManufactoringTextBox.Text, out int monthsFromManufactoring);
                if (successMonthsText)
                {
                    FoundMonthsLabel.Text = Convert.ToString(dateFromDateNambers.AddMonths(monthsFromManufactoring).ToShortDateString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Необходимо ввести дату в формате дд.мм.гггг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
