using Microsoft.Maui.Controls;
using goGlide;

namespace goGlide
{
    public partial class SetAvailable : ContentPage
    {
        private readonly CarViewModel carViewModel;
        private readonly Car selectedCar;

        public SetAvailable(CarViewModel viewModel, Car selectedCar)
        {
            InitializeComponent();

            carViewModel = CarViewModel.Instance;
            this.selectedCar = selectedCar;

            // Set the binding context to this page
            BindingContext = this;
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            // Perform actions when Confirm button is clicked
            bool isCarChecked = CheckCarCheckBox.IsChecked;
            bool hasPaid = IDCardScannedCheckBox.IsChecked;

            // Your additional logic for setting the car as available
            // For example, update the car's properties based on the checkbox values

            // Toggle availability
            selectedCar.IsAvailable = !selectedCar.IsAvailable;

            // Update button text
            ((Button)sender).Text = selectedCar.RentButtonText;

            // Display a success popup
            await DisplayAlert("Success", "Car status updated successfully", "OK");

            // Navigate back to the ListAllCars page
            await Navigation.PopAsync();
        }
    }
}
