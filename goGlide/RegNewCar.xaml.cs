using System;
using goGlide;

namespace goGlide;

public partial class RegNewCar : ContentPage
{
    public RegNewCar()
    {
        InitializeComponent();
    }

    private async void CreateCarButton_Clicked(object sender, EventArgs e)
    {
        string regID = Entry_regID.Text;
        string brand = Entry_Brand.Text;
        string model = Entry_Model.Text;
        string type = Entry_Type.Text;

        // Initialize the CarViewModel
        CarViewModel.Instance.RegisterCar(new Car(regID, brand, model, type));

        // Show a popup alert
        await DisplayAlert("Success", "Your car has been registered!", "OK");

        // Clear the input fields
        Entry_regID.Text = string.Empty;
        Entry_Brand.Text = string.Empty;
        Entry_Model.Text = string.Empty;
        Entry_Type.Text = string.Empty;
    }

    private void InitializeCar(string regID, string brand, string model, string type)
    {
        // You can keep this method as is or make adjustments based on your needs
        CarViewModel.Instance.RegisterCar(new Car(regID, brand, model, type));
    }
}
