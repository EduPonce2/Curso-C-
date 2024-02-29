using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Telefono t1 = new Telefono("PocoPhone","F3");
           Console.WriteLine("El celular es un " + t1.Marca + " " + t1.Modelo);
           Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Edu"));
           
            
            
            
            Console.ReadKey();


         
        }
    }
}