using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciplesPractice
{
    public class Mahindra:IManufacturer
    {
        public void GetCarType()
        {
            Console.WriteLine("Hello I am Mahindra");
        }

        public void GetCarSpeed()
        {
            Console.WriteLine("My speed id 160");
        }

        public void GetCarPrice()
        {
            Console.WriteLine("My price is 12 lakhs");
        }

        public void GetCarAccesories()
        {
            Console.WriteLine("my accessories are Fog Lamps");
        }

        public void GetCarSDisplay()
        {
            Console.WriteLine("And also i have a smart display ");
        }
    }
}
