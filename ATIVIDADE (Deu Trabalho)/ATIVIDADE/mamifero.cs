using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE
{
    class mamifero : Animal
    {
        public void amamenta()
        {
            Console.WriteLine("eles mamam");
        }

        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("os mamiferos podem andar e nadar");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("os mamiferos se comunicam de diferentes formas");
        }
    }
}
