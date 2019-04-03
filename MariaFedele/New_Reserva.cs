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
    public partial class New_Reserva : Form
    {


        public New_Reserva()
        {
            InitializeComponent();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            Menu_Principal.reservas.Add(new Reserva(this.fechaReserva.Value, Convert.ToInt32(this.TB_personas.Text), this.TB_comentarios.Text, this.TB_Persona.Text));
            this.Close();
        }
    }
}
