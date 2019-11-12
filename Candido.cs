using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public class Candido<T>
    {

        private T[] elementos;

        public void Saludos(T dato)
        {
            Console.WriteLine("Este es el dato impreso: " + dato);
            Console.ReadKey();
        }
    }
}
