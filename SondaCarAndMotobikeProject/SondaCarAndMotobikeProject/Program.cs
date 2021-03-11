using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaCarAndMotobikeProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Car car = new Sivic();
            car.Abs = true;
            car.Airbag = true;
            inventory.Add(car);

            Motobike motobike = new Racer();
            motobike.Abs = true;
            inventory.Add(motobike);

            Console.WriteLine(inventory);
        }
    }
}
