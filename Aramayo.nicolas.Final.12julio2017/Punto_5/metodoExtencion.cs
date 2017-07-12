using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    public static class metodoExtencion
    {
        public static bool EsPar(this int val)
        {
            return val % 2 == 0;
        }

        public static bool EsImpar(this int val)
        {
            if (!val.EsPar())
            {
                return true;
            }
            return false;
        }

    }
}
