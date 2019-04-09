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
        public static List<Mesa> Mesas;
        public static List<Reserva> reservas;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void mesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

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

        private void cuadradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas.Add(new Mesa_cuadrada());
            this.salon_selector.Panel2.Controls.Add(Mesas.Last().mesa_PictureBox);
        }

        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas.Add(new Mesa_circular());
            this.salon_selector.Panel2.Controls.Add(Mesas.Last().mesa_PictureBox);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reservas.Add(new Reserva(new DateTime(2019, 4, 9, 19, 00, 00), 5, "", "Pedro"));
            reservas.Add(new Reserva(new DateTime(2019, 4, 9, 19, 35, 00), 5, "QE", "Juan"));
            reservas.Add(new Reserva(new DateTime(2019, 4, 10, 19, 30, 00), 5, "AS", "Manuel"));
            reservas.Add(new Reserva(new DateTime(2019, 4, 10, 19, 40, 00), 5, "N", "Sol"));
            reservas.Add(new Reserva(new DateTime(2019, 4, 13, 21, 30, 00), 5, "D", "Damian"));
            reservas.Add(new Reserva(new DateTime(2019, 4, 15, 22, 00, 00), 5, "ASS", "Batatin"));
            var menu_reservas = new Reservas(reservas);
            menu_reservas.Show();
        }
    }
}
