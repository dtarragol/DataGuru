namespace ProyectoGuruData.Vista
{
    partial class LogIn
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
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.btnLogInCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lablLOGIN = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(475, 200);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(32, 16);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Mail";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(475, 244);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(595, 198);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(237, 22);
            this.txtMail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(595, 244);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Location = new System.Drawing.Point(573, 337);
            this.btnLoginAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(107, 52);
            this.btnLoginAdmin.TabIndex = 5;
            this.btnLoginAdmin.Text = "Login Admin";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // btnLogInCliente
            // 
            this.btnLogInCliente.Location = new System.Drawing.Point(728, 337);
            this.btnLogInCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogInCliente.Name = "btnLogInCliente";
            this.btnLogInCliente.Size = new System.Drawing.Size(103, 52);
            this.btnLogInCliente.TabIndex = 6;
            this.btnLogInCliente.Text = "Login Cliente";
            this.btnLogInCliente.UseVisualStyleBackColor = true;
            this.btnLogInCliente.Click += new System.EventHandler(this.btnLogInCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoGuruData.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lablLOGIN
            // 
            this.lablLOGIN.AutoSize = true;
            this.lablLOGIN.Location = new System.Drawing.Point(677, 89);
            this.lablLOGIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lablLOGIN.Name = "lablLOGIN";
            this.lablLOGIN.Size = new System.Drawing.Size(53, 16);
            this.lablLOGIN.TabIndex = 8;
            this.lablLOGIN.Text = "LOG IN!";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(866, 338);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 52);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1038, 495);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lablLOGIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogInCliente);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogIn";
            this.Text = "FormLogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Button btnLogInCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lablLOGIN;
        private System.Windows.Forms.Button btnSalir;
    }
}