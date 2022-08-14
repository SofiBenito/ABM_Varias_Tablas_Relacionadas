using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace ABMCarrera
{
    public partial class Form1 : Form
    {
        List<Carrera> listaCarrera = new List<Carrera>();
        List<DetalleCarrera>listaDetalle= new List<DetalleCarrera>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            habilitarCarrera(false);
            habilitarDetalle(false);
            limpiarCarrera();
            limpiarDetalle();
            CargarComboAignatura();
            cargarGrillaCarrera();
            cargarGrillaDetalle();
        }
        //---------------------------Carrera-------------------------------
        private void habilitarCarrera(bool x)
        {

            txtCarrera.Enabled = x;
            txtCodigoCarrera.Enabled = x;
            txtTitulo.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            btnEliminar.Enabled = !x;
            dgvCarrera.Enabled = !x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
        }
        private void limpiarCarrera()
        {
            txtCarrera.Text = "";
            txtCodigoCarrera.Text = "";
            txtTitulo.Text = "";

        }
        private bool validarCarrera()
        {
            if (txtCodigoCarrera.Text == string.Empty)
            {

                MessageBox.Show("debe ingresar un Codigo De carrera");
                txtCodigoCarrera.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtCodigoCarrera.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese Solo Numeros En el campo Codigo Por Favor");
                    txtCodigoCarrera.Focus();
                    return false;
                }
            }

            if (txtCarrera.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar una Carrera");
                txtCarrera.Focus();
                return false;
            }

            if (txtTitulo.Text == string.Empty)
            {

                MessageBox.Show("debe ingresar un Titulo");
                txtTitulo.Focus();
                return false;
            }

            return true;
        }
        private bool existe(Carrera nueva)
        {
            for (int i = 0; i < listaCarrera.Count; i++)
            {
                if (listaCarrera[i].Cod_carrera == nueva.Cod_carrera)
                {
                    return true;
                }
            }
            return false;
        }
        private void cargarGrillaCarrera()
        {
            CarreraNegocio carreraNegocio = new CarreraNegocio();
            try
            {
                listaCarrera = carreraNegocio.listar();
                dgvCarrera.DataSource=listaCarrera;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        //-------------------Carrera Detalle---------------------------------
        private void cargarGrillaDetalle()
        {
           DetalleCarreraNegocio detalleCarreraNegocio = new DetalleCarreraNegocio();
            try
            {
                listaDetalle = detalleCarreraNegocio.listar();
                dgvDetalle.DataSource = listaDetalle;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void habilitarDetalle(bool x)
        {
            txtcod_carrera_detalle.Enabled = x;
            txtCuatrimestre.Enabled = x;
            dtpAnioCursado.Enabled = x;
            cboAsignatura.Enabled = x;
            btnNuevoDetalle.Enabled = !x;
            btneditarDetalle.Enabled = !x;
            dgvDetalle.Enabled = !x;
            btngrabardetalle.Enabled = x;
            btncancelardetalle.Enabled = x;

        }
        private void limpiarDetalle()
        {
            txtcod_carrera_detalle.Text = "";
            cboAsignatura.SelectedIndex = -1;
            dtpAnioCursado.Value = DateTime.Today;
            txtCuatrimestre.Text = "";
        }
        private void CargarComboAignatura()
        {
            AsignaturaNegocio asignaturaNegocio = new AsignaturaNegocio();
            try
            {
                cboAsignatura.DataSource = asignaturaNegocio.listar();
                cboAsignatura.ValueMember = "idAsignatura";
                cboAsignatura.DisplayMember = "nombre";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //------------CARRERA---------------------
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCarrera(true);
            limpiarCarrera();
            txtCodigoCarrera.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCarrera(true);
            txtCodigoCarrera.Enabled = false;
            txtCarrera.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            CarreraNegocio carreraNegocio = new CarreraNegocio();
            if(validarCarrera())
            {
                Carrera carrera = new Carrera();
                carrera.Cod_carrera=int.Parse(txtCodigoCarrera.Text);
                carrera.Nombre = txtCarrera.Text;
                carrera.Titulo = txtTitulo.Text;
                if(!existe(carrera))
                {
                    MessageBox.Show("Se agrego exitosamente la carrera");
                    carreraNegocio.agregar(carrera);
                    cargarGrillaCarrera();
                }
                else
                {
                    MessageBox.Show("Se Modifico exitosamente la carrera");
                    carreraNegocio.modificar(carrera);
                    cargarGrillaCarrera();
                }

                habilitarCarrera(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCarrera(false);
            limpiarCarrera();
            cargarGrillaCarrera();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro Que Quiere Salir?", "Saliendo",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
                Close();
        }
        //-----------Detalle--------------------------
        private void btnNuevoDetalle_Click(object sender, EventArgs e)
        {
            habilitarDetalle(true);
            limpiarDetalle();
            txtcod_carrera_detalle.Focus();
        }

        private void btneditarDetalle_Click(object sender, EventArgs e)
        {
            habilitarDetalle(true);
            txtcod_carrera_detalle.Enabled = false;
            dtpAnioCursado.Focus();
        }

        private void btncancelardetalle_Click(object sender, EventArgs e)
        {
            habilitarDetalle(false);
            limpiarDetalle();
            cargarGrillaDetalle();
        }

        private void btneliminarDetalle_Click(object sender, EventArgs e)
        {
            DetalleCarreraNegocio detalleCarreraNegocio = new DetalleCarreraNegocio();
            DetalleCarrera seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Seguro Que Quiere Eliminar?", "Eliminando",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (DetalleCarrera)dgvDetalle.CurrentRow.DataBoundItem;
                detalleCarreraNegocio.eliminar(seleccionado.Carrera.Cod_carrera);
                cargarGrillaDetalle();
            }
        }

        private void btngrabardetalle_Click(object sender, EventArgs e)
        {
            DetalleCarreraNegocio detalleCarreraNegocio = new DetalleCarreraNegocio();
            if (validarDetalle())
            {
                DetalleCarrera detalle = new DetalleCarrera();
                detalle.Carrera = new Carrera();
                detalle.Carrera.Cod_carrera = int.Parse(txtcod_carrera_detalle.Text.ToString());
                detalle.AnioCursado = dtpAnioCursado.Value;
                detalle.Cuatrimestre = txtCuatrimestre.Text;
                detalle.Asignatura = (Asignatura)cboAsignatura.SelectedItem;

                if (!existeDetalle(detalle))
                {
                    MessageBox.Show("Se agrego exitosamente El Detalle");
                    detalleCarreraNegocio.agregar(detalle);
                    cargarGrillaDetalle();
                }
                else if (existeDetalle(detalle))
                {
                    MessageBox.Show("Se Modifico exitosamente El Detalle");
                    detalleCarreraNegocio.modificar(detalle);
                    cargarGrillaDetalle();
                }
                else
                {
                    MessageBox.Show("Esa Carrera no esta cargada");
                }


                habilitarCarrera(false);
            }
           
        }
        private bool validarDetalle()
        {
            if(txtcod_carrera_detalle.Text==String.Empty)
            {
                MessageBox.Show("Ingrese el codigo de carrera que se uso en la carga de la carrera");
                txtcod_carrera_detalle.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtcod_carrera_detalle.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese Numeros en el campo codigo");
                    txtcod_carrera_detalle.Focus();
                    return false;

                }
            }

            if(dtpAnioCursado.Value>DateTime.Today)
            {
                MessageBox.Show("No Puede Registrar Carreras con fecha posterior a la actual");
                dtpAnioCursado.Focus();
                return false;
            }

            if(txtCuatrimestre.Text==string.Empty)
            {
                MessageBox.Show("Ingrese un cuatrimestre");
                txtcod_carrera_detalle.Focus();
                return false;
            }
            if(cboAsignatura.SelectedIndex==-1)
            {
                MessageBox.Show("Ingrese una Asignatura");
                cboAsignatura.Focus();
                return false;
            }
            return true;
        }
        private bool existeDetalle(DetalleCarrera nuevo)
        {
            for (int i = 0; i < listaDetalle.Count; i++)
            {
                if (listaDetalle[i].Carrera.Cod_carrera == nuevo.Carrera.Cod_carrera)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvCarrera_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCarrera!=null)
            {
                Carrera seleccionada = (Carrera)dgvCarrera.CurrentRow.DataBoundItem;
                txtCodigoCarrera.Enabled = false;
                txtCodigoCarrera.Text = seleccionada.Cod_carrera.ToString();
                txtCarrera.Text = seleccionada.Nombre;
                txtTitulo.Text = seleccionada.Titulo;
            }
        }

        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDetalle!=null)
            {
                DetalleCarrera seleccionado =(DetalleCarrera)dgvDetalle.CurrentRow.DataBoundItem;
                txtcod_carrera_detalle.Enabled = false;
                txtcod_carrera_detalle.Text = seleccionado.Carrera.Cod_carrera.ToString();
                dtpAnioCursado.Value = seleccionado.AnioCursado;
                txtCuatrimestre.Text = seleccionado.Cuatrimestre;
                cboAsignatura.SelectedValue = seleccionado.Asignatura.IdAsignatura;
               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CarreraNegocio carreraNegocio = new CarreraNegocio();
            Carrera selecionada;
            DialogResult respuesta = MessageBox.Show("¿Seguro Que Quiere Eliminar? ASEGURESE QUE SE BORRE EN EL DETALLE PRIMERO", "Eliminando",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (respuesta==DialogResult.Yes)
            {
                selecionada=(Carrera)dgvCarrera.CurrentRow.DataBoundItem;
                carreraNegocio.eliminar(selecionada.Cod_carrera);
                cargarGrillaCarrera();
            }
        }
    }
}
