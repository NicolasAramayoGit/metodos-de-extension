using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    public class ProdVendido:ProdExport
    {
        public string _cliente;


        public ProdVendido(ProdExport prodExport, string cliente):base(prodExport)
        {
            this._cliente = cliente;
        }
    }
}
