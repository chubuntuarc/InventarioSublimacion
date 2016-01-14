using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioSublimacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Parent = panel2;
            label4.Parent = panel2;
            label5.Parent = panel2;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmMovimientos movimientos = new frmMovimientos();
            movimientos.Show();
            this.Hide();
        }
    }
}
