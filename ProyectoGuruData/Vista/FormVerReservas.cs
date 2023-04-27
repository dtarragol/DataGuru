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
    public partial class FormVerReservas : Form
    {
        public FormVerReservas()
        {
            InitializeComponent();
        }

        private void VerReservas_Load(object sender, EventArgs e)
        {
            loadReservas();
        }

        private void loadReservas()
        {
            tablaReservas.AutoGenerateColumns = false;
            DATAguruContext db = new DATAguruContext();
            var reservas = (from r in db.Reservas
                            join a in db.Actividades on r.ActividadFk equals a.IdActividad
                            join c in db.Clientes on r.ClienteFk equals c.Nif
                            select new
                            {
                                IdReserva = r.IdReserva,
                                ReservaXcliente = r.ReservaXcliente,
                                FechaHoraReserva = r.FechaHoraReserva,
                                EstadoReserva = r.EstadoReserva,
                                Nif = c.Nif,
                                tipoActividad = a.tipoActividad
                            });
            tablaReservas.DataSource = reservas.ToList();
        }
    }
}
