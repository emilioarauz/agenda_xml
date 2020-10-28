using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
///necesario

namespace agenda
{
    class Agregar
    {
        private static string a;
        private static string b;
        private static string c;
        private static string d;
        private static string e;
        private static string f;

        //metodo para crear o añadir mas texto al archivo txt
        public static void Crear()
        {
 
            a = frm_interfaz.GetNombre();
            b = frm_interfaz.GetDir();
            c = frm_interfaz.GetFecha();
            d = frm_interfaz.GetTel1();
            e = frm_interfaz.GetTel2();
            f = frm_interfaz.GetTel3();

            string path = "Agenda.txt"; //crea el archivo o le da ruta.

            // si el archivo existe agrega el string append en una nueva linea.
            if (File.Exists("Agenda.txt"))
            {

                string appendText = a+","+b+","+c+","+d+","+e+","+f + Environment.NewLine;
                File.AppendAllText(path, appendText); //se concatena el texto.
                MessageBox.Show("Se añadio Exitosamente!");
            }
            else
            //si el archivo no existe lo crea usando un writeline 
            if (!File.Exists("Agenda.txt"))
            {
                TextWriter tw = new StreamWriter(path); //este es el buffer de escritura
                tw.WriteLine(a + "," + b + "," + c + "," + d + "," + e + "," + f); //texto que se escribe
                tw.Close(); //se cierra el buffer
                MessageBox.Show("Se añadio Exitosamente!");
            }
        }
    }
}
