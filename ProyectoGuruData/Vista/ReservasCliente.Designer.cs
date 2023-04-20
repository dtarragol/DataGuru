namespace ProyectoGuruData.Vista
{
    partial class ReservasCliente
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
            this.gridActividades = new System.Windows.Forms.DataGridView();
            this.idActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Anular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblHacerReserva = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // gridActividades
            // 
            this.gridActividades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividad,
            this.NombreActividad,
            this.Hora,
            this.diaSemana,
            this.Plazas,
            this.Reservar,
            this.Anular});
            this.gridActividades.Location = new System.Drawing.Point(61, 101);
            this.gridActividades.Name = "gridActividades";
            this.gridActividades.RowHeadersWidth = 82;
            this.gridActividades.RowTemplate.Height = 33;
            this.gridActividades.Size = new System.Drawing.Size(1602, 682);
            this.gridActividades.TabIndex = 0;
            this.gridActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridActividades_CellContentClick);
            // 
            // idActividad
            // 
            this.idActividad.DataPropertyName = "idActividad";
            this.idActividad.HeaderText = "idActividad";
            this.idActividad.MinimumWidth = 10;
            this.idActividad.Name = "idActividad";
            // 
            // NombreActividad
            // 
            this.NombreActividad.DataPropertyName = "tipoActividad";
            this.NombreActividad.HeaderText = "NombreActividad";
            this.NombreActividad.MinimumWidth = 10;
            this.NombreActividad.Name = "NombreActividad";
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 10;
            this.Hora.Name = "Hora";
            // 
            // diaSemana
            // 
            this.diaSemana.DataPropertyName = "diaSemana";
            this.diaSemana.HeaderText = "diaSemana";
            this.diaSemana.MinimumWidth = 10;
            this.diaSemana.Name = "diaSemana";
            // 
            // Plazas
            // 
            this.Plazas.DataPropertyName = "plazas";
            this.Plazas.HeaderText = "Plazas";
            this.Plazas.MinimumWidth = 10;
            this.Plazas.Name = "Plazas";
            this.Plazas.Visible = false;
            // 
            // Reservar
            // 
            this.Reservar.HeaderText = "Reservar";
            this.Reservar.MinimumWidth = 10;
            this.Reservar.Name = "Reservar";
            this.Reservar.Text = "Reservar";
            this.Reservar.UseColumnTextForButtonValue = true;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.MinimumWidth = 10;
            this.Anular.Name = "Anular";
            this.Anular.Text = "Anular";
            this.Anular.UseColumnTextForButtonValue = true;
            // 
            // lblHacerReserva
            // 
            this.lblHacerReserva.AutoSize = true;
            this.lblHacerReserva.Location = new System.Drawing.Point(66, 51);
            this.lblHacerReserva.Name = "lblHacerReserva";
            this.lblHacerReserva.Size = new System.Drawing.Size(414, 25);
            this.lblHacerReserva.TabIndex = 1;
            this.lblHacerReserva.Text = "Introduce el IdReserva para hacer reserva";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(495, 51);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(223, 31);
            this.txtIdReserva.TabIndex = 2;
            // 
            // ReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1830, 904);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.lblHacerReserva);
            this.Controls.Add(this.gridActividades);
            this.Name = "ReservasCliente";
            this.Text = "Reservas Cliente";
            this.Load += new System.EventHandler(this.ReservasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazas;
        private System.Windows.Forms.DataGridViewButtonColumn Reservar;
        private System.Windows.Forms.DataGridViewButtonColumn Anular;
        private System.Windows.Forms.Label lblHacerReserva;
        private System.Windows.Forms.TextBox txtIdReserva;
    }
}