namespace ProyectoGuruData.Vista
{
    partial class FormControlAdmin
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
            this.btnGestionClientes = new System.Windows.Forms.Button();
            this.btnGestionActividades = new System.Windows.Forms.Button();
            this.btnHacerReserva = new System.Windows.Forms.Button();
            this.btnMostrarReservasTodas = new System.Windows.Forms.Button();
            this.btnMostrarReservasEspera = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Location = new System.Drawing.Point(189, 115);
            this.btnGestionClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(231, 47);
            this.btnGestionClientes.TabIndex = 0;
            this.btnGestionClientes.Text = "Añadir y Mostrar Clientes";
            this.btnGestionClientes.UseVisualStyleBackColor = true;
            this.btnGestionClientes.Click += new System.EventHandler(this.btnGestionClientes_Click);
            // 
            // btnGestionActividades
            // 
            this.btnGestionActividades.Location = new System.Drawing.Point(477, 115);
            this.btnGestionActividades.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionActividades.Name = "btnGestionActividades";
            this.btnGestionActividades.Size = new System.Drawing.Size(231, 51);
            this.btnGestionActividades.TabIndex = 1;
            this.btnGestionActividades.Text = "Añadir y Mostrar Actividades";
            this.btnGestionActividades.UseVisualStyleBackColor = true;
            this.btnGestionActividades.Click += new System.EventHandler(this.btnGestionActividades_Click);
            // 
            // btnHacerReserva
            // 
            this.btnHacerReserva.Location = new System.Drawing.Point(189, 184);
            this.btnHacerReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnHacerReserva.Name = "btnHacerReserva";
            this.btnHacerReserva.Size = new System.Drawing.Size(231, 50);
            this.btnHacerReserva.TabIndex = 2;
            this.btnHacerReserva.Text = "Hacer Reserva para un Cliente";
            this.btnHacerReserva.UseVisualStyleBackColor = true;
            this.btnHacerReserva.Click += new System.EventHandler(this.btnHacerReserva_Click);
            // 
            // btnMostrarReservasTodas
            // 
            this.btnMostrarReservasTodas.Location = new System.Drawing.Point(477, 185);
            this.btnMostrarReservasTodas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarReservasTodas.Name = "btnMostrarReservasTodas";
            this.btnMostrarReservasTodas.Size = new System.Drawing.Size(231, 49);
            this.btnMostrarReservasTodas.TabIndex = 3;
            this.btnMostrarReservasTodas.Text = "Mostrar Todas las Reservas";
            this.btnMostrarReservasTodas.UseVisualStyleBackColor = true;
            this.btnMostrarReservasTodas.Click += new System.EventHandler(this.btnMostrarReservasTodas_Click);
            // 
            // btnMostrarReservasEspera
            // 
            this.btnMostrarReservasEspera.Location = new System.Drawing.Point(336, 256);
            this.btnMostrarReservasEspera.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarReservasEspera.Name = "btnMostrarReservasEspera";
            this.btnMostrarReservasEspera.Size = new System.Drawing.Size(223, 49);
            this.btnMostrarReservasEspera.TabIndex = 4;
            this.btnMostrarReservasEspera.Text = "Mostrar Reservas en el Estado Espera";
            this.btnMostrarReservasEspera.UseVisualStyleBackColor = true;
            this.btnMostrarReservasEspera.Click += new System.EventHandler(this.btnMostrarReservasEspera_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(378, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 49);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarReservasEspera);
            this.Controls.Add(this.btnMostrarReservasTodas);
            this.Controls.Add(this.btnHacerReserva);
            this.Controls.Add(this.btnGestionActividades);
            this.Controls.Add(this.btnGestionClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormControlAdmin";
            this.Text = "Acceso Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionClientes;
        private System.Windows.Forms.Button btnGestionActividades;
        private System.Windows.Forms.Button btnHacerReserva;
        private System.Windows.Forms.Button btnMostrarReservasTodas;
        private System.Windows.Forms.Button btnMostrarReservasEspera;
        private System.Windows.Forms.Button btnSalir;
    }
}