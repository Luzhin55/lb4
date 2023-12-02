using System;
using System.Collections.Generic;


namespace ЛБ4
{
    class Animal : LivingOrganism, IReproducible, IPredator
    {
        public string Species { get; set; }
        public int Speed { get; set; }

        public void Reproduce()
        {
            Console.WriteLine("Animal is reproducing.");
        }

        public void Hunt(LivingOrganism target)
        {
            Console.WriteLine("Animal is hunting.");
        }
    }
}