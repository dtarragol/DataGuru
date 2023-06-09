﻿namespace ProyectoGuruData.Vista
{
    partial class FormVerReservas
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
            this.tablaReservas = new System.Windows.Forms.DataGridView();
            this.IdReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservaXcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).BeginInit();
            this.SuspendLayout();
            //
            // tablaReservas
            //
            this.tablaReservas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.IdReserva,
                this.ReservaXcliente,
                this.FechaHoraReserva,
                this.EstadoReserva,
                this.Nif,
                this.tipoActividad});
            this.tablaReservas.Location = new System.Drawing.Point(96, 118);
            this.tablaReservas.Name = "tablaReservas";
            this.tablaReservas.RowHeadersWidth = 82;
            this.tablaReservas.RowTemplate.Height = 33;
            this.tablaReservas.Size = new System.Drawing.Size(1397, 540);
            this.tablaReservas.TabIndex = 0;
            //
            // IdReserva
            //
            //
            this.IdReserva.DataPropertyName = "IdReserva";
            this.IdReserva.HeaderText = "Id Reserva";
            this.IdReserva.MinimumWidth = 10;
            this.IdReserva.Name = "IdReserva";
            this.IdReserva.Width = 150;
            //
            // ReservaXcliente
            //
            //
            this.ReservaXcliente.DataPropertyName = "ReservaXcliente";
            this.ReservaXcliente.HeaderText = "Reservas del cliente";
            this.ReservaXcliente.MinimumWidth = 10;
            this.ReservaXcliente.Name = "ReservaXcliente";
            this.ReservaXcliente.Width = 150;
            //
            // FechaHoraReserva
            //
            //
            this.FechaHoraReserva.DataPropertyName = "FechaHoraReserva";
            this.FechaHoraReserva.HeaderText = "Fecha de la reserva";
            this.FechaHoraReserva.MinimumWidth = 10;
            this.FechaHoraReserva.Name = "FechaHoraReserva";
            this.FechaHoraReserva.Width = 150;
            // EstadoReserva
            //
            this.EstadoReserva.DataPropertyName = "EstadoReserva";
            this.EstadoReserva.HeaderText = "Estado Reserva";
            this.EstadoReserva.MinimumWidth = 10;
            this.EstadoReserva.Name = "EstadoReserva";
            this.EstadoReserva.Width = 150;
            //
            // Nif
            //
            this.Nif.DataPropertyName = "nif";
            this.Nif.HeaderText = "Cliente";
            this.Nif.MinimumWidth = 10;
            this.Nif.Name = "nif";
            this.Nif.Width = 150;
            //
            // tipoActividad
            //
            this.tipoActividad.DataPropertyName = "tipoActividad";
            this.tipoActividad.HeaderText = "Actividad";
            this.tipoActividad.MinimumWidth = 10;
            this.tipoActividad.Name = "tipoActividad";
            this.tipoActividad.Width = 150;
            //
            // VerReservas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1762, 848);
            this.Controls.Add(this.tablaReservas);
            //this.Name("Ver Reservas en Espera");
            // this.Text("Reservas");
            this.Load += new System.EventHandler(this.VerReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tablaReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaXcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoActividad;
    }
}