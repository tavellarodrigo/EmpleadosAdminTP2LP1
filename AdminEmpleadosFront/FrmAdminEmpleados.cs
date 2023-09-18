using AdminEmpleadosEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleadosNegocio;

namespace AdminEmpleadosFront
{
    public partial class FrmAdminEmpleados : Form
    {
        List<Empleado> empleadosList = new List<Empleado>();

        public FrmAdminEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEmpleados();           
        }
        private void buscarEmpleados()
        {
            //Obtengo el nombre ingresado por el usuario
            string nombreBuscar = txtBuscar.Text.Trim().ToUpper();

            //declaro el parametro
            Empleado parametro = new Empleado();

            //asigno el nombre ingresado
            if (!String.IsNullOrEmpty(nombreBuscar.Trim()))
                parametro.Nombre = nombreBuscar;

            //Busco la lista de empleados en la capa de negocio, pasandole el parametro ingresado
            empleadosList = EmpleadosNegocio.Get(parametro);
            //Actualizo la grilla
            refreshGrid();
        }

        private void refreshGrid()
        {
            //Actualizo el Binding con la lista de empleados que viene desde la BD
            empleadoBindingSource.DataSource = null;
            empleadoBindingSource.DataSource = empleadosList;
            
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Llamo al metodo buscar al presionar la tecla "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarEmpleados();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmEditEmpleados frm = new FrmEditEmpleados();

            //paso por parametro "algo"
            frm.modo = EnumModoForm.Alta;

            frm.ShowDialog();

            buscarEmpleados();
        }

        private void CargarDatosEmpleado()
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (empleadoBindingSource.Current == null)
                return;

            FrmEditEmpleados frm = new FrmEditEmpleados();

            frm.modo = EnumModoForm.Consulta;
            frm._empleado = (Empleado)empleadoBindingSource.Current;

            frm.ShowDialog();

            buscarEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (empleadoBindingSource.Current == null)
                return;

            FrmEditEmpleados frm = new FrmEditEmpleados();
            
            frm.modo = EnumModoForm.Modificacion;
            frm._empleado = (Empleado)empleadoBindingSource.Current;

            frm.ShowDialog();

            buscarEmpleados();
            
        }
    }
}
