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
            this.SuspendLayout();
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Location = new System.Drawing.Point(506, 41);
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(347, 77);
            this.btnGestionClientes.TabIndex = 0;
            this.btnGestionClientes.Text = "Añadir y Mostrar Clientes";
            this.btnGestionClientes.UseVisualStyleBackColor = true;
            this.btnGestionClientes.Click += new System.EventHandler(this.btnGestionClientes_Click);
            // 
            // btnGestionActividades
            // 
            this.btnGestionActividades.Location = new System.Drawing.Point(506, 147);
            this.btnGestionActividades.Name = "btnGestionActividades";
            this.btnGestionActividades.Size = new System.Drawing.Size(347, 93);
            this.btnGestionActividades.TabIndex = 1;
            this.btnGestionActividades.Text = "Añadir y Mostrar Actividades";
            this.btnGestionActividades.UseVisualStyleBackColor = true;
            this.btnGestionActividades.Click += new System.EventHandler(this.btnGestionActividades_Click);
            // 
            // FormControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1402, 758);
            this.Controls.Add(this.btnGestionActividades);
            this.Controls.Add(this.btnGestionClientes);
            this.Name = "FormControlAdmin";
            this.Text = "Acceso Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionClientes;
        private System.Windows.Forms.Button btnGestionActividades;
    }
}