using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace goGlide
{
    public class Car
    {
        public string RegID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

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
    }
}
