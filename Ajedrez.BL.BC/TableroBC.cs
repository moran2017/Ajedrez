using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Ajedrez.BL.BC
{
    public class TableroBC
    {
        public CeldaBC[][] Matriz { get; set; }
        public int N { get; set; }
        public int M { get; set; }

        public TableroBC(int N, int M)
        {
            int X = 10, Y = 10, Ancho = 50, Largo = 50;
            Color Fondo = Color.White;

            this.N = N;
            this.M = M;
            Matriz = new CeldaBC[N][];

            for (int i = 0; i < N; i++)
            {
                Matriz[i] = new CeldaBC[M];

                for (int j = 0; j < M; j++)
                {
                    Matriz[i][j] = new CeldaBC(X + Ancho * i, Y + Largo * j, Ancho, Largo, Fondo, i, j);
                    Fondo = Fondo == Color.White ?
                        Color.LightGray : Color.White;
                }

                Fondo = Fondo == Color.White ?
                        Color.LightGray : Color.White;
            }
        }

        public void Dibujar(Graphics g)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Matriz[i][j].Dibujar(g);
                }
            }
        }

        public CeldaBC ObtenerCelda(int pX, int pY)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (Matriz[i][j].EstaIncluido(pX, pY))
                        return Matriz[i][j];

            return null;
        }

        public bool ExisteCelda(int pX, int pY)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (Matriz[i][j].EstaIncluido(pX, pY))
                        return true;

            return false;
        }
    }
}
