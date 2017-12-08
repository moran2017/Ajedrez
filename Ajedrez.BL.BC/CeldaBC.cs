using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Ajedrez.BL.BC
{
    public class CeldaBC
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public Color Fondo { get; set; }
        public int I { get; set; }
        public int J { get; set; }
        public enum TypeEstado { Libre, Ocupado, Seleccionado }
        public TypeEstado Estado { get; set; }

        public CeldaBC(int X, int Y, int Ancho, int Largo,
                       Color Fondo, int I, int J)
        {
            this.X = X;
            this.Y = Y;
            this.Ancho = Ancho;
            this.Largo = Largo;
            this.Fondo = Fondo;
            this.I = I;
            this.J = J;
            this.Estado = TypeEstado.Libre;
        }

        public void Dibujar(Graphics g)
        {
            SolidBrush objBrush;

            if (Estado == TypeEstado.Seleccionado)
                objBrush = new SolidBrush(Color.Yellow);
            else
                objBrush = new SolidBrush(Fondo);

            g.FillRectangle(objBrush, X, Y,
                Ancho, Largo);
        }

        public bool EstaIncluido(int pX, int pY)
        {
            return pX >= X && pX <= X + Ancho &&
                   pY >= Y && pY <= Y + Largo;
        }
    }
}
