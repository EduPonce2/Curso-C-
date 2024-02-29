using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).


        //ACA CREO LAS PROPIEDADES


        public string Marca { get;  }
        public string Modelo { get;  }

        public string NumeroTelefonico
        {
            get { return NumeroTelefonico; }
            set { NumeroTelefonico = value; }
        }
        public int CodigoOperador { 
         get { return CodigoOperador; } 
         set {  CodigoOperador = value; }
        }
        //ACA CREO LOS CONSTRUCTORES DE MARCA Y MODELO
        public Telefono (string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
        //METODOS
        public string Llamar ()
        {
            return "Llamando..";
        }
        public string Llamar (string contacto)
        {
            return "Llamando a " + contacto;
        }



    }
}
