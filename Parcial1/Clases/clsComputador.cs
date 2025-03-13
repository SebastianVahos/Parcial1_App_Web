using Parcial1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Parcial1.Clases
{
    public class clsComputador
    {
        private VentaComputadoresItmEntities computador = new VentaComputadoresItmEntities();
        public Computador compu { get; set; }

        public string Insertar()
        {
            try
            {
                computador.Computadors.Add(compu);
                computador.SaveChanges();
                return "Equipo insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el equipo: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Computador comp = Consultar(compu.Codigo);
                if (comp == null)
                {
                    return "El computador con el codigo ingresado no existe, no se puede actualizar";
                }
                computador.Computadors.AddOrUpdate(compu);
                computador.SaveChanges();
                return "Se actualizo el computador correctamente";
            }
            catch (Exception ex)
            {
                return "No se pudo actualizar el equipo: " + ex.Message;
            }
        }

        public Computador Consultar(int Codigo)
        {
            return computador.Computadors.FirstOrDefault(c => c.Codigo == Codigo);
        }

        public List<Computador> ConsultarTodos()
        {
            return computador.Computadors.ToList();
        }

        public string Eliminar(int Codigo)
        {
            try
            {
                Computador comp = Consultar(Codigo);
                if (comp == null)
                {
                    return "El computador con el codigo ingresado no existe, no se puede eliminar";
                }
                computador.Computadors.Remove(comp);
                computador.SaveChanges();
                return "Se elimino el computador correctamente";
            }
            catch (Exception ex)
            {
                return "No se pudo eliminar el computador: " + ex.Message;
            }
        }
    }
}