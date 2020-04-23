using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDGVLibreTema
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }
        List<Ciudadano> ListadgvCiudadano = new List<Ciudadano>();
        public void guardar()
        {
            Ciudadano ciudadano = new Ciudadano(txtnombre.Text, txtapellido.Text, int.Parse(txtedad.Text), txtpais.Text, txtciudad.Text, txtbarrio.Text, txtdireccion.Text, int.Parse(txttelefono.Text));
            ListadgvCiudadano.Add(ciudadano);
            dgvlista.DataSource = null;
            dgvlista.DataSource = ListadgvCiudadano;
        }
        public void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txtpais.Clear();
            txtciudad.Clear();
            txtbarrio.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();
            limpiar();
            txtnombre.Focus();
            i = i + 1;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
