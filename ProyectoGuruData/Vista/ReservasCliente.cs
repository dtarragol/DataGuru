using Microsoft.EntityFrameworkCore;
using ProyectoGuruData.ModeloBBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGuruData.Vista
{
    public partial class ReservasCliente : Form
    {
        Reservas reservas = new Reservas();
        Reservas hacerReserva = new Reservas();
        Reservas cambiarEstado = new Reservas();




        public TextBox txtPasswordCliente = LogIn.instance.txtPasswordCliente;
        public ReservasCliente()
        {
            InitializeComponent();
        }

        private void ReservasCliente_Load(object sender, EventArgs e)
        {
            loadGridAvtividades();
        }


        // Rellenar la tabla de Actividades con datos 
        void loadGridAvtividades()
        {
            gridActividades.AutoGenerateColumns = false;
            DATAguruContext db = new DATAguruContext();
            gridActividades.DataSource = db.Actividades.ToList<Actividades>();
        }

        //FUNCION DE LOS BOTONES 
        private void gridActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATAguruContext db = new DATAguruContext();
            String nifCliente = Nif(txtPasswordCliente);

            //BOTON ANULAR RESERVA

            if (gridActividades.Columns[e.ColumnIndex].Name == "Anular")
            {

                anularReserva(e);


            }


            //BOTON HACER RESERVA
            if (gridActividades.Columns[e.ColumnIndex].Name == "Reservar")
            {
                reservarActividad(e);
            }



        }


        // FUNCION ANULAR RESERVA
        private void anularReserva(DataGridViewCellEventArgs e)
        {

            DATAguruContext db = new DATAguruContext();
            String nifCliente = Nif(txtPasswordCliente);
            reservas = db.Reservas.Where(m => m.ClienteFk == nifCliente && m.ActividadFk == gridActividades.Rows[e.RowIndex].Cells["idActividad"].FormattedValue.ToString()).FirstOrDefault();
            if (reservas != null)
            {
                db.Reservas.Remove(reservas);
                db.SaveChanges();
                MessageBox.Show("la actividad se ha anulado correctamente");
            }
            else
            {
                MessageBox.Show("Usted no está incrito en esta actividad");
            }
            actualizarListaEspera(e);

        }


        //FUNCION HACER RESERVA

        private void reservarActividad(DataGridViewCellEventArgs e)
        {
            actualizarListaEspera(e);

            DATAguruContext db = new DATAguruContext();
            String nifCliente = Nif(txtPasswordCliente);

            String idActividad = gridActividades.Rows[e.RowIndex].Cells["idActividad"].FormattedValue.ToString();

            String diaSemanaActividad = gridActividades.Rows[e.RowIndex].Cells["diaSemana"].FormattedValue.ToString();


            List<Reservas> listaEspera = new List<Reservas>();
            // Contamos cuanta gente hay apuntada en Actividad

            int cantidades = db.Reservas.Where(m => m.ActividadFk == idActividad).Count();
            int cantReservasahora = db.Reservas.Where(m => m.ClienteFk == nifCliente).Count();

            var query = (from r in db.Reservas
                         join a in db.Actividades on r.ActividadFk equals a.IdActividad
                         where r.ClienteFk == nifCliente
                         select a.diaSemana
                               );
            int vecesXsemana = query.Count();

            //int countReservasXcliente = db.Reservas.Where(m => m.ActividadFk == idActividad && m.ClienteFk == nifCliente).Count();

            if (cantidades >= 3)
            {
                if (cantReservasahora < 2)
                {
                    if (txtIdReserva.Text != "" && idExiste(txtIdReserva.Text) == false)
                    {
                        MessageBox.Show("Usted se ha apuntado a la lista de espera");

                        hacerReserva.IdReserva = txtIdReserva.Text.Trim();
                        hacerReserva.ReservaXcliente = 2;
                        hacerReserva.FechaHoraReserva = DateTime.Now;
                        hacerReserva.EstadoReserva = "ListaEspera";
                        hacerReserva.ClienteFk = nifCliente;
                        hacerReserva.ActividadFk = idActividad;
                        db.Reservas.Add(hacerReserva);
                        db.SaveChanges();
                    }
                    else { MessageBox.Show("Por favor, introduce otro Id de la reserva"); }
                }
                else
                {
                    MessageBox.Show("No se puede reservar mas de dos actividades al dia");
                }



            }
            else
            {   // metemos la reserva en la bbdd
                if (cantReservasahora < 2)
                {
                    if (txtIdReserva.Text != "" && idExiste(txtIdReserva.Text) == false)
                    {
                        hacerReserva.IdReserva = txtIdReserva.Text.Trim();
                        hacerReserva.ReservaXcliente = 2;
                        hacerReserva.FechaHoraReserva = DateTime.Now;
                        hacerReserva.EstadoReserva = "Aceptada";
                        hacerReserva.ClienteFk = nifCliente;
                        hacerReserva.ActividadFk = idActividad;

                        db.Reservas.Add(hacerReserva);
                        db.SaveChanges();

                        MessageBox.Show("La reserva se ha procesado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, introduce otro Id de la reserva");
                    }

                }
                else { MessageBox.Show("No se puede reservar mas de dos actividades al dia"); }


            }


        }


        //BUSCAMOS NIF DEL CLIENTE
        private String Nif(TextBox password)
        {
            DATAguruContext db = new DATAguruContext();
            var nif = db.Clientes.Where(m => m.Password == password.Text.Trim()).FirstOrDefault();
            return nif.Nif;
        }



        private void actualizarListaEspera(DataGridViewCellEventArgs e)
        {
            DATAguruContext db = new DATAguruContext();
            String idActividad = gridActividades.Rows[e.RowIndex].Cells["idActividad"].FormattedValue.ToString();
            int cantidades = db.Reservas.Where(m => m.ActividadFk == idActividad && m.EstadoReserva == "Aceptada").Count();
            List<Reservas> listaEspera = new List<Reservas>();
            //int idMin; 


            if (cantidades < 3)
            {
                int min = 100;
                String convert;

                listaEspera = db.Reservas.Where(m => m.ActividadFk == idActividad && m.EstadoReserva == "ListaEspera").ToList();
                foreach (var i in listaEspera)
                {
                    if (min > Int32.Parse(i.IdReserva))
                    {
                        min = Int32.Parse(i.IdReserva);
                    }

                    convert = min.ToString();
                    cambiarEstado = db.Reservas.Where(m => m.IdReserva == convert).FirstOrDefault();

                    // idMin = i.IdReserva.Min();
                    // var pendiente = db.Reservas.Where(m => m.IdReserva == idMin.ToString());
                    // cambiarEstado = db.Reservas.Where(m => m.IdReserva == pendiente.ToString()).FirstOrDefault();

                    if (cambiarEstado != null)
                    {
                        cambiarEstado.EstadoReserva = "Aceptada";
                        db.SaveChanges();
                    }


                }

            }

        }

        public Boolean idExiste(String idReserva)
        {
            bool existeBBDDD = false;

            DATAguruContext db = new DATAguruContext();
            var existe = db.Reservas.Where(m => m.IdReserva == idReserva).FirstOrDefault();

            if (existe != null)
            {
                existeBBDDD = true;
            }
            return existeBBDDD;
        }




    }
}
