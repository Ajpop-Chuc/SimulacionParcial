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
    public partial class AddTemperatura : Form
    {
        public AddTemperatura()
        {
            InitializeComponent();
        }

        private void AddTemperatura_Load(object sender, EventArgs e)
        {
            foreach (var departamentos in Departamentos.listaDepartamentos)
            {
                comboBox1.Items.Add(departamentos.Nombre);
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            Departamentos departamento = Departamentos.listaDepartamentos.Find
                (x => x.Nombre == comboBox1.Text);
            DatosTemperaturas dato = new DatosTemperaturas();
            dato.Codigo = departamento.Codigo;
            dato.Grados = Convert.ToDouble(textBox1.Text);
                dato.Fecha = dateTimePicker1.Value;
                DatosTemperaturas.listaDatos.Add(dato);
                DatosTemperaturas.guardarenTxt();

        }
    }
}
