using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO7
{
    public class ClaseMetEstatico
    {
        public ClaseMetEstatico()
        {

        }

        public static void metodoEstatico()
        {
            try
            {
                ClaseMetInstancia obj = new ClaseMetInstancia();
                obj.metodoInstancia(); // lanzo mi excepcion.
            }
            catch (MiException e)
            {
                throw new MiException("Paso por metodo estatico - ", e);
            }
        }


    }
}
