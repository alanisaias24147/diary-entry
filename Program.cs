using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace Diary_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter palabras;
            palabras = new StreamWriter("texto.txt");
            Console.WriteLine("ingresa un texto");
            string mensaje = Console.ReadLine();

            DateTime fechaDehoy = DateTime.Now;
            CultureInfo culture = new CultureInfo("es-MX");
            string fechaDehoyStr = fechaDehoy.ToString(culture);

            Console.WriteLine(fechaDehoyStr);
            palabras.WriteLine(mensaje);

        }
    }
}
