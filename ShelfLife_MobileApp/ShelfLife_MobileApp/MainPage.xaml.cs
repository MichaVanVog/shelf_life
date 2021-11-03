using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShelfLife_MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            BirthdaysLabel.Text = $"{DateTime.Now.AddDays(1).AddYears(-18).ToLongDateString()}";
            DateOfManufactureTextBox.DateSelected += DateOfManufactureTextBox_DateSelected;
            ShelfLifeTextBox.DateSelected += ShelfLifeTextBox_DateSelected;
            DaysFromManufactoringTextBox.TextChanged += DaysFromManufactoringTextBox_TextChanged;
            MonthsFromManufactoringTextBox.TextChanged += DaysFromManufactoringTextBox_TextChanged;
        }

        private void DaysFromManufactoringTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TimeSpan fullShelfLife;
            TimeSpan currentShelfLife;
            var successDaysText = Double.TryParse(DaysFromManufactoringTextBox.Text, out double daysFromManufactoring);
            if (successDaysText)
            {
                FoundDaysLabel.Text = Convert.ToString($"Срок годности: {DateOfManufactureTextBox.Date.AddDays(daysFromManufactoring).ToShortDateString()}");
                fullShelfLife = DateOfManufactureTextBox.Date.AddDays(daysFromManufactoring) - DateOfManufactureTextBox.Date;
                currentShelfLife = DateOfManufactureTextBox.Date.AddDays(daysFromManufactoring) - DateTime.Now;
                if ((currentShelfLife.Days * 100 / fullShelfLife.Days) < 0)
                {
                    percentOfFoundDaysLabel.Text = Convert.ToString("Товар просрочен");
                }
                else percentOfFoundDaysLabel.Text = Convert.ToString($"Остаточный срок годности: {currentShelfLife.Days * 100 / fullShelfLife.Days}%");
            }
            var successMonthsText = Int32.TryParse(MonthsFromManufactoringTextBox.Text, out int monthsFromManufactoring);
            if (successMonthsText)
            {
                FoundMonthsLabel.Text = Convert.ToString($"Срок годности: {DateOfManufactureTextBox.Date.AddMonths(monthsFromManufactoring).ToShortDateString()}");
                fullShelfLife = DateOfManufactureTextBox.Date.AddMonths(monthsFromManufactoring) - DateOfManufactureTextBox.Date;
                currentShelfLife = DateOfManufactureTextBox.Date.AddMonths(monthsFromManufactoring) - DateTime.Now;
                if ((currentShelfLife.Days * 100 / fullShelfLife.Days) < 0)
                {
                    percentOfFoundMonthsLabel.Text = Convert.ToString("Товар просрочен");
                }
                else percentOfFoundMonthsLabel.Text = Convert.ToString($"Остаточный срок годности: {currentShelfLife.Days * 100 / fullShelfLife.Days}%");
            }
        }

        private void ShelfLifeTextBox_DateSelected(object sender, DateChangedEventArgs e)
        {
            TimeSpan fullShelfLife = ShelfLifeTextBox.Date - DateOfManufactureTextBox.Date;
            TimeSpan currentShelfLife = ShelfLifeTextBox.Date - DateTime.Now;
            if ((currentShelfLife.Days * 100 / fullShelfLife.Days) < 0)
            {
                PercentOfShelfLifeLabel.Text = "Товар просрочен";
            }
            else PercentOfShelfLifeLabel.Text = Convert.ToString($"Остаточный срок годности: {currentShelfLife.Days * 100 / fullShelfLife.Days}%");
        }

        private void DateOfManufactureTextBox_DateSelected(object sender, DateChangedEventArgs e)
        {
            ShelfLifeTextBox.IsVisible = true;
            PercentOfShelfLifeLabel.IsVisible = true;
            percentOfFoundMonthsLabel.IsVisible = true;
            DaysFromManufactoringTextBox.IsVisible = true;
            FoundDaysLabel.IsVisible = true;
            MonthsFromManufactoringTextBox.IsVisible = true;
            FoundMonthsLabel.IsVisible = true;
            percentOfFoundDaysLabel.IsVisible = true;
        }
    }
}
