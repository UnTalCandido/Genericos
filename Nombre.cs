using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public struct Nombre
    {
        //constructor
        private string pnombre, amaterno, apaterno;

        public Nombre(string nom, string apat, string amat)
        {
            pnombre = nom;
            amaterno = amat;
            apaterno = apat;
        }
        //Encapsulamiento
        public string PrimerNombre
        {
            get { return pnombre; }
            set { pnombre = PrimerNombre; }
        }
        public string ApellidoMaterno
        {
            get { return amaterno; }
            set { pnombre = ApellidoMaterno; }
        }
        public string ApellidoPaterno
        {
            get { return apaterno; }
            set { pnombre = ApellidoPaterno; }
        }

        public override string ToString()
        {
            //impresion en orden de las variables del contructor
            return (String.Format("{0} {1} {2}",pnombre,apaterno,amaterno));
        }

        public string Iniciales()
        {
            //la funcion ".Substring" nos sirve para poder asignar un parametro que se podra recibir o empezar hasta finalizar la cadena de caracteres
            return (String.Format("{0} {1} {2}", pnombre.Substring(0,1), apaterno.Substring(0,1), amaterno.Substring(0,1)));
        }
    }
}
