using Microsoft.Maui.Controls;
using goGlide;

namespace goGlide
{
    public partial class RentOutCar : ContentPage
    {
        private readonly CarViewModel carViewModel;
        private readonly Car selectedCar;

        public RentOutCar(CarViewModel viewModel, Car selectedCar)
        {
            InitializeComponent();

            carViewModel = viewModel;
            this.selectedCar = selectedCar;

            // Set the binding context to this page
            BindingContext = this;
        }

        private async void OnConfirmRentClicked(object sender, EventArgs e)
        {
            // Perform actions when Confirm Rent button is clicked
            bool isCarChecked = CheckCarCheckBox.IsChecked;
            bool isIDCardScanned = IDCardScannedCheckBox.IsChecked;

            // Validate and get the number of days rented
            if (int.TryParse(DaysRentedEntry.Text, out int daysRented))
            {
                // Update car availability status
                selectedCar.IsAvailable = false;

                // Perform other actions as needed

                // Display a success popup
                await DisplayAlert("Success", "Car successfully rented out", "OK");

                // Navigate back to the ListAllCars page
                await Navigation.PopAsync();
            }
            else
            {
                // Display an error message or handle invalid input
                await DisplayAlert("Error", "Invalid input for days of rental", "OK");
            }
        }
    }
}
