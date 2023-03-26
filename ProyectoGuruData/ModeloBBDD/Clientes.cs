using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGuruData.ModeloBBDD
{
    public partial class Clientes
    {
        public Clientes()
        {
            Reservas = new HashSet<Reservas>();
        }

        public string Nif { get; set; }
        public string Nombre { get; set; }
        public int? Telefono { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}
