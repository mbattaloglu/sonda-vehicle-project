using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaCarAndMotobikeProject
{
    abstract class Motobike
    {
        public string MotobikeName { get; set; }
        public int Price { get; set; }
        public bool Abs { get; set; }
        public bool SeatHeating { get; set; }

        public void CalculatePrice()
        {
            if (Abs)
            {
                Price += 5000;
            }
            if (SeatHeating)
            {
                Price += 2000;
            }
        }
        public override string ToString()
        {
            CalculatePrice();
            string state = MotobikeName + " with" + (Abs ? " ABS, " : "") + (SeatHeating ? " Seat Heating " : "") + "having a total price of " + Price + " TL";
            return state;
        }
    }
}
