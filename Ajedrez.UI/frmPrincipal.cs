using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ajedrez.BL.BC;

namespace Ajedrez.UI
{
    public partial class frmPrincipal : Form
    {
        private TableroBC objTablero;
        private Graphics g;
        private BufferedGraphics buffer;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objTablero = new TableroBC(8, 8);
            g = this.CreateGraphics();
            BufferedGraphicsContext context = BufferedGraphicsManager.Current;
            buffer = context.Allocate(g, this.ClientRectangle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buffer.Graphics.Clear(this.BackColor);
            objTablero.Dibujar(buffer.Graphics);
            buffer.Render(g);
        }
    }
}
