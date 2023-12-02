using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    class Plant : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public void Reproduce()
        {
            Console.WriteLine("Plant is reproducing.");
        }
    }
}
