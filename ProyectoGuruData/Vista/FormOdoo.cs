using ProyectoGuruData.ModeloBBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoGuruData.Vista
{
    public partial class FormOdoo : Form
    {
        public FormOdoo()
        {
            InitializeComponent();
        }

        private void btnCargarCientes_Click(object sender, EventArgs e)
        {
            //exportamos un XML con Clientes

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

            FileStream xmlFile = File.OpenWrite(@"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\\Clientes.xml");
            byte[] xmlBytes = Encoding.UTF8.GetBytes(xml.ToString());
            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
            xmlFile.Close();

            // pasamos el xml al programa python
            var script = @"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\OdooClientes.py";        // ESCIRBIR LA DIRECCIÓN DEL PY

            var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\python.exe"; //// 
            psi.FileName = @"C:\Users\kater\AppData\Local\Programs\Python\Python311\python.exe";
            psi.Arguments = $"\"{script}\"";
            Process process = new Process();
            process.StartInfo = psi;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true; 
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            process.StartInfo.RedirectStandardOutput = true;

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                MessageBox.Show(line);
            }
            process.WaitForExit();

            MessageBox.Show("Se han cargado los datos a Odoo");

        }

        private void FormOdoo_Load(object sender, EventArgs e)
        {

        }

        private void btnActividadesOdoo_Click(object sender, EventArgs e)
        {
            //exportamos un XML con las Actividades

            DATAguruContext db = new DATAguruContext();
            XElement xml = new XElement("Actividades",
                               (from columna in db.Actividades
                                select new
                                {
                                    columna.IdActividad,
                                    columna.tipoActividad,
                                    columna.Hora,
                                    columna.diaSemana,
                                    columna.Plazas
                                }).ToList().Select(
                                           x => new XElement("Actividad",
                                                new XAttribute("Id", x.IdActividad),
                                                new XAttribute("Tipo", x.tipoActividad),
                                                new XAttribute("Hora", x.Hora),
                                                new XAttribute("DiaSemana", x.diaSemana),
                                                new XAttribute("Plazas", x.Plazas)
                                           )));

            FileStream xmlFile = File.OpenWrite(@"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\\Actividades.xml");
            byte[] xmlBytes = Encoding.UTF8.GetBytes(xml.ToString());
            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
            xmlFile.Close();

            // pasamos el xml al programa python
            var script = @"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\OdooActividades.py";        // ESCIRBIR LA DIRECCIÓN DEL PY      

            var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\python.exe"; //// 
            psi.FileName = @"C:\Users\kater\AppData\Local\Programs\Python\Python311\python.exe";
            psi.Arguments = $"\"{script}\"";
            Process process = new Process();
            process.StartInfo = psi;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            process.StartInfo.RedirectStandardOutput = true;

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                MessageBox.Show(line);
            }
            process.WaitForExit();

            MessageBox.Show("Se han cargado los datos a Odoo");
        }

        private void btnReservasOdoo_Click(object sender, EventArgs e)
        {
            //exportamos un XML con Reservas

            DATAguruContext db = new DATAguruContext();
            XElement xml = new XElement("Reservas",
                               (from columna in db.Reservas
                                select new
                                {
                                    columna.IdReserva,
                                    columna.ReservaXcliente,
                                    columna.FechaHoraReserva,
                                    columna.EstadoReserva,
                                    columna.ClienteFk,
                                    columna.ActividadFk
                                }).ToList().Select(
                                           x => new XElement("Reservas",
                                                new XAttribute("Id", x.IdReserva),
                                                new XAttribute("ReservaxCliente", x.ReservaXcliente),
                                                new XAttribute("FechayHora", x.FechaHoraReserva),
                                                new XAttribute("Estado", x.EstadoReserva),
                                                new XAttribute("Cliente", x.ClienteFk),
                                                new XAttribute("Actividad", x.ActividadFk)
                                           )));

            FileStream xmlFile = File.OpenWrite(@"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\\Reservas.xml");
            byte[] xmlBytes = Encoding.UTF8.GetBytes(xml.ToString());
            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
            xmlFile.Close();

            // pasamos el xml al programa python
            var script = @"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\OdooReservas.py";        // ESCIRBIR LA DIRECCIÓN DEL PY        
            var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\kater\OneDrive\Documentos\NET_PROD4\DataGuru\ProyectoGuruData\Controlador\python.exe"; //// 
            psi.FileName = @"C:\Users\kater\AppData\Local\Programs\Python\Python311\python.exe";
            psi.Arguments = $"\"{script}\"";
            Process process = new Process();
            process.StartInfo = psi;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            process.StartInfo.RedirectStandardOutput = true;

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                MessageBox.Show(line);
            }
            process.WaitForExit();

            MessageBox.Show("Se han cargado los datos a Odoo");
        }
    }
}
