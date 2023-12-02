using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    class Microorganism : LivingOrganism, IReproducible
    {
        public string Type { get; set; }
        public string Habitat { get; set; }

        public void Reproduce()
        {
            Console.WriteLine("Microorganism is reproducing.");
        }
    }
}
