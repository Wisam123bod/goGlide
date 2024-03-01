using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace goGlide
{
    public class Car
    {
        public string RegID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        private bool _isAvailable = true;

        public bool IsAvailable
        {
            get => _isAvailable;
            set
            {
                if (_isAvailable != value)
                {
                    _isAvailable = value;
                    OnAvailabilityChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string RentButtonText => IsAvailable ? "Rent" : "Set as Available";
        public string StatusText => IsAvailable ? "Available" : "Not Available";
        public Color StatusColor => IsAvailable ? Color.FromArgb("#007BFF") : Color.FromArgb("#00FF00");

        public event EventHandler OnAvailabilityChanged;

        public Car(string regID, string brand, string model, string type)
        {
            RegID = regID;
            Brand = brand;
            Model = model;
            Type = type;
        }
    }

    public class CarViewModel
    {
        private static CarViewModel _instance;

        public static CarViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CarViewModel();
                return _instance;
            }
        }

        public ObservableCollection<Car> CarFleet { get; } = new ObservableCollection<Car>();

        public void RegisterCar(Car newCar)
        {
            CarFleet.Add(newCar);
        }

        public List<string> GetDistinctCarModels()
        {
            return CarFleet.Select(car => car.Model).Distinct().ToList();
        }
    }
}
