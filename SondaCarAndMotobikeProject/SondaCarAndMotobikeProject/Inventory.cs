using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaCarAndMotobikeProject
{
    class Inventory
    {
        List<Car> cars = new List<Car>();
        List<Motobike> motobikes = new List<Motobike>();

        public void Add(Car car)
        {
            cars.Add(car);
        }
        public void Add(Motobike motobike)
        {
            motobikes.Add(motobike);
        }

        public int CalculateTotal()
        {
            int total = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                total += cars[i].Price;
            }
            for (int i = 0; i < motobikes.Count; i++)
            {
                total += motobikes[i].Price;
            }
            return total;
        }

        public override string ToString()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i]);
            }
            for (int i = 0; i < motobikes.Count; i++)
            {
                Console.WriteLine(motobikes[i]);
            }
            int totalVehicle = cars.Count + motobikes.Count;
            return "TOTAL : " + totalVehicle + " Vehicles including " + cars.Count + " Cars and " + motobikes.Count + " Motobikes having a total price of " + CalculateTotal().ToString() + " TL";
        }
    }
}
