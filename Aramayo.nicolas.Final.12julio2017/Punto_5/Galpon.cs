using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Punto_5
{
    public delegate void EventHandler(object obj, EventArgs args);

    [Serializable]
    public class Galpon<T>
    {
        public event EventHandler EsImpar;

        public List<T> _lista;
        private int _cantidad;

        public int Cantidad
        {

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("No se le puede asignar cero 0...");
                }
                //hacer metodo extencion
                if (value.EsPar())
                {
                    this._cantidad = value;
                }

                if (value.EsImpar())
                {
                    this._cantidad = value;
                    this.EsImpar(this.ToString(), null);
                }
            }
        }

        public Galpon()
        {

        }

        public bool SerializarXML()
        {
            XmlSerializer Serializador = new XmlSerializer(typeof(Galpon<T>));
            using (XmlTextWriter escritor = new XmlTextWriter("datos.xml", Encoding.UTF8))
            {
                Serializador.Serialize(escritor, this);
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(this._cantidad.ToString());

            return sb.ToString();
        }
    }

    

}
