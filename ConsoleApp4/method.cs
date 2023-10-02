using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp4.Class1;

namespace ConsoleApp4
{
    internal class method
    {
        public static int GetAge()
        {
            Console.WriteLine("Please enter your age: ");
            string text = Console.ReadLine();
            int age = Convert.ToInt32(text);
            return age;
        }

        public static string GetTicket()
        {
            Console.WriteLine("\nEnter Place preference(Standing or Seated): ");
            string place = Console.ReadLine();
            if (place != "standing" && place != "seated")
            {
                Console.WriteLine("Invalid input. Please enter 'standing' or 'seated'.");
                return GetTicket();
            }
            return place;
        }

        public int PriceSetter(int age, PlacePreference place)
        {
            int price = 0;
         
             if (age <= 11)
            {
                price = (place == PlacePreference.Seated) ? 50 : 25;
            }
            else if (age >=12 && age<= 64)
            {
                price = (place == PlacePreference.Seated) ? 170 : 110;
            }
            else
            {
                price = (place == PlacePreference.Seated) ? 100 : 60;
            }

            return price;
        }
    }
}
    
