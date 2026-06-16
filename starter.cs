using System;
using System.Collections.Generic;

namespace Klantenbeheer
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de Klantenbeheer Applicatie!");
            // Hier komt de logica voor de applicatie
        }
    }
}