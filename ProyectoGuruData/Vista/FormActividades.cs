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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoGuruData
{
    public partial class FormActividades : Form
    {
        Actividades actividad = new Actividades();
        public FormActividades()
        {
            InitializeComponent();
            InitializeComboBox();
            cargarTablaActividades();
        }

        private void InitializeComboBox()
        {
            //comboBoxActividades.Items.AddRange(Actividades.TipoActividad.GetNames(typeof(Actividades.TipoActividad)));
            //comboBoxDia.Items.AddRange(Actividades.TipoActividad.GetNames(typeof(Actividades.DiaSemana)));
            List<string> opciones = new List<string> { "Zumba", "Pilates", "BodyPump" };
            comboBoxActividades.Items.AddRange(opciones.ToArray());
            List<string> opciones2 = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            comboBoxDia.Items.AddRange(opciones2.ToArray());
        }

        
        private void cargarTablaActividades()
        {
            tablaActividades.AutoGenerateColumns = false;
            DATAguruContext db = new DATAguruContext();
            tablaActividades.DataSource = db.Actividades.ToList<Actividades>();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int i = 0;
            DATAguruContext db = new DATAguruContext(); // para hacer la conexión con BBDD

            
            if ( txtPlazas.Text != "" && txtHora.Text != "")
            {
                string tipoActividad = comboBoxActividades.SelectedItem.ToString();
                string Dia = comboBoxDia.SelectedItem.ToString();
                
                if (!int.TryParse(txtPlazas.Text, out i))
                {
                    MessageBox.Show("Introduce valores numéricos en el cámpo 'Plazas'");
                }
                else
                {
                    actividad.tipoActividad = tipoActividad;
                    actividad.diaSemana = Dia;

                    actividad.IdActividad = txtIDActividad.Text.Trim();
                    actividad.Plazas = int.Parse(txtPlazas.Text.Trim());

                    string tiempoStr = txtHora.Text.Trim();
                    // Convertir la cadena a un objeto TimeSpan utilizando el método ParseExact
                    TimeSpan hora = TimeSpan.ParseExact(tiempoStr, "hh\\:mm", null);

                    actividad.Hora = hora;
                    db.Actividades.Add(actividad);
                    db.SaveChanges();

                    //clear();
                    //TablaCliente();
                    cargarTablaActividades();
                    MessageBox.Show("La actividad se ha añadido correctamente");
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }




        }
    }
}
