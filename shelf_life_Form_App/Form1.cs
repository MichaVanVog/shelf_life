using System;
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
            thirtyDaysLabel.Text = $"90 дней: {DateTime.Now.AddDays(-90).ToLongDateString()}";
            threeMonthsLabel.Text = $"3 месяца: {DateTime.Now.AddMonths(-3).ToLongDateString()}";
            oneHundredThirtyFiveDaysLabel.Text = $"135 дней: {DateTime.Now.AddDays(-135).ToLongDateString()}";
            oneHundredFiftyDaysLabel.Text = $"150 дней: {DateTime.Now.AddDays(-150).ToLongDateString()}";
            oneHundredEightyDaysLabel.Text = $"180 дней: {DateTime.Now.AddDays(-180).ToLongDateString()}";
            sixMonthsLabel.Text = $"6 месяцев: {DateTime.Now.AddMonths(-6).ToLongDateString()}";
            BirthdaysLabel.Text = $"{DateTime.Now.AddDays(1).AddYears(-18).ToLongDateString()}";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {            
            var validMnufactureTextBox = DateTime.TryParse(DateOfManufactureTextBox.Text, out var dateFromDateNambersOfManufactoring);
            if (validMnufactureTextBox)
            {
                //get percent of the rest of shelf life
                var validShelfLifeTextBox = DateTime.TryParse(ShelfLifeTextBox.Text, out var dateFromDateNumbersOfShelfLife);
                if (!validShelfLifeTextBox)
                {
 
                    dateFromDateNumbersOfShelfLife.ToUniversalTime();
                    PercentOfShelfLifeLabel.Text = "";
                }
                else
                {
                    TimeSpan fullShelfLife = dateFromDateNumbersOfShelfLife - dateFromDateNambersOfManufactoring;
                    TimeSpan currentShelfLife = dateFromDateNumbersOfShelfLife - DateTime.Now;
                    if ((currentShelfLife.Days * 100 / fullShelfLife.Days) < 0)
                    {
                        PercentOfShelfLifeLabel.Text = "Товар просрочен";
                    }
                    else PercentOfShelfLifeLabel.Text = Convert.ToString($"Остаточный срок годности: {currentShelfLife.Days * 100 / fullShelfLife.Days}%");
                }
            }
            else MessageBox.Show("Ведите дату производства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var successDaysText = Double.TryParse(DaysFromManufactoringTextBox.Text, out double daysFromManufactoring);
            if (successDaysText)
            {
                FoundDaysLabel.Text = Convert.ToString($"Срок годности: {dateFromDateNambersOfManufactoring.AddDays(daysFromManufactoring).ToShortDateString()}");
                TimeSpan fullShelfLife = dateFromDateNambersOfManufactoring.AddDays(daysFromManufactoring) - dateFromDateNambersOfManufactoring;
                TimeSpan currentShelfLife = dateFromDateNambersOfManufactoring.AddDays(daysFromManufactoring) - DateTime.Now;
                if ((currentShelfLife.Days * 100 / fullShelfLife.Days) < 0)
                {
                    percentOfFoundDaysLabel.Text = Convert.ToString("Товар просрочен");
                }
                else percentOfFoundDaysLabel.Text = Convert.ToString($"Остаточный срок годности: {currentShelfLife.Days * 100 / fullShelfLife.Days}%");
            }
            var successMonthsText = Int32.TryParse(MonthsFromManufactoringTextBox.Text, out int monthsFromManufactoring);
            if (successMonthsText)
            {
                FoundMonthsLabel.Text = Convert.ToString($"Срок годности: {dateFromDateNambersOfManufactoring.AddMonths(monthsFromManufactoring).ToShortDateString()}");
                TimeSpan fullShelfLife = dateFromDateNambersOfManufactoring.AddMonths(monthsFromManufactoring) - dateFromDateNambersOfManufactoring;
                TimeSpan currentShelfLife = dateFromDateNambersOfManufactoring.AddMonths(monthsFromManufactoring) - DateTime.Now;
                if ((currentShelfLife.Days * 100 / fullShelfLife.Days) < 0)
                {
                    percentOfFoundMonthsLabel.Text = Convert.ToString("Товар просрочен");
                }
                else percentOfFoundMonthsLabel.Text = Convert.ToString($"Остаточный срок годности: {currentShelfLife.Days * 100 / fullShelfLife.Days}%");
            }

        }
    }
}
