using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaFedele
{
    public class Mesa_Menu //:IMesa
    {
        public ContextMenuStrip menu { get; set; }

        //public List<Reserva> reservas { get; set; }
        //public List<Bebida> bebidas { get; set; }
        private Mesa _mesa;

        public Mesa_Menu(Mesa _mesa)
        {
            //this.reservas = _mesa.reservas;
            //this.bebidas = _mesa.bebidas;

            this._mesa = _mesa;

            this.menu = new System.Windows.Forms.ContextMenuStrip();
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            new System.Windows.Forms.ToolStripMenuItem(){
                Name="eliminarToolStripMenuItem",
                Size=new System.Drawing.Size(180, 22),
                Text = "Eliminar"
            },
            new System.Windows.Forms.ToolStripMenuItem(){
                Name="reservasToolStripMenuItem",
                Size=new System.Drawing.Size(180, 22),
                Text = "Reservas"
            },
            new System.Windows.Forms.ToolStripMenuItem(){
                Name="bebidasToolStripMenuItem",
                Size=new System.Drawing.Size(180, 22),
                Text = "Bebidas"
            },
            new System.Windows.Forms.ToolStripMenuItem(){
                Name="detallesToolStripMenuItem",
                Size=new System.Drawing.Size(180, 22),
                Text = "Detalles",  
            } });
            this.menu.Items[0].Click += new EventHandler(Eliminar_Menu);
            this.menu.Items[1].Click += new EventHandler(Reservas_Menu);
            this.menu.Items[2].Click += new EventHandler(Bebidas_Menu);
            this.menu.Items[3].Click += new EventHandler(Detalles_Menu);

            this.menu.Name = "Opciones";
            this.menu.Size = new System.Drawing.Size(181, 114);

        }

        public void Eliminar_Menu(object sender, EventArgs e)
        {
            _mesa.Dispose();
        }

        public void Reservas_Menu(object sender, EventArgs e)
        {

        }

        public void Bebidas_Menu(object sender, EventArgs e)
        {

        }

        public void Detalles_Menu(object sender, EventArgs e)
        {

        }

    }
}
