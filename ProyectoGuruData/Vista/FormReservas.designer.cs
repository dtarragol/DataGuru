namespace ProyectoGuruData.Vista
{
    partial class FormReservas
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
            this.components = new System.ComponentModel.Container();
            this.plazasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATAguruDataSet = new ProyectoGuruData.DATAguruDataSet();
            this.plazasTableAdapter = new ProyectoGuruData.DATAguruDataSetTableAdapters.PlazasTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRCliente = new System.Windows.Forms.TextBox();
            this.txtFechaHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.comboBoxActividad = new System.Windows.Forms.ComboBox();
            this.Actividad = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstadoReserva = new System.Windows.Forms.TextBox();
            this.gridReservas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plazasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATAguruDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // plazasBindingSource
            // 
            this.plazasBindingSource.DataMember = "Plazas";
            this.plazasBindingSource.DataSource = this.dATAguruDataSet;
            // 
            // dATAguruDataSet
            // 
            this.dATAguruDataSet.DataSetName = "DATAguruDataSet";
            this.dATAguruDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plazasTableAdapter
            // 
            this.plazasTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reserva Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "NIF";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(11, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(196, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtRCliente
            // 
            this.txtRCliente.Location = new System.Drawing.Point(240, 33);
            this.txtRCliente.Name = "txtRCliente";
            this.txtRCliente.Size = new System.Drawing.Size(196, 22);
            this.txtRCliente.TabIndex = 6;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Location = new System.Drawing.Point(494, 33);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(196, 22);
            this.txtFechaHora.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Hora";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(11, 95);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(196, 22);
            this.txtCliente.TabIndex = 10;
            // 
            // comboBoxActividad
            // 
            this.comboBoxActividad.FormattingEnabled = true;
            this.comboBoxActividad.Location = new System.Drawing.Point(240, 95);
            this.comboBoxActividad.Name = "comboBoxActividad";
            this.comboBoxActividad.Size = new System.Drawing.Size(196, 24);
            this.comboBoxActividad.TabIndex = 11;
            // 
            // Actividad
            // 
            this.Actividad.AutoSize = true;
            this.Actividad.Location = new System.Drawing.Point(237, 78);
            this.Actividad.Name = "Actividad";
            this.Actividad.Size = new System.Drawing.Size(63, 16);
            this.Actividad.TabIndex = 12;
            this.Actividad.Text = "Actividad";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(5, 378);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(90, 46);
            this.btnReservar.TabIndex = 13;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(124, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 46);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado de reserva";
            // 
            // txtEstadoReserva
            // 
            this.txtEstadoReserva.Location = new System.Drawing.Point(494, 97);
            this.txtEstadoReserva.Name = "txtEstadoReserva";
            this.txtEstadoReserva.Size = new System.Drawing.Size(196, 22);
            this.txtEstadoReserva.TabIndex = 18;
            // 
            // gridReservas
            // 
            this.gridReservas.AllowUserToAddRows = false;
            this.gridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.gridReservas.Location = new System.Drawing.Point(11, 167);
            this.gridReservas.Name = "gridReservas";
            this.gridReservas.ReadOnly = true;
            this.gridReservas.RowHeadersWidth = 51;
            this.gridReservas.RowTemplate.Height = 24;
            this.gridReservas.Size = new System.Drawing.Size(786, 205);
            this.gridReservas.TabIndex = 19;
            this.gridReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReservas_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Selecciona IdReserva y pulsa el boton eliminar";
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridReservas);
            this.Controls.Add(this.txtEstadoReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.Actividad);
            this.Controls.Add(this.comboBoxActividad);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormReservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plazasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATAguruDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DATAguruDataSet dATAguruDataSet;
        private System.Windows.Forms.BindingSource plazasBindingSource;
        private DATAguruDataSetTableAdapters.PlazasTableAdapter plazasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRCliente;
        private System.Windows.Forms.TextBox txtFechaHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox comboBoxActividad;
        private System.Windows.Forms.Label Actividad;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstadoReserva;
        private System.Windows.Forms.DataGridView gridReservas;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label1;
    }
}