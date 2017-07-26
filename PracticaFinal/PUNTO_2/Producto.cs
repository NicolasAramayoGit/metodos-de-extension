using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_2
{
    public class Producto
    {
        public string _nombre;
        public int _stock;

        public string Nombre
        {
            get
            {
                return this.Nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public Producto(string nombre, int stock)
        {
            this._stock = stock;
            this._nombre = nombre;
        }


    }
}
