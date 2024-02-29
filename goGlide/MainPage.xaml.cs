using System;
using Microsoft.Maui.Controls;
using goGlide;

namespace goGlide
{
    public partial class MainPage : ContentPage
    {
        private readonly CarViewModel carViewModel;

        public MainPage()
        {
            InitializeComponent();

            carViewModel = CarViewModel.Instance;
        }

        private void RegNewCarClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegNewCar());
        }

        private void ListAllCarsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListAllCars(carViewModel));
        }
    }
}
