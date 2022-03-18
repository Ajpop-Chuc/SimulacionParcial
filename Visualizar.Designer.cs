namespace Simulacion1
{
    partial class Visualizar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeTemperaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarPorTemperaturaToolStripMenuItem,
            this.promedioDeTemperaturasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ordenarPorTemperaturaToolStripMenuItem
            // 
            this.ordenarPorTemperaturaToolStripMenuItem.Name = "ordenarPorTemperaturaToolStripMenuItem";
            this.ordenarPorTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.ordenarPorTemperaturaToolStripMenuItem.Text = "Ordenar por Temperatura ";
            this.ordenarPorTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorTemperaturaToolStripMenuItem_Click);
            // 
            // promedioDeTemperaturasToolStripMenuItem
            // 
            this.promedioDeTemperaturasToolStripMenuItem.Name = "promedioDeTemperaturasToolStripMenuItem";
            this.promedioDeTemperaturasToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.promedioDeTemperaturasToolStripMenuItem.Text = "Promedio de Temperaturas";
            this.promedioDeTemperaturasToolStripMenuItem.Click += new System.EventHandler(this.promedioDeTemperaturasToolStripMenuItem_Click);
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Visualizar";
            this.Text = "Visualizar";
            this.Load += new System.EventHandler(this.Visualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeTemperaturasToolStripMenuItem;
    }
}