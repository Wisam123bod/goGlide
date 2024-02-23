using System;

namespace goGlide;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	
	private void RegNewCarClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new RegNewCar());
    }

    private void ListAllCarsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListAllCars());
    }

    private void RentOutCarClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RentOutCar());
    }
}


