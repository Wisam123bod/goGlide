using System;
using System.Collections.Generic;

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
        public List<Car> CarFleet { get; } = new List<Car>();

        public void RegisterCar(Car newCar)
        {
            CarFleet.Add(newCar);
        }
    }

}

