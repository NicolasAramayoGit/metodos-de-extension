using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// REFENCIAS.
using PUNTO8;
using System.Xml.Serialization;
using System.Xml;
using PUNTO4;
using PUNTO3;

namespace PUNTO5
{
    // DELEGADO.
    public delegate void CantidadImpar(object sender, EventArgs e);

    [XmlInclude(typeof(Deposito))]
    [XmlInclude(typeof(ProdImpuesto))]
    [XmlInclude(typeof(ProdExport))]
    [XmlInclude(typeof(ProdVendido))]
    [XmlInclude(typeof(Producto))]
    public class Galpon<T>:IGuardarXML
    {
        //DECLARO EVENTO.
        public event CantidadImpar EsImpar;

        private int _cantidad;
        public List<T> _elementos;

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("No se puede ingresar cero...");
                }

                if (value % 2 != 0)
                {
                    this.EsImpar(value, new EventArgs());
                }

                this._cantidad = value;
            }
        }


        public Galpon()
        {
            this._elementos = new List<T>();
        }

        public bool SerializarXML()
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Galpon<T>));
                using (XmlTextWriter escritor = new XmlTextWriter("archivos.xml",Encoding.UTF8))
                {
                    serializador.Serialize(escritor, this);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("No se pudo Serializar con éxito..." + e.Message);
                return false;
            }

            return true;
        }
    }
}
