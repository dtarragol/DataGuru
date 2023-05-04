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
            this.SuspendLayout();
            // 
            // btnCargarCientes
            // 
            this.btnCargarCientes.Location = new System.Drawing.Point(611, 200);
            this.btnCargarCientes.Name = "btnCargarCientes";
            this.btnCargarCientes.Size = new System.Drawing.Size(278, 66);
            this.btnCargarCientes.TabIndex = 0;
            this.btnCargarCientes.Text = "Cargar Clientes a Odoo";
            this.btnCargarCientes.UseVisualStyleBackColor = true;
            this.btnCargarCientes.Click += new System.EventHandler(this.btnCargarCientes_Click);
            // 
            // FormOdoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1523, 873);
            this.Controls.Add(this.btnCargarCientes);
            this.Name = "FormOdoo";
            this.Text = "Cargar datos a Odoo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCientes;
    }
}