namespace FormularioExcepciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txmMovil = new System.Windows.Forms.MaskedTextBox();
            this.txmMatricula = new System.Windows.Forms.MaskedTextBox();
            this.txmNIF = new System.Windows.Forms.MaskedTextBox();
            this.txmCuenta = new System.Windows.Forms.MaskedTextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMovil = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMatricula = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNIF = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCuenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(105, 111);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(387, 22);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txmMovil
            // 
            this.txmMovil.Location = new System.Drawing.Point(105, 156);
            this.txmMovil.Mask = "000-000-000";
            this.txmMovil.Name = "txmMovil";
            this.txmMovil.Size = new System.Drawing.Size(162, 22);
            this.txmMovil.TabIndex = 3;
            this.txmMovil.TextChanged += new System.EventHandler(this.txmMovil_TextChanged);
            // 
            // txmMatricula
            // 
            this.txmMatricula.Location = new System.Drawing.Point(167, 252);
            this.txmMatricula.Mask = "0000-LLL";
            this.txmMatricula.Name = "txmMatricula";
            this.txmMatricula.Size = new System.Drawing.Size(100, 22);
            this.txmMatricula.TabIndex = 4;
            this.txmMatricula.TextChanged += new System.EventHandler(this.txmMatricula_TextChanged);
            // 
            // txmNIF
            // 
            this.txmNIF.Location = new System.Drawing.Point(392, 252);
            this.txmNIF.Mask = "00000000-L";
            this.txmNIF.Name = "txmNIF";
            this.txmNIF.Size = new System.Drawing.Size(100, 22);
            this.txmNIF.TabIndex = 5;
            this.txmNIF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txmNIF_MaskInputRejected);
            // 
            // txmCuenta
            // 
            this.txmCuenta.Location = new System.Drawing.Point(167, 297);
            this.txmCuenta.Mask = "LL000-0000.0000.000.0000000000";
            this.txmCuenta.Name = "txmCuenta";
            this.txmCuenta.Size = new System.Drawing.Size(325, 22);
            this.txmCuenta.TabIndex = 6;
            this.txmCuenta.Text = "ES";
            this.txmCuenta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txmCuenta_MaskInputRejected);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(382, 361);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(110, 23);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Matricula Coche:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nº de Cuenta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "NIF:";
            // 
            // epNombre
            // 
            this.epNombre.BlinkRate = 500;
            this.epNombre.ContainerControl = this;
            // 
            // epApellidos
            // 
            this.epApellidos.ContainerControl = this;
            // 
            // epMovil
            // 
            this.epMovil.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epMatricula
            // 
            this.epMatricula.ContainerControl = this;
            // 
            // epNIF
            // 
            this.epNIF.ContainerControl = this;
            // 
            // epCuenta
            // 
            this.epCuenta.ContainerControl = this;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(47, 361);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(159, 23);
            this.btnEscribir.TabIndex = 15;
            this.btnEscribir.Text = "ESCRIBIR";
            this.btnEscribir.UseVisualStyleBackColor = true;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(47, 403);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(159, 23);
            this.btnLeer.TabIndex = 16;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txmCuenta);
            this.Controls.Add(this.txmNIF);
            this.Controls.Add(this.txmMatricula);
            this.Controls.Add(this.txmMovil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Datos Personales";
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txmMovil;
        private System.Windows.Forms.MaskedTextBox txmMatricula;
        private System.Windows.Forms.MaskedTextBox txmNIF;
        private System.Windows.Forms.MaskedTextBox txmCuenta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellidos;
        private System.Windows.Forms.ErrorProvider epMovil;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epMatricula;
        private System.Windows.Forms.ErrorProvider epNIF;
        private System.Windows.Forms.ErrorProvider epCuenta;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
    }
}

