using System;

namespace goGlide;

public partial class RegNewCar : ContentPage
{
	public RegNewCar()
	{
		InitializeComponent();
	}

    private void CreateCarButton_Clicked(object sender, EventArgs e)
    {
        string regID = Entry_regID.Text;
        string brand = Entry_Brand.Text;
        string model = Entry_Model.Text;
        string type = Entry_Type.Text;

        InitializeCar(regID, brand, model, type);
    }

    private void InitializeCar(string regID, string brand, string model, string type)
    {
        CarViewModel carViewModel = new CarViewModel();
        Car newCar = new Car(regID, brand, model, type);
        carViewModel.CarFleet.Add(newCar);

        foreach (Car car in carViewModel.CarFleet)
        {
            registeredCarsLabel.Text += $"Brand: {car.Brand}, Model: {car.Model}, Type: {car.Type}\n";
        }
    }
}
