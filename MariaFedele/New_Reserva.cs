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
        private List<horario> horas;

        public class horario{
            public int hora;
            public int minuto;
            public override string ToString()
            {
                string text;
                if (hora < 10)
                    text = "0" + hora.ToString();
                else text = hora.ToString();

                if (minuto == 0)
                    text += ":" + "00";
                else text += ":" + minuto.ToString();
                return text;
            }
            public horario(int hora,int minuto)
            {
                this.hora = hora;
                this.minuto = minuto;
            }
        };

        public New_Reserva()
        {
            InitializeComponent();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            horas = new List<horario>();
            var index = 0;
            int[] min = { 0, 15,30, 45 };
            for (int i = 0; i < 24*4; i++)
            {
                horas.Add(new horario(Convert.ToInt32(Math.Floor(((double)i / 4))), 0)
                {
                    minuto = min[index]
                });
                index++;
                if (index == 4)
                    index = 0;
            }

            horaComboBox.Items.AddRange(horas.ToArray());
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            var fecha = this.fechaReserva.Value;
            var hora = horaComboBox.SelectedItem as horario;
            Menu_Principal.reservas.Add(new Reserva(new DateTime(fecha.Year,fecha.Month,fecha.Day,hora.hora,hora.minuto,0), Convert.ToInt32(this.TB_personas.Text), this.TB_comentarios.Text, this.TB_Persona.Text));
            this.Close();
        }
    }
}
