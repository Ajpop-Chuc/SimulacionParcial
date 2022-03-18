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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTemperatura_Click(object sender, EventArgs e)
        {
            AddTemperatura form = new AddTemperatura();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Departamentos.cargarLista();
            DatosTemperaturas.cargarLista();
        }

        private void buttonVerDatos_Click(object sender, EventArgs e)
        {
            Visualizar form = new Visualizar();
            form.Show();
        }
    }
}
