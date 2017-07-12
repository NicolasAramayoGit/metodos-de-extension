using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using Punto_1;
using Punto_3;
using Punto_4;

namespace main_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //PUNTO Nº1
            Persona objPersona = new Persona(1.85f);
            objPersona.Muestro();

            Console.ReadKey();

            //PUNTO Nº2
            Queue<Double> pila = new Queue<double>();

            pila.Enqueue(5);
            pila.Enqueue(2);
            pila.Enqueue(4);

            // muestro la pila
            foreach (var item in pila)
            {
                Console.WriteLine("" + item);
                
            }

            Queue<double> pilaDos = new Queue<double>();
            Stack<Double> colaAux = new Stack<double>();
            // al obj stack le agrego la pila inversa.
            while (pila.Count != 0)
            {
                colaAux.Push(pila.Dequeue());
            }

            //muestro el obj stack.
            foreach (var item in colaAux)
            {
                Console.WriteLine("" + item);
            }

            pila = pilaDos;

            while(pilaDos.Count != 0)
            {
                pila.Enqueue(pilaDos.Dequeue());
            }

            foreach (var item in pila)
            {
                Console.WriteLine("" + item);
            }

            Console.ReadKey();

            Deposito depositoUno = new Deposito(3);
            Deposito depositoDos = new Deposito(3);

            Producto prodUno = new Producto("gaseosa",10);
            Producto prodDos = new Producto("pan", 5);
            Producto prodTres = new Producto("manteca", 15);

            Producto prodCuatro = new Producto("gaseosa", 10);
            Producto prodCinco = new Producto("leche", 10);
            Producto prodSeis = new Producto("azucar", 15);


            Producto[] productos = depositoUno + depositoDos;


            Console.ReadKey();

            //PUNTO N4

            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");


            Console.ReadKey();

        }
    }
}
