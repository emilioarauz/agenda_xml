using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace agenda
{
    public partial class frm_interfaz : Form
    {
        public frm_interfaz()
        {
            InitializeComponent();
        }

        //definicion de variables/objetos
        private static string Nombre;
        private static string Dire;
        private static string Fecha;
        private static string tel1;
        private static string tel2;
        private static string tel3;
        DataTable table = new DataTable();
        DataSet ds = new DataSet();

        //metodo para salvar el archivo xml en donde indica el usuario
        private void Salvarxml()
        {
            ds.Merge(table); //aqui se une el datatable al dataset para ser usado en el archivo xml
            SaveFileDialog sfd = new SaveFileDialog(); //abre la ventana para seleccionar ruta del archivo
            sfd.Filter = "XML|*.xml"; // filtro del formato que puede ser usado
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.Tables[0].WriteXml(sfd.FileName); //se escribe el xml
                    MessageBox.Show("Se Salvaron los cambios.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void CargarDataxml() //este metodo es para leer un archivo xml y añadirlo al datagridview
        {
            OpenFileDialog ofd = new OpenFileDialog(); //crea o abre la ventana para buscar/salvar el archivo
            ofd.Filter = "XML|*.xml"; // filto del formato aceptado
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                    ds.ReadXml(xmlFile);//se lee pasa el xmlreader a un dataset
                    Dgv_test.DataSource = ds.Tables[0].DefaultView; //se asigna el datasource del datagridview

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        //llenado de la tabla cuando se carga la lista de contactos desde un txt
        private void Llenar()
        {

            Btn_Borrar.Enabled = true;

            //crea usa el streamreader que seria la lectura del archivo
            if (File.Exists("Agenda.txt"))
            {
                using (StreamReader sr = new StreamReader("Agenda.txt"))
                {
                    while (!sr.EndOfStream) //mientras no sea el final del archivo.
                    {
                        string[] parts = sr.ReadLine().Split(','); //es equivalente a las lineas separadas por espacio
                        table.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]); // se agregan las partes a un vector
                    }
                }
                Dgv_test.DataSource = table; //se le da el source al gridview
            }
            else
            {
                MessageBox.Show("No Existe el Archivo.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Txt_nombre.Text != "")//verificar campos en blanco
            {
                if (Txt_tel1.Text != "" || Txt_tel2.Text != "" || Txt_tel3.Text != "")
                {
                    // se ejecuta metodo para dar valor a las variables
                    Valores();
                    //simplemente se llama el metodo de la clase para ser ejecutado.
                    Agregar.Crear();
                    Llenar();
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos un número de teléfono.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del contacto.");
            }



        }
        //metodo boton para salvar el Datagrid al documento de texto luego de hacer cambios.
        private void Btn_salvar_Click(object sender, EventArgs e)
        {

            TextWriter writer = new StreamWriter("Agenda.txt"); //crea un stream writer.
            // se usan 2 for que recorran las filas y columnas y las imprima en el documento de texto.
            for (int i = 0; i < Dgv_test.Rows.Count; i++)
            {
                for (int j = 0; j < Dgv_test.Columns.Count; j++)
                {
                    writer.Write(Dgv_test.Rows[i].Cells[j].Value.ToString() + ',');
                }
                writer.WriteLine("");
            }
            writer.Close();
            Salvarxml();

        }


        //da valor a las variables
        private void Valores()
        {
            Nombre = Txt_nombre.Text;
            Dire = Txt_direcc.Text;
            Fecha = Txt_fecha.Text;
            tel1 = Cb_tel1.Text + ": " + Txt_tel1.Text;
            tel2 = Cb_tel2.Text + ": " + Txt_tel2.Text;
            tel3 = Cb_tel3.Text + ": " + Txt_tel3.Text;
        }

        //metodos para llamar valor en caso de ser necesario
        public static string GetNombre()
        {
            return Nombre;
        }
        public static string GetDir()
        {
            return Dire;
        }
        public static string GetFecha()
        {
            return Fecha;
        }
        public static string GetTel1()
        {
            return tel1;
        }
        public static string GetTel2()
        {
            return tel2;
        }
        public static string GetTel3()
        {
            return tel3;
        }

        //borrar contacto seleccionado del gridview
        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            int rowIndex = Dgv_test.CurrentCell.RowIndex;
            Dgv_test.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Se Borro el Contacto.");
        }

        private void frm_interfaz_Load(object sender, EventArgs e)
        {

            //crea tabla de usuario
            table.Columns.Add("Nombre");
            table.Columns.Add("Dirección");
            table.Columns.Add("Fecha");
            table.Columns.Add("Telefono 1");
            table.Columns.Add("Telefono 2");
            table.Columns.Add("Telefono 3");

        }

        //llamada del botón de cargar datos desde un xml
        private void Btn_cargarxml_Click(object sender, EventArgs e)
        {
            if (Dgv_test.DataSource != null)
            {
                ds.Clear(); // se limpia el dataset
                Dgv_test.DataSource = null; //se limpia al datasource de la tabla
                CargarDataxml(); //se carga los datos del xml
            }
            else
            {
                CargarDataxml();
            }
        }
        //llamada del botón de cargar datos desde un txt
        private void Btn_cargartxt_Click(object sender, EventArgs e)
        {
            if (Dgv_test.DataSource != null)
            {
                table.Clear(); //se limpia la tabla
                Llenar();
            }
            else
            {
                Llenar();
            }
        }
    }
}






