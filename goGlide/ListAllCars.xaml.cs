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

            carViewModel = CarViewModel.Instance;

            // Set the ItemsSource to the CarFleet
            CarsListView.ItemsSource = carViewModel.CarFleet;

            // Set the binding context to the view model
            BindingContext = this;

            // Subscribe to the event
            foreach (var car in carViewModel.CarFleet)
            {
                car.OnAvailabilityChanged += OnAvailabilityChanged;
            }
        }

        // Event handler for Rent button click
        private async void OnRentClicked(object sender, EventArgs e)
        {
            var selectedCar = ((Button)sender).CommandParameter as Car;
            await Navigation.PushAsync(new RentOutCar(carViewModel, selectedCar));

            // Notify that the StatusText property has changed
            OnPropertyChanged(nameof(selectedCar.StatusText));
        }

        // Event handler for availability changes
        private void OnAvailabilityChanged(object sender, EventArgs e)
        {
            // Refresh the ListView to update the UI
            CarsListView.ItemsSource = null;
            CarsListView.ItemsSource = carViewModel.CarFleet;
        }
    }
}
