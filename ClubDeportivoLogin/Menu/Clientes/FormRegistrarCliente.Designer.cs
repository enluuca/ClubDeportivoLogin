namespace ClubDeportivoLogin
{

    partial class FormRegistrarCliente
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            chkAptoFisico = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            label7 = new Label();
            dtpInscripcion = new DateTimePicker();
            dtpVencimiento = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            chkCarnetEntregado = new CheckBox();
            chkAsociarse = new CheckBox();
            btnGuardar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblDni = new Label();
            tabPage2 = new TabPage();
            btnImprimirCarnet = new Button();
            panel1 = new Panel();
            lblTotalDescuento = new Label();
            label13 = new Label();
            txtCuotas = new TextBox();
            txtDescuento = new TextBox();
            lblDescuento = new Label();
            lblCuotas = new Label();
            lblMonto = new Label();
            lblMedPago = new Label();
            txtMonto = new TextBox();
            comboMedPago = new ComboBox();
            lblFeBaja = new Label();
            dateBaja = new DateTimePicker();
            lblNumCarnet = new Label();
            tabPage3 = new TabPage();
            dgvPagos = new DataGridView();
            btnSalir = new Button();
            lblEstado = new Label();
            lblTipoCliente = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 59);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(158, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 25);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(158, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(188, 25);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(138, 17);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(158, 144);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(188, 25);
            txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 144);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 8;
            label5.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(158, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 25);
            txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 173);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 10;
            label6.Text = "Teléfono:";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAptoFisico.Location = new Point(382, 92);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(106, 24);
            chkAptoFisico.TabIndex = 12;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "DD/MM/YYYY";
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Location = new Point(158, 113);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(188, 25);
            dtpFechaNacimiento.TabIndex = 13;
            dtpFechaNacimiento.Value = new DateTime(2025, 6, 7, 1, 54, 11, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 73);
            label7.Name = "label7";
            label7.Size = new Size(134, 17);
            label7.TabIndex = 14;
            label7.Text = "Fecha de Inscripción:";
            // 
            // dtpInscripcion
            // 
            dtpInscripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInscripcion.Location = new Point(173, 67);
            dtpInscripcion.Name = "dtpInscripcion";
            dtpInscripcion.Size = new Size(139, 25);
            dtpInscripcion.TabIndex = 15;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpVencimiento.Location = new Point(173, 106);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(139, 25);
            dtpVencimiento.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 108);
            label8.Name = "label8";
            label8.Size = new Size(125, 17);
            label8.TabIndex = 16;
            label8.Text = "Vencimiento Cuota:";
            // 
            // label9
            // 
            label9.BackColor = Color.LightGray;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 25);
            label9.Name = "label9";
            label9.Size = new Size(130, 25);
            label9.TabIndex = 18;
            label9.Text = "N° de Carnet:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkCarnetEntregado
            // 
            chkCarnetEntregado.AutoSize = true;
            chkCarnetEntregado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCarnetEntregado.Location = new Point(364, 6);
            chkCarnetEntregado.Name = "chkCarnetEntregado";
            chkCarnetEntregado.Size = new Size(134, 21);
            chkCarnetEntregado.TabIndex = 20;
            chkCarnetEntregado.Text = "Carnet Entregado";
            chkCarnetEntregado.UseVisualStyleBackColor = true;
            // 
            // chkAsociarse
            // 
            chkAsociarse.BackColor = Color.Transparent;
            chkAsociarse.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAsociarse.ForeColor = Color.Black;
            chkAsociarse.Location = new Point(382, 148);
            chkAsociarse.Name = "chkAsociarse";
            chkAsociarse.Size = new Size(106, 30);
            chkAsociarse.TabIndex = 23;
            chkAsociarse.Text = "Asociar";
            chkAsociarse.UseVisualStyleBackColor = false;
            chkAsociarse.CheckedChanged += chkAsociarse_CheckedChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(278, 319);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 30);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(71, 20);
            tabControl1.Location = new Point(36, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(517, 272);
            tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblDni);
            tabPage1.Controls.Add(txtDireccion);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(chkAsociarse);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtTelefono);
            tabPage1.Controls.Add(chkAptoFisico);
            tabPage1.Controls.Add(dtpFechaNacimiento);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(509, 244);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificación";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDni
            // 
            lblDni.BackColor = Color.LightGray;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(75, 19);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(188, 25);
            lblDni.TabIndex = 24;
            lblDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnImprimirCarnet);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(lblFeBaja);
            tabPage2.Controls.Add(dateBaja);
            tabPage2.Controls.Add(lblNumCarnet);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dtpInscripcion);
            tabPage2.Controls.Add(dtpVencimiento);
            tabPage2.Controls.Add(chkCarnetEntregado);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(509, 244);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datos Socio";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.BackColor = Color.FromArgb(255, 255, 192);
            btnImprimirCarnet.Font = new Font("Segoe UI Semibold", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimirCarnet.Location = new Point(346, 29);
            btnImprimirCarnet.Margin = new Padding(3, 2, 3, 2);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(160, 34);
            btnImprimirCarnet.TabIndex = 30;
            btnImprimirCarnet.Text = "Imprimir Carnet";
            btnImprimirCarnet.UseVisualStyleBackColor = false;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalDescuento);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtCuotas);
            panel1.Controls.Add(txtDescuento);
            panel1.Controls.Add(lblDescuento);
            panel1.Controls.Add(lblCuotas);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lblMedPago);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(comboMedPago);
            panel1.Location = new Point(6, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 104);
            panel1.TabIndex = 29;
            // 
            // lblTotalDescuento
            // 
            lblTotalDescuento.Font = new Font("Segoe UI Semibold", 11.1272726F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDescuento.ForeColor = Color.DarkGreen;
            lblTotalDescuento.Location = new Point(195, 9);
            lblTotalDescuento.Name = "lblTotalDescuento";
            lblTotalDescuento.Size = new Size(297, 23);
            lblTotalDescuento.TabIndex = 33;
            lblTotalDescuento.TextAlign = ContentAlignment.MiddleRight;
            lblTotalDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label13.Location = new Point(11, 9);
            label13.Name = "label13";
            label13.Size = new Size(177, 17);
            label13.TabIndex = 32;
            label13.Text = "DETALLE DEL PRIMER PAGO:";
            // 
            // txtCuotas
            // 
            txtCuotas.Location = new Point(396, 75);
            txtCuotas.Name = "txtCuotas";
            txtCuotas.Size = new Size(67, 21);
            txtCuotas.TabIndex = 31;
            txtCuotas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(396, 42);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(67, 21);
            txtDescuento.TabIndex = 30;
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(309, 45);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(75, 17);
            lblDescuento.TabIndex = 29;
            lblDescuento.Text = "Descuento:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuotas.Location = new Point(302, 78);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(88, 17);
            lblCuotas.TabIndex = 28;
            lblCuotas.Text = "Cant. Cuotas:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(65, 43);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(52, 17);
            lblMonto.TabIndex = 24;
            lblMonto.Text = "Monto:";
            // 
            // lblMedPago
            // 
            lblMedPago.AutoSize = true;
            lblMedPago.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedPago.Location = new Point(16, 78);
            lblMedPago.Name = "lblMedPago";
            lblMedPago.Size = new Size(103, 17);
            lblMedPago.TabIndex = 26;
            lblMedPago.Text = "Medio de Pago:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(123, 41);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 21);
            txtMonto.TabIndex = 25;
            // 
            // comboMedPago
            // 
            comboMedPago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboMedPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMedPago.FormattingEnabled = true;
            comboMedPago.Location = new Point(123, 75);
            comboMedPago.Name = "comboMedPago";
            comboMedPago.Size = new Size(121, 20);
            comboMedPago.TabIndex = 27;
            // 
            // lblFeBaja
            // 
            lblFeBaja.AutoSize = true;
            lblFeBaja.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeBaja.ForeColor = Color.FromArgb(192, 0, 0);
            lblFeBaja.Location = new Point(358, 87);
            lblFeBaja.Name = "lblFeBaja";
            lblFeBaja.Size = new Size(111, 17);
            lblFeBaja.TabIndex = 23;
            lblFeBaja.Text = "Fecha Baja Socio:";
            lblFeBaja.Visible = false;
            // 
            // dateBaja
            // 
            dateBaja.Checked = false;
            dateBaja.CustomFormat = "\"dd/MM/yyyy\"";
            dateBaja.Font = new Font("Segoe UI", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBaja.Format = DateTimePickerFormat.Custom;
            dateBaja.Location = new Point(346, 106);
            dateBaja.Name = "dateBaja";
            dateBaja.ShowCheckBox = true;
            dateBaja.Size = new Size(139, 24);
            dateBaja.TabIndex = 22;
            dateBaja.Visible = false;
            // 
            // lblNumCarnet
            // 
            lblNumCarnet.BackColor = Color.LightGray;
            lblNumCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumCarnet.ForeColor = Color.Blue;
            lblNumCarnet.Location = new Point(163, 25);
            lblNumCarnet.Name = "lblNumCarnet";
            lblNumCarnet.Size = new Size(150, 25);
            lblNumCarnet.TabIndex = 21;
            lblNumCarnet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvPagos);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(509, 244);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Pagos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            dgvPagos.BackgroundColor = SystemColors.Control;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(3, 3);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(503, 238);
            dgvPagos.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(423, 319);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 30);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI Semibold", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Blue;
            lblEstado.Location = new Point(220, 287);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(333, 29);
            lblEstado.TabIndex = 24;
            lblEstado.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoCliente.ForeColor = Color.FromArgb(192, 0, 0);
            lblTipoCliente.Location = new Point(250, 5);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(303, 25);
            lblTipoCliente.TabIndex = 27;
            lblTipoCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 361);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblEstado);
            Controls.Add(btnSalir);
            Controls.Add(tabControl1);
            Controls.Add(btnGuardar);
            Name = "FormRegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A.B.M. de \"Maestro de Cliente\"";
            Load += FormRegistrarCliente_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private CheckBox chkAptoFisico;
        private DateTimePicker dtpFechaNacimiento;
        private Label label7;
        private DateTimePicker dtpInscripcion;
        private DateTimePicker dtpVencimiento;
        private Label label8;
        private Label label9;
        private CheckBox chkCarnetEntregado;
        private CheckBox chkAsociarse;
        private Button btnGuardar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSalir;
        private Label lblNumCarnet;
        private Label lblEstado;
        private Label lblFeBaja;
        private DateTimePicker dateBaja;
        private Label lblDni;
        private Label lblTipoCliente;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblMedPago;
        private ComboBox comboMedPago;
        private Label lblCuotas;
        private Panel panel1;
        private Label label13;
        private TextBox txtCuotas;
        private TextBox txtDescuento;
        private Label lblDescuento;
        private Label lblTotalDescuento;
        private Button btnImprimirCarnet;
        private TabPage tabPage3;
        private DataGridView dgvPagos;
    }
}