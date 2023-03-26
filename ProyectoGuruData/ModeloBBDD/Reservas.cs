using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGuruData.ModeloBBDD
{
    public partial class Reservas
    {
        public string IdReserva { get; set; }
        public int? ReservaXcliente { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public string EstadoReserva { get; set; }
        public string ClienteFk { get; set; }
        public string ActividadFk { get; set; }

        public virtual Actividades ActividadFkNavigation { get; set; }
        public virtual Clientes ClienteFkNavigation { get; set; }
    }
}
