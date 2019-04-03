using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaFedele
{
    public enum Paso_plato
    {
        Antipasto, PrimerPlato, SegundoPlato, Postre
    }
    //https://www.youtube.com/watch?v=Yb7R7Dr2DBk
    //https://github.com/DMLON/MariaFedele
    public class Mesa
    {
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
            }
        }
        public Bitmap bitmap;

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
        public List<Reserva> reservas { get; set; }
        public List<Bebida> bebidas { get; set; }

        #region Constructores
        public Mesa(SplitterPanel contenedor) : this()
        {
            posicion = new Point(contenedor.Location.X + 20, contenedor.Location.Y + 20);
            mesa_PictureBox = new PictureBox
            {
                Image = bitmap,
                Location = posicion,
                Size = tam
            };
        }
        public Mesa()
        {
            tamSet = posSet = false;
            bitmap = null;
            tam = new Size(20, 20);
            tamSet = true;
            posicion = new Point(20, 20);
            posSet = true;
            mesa_PictureBox = new PictureBox
            {
                Image = bitmap,
                Location = posicion,
                Size = tam
            };
           
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
        public bool WorkAble;
        protected Point lastPoint { get; set; }
        protected void mesa_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            WorkAble = true;
            lastPoint = new Point(e.X, e.Y);
        }

        protected void mesa_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (WorkAble)
            {
                posicion = new Point((posicion.X + e.X - lastPoint.X), (posicion.Y + e.Y - lastPoint.Y));
                mesa_PictureBox.Invalidate();
            }
        }

        protected void mesa_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            WorkAble = false;
            lastPoint = new Point(e.X, e.Y);
        }

        #endregion



    }

    public class Mesa_cuadrada : Mesa{
        public Mesa_cuadrada() : base()
        {
            bitmap = new Bitmap("MesaCuadradaV2.png");
            mesa_PictureBox = new PictureBox
            {
                Image = bitmap,
                Location = posicion,
                Size = tam
            };
        }
    }

    public class Mesa_circular : Mesa
    {
        public Mesa_circular() : base()
        {
            bitmap = new Bitmap("MesaCirc.png");
            mesa_PictureBox = new PictureBox
            {
                Image = bitmap,
                Location = posicion,
                Size = tam
            };
        }
    }

    public class Reserva
    {
        public DateTime fecha;
        public int personas;
        public string comentarios;
        public string persona;
        public Reserva(DateTime fecha, int personas, string comentarios,string persona) {
            this.fecha = fecha;
            this.personas = personas;
            this.comentarios = comentarios;
            this.persona = persona;
        }
    }

    public class Bebida
    {
        public string nombre;
        public int precio;
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
