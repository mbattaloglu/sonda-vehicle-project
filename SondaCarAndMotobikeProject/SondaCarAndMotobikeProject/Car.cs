using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaCarAndMotobikeProject
{
    abstract class Car
    {
        public string CarName { get; set; } 
        public int Price { get; set; }
        public bool Airbag { get; set; }
        public bool MusicSystem { get; set; }
        public bool Abs { get; set; }
        public bool Sunroof { get; set; }


        public void CalculatePrice()
        {
            if (Abs)
            {
                Price += 5000;
            }
            if (Airbag)
            {
                Price += 3000;
            }
            if (MusicSystem)
            {
                Price += 1000;
            }
            if (Sunroof)
            {
                Price += 2000;
            }
        }


        public override string ToString()
        {
            CalculatePrice();
            string state = CarName + " with" + (Abs ? " ABS, " : "") + (MusicSystem ? "Music System, " : "") + (Airbag ? "Airbag, " : "") + (Sunroof ? "Sunroof" : "") + "having a total price of " + this.Price +" TL";
            return state;
        }
    }
}
