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
    public partial class FormVistaCliente : Form
    {
        public FormVistaCliente()
        {
            InitializeComponent();
        }

        private void btnReservarActv_Click(object sender, EventArgs e)
        {
            ReservasCliente reservasCliente = new ReservasCliente();
            reservasCliente.Show();
        }
    }
}
