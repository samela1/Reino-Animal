using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE
{
    class ave : Animal
    {
        public void migra()
        {
            Console.WriteLine("As aves migram quando necessario");
        }

        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Ave voa");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("As aves  piam");
        }

    }
}
