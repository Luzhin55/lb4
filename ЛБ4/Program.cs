using System;
using System.Collections.Generic;

namespace ЛБ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ecosystem ecosystem = new Ecosystem();

            ecosystem.Organisms.Add(new Animal { Species = "Tiger", Energy = 100, Age = 5, Size = 20, Speed = 30 });
            ecosystem.Organisms.Add(new Plant { Type = "Tree", Energy = 50, Age = 10, Size = 100 });
            ecosystem.Organisms.Add(new Microorganism { Type = "Bacteria", Energy = 20, Age = 1, Size = 1, Habitat = "Water" });
            ecosystem.Simulate();
        }
    }
}