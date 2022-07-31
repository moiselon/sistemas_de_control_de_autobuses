using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace segunparcial
{
    public partial class Form2 : Form
    {

        private List<Contacto> Contactos = new List<Contacto>();
        private int indice = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Contacto persona = new Contacto();
            persona.Nombre = tbnombre.Text;
            persona.Apellido = tbapellido.Text;
            persona.Fechadenacimiento = tbcumpleaño.Text;
            persona.placa = txtplaca.Text;
            persona.ruta = txtruta.Text;
            persona.año = txtaño.Text;
            persona.color = txtcolor.Text;
            persona.modelo = txtmodelo.Text;
            persona.marca = txtautobus.Text;
            persona.cedula = txtcedula.Text;


            if (indice > -1)
            {
                Contactos[indice] = persona;
                indice = -1;
            }
            else
            {

                Contactos.Add(persona);
            }
            actualizavista();
            limpiacampos();


        }
        private void actualizavista()
        {
            dgvcontactos.DataSource = null;
            dgvcontactos.DataSource = Contactos;
            dgvcontactos.ClearSelection();
        }

        private void dgvcontactos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dgvcontactos.SelectedRows[0];
            indice = dgvcontactos.Rows.IndexOf(renglon);
            Contacto persona = Contactos[indice];
            tbnombre.Text = persona.Nombre;
            tbapellido.Text = persona.Apellido;
            tbcumpleaño.Text = persona.Fechadenacimiento;
            txtplaca.Text = persona.placa;
            txtruta.Text = persona.ruta;
            txtaño.Text = persona.año;
            txtcolor.Text = persona.color;
            txtmodelo.Text = persona.modelo;
            txtautobus.Text = persona.marca;
            txtcedula.Text = persona.cedula;

        }

        private void limpiacampos()
        {
            tbnombre.Text = null;
            tbapellido.Text = null;
            tbcumpleaño.Text = null;
            txtplaca.Text = null;
            txtruta.Text = null;
            txtaño.Text = null;
            txtcolor.Text = null;
            txtmodelo.Text = null;
            txtautobus.Text = null;
            txtcedula.Text = null;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                Contactos.RemoveAt(indice);
                actualizavista();
                limpiacampos();
                indice = -1;
            }

            else
            {
                MessageBox.Show("seleccione el registro al borrar");
            }

            
                 
        }

        
    }
}
