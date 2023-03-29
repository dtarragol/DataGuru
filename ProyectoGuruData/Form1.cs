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
using System.Xml.Linq;

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
            TablaCliente();
        }

        void clear()
        {
            txtNif.Text = txtNombre.Text = txtTelefono.Text = txtMail.Text = txtPassword.Text = "";
        }

        // BOTON AÑADIR CLIENTE
        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            DATAguruContext db = new DATAguruContext(); // para hacer la conexión con BBDD

            if (txtNif.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtMail.Text != "" && txtPassword.Text != "")
            {
                cliente.Nif = txtNif.Text.Trim();
                cliente.Nombre = txtNombre.Text.Trim();
                if(!int.TryParse(txtTelefono.Text, out i))
                {
                    MessageBox.Show("Introduce valores numéricos en el cámpo 'Teléfono'");
                }
                else
                {
                    cliente.Telefono = int.Parse(txtTelefono.Text.Trim());
                    cliente.Mail = txtMail.Text.Trim();
                    cliente.Password = txtPassword.Text.Trim();
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                    clear();
                    TablaCliente();
                    MessageBox.Show("El cliente se ha añadido correctamente");
                }
              
            } 
            else
            {               
                MessageBox.Show("Por favor, rellene todos los campos");
            }
           
                 
                     

        }

        // Rellenar la tabla de Cliente con Columnas 
        void TablaCliente()
        {
            dgvClientes.AutoGenerateColumns = false;
            DATAguruContext db = new DATAguruContext();
            dgvClientes.DataSource = db.Clientes.ToList<Clientes>();
        }


        // BOTON PARA GENERAR XML PARA LA TABLA CLEINTES
        private void btnXML_Click(object sender, EventArgs e)
        {
            DATAguruContext db = new DATAguruContext();
            XElement xml = new XElement("Clientes",
                               (from columna in db.Clientes
                               select new
                               {
                                   columna.Nif,
                                   columna.Nombre,
                                   columna.Telefono,
                                   columna.Mail,
                                   columna.Password
                               }).ToList().Select(
                                           x => new XElement("Cliente",
                                                new XAttribute("NIF", x.Nif),
                                                new XAttribute("Nombre", x.Nombre),
                                                new XAttribute("Teléfono", x.Telefono),
                                                new XAttribute("Mail", x.Mail),
                                                new XAttribute("Contraseña", x.Password)
                                           )));
           
            xml.Save(@"C:\Users\ciner\OneDrive\Escritorio\NET\DataGuru\ProyectoGuruData\XMLcreado\\clientes.xml");
            MessageBox.Show("El XML se ha generado correctamente");



        }
    }
}
