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
    public partial class Reservas : Form
    {
        public List<Reserva> reservas;
        BindingSource reservas_bs;
        public Reservas(List<Reserva> reservas)
        {
            InitializeComponent();

            this.reservas = reservas;
        }

        private void Calendario_reservas_DateChanged(object sender, DateRangeEventArgs e)
        {
            var FechaAct = Calendario_reservas.SelectionStart;
            var reservas_Dia = reservas.
                Where(x => x.fecha.Year == FechaAct.Year).
                Where(x => x.fecha.Month == FechaAct.Month).
                Where(x => x.fecha.Day == FechaAct.Day);
            reservas_bs.DataSource = reservas_Dia.ToList();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            reservas_bs = new BindingSource();
            var FechaAct = Calendario_reservas.SelectionStart;
            var reservas_Dia=reservas.
                Where(x => x.fecha.Year == FechaAct.Year).
                Where(x=>x.fecha.Month == FechaAct.Month).
                Where(x=>x.fecha.Day == FechaAct.Day);
            reservas_bs.DataSource = reservas_Dia.ToList();
            Grid_reservas.DataSource = reservas_bs;
            Grid_reservas.Columns[0].HeaderText = "Fecha";
            Grid_reservas.Columns[1].HeaderText = "Cantidad";
            Grid_reservas.Columns[2].HeaderText = "Comentarios";
            Grid_reservas.Columns[3].HeaderText = "A nombre de";
        }
    }
}
