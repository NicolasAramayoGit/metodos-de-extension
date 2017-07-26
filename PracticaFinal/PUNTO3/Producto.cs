using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO3
{
    [Serializable]
    public class Producto
    {
        public string _nombre;
        public int _stock;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public int Stock
        {
            get
            {
                return this._stock;
            }

            set
            {
                this._stock = value;
            }
        }

        public Producto()
        {

        }

        public Producto(string nombre, int stock)
        {
            this._stock = stock;
            this._nombre = nombre;
        }
    }
}
