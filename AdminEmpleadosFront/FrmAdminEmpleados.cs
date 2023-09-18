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
        private void FrmAdminEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEmpleados();

        }
        private void buscarEmpleados()
        {

            Empleado e = new Empleado();


            empleadosList = EmpleadosNegocio.Get(e);
            refreshGrid();
        }

        private void refreshGrid()
        {
            dataGridView1.DataSource = empleadosList;
            dataGridView1.Refresh();
        }


    }
}
