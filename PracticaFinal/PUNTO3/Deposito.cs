using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO3
{
    [Serializable]
    public class Deposito
    {
        public Producto[] _productos;

        /// <summary>
        /// Inicializa el prod de productos.
        /// </summary>
        /// <param name="valor"></param>
        public Deposito(int valor)
        {
            this._productos = new Producto[valor];
        }

        public Deposito()
        {

        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] aux = new Producto[d1._productos.Length + d2._productos.Length];

            // SUMA EL STOCK DE LOS PRODUCTOS REPETIDOS Y LOS AGREGA AL ARRAY PRODUCTOS AUXILIAR,
            // TODOS LOS PRODUCTOS DEL ARRAY D2.
            for (int i = 0; i < d2._productos.Length; i++)
            {
                for (int j = 0; j < d1._productos.Length; j++)
                {   // SUMO EL STOCK DE PRODUCTOS REPETIDOS.
                    if (d2._productos[i]._nombre == d1._productos[j]._nombre)
                    {
                        d2._productos[i]._stock += d1._productos[j]._stock;
                    }
                }

                // AGREGO TODOS LOS PRODUCTOS D2 CON STOCK'S SUMADOS.
                for (int k = 0; k < aux.Length; k++)
                {
                    if (aux[k] == null)
                    {
                        aux[k] = d2._productos[i];
                        break;
                    }
                }
            }

            // AGREGO EL OTRO ARRAY D1, AL AUXILIAR, SIN REPETIR ELEMENTOS.
            for (int i = 0; i < d1._productos.Length; i++)
            {
                bool repetido = false;

                for (int j = 0; j < d2._productos.Length; j++)
                {
                    if (d1._productos[i]._nombre == d2._productos[j]._nombre)
                    {
                        repetido = true;
                    }
                }

                // SI ESTA REPETIDO, CONTINUO, SIN AGREGAR.
                if (repetido)
                {
                    continue;
                }
                else
                {   // SI NO, AGREGO EN ÍNDICES DISPONIBLES.
                    for (int k = 0; k < aux.Length; k++)
                    {
                        if (aux[k] == null)
                        {
                            aux[k] = d1._productos[i];
                            break;
                        }
                    }
                }
            }

            // MUESTRO POR CONSOLA.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******** PRODUCTOS **********");
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == null)
                    break;

                sb.AppendLine("Nombre: " + aux[i]._nombre);
                sb.AppendLine("Stock: " + aux[i]._stock.ToString());
                sb.AppendLine("----------------------------------");
            }

            Console.WriteLine(sb.ToString());

            return aux;
        }
    }
}
