using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//refencia
using PUNTO3;

namespace PUNTO4
{
    public class ProdImpuesto : Producto
    {
        public double _impuesto;


        public ProdImpuesto(string nombre, int stock, double impuesto) : base(nombre, stock)
        {
            this._impuesto = impuesto;
        }

        public ProdImpuesto()
        {

        }
    }
}
