namespace SistemaVentas
{
    partial class RequerimientoEditForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaRequerida = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRequerida = new System.Windows.Forms.DateTimePicker();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblObra = new System.Windows.Forms.Label();
            this.cmbObra = new System.Windows.Forms.ComboBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.Prioridad = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.lblBuscarMaterial = new System.Windows.Forms.Label();
            this.txtBuscarMaterial = new System.Windows.Forms.TextBox();
            this.btnBuscarMaterial = new System.Windows.Forms.Button();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCierra = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(494, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REQUERIMIENTO DE COMPRA";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 77);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(61, 16);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 114);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 16);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 167);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblFechaRequerida
            // 
            this.lblFechaRequerida.AutoSize = true;
            this.lblFechaRequerida.Location = new System.Drawing.Point(12, 204);
            this.lblFechaRequerida.Name = "lblFechaRequerida";
            this.lblFechaRequerida.Size = new System.Drawing.Size(112, 16);
            this.lblFechaRequerida.TabIndex = 4;
            this.lblFechaRequerida.Text = "FechaRequerida:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(93, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(93, 114);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(96, 167);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // dtpFechaRequerida
            // 
            this.dtpFechaRequerida.Location = new System.Drawing.Point(130, 204);
            this.dtpFechaRequerida.Name = "dtpFechaRequerida";
            this.dtpFechaRequerida.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaRequerida.TabIndex = 7;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtObservacion);
            this.grpDatos.Controls.Add(this.cmbPrioridad);
            this.grpDatos.Controls.Add(this.txtSolicitante);
            this.grpDatos.Controls.Add(this.lblObservacion);
            this.grpDatos.Controls.Add(this.Prioridad);
            this.grpDatos.Controls.Add(this.lblSolicitante);
            this.grpDatos.Controls.Add(this.cmbObra);
            this.grpDatos.Controls.Add(this.lblObra);
            this.grpDatos.Location = new System.Drawing.Point(12, 255);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(308, 301);
            this.grpDatos.TabIndex = 8;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblObra
            // 
            this.lblObra.AutoSize = true;
            this.lblObra.Location = new System.Drawing.Point(36, 34);
            this.lblObra.Name = "lblObra";
            this.lblObra.Size = new System.Drawing.Size(37, 16);
            this.lblObra.TabIndex = 0;
            this.lblObra.Text = "Obra";
            // 
            // cmbObra
            // 
            this.cmbObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObra.FormattingEnabled = true;
            this.cmbObra.Location = new System.Drawing.Point(131, 34);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(121, 24);
            this.cmbObra.TabIndex = 1;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(39, 90);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(69, 16);
            this.lblSolicitante.TabIndex = 2;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // Prioridad
            // 
            this.Prioridad.AutoSize = true;
            this.Prioridad.Location = new System.Drawing.Point(39, 142);
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Size = new System.Drawing.Size(62, 16);
            this.Prioridad.TabIndex = 3;
            this.Prioridad.Text = "Prioridad";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(39, 199);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(84, 16);
            this.lblObservacion.TabIndex = 4;
            this.lblObservacion.Text = "Observacion";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(131, 90);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(100, 22);
            this.txtSolicitante.TabIndex = 5;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cmbPrioridad.Location = new System.Drawing.Point(131, 142);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(121, 24);
            this.cmbPrioridad.TabIndex = 6;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(131, 191);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(153, 22);
            this.txtObservacion.TabIndex = 7;
            this.txtObservacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.txtTotalItems);
            this.grpItems.Controls.Add(this.lblTotalItems);
            this.grpItems.Controls.Add(this.dgvItems);
            this.grpItems.Controls.Add(this.btnAgregarItem);
            this.grpItems.Controls.Add(this.btnQuitarItem);
            this.grpItems.Controls.Add(this.btnBuscarMaterial);
            this.grpItems.Controls.Add(this.txtBuscarMaterial);
            this.grpItems.Controls.Add(this.lblBuscarMaterial);
            this.grpItems.Location = new System.Drawing.Point(350, 77);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(714, 393);
            this.grpItems.TabIndex = 9;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            // 
            // lblBuscarMaterial
            // 
            this.lblBuscarMaterial.AutoSize = true;
            this.lblBuscarMaterial.Location = new System.Drawing.Point(16, 22);
            this.lblBuscarMaterial.Name = "lblBuscarMaterial";
            this.lblBuscarMaterial.Size = new System.Drawing.Size(100, 16);
            this.lblBuscarMaterial.TabIndex = 0;
            this.lblBuscarMaterial.Text = "Buscar Material";
            // 
            // txtBuscarMaterial
            // 
            this.txtBuscarMaterial.Location = new System.Drawing.Point(147, 21);
            this.txtBuscarMaterial.Name = "txtBuscarMaterial";
            this.txtBuscarMaterial.Size = new System.Drawing.Size(132, 22);
            this.txtBuscarMaterial.TabIndex = 1;
            // 
            // btnBuscarMaterial
            // 
            this.btnBuscarMaterial.Location = new System.Drawing.Point(23, 72);
            this.btnBuscarMaterial.Name = "btnBuscarMaterial";
            this.btnBuscarMaterial.Size = new System.Drawing.Size(75, 34);
            this.btnBuscarMaterial.TabIndex = 2;
            this.btnBuscarMaterial.Text = "Buscar";
            this.btnBuscarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnQuitarItem
            // 
            this.btnQuitarItem.Location = new System.Drawing.Point(235, 72);
            this.btnQuitarItem.Name = "btnQuitarItem";
            this.btnQuitarItem.Size = new System.Drawing.Size(78, 34);
            this.btnQuitarItem.TabIndex = 3;
            this.btnQuitarItem.Text = "Quitar";
            this.btnQuitarItem.UseVisualStyleBackColor = true;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(119, 72);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(78, 34);
            this.btnAgregarItem.TabIndex = 4;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colCodigo,
            this.colDescripcion,
            this.colUnidad,
            this.colCantidad,
            this.colObservacion});
            this.dgvItems.Location = new System.Drawing.Point(6, 127);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(687, 150);
            this.dgvItems.TabIndex = 5;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.Width = 125;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 120;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.MinimumWidth = 6;
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Width = 70;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 70;
            // 
            // colObservacion
            // 
            this.colObservacion.HeaderText = "Observacion";
            this.colObservacion.MinimumWidth = 6;
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Width = 125;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(49, 319);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(79, 16);
            this.lblTotalItems.TabIndex = 6;
            this.lblTotalItems.Text = "Total Items :";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(134, 316);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(100, 22);
            this.txtTotalItems.TabIndex = 7;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCierra);
            this.pnlAcciones.Controls.Add(this.btnImprimir);
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnAnula);
            this.pnlAcciones.Controls.Add(this.btnEnviar);
            this.pnlAcciones.Controls.Add(this.btnInicio);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(356, 475);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(517, 93);
            this.pnlAcciones.TabIndex = 23;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(40, 297);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(121, 48);
            this.btnAnular.TabIndex = 18;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(177, 32);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 44);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(86, 571);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 32);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 44);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(40, 369);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 47);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(96, 32);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 44);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAnula
            // 
            this.btnAnula.Location = new System.Drawing.Point(258, 32);
            this.btnAnula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(75, 44);
            this.btnAnula.TabIndex = 17;
            this.btnAnula.Text = "Anular";
            this.btnAnula.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(339, 32);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 44);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCierra
            // 
            this.btnCierra.Location = new System.Drawing.Point(420, 32);
            this.btnCierra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCierra.Name = "btnCierra";
            this.btnCierra.Size = new System.Drawing.Size(75, 44);
            this.btnCierra.TabIndex = 22;
            this.btnCierra.Text = "Cerrar";
            this.btnCierra.UseVisualStyleBackColor = true;
            // 
            // RequerimientoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 593);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dtpFechaRequerida);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblFechaRequerida);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.Name = "RequerimientoEditForm";
            this.Text = "Requerimiento de Compra";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaRequerida;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaRequerida;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label Prioridad;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.ComboBox cmbObra;
        private System.Windows.Forms.Label lblObra;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Button btnBuscarMaterial;
        private System.Windows.Forms.TextBox txtBuscarMaterial;
        private System.Windows.Forms.Label lblBuscarMaterial;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCierra;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAnula;
    }
}