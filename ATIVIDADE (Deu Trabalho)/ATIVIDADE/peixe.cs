using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE
{
    class peixe : Animal
    {
        public void barbatanas()
        {

        }

        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Os peixes nadam");
        }
    }
}
