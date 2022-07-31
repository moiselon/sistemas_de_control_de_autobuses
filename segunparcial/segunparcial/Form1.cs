using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segunparcial
{
    public partial class Form1 : Form
    {

        Form2 formulariodatos;
        public Form1()
        {
            InitializeComponent();
            formulariodatos = new Form2();
        }

        private void btn_ventana2_Click(object sender, EventArgs e)
        {
            formulariodatos.ShowDialog();
        }
    }
}
