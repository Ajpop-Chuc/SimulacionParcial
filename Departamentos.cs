using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Simulacion1
{
    internal class Departamentos
    {
        string codigo;
        string nombre;
        public static List<Departamentos> listaDepartamentos = new List<Departamentos>();
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static void cargarLista()
        {
            FileStream abrir = new FileStream("Departamentos.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(abrir);
            while (leer.Peek() > -1)
            {
                Departamentos departamento = new Departamentos();
                departamento.codigo = leer.ReadLine();
                departamento.nombre = leer.ReadLine();
                listaDepartamentos.Add(departamento);
            }
            abrir.Close();
            leer.Close();
        }
    }
}
