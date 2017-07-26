using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO7
{
    public class MiException:Exception
    {
        public MiException(string msg):base(msg)
        {

        }

        public MiException(string msg, Exception inner):base(msg,inner)
        {

        }

    }
}
