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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aplicarFiltros(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(filtro);
            filtro.BringToFront();

        }

        private void btnAlojamientos_Click(object sender, EventArgs e)
        {
            FiltroAlojamiento falojamiento = new FiltroAlojamiento();
            aplicarFiltros(falojamiento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltroClientes Fclientes = new FiltroClientes();
            aplicarFiltros(Fclientes);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {

            FiltroReservas Fresertas = new FiltroReservas();
            aplicarFiltros(Fresertas);
        }
    }
}
