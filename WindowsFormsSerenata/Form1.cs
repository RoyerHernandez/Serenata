using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business;
using BE;


namespace WindowsFormsSerenata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Amigos de la Serenata");

            obtenerDatos datos = new obtenerDatos();
            int ctdaAmi = datos.RandomNumber(1, 20);
            Console.WriteLine(" Los amigos que asisten son " + ctdaAmi);
            Amigos ami = new Amigos();

            ami.Nombre = "Alejandro";
            Instrumentos ins = new BE.Instrumentos();
            ins.Instrumento = "Vocalista";
            Console.WriteLine(ami.crear() + " " + ins.crear());
            int count = 0;

            DataRow row = dt.NewRow();
            string salida = ami.crear() + " " + ins.crear();
            row["Amigos de la Serenata"] = salida;
            dt.Rows.Add(row);
            serenata.Text = dt.Rows[0][0].ToString();

            row.Delete();
            dt.Dispose();

            salida = "";

            for (int i = 0; i<=ctdaAmi; i++) {

                ami.Nombre = datos.obtenerAmigos(1, 20);
                ins.Instrumento = datos.obtenerInstrumento(1, 4);                              
                salida = ami.crear() + " " + ins.crear();
                row = dt.NewRow();
                row["Amigos de la Serenata"] = salida;                
                dt.Rows.Add(row);
                dataGridViewSerenata.DataSource = dt;

                System.Threading.Thread.Sleep(30);
               
                
            }

        }

        private void groupBoxSerenata_Enter(object sender, EventArgs e)
        {

        }
    }
}
