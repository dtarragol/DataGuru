using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGuruData
{
    public class Actividad
    {

        public int idActividad { get; set; }
        public int plazas { get; set; }
        public string nombreActividad { get; set; }


        public enum DiaSemana
        {
            Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
        }
        public DiaSemana diaSemana { get; set; }

        public enum TipoActividad
        {
            Zumba, Pilates, BodyPump
        }
        public TipoActividad tipoActividad { get; set; }

        public Actividad(int idActividad, int plazas, string nombreActividad, DiaSemana diaSemana, TipoActividad tipoActividad) 
        {
            this.idActividad = idActividad;
            this.plazas = plazas;   
            this.nombreActividad = nombreActividad;
            this.diaSemana = diaSemana;
            this.tipoActividad = tipoActividad;
        }  
    }
}
