using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

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

            //leer ficheros csv---------------------------------------------------------------------------------------------------------------

            string fichero = @"C:\resuelto1.csv";
            StreamReader archivo=new StreamReader(fichero);

            char separador = ',';
            string linea;
            //si el archivo no tiene encabezado, elimina la siguiente linea
            archivo.ReadLine();//lee la primera linea pero descartarla xq es el encabezado
            while((linea = archivo.ReadLine()) != null)
            {
                string[]fila=linea.Split(',');
                for(int i=0;i<fila.Length;i++)
                {
                    Console.Write(fila[i]+"\t");
                }
                Console.WriteLine();
            }

            //Grabar ficheros CSV-------------------------------------------------------------------------------------------------------

            // Definim l'array de dades

            string[,] dades = new string[10, 4]
            {
            { "John", "Doe", "johndoe@example.com", "555-555-5555" },
            { "Jane", "Doe", "janedoe@example.com", "555-555-5555" },
            { "Bob", "Smith", "bobsmith@example.com", "555-555-5555" },
            { "Sue", "Jones", "suejones@example.com", "555-555-5555" },
            { "Mike", "Johnson", "mikejohnson@example.com", "555-555-5555" },
            { "Emily", "Davis", "emilydavis@example.com", "555-555-5555" },
            { "Tom", "Brown", "tombrown@example.com", "555-555-5555" },
            { "Amy", "Miller", "amymiller@example.com", "555-555-5555" },
            { "Dave", "Wilson", "davewilson@example.com", "555-555-5555" },
            { "Lisa", "Taylor", "lisataylor@example.com", "555-555-5555" }
            };

            // Creem un fitxer i l'obrim per escriure les dades
            StreamWriter fitxer = new StreamWriter(@"c:\CSV\dades.csv");
            // Escrivim les dades de l'array en format CSV
            string texto = "";
            for (int i = 0; i < dades.GetLength(0); i++)
            {
                    //string[] fila = new string[4];
                    //for (int j = 0; j < 4; j++)
                    //{
                    //    fila[j] = dades[i, j];
                    //}
                    //string texto = string.Join(",", fila);
                    texto = "";
                    //for (int j = 0; j < 4; j++)
                    //{
                    //    texto += dades[i, j];
                    //    if (j < 3)
                    //    {
                    //        texto += ",";
                    //    }
                    //}

                    //fitxer.WriteLine(texto);

                    for (int j = 0; j < 4; j++)
                    {
                        fitxer.Write(dades[i, j]);

                        if (j < 3)
                        {
                            fitxer.Write(",");
                        }
                        else
                        {
                            fitxer.Write("\n");
                        }
                    }


            }

            fitxer.Close();

            Console.WriteLine("Les dades s'han escrit al fitxer.");

            }  

       

      








    }
}
