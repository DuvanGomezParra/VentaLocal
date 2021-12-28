using System;
using System.Linq;
using System.Threading.Tasks;

namespace WS_Ventas.Models.Response
{
    public class Response
    {

        public int Exito { get; set; }
        public string Mensage { get; set; }
        public object Datos { get; set; }

        public Response()
        {
            this.Exito = 0;
        }

     }
}
