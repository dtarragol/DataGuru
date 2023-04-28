
using ProyectoGuruData.ModeloBBDD;
using ProyectoGuruData.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoGuruData.Vista
{

    public partial class FormReservas : Form
    {
        //public TextBox txtPasswordCliente = Vista.FormLogin.instance.txtPasswordCliente;
        Reservas reserva = new Reservas();  // instanciamos una reserva
        public FormReservas()
        {
            InitializeComponent();
            InitializeComboBox();
            CargarGrid();

        }

        private void InitializeComboBox()
        {

            List<string> opciones = new List<string> { "Zumba", "Pilates", "BodyPump" };
            comboBoxActividad.Items.AddRange(opciones.ToArray());

        }


        private void FormReservas_Load(object sender, EventArgs e)
        {



        }

        void clear()
        {
            txtId.Text = txtCliente.Text = txtRCliente.Text = txtFechaHora.Text = comboBoxActividad.Text = txtEstadoReserva.Text = "";
        }

        private void CargarGrid()
        {
            try
            {
                DATAguruContext db = new DATAguruContext(); // crear conexión con BBDD
                var Datos = db.Reservas.ToList<Reservas>();
                gridReservas.DataSource = Datos;
                gridReservas.Columns.Remove("ActividadFkNavigation");
                gridReservas.Columns.Remove("ClienteFkNavigation");
                gridReservas.Columns["Eliminar"].DisplayIndex =6;
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                             
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            DATAguruContext db = new DATAguruContext(); // crear conexión con BBDD



            if (txtId.Text != "" && txtFechaHora.Text != "" && txtCliente.Text != "")
            {
                string ActividadFk = comboBoxActividad.SelectedItem.ToString();
                reserva.IdReserva = txtId.Text.Trim();
                reserva.ReservaXcliente = int.Parse(txtRCliente.Text.Trim());
                reserva.ClienteFk = txtCliente.Text;
                reserva.ActividadFk = ActividadFk;
                string tiempoStr = txtFechaHora.Text.Trim();
                // Convertir la cadena a un objeto DateTime utilizando el método ParseExact
                DateTime hora = DateTime.ParseExact(tiempoStr, "dd/MM/yyyy HH:mm", null);

                reserva.FechaHoraReserva = hora;
                reserva.EstadoReserva = txtEstadoReserva.Text.Trim();
                db.Reservas.Add(reserva);
                db.SaveChanges();
                clear();
                CargarGrid();


                MessageBox.Show("La reserva se ha añadido correctamente");


            }

            else
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarReserva(String pId)
        {
            DATAguruContext db = new DATAguruContext(); // crear conexión con BBDD
            db.Reservas.Remove(db.Reservas.Single(p => p.IdReserva == pId));
            db.SaveChanges();
        }

        private void gridReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridReservas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string Id = gridReservas.CurrentRow.Cells["Idreserva"].Value.ToString();
                EliminarReserva(Id);
                MessageBox.Show("La reserva se ha eliminado correctamente");
                CargarGrid();

            }
        }
    }

}