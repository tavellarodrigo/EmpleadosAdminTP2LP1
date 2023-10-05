using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleadosEntidades;
using AdminEmpleadosNegocio;

namespace AdminEmpleadosFront
{

    public partial class FrmEditEmpleados : Form
    {
        public EnumModoForm modo = EnumModoForm.Alta;

        public FrmEditEmpleados()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {
            try
            {
                //cargo los datos ingresados en un objeto empleado
                Empleado emp = new Empleado();
                emp.Salario = txtSalario.Value;
                emp.Direccion = txtDireccion.Text.Trim();
                emp.Dni = txtDni.Text.Trim();
                emp.FechaIngreso = txtIngreso.Value;
                emp.Departamento = null;
                emp.Nombre = txtNombre.Text.Trim();

                string mensajeErrores = "";
                //realizo validaciones. El mensaje va por referencia
                if (!ValidarEmpleado(ref mensajeErrores, emp))
                {
                    //si falla alguna validacion muestro el mensaje y no hago nada mas
                    MessageBox.Show("Atención: Se encontraron los siguientes errores \n" + mensajeErrores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //las validaciones estan bien
                //pregunto si quiere guardar los datos
                DialogResult res = MessageBox.Show("¿Confirma guardar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    return;
                }

                //Guardo los datos
                int idEmp = EmpleadosNegocio.Insert(emp);

                txtId.Text = idEmp.ToString();

                MessageBox.Show("Se generó el empleado nro " + idEmp.ToString(), "Empleado creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarEmpleado(ref string mensaje, Empleado e)
        {
            mensaje = "";

            if (String.IsNullOrEmpty(e.Dni.Trim()))
            {
                mensaje += "\nError en DNI";

            }

            if (String.IsNullOrEmpty(e.Nombre.Trim()))
            {
                mensaje += "\nError en Nombre";

            }
            if (!String.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            return true;

        }

        private void LimpiarControles()
        {
            txtId.Text = "";
            txtSalario.Value = 0;
            txtDireccion.Text = "";
            txtDni.Text = "";
            txtIngreso.Value = DateTime.Now;
            txtNombre.Text = "";
        }

        private void FrmEditEmpleados_Load(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
