using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    public static class MetodoExtension
    {
        public static void Muestro(this Persona obj)
        {
            Console.WriteLine("Su altura es: " + obj._largo);        
        }
    }
}
