using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    class Ecosystem
    {
        public List<LivingOrganism> Organisms { get; set; }

        public Ecosystem()
        {
            Organisms = new List<LivingOrganism>();
        }

        public void Simulate()
        {
            foreach (var organism in Organisms)
            {
                if (organism is IReproducible)
                {
                    ((IReproducible)organism).Reproduce();
                }

                if (organism is IPredator)
                {
                    var predator = (IPredator)organism;
                    foreach (var otherOrganism in Organisms)
                    {
                        if (otherOrganism != organism)
                        {
                            predator.Hunt(otherOrganism);
                        }
                    }
                }
            }
        }
    }
}
