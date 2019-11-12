using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista<int> elementos = new lista<int>();
            Candido<string> elementos = new Candido<string>();
            elementos.Saludos("Saludos ");

            //Esta es una lista de objetos que puede manejar cualquier tipo de variable
            List<object> listachida = new List<object>();
            listachida.Add(3); //en este caso sera int
            listachida.Add("String grande grande grande"); //en este caso sera string
            listachida.Add(false); //en este caso sera bool


            Nombre miNombre = new Nombre("Candido", "Rodriguez", "Guzman"); //instanciacion y contenido del objeto "miNombre"
            string nombrecompleto;
            
            nombrecompleto = miNombre.ToString();
            Console.WriteLine("{0}", nombrecompleto); //Impresio
            Console.ReadKey();
            
            //impresion de las iniciales del nombre completo (Candido Rodriguez Guzman , linea 24)
            string iniciales = miNombre.Iniciales();
            Console.WriteLine(iniciales);
            Console.ReadKey();

            Persona.Saludar();
            Console.ReadLine();
        }
    }
}
