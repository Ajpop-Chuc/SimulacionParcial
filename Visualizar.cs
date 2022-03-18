using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion1
{
    public partial class Visualizar : Form
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = DatosTemperaturas.listaDatos;
            dataGridView1.Refresh();
        }

        private void ordenarPorTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosTemperaturas.listaDatos = DatosTemperaturas.listaDatos.OrderBy(x=>x.Grados).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = DatosTemperaturas.listaDatos;
            dataGridView1.Refresh();
        }

        private void promedioDeTemperaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string promedio;
            promedio = DatosTemperaturas.listaDatos.Average(x => x.Grados).ToString();
            MessageBox.Show("El promedio es: "+promedio);
        }
    }
}
