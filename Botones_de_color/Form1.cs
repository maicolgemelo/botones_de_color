using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botones_de_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAzul.ForeColor = Color.Blue;
            btnVerde.ForeColor = Color.Green;
            btnNaranja.ForeColor = Color.Orange;
            btnRojo.ForeColor = Color.Red;
            btnNegro.ForeColor = Color.Black;



        }

        private void BtnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void BtnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void BtnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
                
        }

        private void BtnNaranja_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void BtnNegro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            lblTitular.ForeColor = Color.White;
        }
    }
}
