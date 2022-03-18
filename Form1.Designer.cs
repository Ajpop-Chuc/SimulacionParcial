namespace Simulacion1
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
            this.buttonAddTemperatura = new System.Windows.Forms.Button();
            this.buttonVerDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTemperatura
            // 
            this.buttonAddTemperatura.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTemperatura.Location = new System.Drawing.Point(70, 42);
            this.buttonAddTemperatura.Name = "buttonAddTemperatura";
            this.buttonAddTemperatura.Size = new System.Drawing.Size(207, 79);
            this.buttonAddTemperatura.TabIndex = 0;
            this.buttonAddTemperatura.Text = "Agregar Temperatura";
            this.buttonAddTemperatura.UseVisualStyleBackColor = true;
            this.buttonAddTemperatura.Click += new System.EventHandler(this.buttonAddTemperatura_Click);
            // 
            // buttonVerDatos
            // 
            this.buttonVerDatos.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerDatos.Location = new System.Drawing.Point(70, 127);
            this.buttonVerDatos.Name = "buttonVerDatos";
            this.buttonVerDatos.Size = new System.Drawing.Size(207, 80);
            this.buttonVerDatos.TabIndex = 1;
            this.buttonVerDatos.Text = "Visualizar Departamentos y  Temperaturas";
            this.buttonVerDatos.UseVisualStyleBackColor = true;
            this.buttonVerDatos.Click += new System.EventHandler(this.buttonVerDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 271);
            this.Controls.Add(this.buttonVerDatos);
            this.Controls.Add(this.buttonAddTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTemperatura;
        private System.Windows.Forms.Button buttonVerDatos;
    }
}

