using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace DPRN3_U2_A1_JHRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Prueba de conexión
            Conexion q1 = new Conexion();
            q1.conectar();
            q1.desconectar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

            try
            {
                Auto a = new Auto();
                a.Tipo_vehiculo = cmpTVehiculo.Text;
                a.Serie = cmpSerie.Text;
                a.Ano_adq = Convert.ToInt32(cmpAnoAdq.Text);
                a.Marca = cmpMarca.Text;
                a.Modelo = cmpModelo.Text;
                a.Ano_vehiculo = Convert.ToInt32(cmpAnoVehiculo.Text);
                a.Verificacion = cmpVerificacion.Text;

                //Lista par almacenar colores
                List<string> list = new List<string>();
                //extraer colores seleccionados de ListBox
                foreach (string li in cmpColor.SelectedItems)
                {
                    list.Add(li);
                }
                //Convertir lista de colores a string
                string colores_output = string.Join(Environment.NewLine, list.ToArray());
                //Enviar colores a DB 
                a.Color = colores_output;

                //Foto

                //Convertir PictureBox a byte []
                Byte[] data;
                using (var memoryStream = new MemoryStream())
                {
                    cmpFoto.Image.Save(memoryStream, ImageFormat.Bmp);
                    data = memoryStream.ToArray();
                }
                //Enviar byte[] de foto a SQL
                a.Foto = data;

                if (AccesoDatosAuto.guardar(a))
                {
                    MessageBox.Show("Auto se guardó");
                }else
                {
                    MessageBox.Show("Auto no se guardó");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmpColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                cmpFoto.Image = new Bitmap(opnfd.FileName);

            }
        }

        private void cmpFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
