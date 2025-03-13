using Parcial1.Clases;
using Parcial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial1.Controllers
{
    [RoutePrefix("api/Computador")]
    public class ComputadorsController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXCodigo")]
        public Computador ConsultarXCodigo(int Codigo)
        {
            clsComputador computador = new clsComputador(); 
            return computador.Consultar(Codigo);
        }
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Computador> ConsultarTodos()
        {
            clsComputador computador = new clsComputador();
            return computador.ConsultarTodos();
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Computador Computador)
        {
            clsComputador computador = new clsComputador();
            computador.compu = Computador;
            return computador.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Computador Computador)
        {
            clsComputador computador = new clsComputador();
            computador.compu = Computador;
            return computador.Actualizar();
        }
        [HttpDelete]
        [Route("EliminarXCodigo")]
        public string EliminarXCodigo(int Codigo)
        {
            clsComputador computador = new clsComputador();
            return computador.Eliminar(Codigo);
        }
    }
}