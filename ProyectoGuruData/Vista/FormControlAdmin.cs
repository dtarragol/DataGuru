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
    public partial class FormControlAdmin : Form
    {
        public FormControlAdmin()
        {
            InitializeComponent();
        }

        //BOTON PARA MANEJAR CLIENTES: ADMIN
        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FormAddCliente formCliente = new FormAddCliente();
            formCliente.Show();
        }

        private void btnGestionActividades_Click(object sender, EventArgs e)
        {
            //BOTON PARA MANEJAR ARTICULOS: ADMIN
            FormActividades actv = new FormActividades();
            actv.Show();



        }

        private void btnMostrarReservasEspera_Click(object sender, EventArgs e)
        {
            //BOTON PARA VER RESERVAS PENDIENTES: ADMIN
            FormVerReservasEspera formVerReservasEspera = new FormVerReservasEspera();
            formVerReservasEspera.Show();
        }

        private void btnMostrarReservasTodas_Click(object sender, EventArgs e)
        {
            //BOTON PARA VER TODAS LAS RESERVAS: ADMIN
            FormVerReservas formVerReservas = new FormVerReservas();
            formVerReservas.Show();
        }

        private void btnHacerReserva_Click(object sender, EventArgs e)
        {
            
            FormReservas reservas= new FormReservas();
            reservas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdoo_Click(object sender, EventArgs e)
        {
            FormOdoo odoo = new FormOdoo();
            odoo.Show();
        }
    }
}
