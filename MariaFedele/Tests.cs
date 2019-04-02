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
    public partial class Tests : Form
    {

        public List<Mesa> Mesas;


        public Tests()
        {
            InitializeComponent();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            Mesas = new List<Mesa>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mesas.Add(new Mesa());
            this.Controls.Add(Mesas.Last().mesa_PictureBox);
        }
    }
}
