using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_2___lab
{
    public partial class FiltroAlojamiento : UserControl
    {
        public FiltroAlojamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo de imagen seleccionado
                    string imagenPath = openFileDialog.FileName;
                    pBox1.Image = new System.Drawing.Bitmap(imagenPath);

                    // Carga la imagen en un PictureBox
                    // PictureBox[] fotos = new PictureBox[3];
                    PictureBox pictureBox = new PictureBox();
                   

                    pictureBox.Image = new System.Drawing.Bitmap(imagenPath);

                    // Ajusta el tamaño del PictureBox para adaptarse al control contenedor
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;

                    for (int i = 0; i < 5; i++)
                    {
                        // Crea un PictureBox
                        PictureBox pictureBox2 = new PictureBox();

                        // Configura las propiedades del PictureBox
                        pictureBox.Image = new System.Drawing.Bitmap(imagenPath);  // Asigna la imagen que deseas mostrar
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;

                        // Agrega el PictureBox al FlowLayoutPanel
                        flowLayoutPanelAlojamiento.Controls.Add(pictureBox2);
                        FlpAlojamientos.Controls.Add(pictureBox2);
                    }
                }
            
        }









                }
}
        }
       





        


