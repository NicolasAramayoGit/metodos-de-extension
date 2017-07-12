using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_3;

namespace Punto_4
{
    public class ProdImpuesto:Producto
    {
        public double _impuesto;

        public ProdImpuesto(Producto prod, double impuesto)
            : base(prod._nombre, prod._stock)
        {
            this._impuesto = impuesto;
        }



    }
}
