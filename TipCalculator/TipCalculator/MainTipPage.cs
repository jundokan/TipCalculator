using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator
{
    class MainTipPage : ContentPage
    {
        public MainTipPage()
        {
            Entry amountEntry = new Entry
            {
                Placeholder = "Enter amount of check",
                Keyboard = Keyboard.Numeric
            };

            Button buttonTipCalculation = new Button
            {
                Text = "Calculate Tip",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill
            };

            Label tipPercent = new Label
            {
                Text = "Tip Percentage",
                FontSize = 20
            };

            Label tipPercentValue = new Label
            {
                Text = "{}",
                FontSize = 20
            };

            StackLayout percentTipRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { tipPercent, tipPercentValue }
            };

            Label amountTip = new Label
            {
                Text = "Tip Amount",
                FontSize = 20
            };

            Label amountTipValue = new Label
            {
                Text = "{}",
                FontSize = 20
            };


            StackLayout amountTipRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { amountTip, amountTipValue }
            };

            Label amountTotal = new Label
            {
                Text = "Total Amount",
                FontSize = 20
            };

            Label amountTotalValue = new Label
            {
                Text = "{}",
                FontSize = 20
            };

            StackLayout totalAmountRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { amountTotal, amountTotalValue }
            };

            buttonTipCalculation.Clicked += (object sender, EventArgs e) =>
            {
                decimal checkAmount = Convert.ToDecimal(amountEntry.Text);
                decimal tipValue = 10m;
                decimal tipAmount;
                decimal totalAmount;
                decimal tipPercentage;

                tipAmount = checkAmount * tipValue / 100;
                totalAmount = checkAmount + tipAmount;

                tipPercentValue.Text = tipValue.ToString();
                amountTipValue.Text = tipAmount.ToString();
                amountTotalValue.Text = totalAmount.ToString();
            };

            StackLayout mainStackLayout = new StackLayout
            {
                Children =
                    {
                        amountEntry,
                        buttonTipCalculation,
                        percentTipRow,
                        amountTipRow,
                        totalAmountRow
                    },
                HeightRequest = 1500
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            this.Content = mainStackLayout;
        }              
    }
}
