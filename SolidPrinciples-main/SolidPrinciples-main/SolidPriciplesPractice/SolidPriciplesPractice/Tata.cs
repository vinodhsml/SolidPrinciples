using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciplesPractice
{
    public class Tata:IManufacturer
    {
        public void GetCarType()
        {
            Console.WriteLine("Hello I am Tata");
        }

        public void GetCarSpeed()
        {
            Console.WriteLine("My speed id 160");
        }

        public void GetCarPrice()
        {
            Console.WriteLine("My price is 10 lakhs");
        }

        public void GetCarAccesories()
        {
            Console.WriteLine("my accessories are Fog Lamps,Reverse parking sensors,car cover");
        }

        public void GetCarSDisplay()
        {
            Console.WriteLine("And i have smart display ");
        }
    }
}
