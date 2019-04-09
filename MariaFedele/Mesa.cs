using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace MariaFedele
{
    public enum Paso_plato
    {
        Antipasto, PrimerPlato, SegundoPlato, Postre
    }
    //https://www.youtube.com/watch?v=Yb7R7Dr2DBk
    //https://github.com/DMLON/MariaFedele

    //public interface IMesa {
    //    List<Reserva> reservas { get; set; }
    //    List<Bebida> bebidas { get; set; }
    //}

    public class Mesa :IDisposable //: IMesa
    {
        public List<Reserva> reservas { get; set; }
        public List<Bebida> bebidas { get; set; }

        public string nombre;
        protected PictureBox _mesa_PictureBox;
        public PictureBox mesa_PictureBox {
            get {
                return _mesa_PictureBox;
            }
            set {
                _mesa_PictureBox = value;
                _mesa_PictureBox.MouseDown += mesa_PictureBox_MouseDown;
                _mesa_PictureBox.MouseMove += mesa_PictureBox_MouseMove;
                _mesa_PictureBox.MouseUp += mesa_PictureBox_MouseUp;
                _mesa_PictureBox.ContextMenuStrip = menu.menu;
            }
        }

        protected bool posSet;
        protected Point _posicion;
        public Point posicion {
            get {
                return _posicion;
            }
            set {
                _posicion = value;
                if (tamSet && posSet) UpdateImg(_tam.Width, _tam.Height, _posicion.X, _posicion.Y);
            }
        }

        protected bool tamSet;
        protected Size _tam;
        public Size tam {
            get {
                return _tam;
            }
            set {
                _tam = value;
                if (tamSet && posSet) UpdateImg(_tam.Width, _tam.Height, _posicion.X, _posicion.Y);
            }
        }

        public Paso paso { get; set; }
 
        public Mesa_Menu menu { get; set; }

        #region Constructores
        public Mesa(SplitterPanel contenedor) : this()
        {
            posicion = new Point(contenedor.Location.X + 20, contenedor.Location.Y + 20);

        }
        public Mesa()
        {
            reservas = new List<Reserva>();
            bebidas = new List<Bebida>();
            menu = new Mesa_Menu(this);
            tamSet = posSet = false;
            tam = new Size(50, 50);
            tamSet = true;
            posicion = new Point(20, 20);
            posSet = true;
        }
        #endregion

        protected void UpdateImg(int width, int height, int x, int y)
        {

            mesa_PictureBox.Location = new Point(posicion.X, posicion.Y);
            mesa_PictureBox.Size = new Size(tam.Width, tam.Height);
        }




        //----------------------Eventos para mouse
        //Se mueve al arrastrar
        #region MouseEvents
        public bool WorkAble_pos;
        public bool WorkAble_size;
        protected Point lastPoint { get; set; }



        protected void mesa_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (mesa_PictureBox.Cursor == Cursors.Arrow)
            {
                WorkAble_pos = true;
                lastPoint = new Point(e.X, e.Y);
                WorkAble_size = false;
            }
            else if (mesa_PictureBox.Cursor == Cursors.SizeWE || mesa_PictureBox.Cursor == Cursors.SizeNS)
            {
                WorkAble_size = true;
            }
        }

        protected void mesa_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (WorkAble_pos)
            {
                posicion = new Point((posicion.X + e.X - lastPoint.X), (posicion.Y + e.Y - lastPoint.Y));
                mesa_PictureBox.Invalidate();
            }
            else
            {
                var eMouse = mesa_PictureBox.PointToClient(Cursor.Position);
                if (Math.Abs(eMouse.X - mesa_PictureBox.Width) <= 5 || Math.Abs(eMouse.X) <= 5)
                {
                    mesa_PictureBox.Cursor = Cursors.SizeWE;
                }
                else if (Math.Abs(eMouse.Y - mesa_PictureBox.Height) <= 5 || Math.Abs(eMouse.Y) <= 5)
                {
                    mesa_PictureBox.Cursor = Cursors.SizeNS;
                }
                else
                    mesa_PictureBox.Cursor = Cursors.Arrow;
            }
            //Resize con mouse VER
            //if (WorkAble_size)
            //{
            //    var eMouse_abs = mesa_PictureBox.Parent.PointToClient(Cursor.Position);
            //    if (mesa_PictureBox.Cursor == Cursors.SizeWE)
            //    {
            //        mesa_PictureBox.Size = new Size(mesa_PictureBox.Width -e.X, mesa_PictureBox.Height);
            //        mesa_PictureBox.Invalidate();
            //    }
            //    else if (mesa_PictureBox.Cursor == Cursors.SizeNS)
            //    {
            //        mesa_PictureBox.Size = new Size(mesa_PictureBox.Width, mesa_PictureBox.Height - eMouse_abs.Y);
            //        mesa_PictureBox.Invalidate();
            //    }
            //}
        }

        protected void mesa_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            WorkAble_pos = false;
            WorkAble_size = false;
            lastPoint = new Point(e.X, e.Y);
        }

        #endregion

        public void Dispose()
        {
            Menu_Principal.Mesas.Remove(this);
            _mesa_PictureBox.Dispose();
            GC.SuppressFinalize(this);
        }

    }

    public class Mesa_cuadrada : Mesa
    {
        public Mesa_cuadrada() : base()
        {
            mesa_PictureBox = new PictureBox
            {
                Location = posicion,
                Size = tam
            };

            mesa_PictureBox.Image = Image.FromFile("MesaCuadradaV2.png");
            mesa_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

        }
    }

    public class Mesa_circular : Mesa
    {
        public Mesa_circular() : base()
        {
            mesa_PictureBox = new PictureBox
            {
                Location = posicion,
                Size = tam
            };

            mesa_PictureBox.Image = Image.FromFile("MesaCirc.png");
            mesa_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

        }
    }

    public class Reserva
    {
        public DateTime fecha { get; set; }
        public int personas { get; set; }
        public string comentarios { get; set; }
        public string persona { get; set; }
        public Reserva(DateTime fecha, int personas, string comentarios,string persona) {
            this.fecha = fecha;
            this.personas = personas;
            this.comentarios = comentarios;
            this.persona = persona;
        }
    }

    public class Bebida
    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public Bebida(string nombre,int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }

    public class Paso
    {
        private Paso_plato _plato;
        public Paso_plato plato {
            get { return _plato; }
            set {
                _plato = value;
                Asignar_color(_plato);
            }
        }
        public int[] color { get; private set; }
        public Paso(Paso_plato plato)
        {
            this.plato = plato;
            Asignar_color(plato);
        }
        public void Asignar_color(Paso_plato plato)
        {
            switch (plato) {
                case Paso_plato.Antipasto:
                    color = new int[] { 255, 0, 0 };
                    break;
                case Paso_plato.PrimerPlato:
                    color = new int[] { 255, 127, 0 };
                    break;
                case Paso_plato.SegundoPlato:
                    color = new int[] { 255, 255, 0 };
                    break;
                case Paso_plato.Postre:
                    color = new int[] { 97, 255, 0 };
                    break;
            }
        }
    }

}
