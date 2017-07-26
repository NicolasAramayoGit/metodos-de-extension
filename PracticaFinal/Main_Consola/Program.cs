using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias.
using PUNTO_1;
using PUNTO3;
using PUNTO4;
using System.IO; // Utilizo para menejador.
using PUNTO5;
using PUNTO7;

namespace Main_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // PUNTO N°1
            Persona objPERSONA = new Persona(1.85f);
            objPERSONA.MostrarLargo();

            Console.ReadKey();


            // PUNTO N°2
            Queue<Double> pila1 = new Queue<double>();
            Stack<Double> stackAux = new Stack<double>();

            // AGREGO LOS ELEMENTOS 5 2 4 
            pila1.Enqueue(5);
            pila1.Enqueue(2);
            pila1.Enqueue(4);

            // AGREGO EL CONTENIDO DE LA PILA1 AL STACK QUEDANDO 4 2 5
            while (pila1.Count != 0)
            {
                stackAux.Push( pila1.Dequeue());
            }

            while (stackAux.Count != 0)
            {
                pila1.Enqueue(stackAux.Pop());
            }


            // MUESTO EL ORDEN FINAL
            Console.WriteLine("ORDEN FINAL:");
            while(pila1.Count != 0)
            {
                Console.WriteLine("" + pila1.Dequeue());
                
            }


            Console.ReadKey();


            // PUNTO N°3

            Deposito D1 = new Deposito(3);
            Deposito D2 = new Deposito(3);

            Producto pro1 = new Producto("leche", 5);
            Producto pro2 = new Producto("azucar", 10);
            Producto pro3 = new Producto("mermelada", 15);

            Producto pro4 = new Producto("leche", 20);
            Producto pro5 = new Producto("mermelada", 15);
            Producto pro6 = new Producto("manteca", 10);

            // AGREGO LOS PRODUCTOS AL ARRAY PRODUCTOS d1 y d2.
            D1._productos.SetValue(pro1, 0);
            D1._productos.SetValue(pro2, 1);
            D1._productos.SetValue(pro3, 2);

            D2._productos.SetValue(pro4, 0);
            D2._productos.SetValue(pro5, 1);
            D2._productos.SetValue(pro6, 2);

            Producto[] productos;

            productos = D1 + D2;

            

            Console.ReadKey();


            // PUNTO N°4
            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");

            Console.ReadKey();

            //PUNTO N°5
            Galpon<int> galpon = new Galpon<int>();

            galpon.EsImpar += new CantidadImpar(Program.Manejador);

            try
            {
                galpon.Cantidad = 1;
            }
            catch (Exception e)
            {

                Console.WriteLine("Ocurrio un error " + e.Message);
            }

            // PUNTO N°6
            try
            {
                galpon.Cantidad = 0;
            }
            catch (ArgumentException e)
            {

                Console.WriteLine("Ocurrio un error: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

            // PUNTO N°7
            try
            {
                ClaseMetEstatico.metodoEstatico();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terminando en el MAIN." + e.Message + "" + e.InnerException.Message); ;
            }

            Console.ReadKey();


            // PUNTO N°8
            Galpon<Deposito> DepostioGalpon = new Galpon<Deposito>();

            Deposito D3 = new Deposito(4);

            D3._productos.SetValue(pro,0);
            D3._productos.SetValue(pI, 1);
            D3._productos.SetValue(pEX, 2);
            D3._productos.SetValue(p, 3);

            DepostioGalpon._elementos.Add(D3);

            DepostioGalpon.SerializarXML();

            // PUNTO N°9



        }


        /// <summary>
        /// Escribe en archivo de texto, fecha y el valor.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void Manejador(object obj, EventArgs args)
        {
            DateTime Time = new DateTime();
            Time = DateTime.Now;

            using (StreamWriter escritor = new StreamWriter("log.txt"))
            {
                escritor.WriteLine("Valor Impar: " + obj.ToString());
                escritor.WriteLine("Fecha y Hora: " + Time.ToString());
            }
        }
    }
}
