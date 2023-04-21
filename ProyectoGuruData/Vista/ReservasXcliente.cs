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
    public partial class ReservasXcliente : Form
    {
        //PASSWORD CON EL QUE SE LOGEA EL CLIENTE
        public TextBox txtPasswordCliente = LogIn.instance.txtPasswordCliente;

        public ReservasXcliente()
        {
            InitializeComponent();
        }

        private void ReservasXcliente_Load(object sender, EventArgs e)
        {
            loadMisReservas();
        }

        private void loadMisReservas()
        {
            String nifCliente = Nif(txtPasswordCliente);
            dgwMisReservas.AutoGenerateColumns = false;
            DATAguruContext db = new DATAguruContext();
            var misReservas = (from r in db.Reservas join a in db.Actividades on r.ActividadFk equals a.IdActividad where nifCliente == r.ClienteFk 
                               select new  {  estadoReserva = r.EstadoReserva, tipoActividad = a.tipoActividad, Hora = a.Hora, diaSemana = a.diaSemana }

                               );
            dgwMisReservas.DataSource = misReservas.ToList();

        }
                

        private void dgwMisReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        //BUSCAMOS NIF DEL CLIENTE
        private String Nif(TextBox password)
        {
            DATAguruContext db = new DATAguruContext();
            var nif = db.Clientes.Where(m => m.Password == password.Text.Trim()).FirstOrDefault();
            return nif.Nif;
        }
    }
}
