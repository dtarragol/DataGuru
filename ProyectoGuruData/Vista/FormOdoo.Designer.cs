namespace ProyectoGuruData.Vista
{
    partial class FormOdoo
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
            this.btnCargarCientes = new System.Windows.Forms.Button();
            this.btnActividadesOdoo = new System.Windows.Forms.Button();
            this.btnReservasOdoo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarCientes
            // 
            this.btnCargarCientes.Location = new System.Drawing.Point(611, 228);
            this.btnCargarCientes.Name = "btnCargarCientes";
            this.btnCargarCientes.Size = new System.Drawing.Size(307, 66);
            this.btnCargarCientes.TabIndex = 0;
            this.btnCargarCientes.Text = "Cargar Clientes a Odoo";
            this.btnCargarCientes.UseVisualStyleBackColor = true;
            this.btnCargarCientes.Click += new System.EventHandler(this.btnCargarCientes_Click);
            // 
            // btnActividadesOdoo
            // 
            this.btnActividadesOdoo.Location = new System.Drawing.Point(611, 325);
            this.btnActividadesOdoo.Name = "btnActividadesOdoo";
            this.btnActividadesOdoo.Size = new System.Drawing.Size(307, 63);
            this.btnActividadesOdoo.TabIndex = 1;
            this.btnActividadesOdoo.Text = "Cargar Actividades a Odoo";
            this.btnActividadesOdoo.UseVisualStyleBackColor = true;
            this.btnActividadesOdoo.Click += new System.EventHandler(this.btnActividadesOdoo_Click);
            // 
            // btnReservasOdoo
            // 
            this.btnReservasOdoo.Location = new System.Drawing.Point(611, 420);
            this.btnReservasOdoo.Name = "btnReservasOdoo";
            this.btnReservasOdoo.Size = new System.Drawing.Size(307, 69);
            this.btnReservasOdoo.TabIndex = 2;
            this.btnReservasOdoo.Text = "Cargar Reservas a Odoo";
            this.btnReservasOdoo.UseVisualStyleBackColor = true;
            this.btnReservasOdoo.Click += new System.EventHandler(this.btnReservasOdoo_Click);
            // 
            // FormOdoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1616, 873);
            this.Controls.Add(this.btnReservasOdoo);
            this.Controls.Add(this.btnActividadesOdoo);
            this.Controls.Add(this.btnCargarCientes);
            this.Name = "FormOdoo";
            this.Text = "Cargar datos a Odoo";
            this.Load += new System.EventHandler(this.FormOdoo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCientes;
        private System.Windows.Forms.Button btnActividadesOdoo;
        private System.Windows.Forms.Button btnReservasOdoo;
    }
}