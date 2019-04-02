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


        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void mesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas.Add(new Mesa(this.salon_selector.Panel1));
            this.Controls.Add(Mesas[0].mesa_PictureBox);
            var a = new Tests();
            a.Show();
        }

        private void salon_selector_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Mesas = new List<Mesa>();
        }
    }
}
