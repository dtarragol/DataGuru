namespace ProyectoGuruData.Vista
{
    partial class FormVistaCliente
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
            this.btnReservarActv = new System.Windows.Forms.Button();
            this.btnConsultarResrv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReservarActv
            // 
            this.btnReservarActv.Location = new System.Drawing.Point(530, 214);
            this.btnReservarActv.Name = "btnReservarActv";
            this.btnReservarActv.Size = new System.Drawing.Size(274, 96);
            this.btnReservarActv.TabIndex = 0;
            this.btnReservarActv.Text = "Reservar/Anular Actividad";
            this.btnReservarActv.UseVisualStyleBackColor = true;
            this.btnReservarActv.Click += new System.EventHandler(this.btnReservarActv_Click);
            // 
            // btnConsultarResrv
            // 
            this.btnConsultarResrv.Location = new System.Drawing.Point(530, 362);
            this.btnConsultarResrv.Name = "btnConsultarResrv";
            this.btnConsultarResrv.Size = new System.Drawing.Size(274, 97);
            this.btnConsultarResrv.TabIndex = 2;
            this.btnConsultarResrv.Text = "Consultar Mis Reservas";
            this.btnConsultarResrv.UseVisualStyleBackColor = true;
            // 
            // FormVistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1359, 728);
            this.Controls.Add(this.btnConsultarResrv);
            this.Controls.Add(this.btnReservarActv);
            this.Name = "FormVistaCliente";
            this.Text = "Vista Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservarActv;
        private System.Windows.Forms.Button btnConsultarResrv;
    }
}