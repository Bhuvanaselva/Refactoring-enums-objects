// See https://aka.ms/new-console-template for more information
using ConsoleApp4;
using System;
using static ConsoleApp4.Class1;

Console.WriteLine("Welcome !!\n");
Ticket ticket = new Ticket(24, PlacePreference.Seated);
Console.WriteLine($"Age: {ticket.Age}");
Console.WriteLine($"Place: {ticket.Place}");
Console.WriteLine($"Ticket Price: {ticket.Price()} SEK");
Console.WriteLine($"Tax: {ticket.Tax()} SEK");
Console.WriteLine($"Ticket Number: {ticket.Number}");