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

        public Empleado _empleado = new Empleado();
        public FrmEditEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEditEmpleados_Load(object sender, EventArgs e)
        {
            CargarComboDepartamento();

            if (modo == EnumModoForm.Alta)
            {
                LimpiarControles();
                HabilitarControles(true);
            }
            if (modo == EnumModoForm.Modificacion)
            {
                HabilitarControles(true);
                CargarDatos();
            }
            if (modo == EnumModoForm.Consulta)
            {
                HabilitarControles(false);
                CargarDatos();
                btnAceptar.Enabled = false;
            }

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
                emp.Departamento = new Departamento();
                
                //tomo el ID del departamento, el cual esta en el combo
                emp.Departamento.id = (int)cmbDepartamento.SelectedValue;
                emp.dpto_id = emp.Departamento.id;

                string mensajeErrores = "";
                //realizo validaciones. El mensaje va por referencia
                if (! ValidarEmpleado(ref mensajeErrores, emp) )
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

                if (modo == EnumModoForm.Alta)
                {
                    int idEmp = EmpleadosNegocio.Insert(emp);
                    txtId.Text = idEmp.ToString();
                    MessageBox.Show("Se generó el empleado nro " + idEmp.ToString(), "Empleado creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (modo == EnumModoForm.Modificacion)
                {
                    emp.id =Convert.ToInt32( txtId.Text);
                    EmpleadosNegocio.Update(emp);                    
                    MessageBox.Show("Se actualizaron los datos correctamente", "Empleado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }


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
       

        private void CargarComboDepartamento()
        {
            //envio por parametro un departamento sin datos, asi va sin filtro y trae todos los dptos
            Departamento d = new Departamento();            
            departamentoBindingSource.DataSource = DepartamentosNegocio.Get(d);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
        
            Close();
        }
        private void HabilitarControles(bool habilitar)
        {            
            
            txtSalario.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            txtDni.Enabled = habilitar;
            txtIngreso.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            cmbDepartamento.Enabled = habilitar;    
        }
        private void CargarDatos()
        {
            txtId.Text = _empleado.id.ToString();
            txtSalario.Value = Convert.ToDecimal(_empleado.Salario);
            txtDireccion.Text = _empleado.Direccion;
            txtDni.Text = _empleado.Dni;
            if (_empleado.FechaIngreso != null)
                txtIngreso.Value = Convert.ToDateTime(_empleado.FechaIngreso);
            txtNombre.Text = _empleado.Nombre;
                        
            if (_empleado.Departamento != null)
                cmbDepartamento.SelectedValue = _empleado.Departamento.id;

        }

      
    }
}
