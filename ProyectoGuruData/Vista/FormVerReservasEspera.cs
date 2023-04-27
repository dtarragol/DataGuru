using ProyectoGuruData.ModeloBBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGuruData.Vista
{
    public partial class FormVerReservasEspera : Form
    {
        public FormVerReservasEspera()
        {
            InitializeComponent();
        }

        private void VerReservasEspera_Load(object sender, EventArgs e)
        {
            loadReservasEspera();
        }

        private void loadReservasEspera()
        {
            tablaReservasEspera.AutoGenerateColumns = false;
            DATAguruContext db = new DATAguruContext();
            var reservas = (from r in db.Reservas
                            join a in db.Actividades on r.ActividadFk equals a.IdActividad
                            join c in db.Clientes on r.ClienteFk equals c.Nif
                            where r.EstadoReserva == "Pendiente"
                            select new
                            {
                                estadoReserva = r.EstadoReserva,
                                IdReserva = r.IdReserva,
                                tipoActividad = a.tipoActividad,
                                FechaHoraReserva = r.FechaHoraReserva,
                                Nif = c.Nif
                            });

            tablaReservasEspera.DataSource = reservas.ToList();
        }
    }
}
