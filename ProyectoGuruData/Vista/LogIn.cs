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
    public partial class FormLogin : Form
    {
        public static FormLogin instance;  // para acceder a sus datos desde otors forms
        public TextBox txtPasswordCliente;
        public FormLogin()
        {
            InitializeComponent();
            instance = this;      // para acceder a sus datos desde otors forms
            txtPasswordCliente = txtPassword;
        }

        //BOTON LOGIN DEL ADMINISTRADOR
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormControlAdmin formAdmin = new FormControlAdmin();
            DATAguruContext db = new DATAguruContext(); // para hacer la conexión con BBDD

            var adminLogin = db.Clientes.Where(m => m.Mail == txtMail.Text.Trim() && m.Password == txtPassword.Text.Trim()).FirstOrDefault();
             if (adminLogin != null && adminLogin.Mail== "admin@gmail.com")
            {
                formAdmin.Show();
            }
            else
            {
                MessageBox.Show("Has introducido datos incorrrectos o no tienes derechos de Administrador");
            }
        }

        private void btnLogInCliente_Click(object sender, EventArgs e)
        {
            FormVistaCliente vistaCli = new FormVistaCliente();
            DATAguruContext db = new DATAguruContext(); // para hacer la conexión con BBDD

            var clienteLogin = db.Clientes.Where(m => m.Mail == txtMail.Text.Trim() && m.Password == txtPassword.Text.Trim()).FirstOrDefault();
            if (clienteLogin != null)
            {
                vistaCli.Show();
            }
            else
            {
                MessageBox.Show("Has introducido datos incorrrectos");
            }


        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
