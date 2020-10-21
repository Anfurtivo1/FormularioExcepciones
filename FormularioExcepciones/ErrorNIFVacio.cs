using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioExcepciones
{
    class ErrorNIFVacio: ApplicationException
    {
        String mensaje;
        public ErrorNIFVacio(string mensaje)
        {
            this.mensaje = mensaje;
        }
        public string Message
        {
            get
            {
                return this.mensaje;
            }
        }
    }
}
