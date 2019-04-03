using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaFedele
{
    public partial class Menu_Principal : Form
    {
        public List<Mesa> Mesas;
        public static List<Reserva> reservas;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void mesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas.Add(new Mesa_cuadrada());
            this.salon_selector.Panel2.Controls.Add(Mesas.Last().mesa_PictureBox);

        }

        private void salon_selector_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            reservas = new List<Reserva>();
            Mesas = new List<Mesa>();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res_form = new New_Reserva();
            res_form.Show();
        }
    }
}
