using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\");//Obtener archivos
            foreach(string f in files)
            {
                Console.WriteLine(f); //mostramos los archivos en la consola
            }

            string[] folders = Directory.GetDirectories(@"C:\");
            foreach(string f in folders)
            {
                Console.WriteLine(f); //mostramos las carpetas en la consola
            }

            //leer ficheros csv

            string fichero = @"C:\resuelto1.csv";
            StreamReader archivo=new StreamReader(fichero);

            char separador = ',';
            string linea;
            //si el archivo no tiene encabezado, elimina la siguiente linea
            archivo.ReadLine();//leer la primera linea pero descartarla xq es el encabezado
            while((linea = archivo.ReadLine()) != null)
            {
                string[]fila=linea.Split(',');
                for(int i=0;i<fila.Length;i++)
                {
                    Console.Write(fila[i]+"\t");
                }
                Console.WriteLine();
            }

            
            
        }
    }
}
