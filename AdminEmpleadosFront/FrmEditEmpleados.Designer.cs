namespace AdminEmpleadosFront
{
    partial class FrmEditEmpleados
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
            btnAceptar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDni = new TextBox();
            txtDireccion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtIngreso = new DateTimePicker();
            label6 = new Label();
            txtSalario = new NumericUpDown();
            label7 = new Label();
            cmbDepartamento = new ComboBox();
            departamentoBindingSource = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)txtSalario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departamentoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.Location = new Point(161, 234);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Location = new Point(242, 234);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 16);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Validating += txt_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 48);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(110, 45);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(207, 23);
            txtDni.TabIndex = 1;
            txtDni.Validating += txt_Validating;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(110, 103);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(207, 23);
            txtDireccion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 106);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 140);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 10;
            label5.Text = "Ingreso";
            // 
            // txtIngreso
            // 
            txtIngreso.CustomFormat = "dd/MM/yyyy";
            txtIngreso.Format = DateTimePickerFormat.Custom;
            txtIngreso.Location = new Point(110, 134);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(84, 23);
            txtIngreso.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 166);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.DecimalPlaces = 2;
            txtSalario.Location = new Point(110, 164);
            txtSalario.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(102, 23);
            txtSalario.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 196);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 14;
            label7.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DataSource = departamentoBindingSource;
            cmbDepartamento.DisplayMember = "Nombre";
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(110, 193);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(207, 23);
            cmbDepartamento.TabIndex = 6;
            cmbDepartamento.ValueMember = "DepartamentoId";
            // 
            // departamentoBindingSource
            // 
            departamentoBindingSource.DataSource = typeof(AdminEmpleadosEntidades.Departamento);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmEditEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 269);
            Controls.Add(cmbDepartamento);
            Controls.Add(label7);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtIngreso);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnAceptar);
            Name = "FrmEditEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar empleados";
            Load += FrmEditEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)txtSalario).EndInit();
            ((System.ComponentModel.ISupportInitialize)departamentoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtDni;
        private TextBox txtDireccion;
        private Label label4;
        private Label label5;
        private DateTimePicker txtIngreso;
        private Label label6;
        private NumericUpDown txtSalario;
        private Label label7;
        private ComboBox cmbDepartamento;
        private BindingSource departamentoBindingSource;
        private ErrorProvider errorProvider1;
    }
}