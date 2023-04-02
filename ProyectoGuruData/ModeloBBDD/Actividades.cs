using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGuruData.ModeloBBDD
{
    public partial class Actividades
    {
        public Actividades()
        {
            Reservas = new HashSet<Reservas>();
        }

        public string IdActividad { get; set; }
        
        public string diaSemana { get; set; }
        
        public string tipoActividad { get; set; }
        //public string Hora { get; set; }
        public TimeSpan? Hora { get; set; }

        public int? Plazas { get; set; }

        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}
