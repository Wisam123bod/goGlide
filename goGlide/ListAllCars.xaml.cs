using Microsoft.Maui.Controls;
using goGlide;

namespace goGlide;

public partial class ListAllCars : ContentPage
{
    private readonly CarViewModel carViewModel = CarViewModel.Instance;

    public ListAllCars()
    {
        InitializeComponent();

        // Set the ItemsSource to the CarFleet
        CarsListView.ItemsSource = carViewModel.CarFleet;
    }
}
