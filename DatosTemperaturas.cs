using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion1
{
    internal class DatosTemperaturas
    {
        string codigo;
        double grados;
        DateTime fecha;

        public static List<DatosTemperaturas> listaDatos = new List<DatosTemperaturas>();
        public string Codigo { get => codigo; set => codigo = value; }
        public double Grados { get => grados; set => grados = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public static void guardarenTxt()
        {
            FileStream abrir = new FileStream("Datos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);
            foreach (var dato in listaDatos)
            {
                escribir.WriteLine(dato.Codigo);
                escribir.WriteLine(dato.grados);
                escribir.WriteLine(dato.fecha);
            }
            escribir.Close();
            abrir.Close();
        }
        public static void cargarLista()
        {
            FileStream abrir = new FileStream("Datos.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(abrir);
            while (leer.Peek() > -1)
            {
                DatosTemperaturas dato = new DatosTemperaturas();
                dato.Codigo = leer.ReadLine();
                dato.grados = Convert.ToDouble(leer.ReadLine());
                dato.fecha = Convert.ToDateTime(leer.ReadLine());
                listaDatos.Add(dato);
            }
            abrir.Close();
            leer.Close();
        }

    }
}
