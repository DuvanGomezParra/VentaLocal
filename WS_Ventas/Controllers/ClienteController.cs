using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WS_Ventas.Models;
using WS_Ventas.Models.Request;
using WS_Ventas.Models.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WS_Ventas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            Response oRespuesta = new Response();
            
            try
            {

                List<Cliente> lst = new List<Cliente>();

                using (var db = new VentaLocalContext())
                {
                    lst = db.Cliente.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Datos = lst;
                }

            }
            
            catch(Exception ex)
            {
                oRespuesta.Mensage = ex.Message;
            }
            return Ok(oRespuesta);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Add(ClienteRequest oModel)
        {
            Response oRespuesta = new Response();

            try
            {
                using (VentaLocalContext db = new VentaLocalContext())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Nombre = oModel.Nombre;
                    db.Cliente.Add(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensage = ex.Message;
            }

            return Ok(oRespuesta);
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put(ClienteRequest oModel)
        {
            Response oRespuesta = new Response();

            try
            {
                using (VentaLocalContext db = new VentaLocalContext())
                {
                    Cliente oCliente = new Cliente();
                    oCliente = db.Cliente.Find((long)oModel.Id);
                    oCliente.Nombre = oModel.Nombre;
                    db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensage = ex.Message;
            }

            return Ok(oRespuesta);


        }

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        [HttpDelete]
        public IActionResult Delete(ClienteRequest oModel)
        {
            Response oRespuesta = new Response();

            try
            {
                using (VentaLocalContext db = new VentaLocalContext())
                {
                    Cliente oCliente = new Cliente();
                    oCliente = db.Cliente.Find((long)oModel.Id);
                    db.Cliente.Remove(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensage = ex.Message;
            }

            return Ok(oRespuesta);

        }
    }
}
