using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioExcepciones
{
    class ErrorUsuarioRepetido: ApplicationException
    {
        String mensaje;
        public ErrorUsuarioRepetido(string mensaje)
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
