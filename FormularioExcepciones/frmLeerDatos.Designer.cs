namespace FormularioExcepciones
{
    partial class frmLeerDatos
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
            this.txbDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbDatos
            // 
            this.txbDatos.Location = new System.Drawing.Point(84, 40);
            this.txbDatos.Multiline = true;
            this.txbDatos.Name = "txbDatos";
            this.txbDatos.ReadOnly = true;
            this.txbDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbDatos.Size = new System.Drawing.Size(598, 361);
            this.txbDatos.TabIndex = 0;
            // 
            // frmLeerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbDatos);
            this.Name = "frmLeerDatos";
            this.Text = "Registro de los datos";
            this.Shown += new System.EventHandler(this.frmLeerDatos_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbDatos;
    }
}