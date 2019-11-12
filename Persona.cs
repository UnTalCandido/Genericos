using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public class Persona
    {
        public static void Saludar() //metodo estatico, se puede mandar a llamar en cualquier lugar sin ningun problema
        {
            Console.WriteLine("Esto es un saludo");
            Console.ReadKey();
        }
    }
}
