﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp4.Class1;

namespace ConsoleApp4
{
    internal class Ticket
    {
        public int Age { get; set; }
        public PlacePreference Place { get; set; }
        public int Number { get; set; }

        public Ticket(int age, PlacePreference place)
        {
            Age = age;
            Place = place;
            Number = TicketNumberGenerator();
        }
        public int Price()
        {
            int price;

            if (Age <= 11)
            {
                price = (Place == PlacePreference.Seated) ? 50 : 25;
            }
            else if (Age >= 12 && Age <= 64)
            {
                price = (Place == PlacePreference.Seated) ? 170 : 110;
            }
            else
            {
                price = (Place == PlacePreference.Seated) ? 100 : 60;
            }

            return price;
        }
        public decimal Tax()
        {
            int price = Price();
            decimal tax = Convert.ToDecimal((1 - 1 / 1.06) * price);
            return Math.Round(tax, 2);
        }


        public static int TicketNumberGenerator()
        {
            var rand = new Random();
            return rand.Next(1, 8000);
        }

    }
}