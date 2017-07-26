using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO4
{
    public class ProdExport:ProdImpuesto
    {
        public string _exportado;


        public ProdExport(ProdImpuesto prodImpuesto, string exportadoDe) : base(prodImpuesto.Nombre, prodImpuesto.Stock, prodImpuesto._impuesto)
        {
            this._exportado = exportadoDe;
        }

        public ProdExport()
        {

        }
    }
}
