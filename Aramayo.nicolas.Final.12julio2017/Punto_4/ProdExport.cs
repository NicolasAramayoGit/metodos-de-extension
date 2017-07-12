using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    public class ProdExport:ProdImpuesto
    {
        public string _exportacion;

        public ProdExport(ProdImpuesto prodImpuesto, string exportacion):base(prodImpuesto,prodImpuesto._impuesto)
        {
            this._exportacion = exportacion;
        }
    }
}
