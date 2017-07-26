using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_1
{
    public static class MetodoExtension
    {

        public static void MostrarLargo(this Persona persona)
        {
            Console.WriteLine("Es largo de la persona es: " + persona._largo);
        }


    }
}
