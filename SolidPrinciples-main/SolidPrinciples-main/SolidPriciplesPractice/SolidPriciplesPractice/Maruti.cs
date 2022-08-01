using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciplesPractice
{
    public class Maruti:IManufacturer
    {
        public void GetCarType()
        {
            Console.WriteLine("Hello I am Maruthi");
        }

        public void GetCarSpeed()
        {
            Console.WriteLine("My speed id 140");
        }

        public void GetCarPrice()
        {
            Console.WriteLine("My price is 8 lakhs");
        }

        public void GetCarAccesories()
        {
            Console.WriteLine("my accessories are Fog Lamps,Reverse parking sensors");
        }

        public void GetCarSDisplay()
        {
            Console.WriteLine("And alos i have smart display ");
        }

    }
}
