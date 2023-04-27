namespace ProyectoGuruData.Vista
{
    partial class FormVerReservasEspera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaReservasEspera = new System.Windows.Forms.DataGridView();
            this.EstadoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservasEspera)).BeginInit();
            this.SuspendLayout();
            //
            // tablaReservasEspera
            //
            this.tablaReservasEspera.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablaReservasEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservasEspera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.EstadoReserva,
                this.IdReserva,
                this.tipoActividad,
                this.FechaHoraReserva,
                this.Nif });
            this.tablaReservasEspera.Location = new System.Drawing.Point(96, 118);
            this.tablaReservasEspera.Name = "tablaReservasEspera";
            this.tablaReservasEspera.RowHeadersWidth = 82;
            this.tablaReservasEspera.RowTemplate.Height = 33;
            this.tablaReservasEspera.Size = new System.Drawing.Size(1397, 540);
            this.tablaReservasEspera.TabIndex = 0;
            //
            // EstadoReserva
            //
            this.EstadoReserva.DataPropertyName = "EstadoReserva";
            this.EstadoReserva.HeaderText = "Estado Reserva";
            this.EstadoReserva.MinimumWidth = 10;
            this.EstadoReserva.Name = "EstadoReserva";
            this.EstadoReserva.Width = 150;
            //
            // IdReserva
            //
            this.IdReserva.DataPropertyName = "IdReserva";
            this.IdReserva.HeaderText = "Id de la Reserva";
            this.IdReserva.MinimumWidth = 10;
            this.IdReserva.Name = "IdReserva";
            this.IdReserva.Width = 150;
            //
            // tipoActividad
            //
            this.tipoActividad.DataPropertyName = "tipoActividad";
            this.tipoActividad.HeaderText = "Actividad";
            this.tipoActividad.MinimumWidth = 10;
            this.tipoActividad.Name = "tipoActividad";
            this.tipoActividad.Width = 150;
            //
            // FechaHoraReserva
            //
            this.FechaHoraReserva.DataPropertyName = "FechaHoraReserva";
            this.FechaHoraReserva.HeaderText = "Fecha y Hora";
            this.FechaHoraReserva.MinimumWidth = 10;
            this.FechaHoraReserva.Name = "FechaHoraReserva";
            this.FechaHoraReserva.Width = 150;
            //
            // Nif
            //
            this.Nif.DataPropertyName = "nif";
            this.Nif.HeaderText = "Cliente";
            this.Nif.MinimumWidth = 10;
            this.Nif.Name = "nif";
            this.Nif.Width = 150;
            //
            // VerReservasEspera
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1762, 848);
            this.Controls.Add(this.tablaReservasEspera);
            //this.Name("Ver Reservas en Espera");
            // this.Text("Reservas");
            this.Load += new System.EventHandler(this.VerReservasEspera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservasEspera)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tablaReservasEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nif;
    }
}