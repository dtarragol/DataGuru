namespace ProyectoGuruData.Vista
{
    partial class ReservasXcliente
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
            this.dgwMisReservas = new System.Windows.Forms.DataGridView();
            this.estadoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMisReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMisReservas
            // 
            this.dgwMisReservas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMisReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMisReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estadoReserva,
            this.tipoActividad,
            this.Hora,
            this.diaSemana});
            this.dgwMisReservas.Location = new System.Drawing.Point(96, 118);
            this.dgwMisReservas.Name = "dgwMisReservas";
            this.dgwMisReservas.RowHeadersWidth = 82;
            this.dgwMisReservas.RowTemplate.Height = 33;
            this.dgwMisReservas.Size = new System.Drawing.Size(1397, 540);
            this.dgwMisReservas.TabIndex = 0;
            this.dgwMisReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMisReservas_CellContentClick);
            // 
            // estadoReserva
            // 
            this.estadoReserva.DataPropertyName = "estadoReserva";
            this.estadoReserva.HeaderText = "Estado Reserva";
            this.estadoReserva.MinimumWidth = 10;
            this.estadoReserva.Name = "estadoReserva";
            this.estadoReserva.Width = 150;
            // 
            // tipoActividad
            // 
            this.tipoActividad.DataPropertyName = "tipoActividad";
            this.tipoActividad.HeaderText = "Actividad";
            this.tipoActividad.MinimumWidth = 10;
            this.tipoActividad.Name = "tipoActividad";
            this.tipoActividad.Width = 150;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 10;
            this.Hora.Name = "Hora";
            this.Hora.Width = 150;
            // 
            // diaSemana
            // 
            this.diaSemana.DataPropertyName = "diaSemana";
            this.diaSemana.HeaderText = "Dia Semana";
            this.diaSemana.MinimumWidth = 10;
            this.diaSemana.Name = "diaSemana";
            this.diaSemana.Width = 150;
            // 
            // ReservasXcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1762, 848);
            this.Controls.Add(this.dgwMisReservas);
            this.Name = "ReservasXcliente";
            this.Text = "Mis Reservas";
            this.Load += new System.EventHandler(this.ReservasXcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMisReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMisReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemana;
    }
}