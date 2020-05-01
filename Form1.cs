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
        public Form1()
        {
            InitializeComponent();
        }
        int posicion;
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
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
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
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnagregarguardar.Enabled = true;
            txtnombre.Focus();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, pais, ciudad, barrio, direccion;
            int edad, telefono;
            nombre = txtnombre.Text;
            apellido = txtapellido.Text;
            edad = int.Parse(txtedad.Text);
            pais = txtpais.Text;
            ciudad = txtciudad.Text;
            barrio = txtbarrio.Text;
            direccion = txtdireccion.Text;
            telefono = int.Parse(txttelefono.Text);
            dgvlista[0, posicion].Value = txtnombre.Text;
            dgvlista[1, posicion].Value = txtapellido.Text;
            dgvlista[2, posicion].Value = txtedad.Text;
            dgvlista[3, posicion].Value = txtpais.Text;
            dgvlista[4, posicion].Value = txtciudad.Text;
            dgvlista[5, posicion].Value = txtbarrio.Text;
            dgvlista[6, posicion].Value = txtdireccion.Text;
            dgvlista[7, posicion].Value = txttelefono.Text;
            limpiar();
        }
        private void dgvlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvlista.CurrentRow.Index;
            txtnombre.Text = dgvlista[0, posicion].Value.ToString();
            txtapellido.Text = dgvlista[1, posicion].Value.ToString();
            txtedad.Text = dgvlista[2, posicion].Value.ToString();
            txtpais.Text = dgvlista[3, posicion].Value.ToString();
            txtciudad.Text = dgvlista[4, posicion].Value.ToString();
            txtbarrio.Text = dgvlista[5, posicion].Value.ToString();
            txtdireccion.Text = dgvlista[6, posicion].Value.ToString();
            txttelefono.Text = dgvlista[7, posicion].Value.ToString();
            btnagregarguardar.Enabled = false;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            dgvlista.Rows.RemoveAt(posicion);
        }
    }
}
