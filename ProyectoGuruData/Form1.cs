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

namespace ProyectoGuruData
{
    public partial class Form1 : Form
    {
        Clientes cliente = new Clientes();  // instanciamos un Cliente 
        public Form1()
        {            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void clear()
        {
            txtNif.Text = txtNombre.Text = txtTelefono.Text = txtMail.Text = txtPassword.Text = "";
        }

        // BOTON AÑADIR CLIENTE
        private void btnSave_Click(object sender, EventArgs e)
        {
            cliente.Nif = txtNif.Text.Trim();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Telefono = int.Parse(txtTelefono.Text.Trim());
            cliente.Mail = txtMail.Text.Trim();
            cliente.Password = txtPassword.Text.Trim();

            DATAguruContext db = new DATAguruContext(); // para hacer la conexión con BBDD
            db.Clientes.Add(cliente);
            db.SaveChanges();
            clear();
            MessageBox.Show("El cliente se ha añadido correctamente");

        }
    }
}
