using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShelfLifeMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            PercentOfShelfLifeLabel.Text = "вот это дааа";
        }
    }
}
    
        //    StackLayout stackLayout = new StackLayout();

        //    Label BirthdaysLabel = new Label
        //    {
        //        Text = $"{DateTime.Now.AddDays(1).AddYears(-18).ToShortDateString()}",
        //        HorizontalTextAlignment = TextAlignment.Center,
        //        FontAttributes = FontAttributes.Bold,
        //        Style = Device.Styles.SubtitleStyle
        //    };
        //    stackLayout.Children.Add(BirthdaysLabel);

        //    ScrollView scrollView = new ScrollView
        //    {
        //        Content = stackLayout
        //    };
        //    this.Content = scrollView;
        //}

        //private void OnTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    Entry entry = sender as Entry;
        //    var text = entry.Text;
        //    int restrictCount = 3;
        //    if (text.Length > restrictCount)
        //    {
        //        text.Remove(text.Length - 1);
        //        entry.Text = text;
        //    }