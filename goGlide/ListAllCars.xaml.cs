using Microsoft.Maui.Controls;
using goGlide;

namespace goGlide
{
    public partial class ListAllCars : ContentPage
    {
        private readonly CarViewModel carViewModel;

        public ListAllCars(CarViewModel viewModel)
        {
            InitializeComponent();

            carViewModel = viewModel;

            // Set the ItemsSource to the CarFleet
            CarsListView.ItemsSource = carViewModel.CarFleet;

            // Set the binding context to the view model
            BindingContext = this;
        }

        // Event handler for Rent button click
        private async void OnRentClicked(object sender, EventArgs e)
        {
            var selectedCar = ((Button)sender).CommandParameter as Car;
            await Navigation.PushAsync(new RentOutCar(carViewModel, selectedCar));
        }
    }
}
