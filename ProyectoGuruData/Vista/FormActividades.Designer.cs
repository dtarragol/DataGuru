namespace ProyectoGuruData
{
    partial class FormActividades
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxActividades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlazas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tablaActividades = new System.Windows.Forms.DataGridView();
            this.IdActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDActividad = new System.Windows.Forms.TextBox();
            this.comboBoxHoras = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Actividad";
            // 
            // comboBoxActividades
            // 
            this.comboBoxActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActividades.FormattingEnabled = true;
            this.comboBoxActividades.Location = new System.Drawing.Point(32, 122);
            this.comboBoxActividades.Name = "comboBoxActividades";
            this.comboBoxActividades.Size = new System.Drawing.Size(207, 24);
            this.comboBoxActividades.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plazas";
            // 
            // txtPlazas
            // 
            this.txtPlazas.Location = new System.Drawing.Point(32, 207);
            this.txtPlazas.Name = "txtPlazas";
            this.txtPlazas.Size = new System.Drawing.Size(207, 22);
            this.txtPlazas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dia";
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.AutoCompleteCustomSource.AddRange(new string[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Location = new System.Drawing.Point(32, 385);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(207, 24);
            this.comboBoxDia.TabIndex = 8;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(64, 417);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 44);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear Actividad";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tablaActividades
            // 
            this.tablaActividades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdActividad,
            this.TipoActividad,
            this.Plazas,
            this.Hora,
            this.Dia});
            this.tablaActividades.Location = new System.Drawing.Point(266, 21);
            this.tablaActividades.Name = "tablaActividades";
            this.tablaActividades.RowHeadersWidth = 51;
            this.tablaActividades.RowTemplate.Height = 24;
            this.tablaActividades.Size = new System.Drawing.Size(863, 451);
            this.tablaActividades.TabIndex = 10;
            // 
            // IdActividad
            // 
            this.IdActividad.DataPropertyName = "idActividad";
            this.IdActividad.HeaderText = "ID";
            this.IdActividad.MinimumWidth = 6;
            this.IdActividad.Name = "IdActividad";
            this.IdActividad.Width = 125;
            // 
            // TipoActividad
            // 
            this.TipoActividad.DataPropertyName = "tipoActividad";
            this.TipoActividad.HeaderText = "Actividad";
            this.TipoActividad.MinimumWidth = 6;
            this.TipoActividad.Name = "TipoActividad";
            this.TipoActividad.Width = 125;
            // 
            // Plazas
            // 
            this.Plazas.DataPropertyName = "plazas";
            this.Plazas.HeaderText = "Plazas";
            this.Plazas.MinimumWidth = 6;
            this.Plazas.Name = "Plazas";
            this.Plazas.Width = 125;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.Width = 125;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "diaSemana";
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // txtIDActividad
            // 
            this.txtIDActividad.Location = new System.Drawing.Point(32, 50);
            this.txtIDActividad.Name = "txtIDActividad";
            this.txtIDActividad.Size = new System.Drawing.Size(207, 22);
            this.txtIDActividad.TabIndex = 12;
            // 
            // comboBoxHoras
            // 
            this.comboBoxHoras.AutoCompleteCustomSource.AddRange(new string[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.comboBoxHoras.FormattingEnabled = true;
            this.comboBoxHoras.Location = new System.Drawing.Point(32, 312);
            this.comboBoxHoras.Name = "comboBoxHoras";
            this.comboBoxHoras.Size = new System.Drawing.Size(80, 24);
            this.comboBoxHoras.TabIndex = 13;
            // 
            // comboBoxMinutos
            // 
            this.comboBoxMinutos.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "30"});
            this.comboBoxMinutos.FormattingEnabled = true;
            this.comboBoxMinutos.Location = new System.Drawing.Point(135, 312);
            this.comboBoxMinutos.Name = "comboBoxMinutos";
            this.comboBoxMinutos.Size = new System.Drawing.Size(80, 24);
            this.comboBoxMinutos.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minuto";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = ":";
            // 
            // FormActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1173, 498);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMinutos);
            this.Controls.Add(this.comboBoxHoras);
            this.Controls.Add(this.txtIDActividad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablaActividades);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlazas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxActividades);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormActividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.FormActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxActividades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlazas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView tablaActividades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.ComboBox comboBoxHoras;
        private System.Windows.Forms.ComboBox comboBoxMinutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}