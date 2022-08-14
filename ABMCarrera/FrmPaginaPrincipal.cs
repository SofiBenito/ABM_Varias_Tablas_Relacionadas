using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCarrera
{
    public partial class FrmPaginaPrincipal : Form
    {
        public FrmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro Que Quiere Salir de la aplicacion?", "Saliendo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ingresarCarrerasYDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType()==typeof(Form1))
                {
                    MessageBox.Show("Ya Hay una ventana abierta trabaje en esa");
                    return;
                }
            }
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();

        }
    }
}
