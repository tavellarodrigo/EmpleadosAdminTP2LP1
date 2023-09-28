namespace AdminEmpleadosFront
{
    partial class FrmAdminEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            EmpleadoId = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            NombreDepartamento = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dptoidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoBindingSource = new BindingSource(components);
            txtBuscar = new TextBox();
            btnAlta = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBuscar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnCerrar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmpleadoId, Dni, Nombre, Direccion, FechaIngreso, Salario, NombreDepartamento, empleadoIdDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, fechaIngresoDataGridViewTextBoxColumn, salarioDataGridViewTextBoxColumn, dptoidDataGridViewTextBoxColumn, departamentoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = empleadoBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(108, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(692, 422);
            dataGridView1.TabIndex = 0;
            // 
            // EmpleadoId
            // 
            EmpleadoId.DataPropertyName = "EmpleadoId";
            EmpleadoId.HeaderText = "id";
            EmpleadoId.Name = "EmpleadoId";
            EmpleadoId.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.DataPropertyName = "Dni";
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            FechaIngreso.DataPropertyName = "FechaIngreso";
            FechaIngreso.HeaderText = "FechaIngreso";
            FechaIngreso.Name = "FechaIngreso";
            FechaIngreso.ReadOnly = true;
            // 
            // Salario
            // 
            Salario.DataPropertyName = "Salario";
            Salario.HeaderText = "Salario";
            Salario.Name = "Salario";
            Salario.ReadOnly = true;
            // 
            // NombreDepartamento
            // 
            NombreDepartamento.DataPropertyName = "NombreDepartamento";
            NombreDepartamento.HeaderText = "NombreDepartamento";
            NombreDepartamento.Name = "NombreDepartamento";
            NombreDepartamento.ReadOnly = true;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            fechaIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dptoidDataGridViewTextBoxColumn
            // 
            dptoidDataGridViewTextBoxColumn.DataPropertyName = "dpto_id";
            dptoidDataGridViewTextBoxColumn.HeaderText = "dpto_id";
            dptoidDataGridViewTextBoxColumn.Name = "dptoidDataGridViewTextBoxColumn";
            dptoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(AdminEmpleadosEntidades.Empleado);
            // 
            // txtBuscar
            // 
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Location = new Point(0, 0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(692, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(3, 47);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(99, 38);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Controls.Add(btnAlta);
            flowLayoutPanel1.Controls.Add(btnConsultar);
            flowLayoutPanel1.Controls.Add(btnModificar);
            flowLayoutPanel1.Controls.Add(btnBaja);
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(108, 450);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(3, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 38);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(3, 91);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 38);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(3, 135);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 38);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(3, 179);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(99, 38);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(3, 223);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(99, 38);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(108, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 28);
            panel1.TabIndex = 4;
            // 
            // FrmAdminEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmAdminEmpleados";
            Text = "Administración de empleados";
            Load += FrmAdminEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource empleadoBindingSource;
        private TextBox txtBuscar;
        private Button btnAlta;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnConsultar;
        private Button btnCerrar;
        private Panel panel1;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn EmpleadoId;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn NombreDepartamento;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dptoidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
    }
}