using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    public class Deposito
    {
        
        public Producto[] _productos;

        public Deposito (int valor)
	    {
            this._productos = new Producto[valor];
	    }


        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            bool repetido = false;
            Producto[] aux = new Producto[d1._productos.Length + d2._productos.Length];

            for (int i = 0; i < aux.Length; i++)
            {
                aux[i] = null;
            }

            for (int i = 0; i < d2._productos.Length; i++)
            {
                for (int j = 0; j < aux.Length; j++)
                {
                    if (aux[j] != null && d2._productos[i] != null)
                    {
                        if (aux[j]._nombre == d2._productos[i]._nombre)
                        {
                            aux[j]._stock += aux[j]._stock;
                            repetido = true;
                        }
                    }
                }

                if (!repetido)
                {
                    for (int k = 0; k < aux.Length; k++)
                    {
                        if (aux[k] == null)
                        {
                            aux[k] = d2._productos[i];
                            break;
                        }
                    }
                }

                repetido = false;
            }

            return aux;

        }



    }
}
