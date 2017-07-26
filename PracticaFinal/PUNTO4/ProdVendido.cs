using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO4
{
    public class ProdVendido:ProdExport
    {
        public string _cliente;


        public ProdVendido(ProdExport prodExport, string cliente) : base(prodExport, prodExport._exportado)
        {
            this._cliente = cliente;
        }

        public ProdVendido()
        {

        }
    }
}
