namespace SistemaVentas
{
    partial class OrdenIngresoForm
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.grpOrigen = new System.Windows.Forms.GroupBox();
            this.lblNumPc = new System.Windows.Forms.Label();
            this.txtNumPc = new System.Windows.Forms.TextBox();
            this.btnBuscarPc = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblCondicionPago = new System.Windows.Forms.Label();
            this.txtCondicionPago = new System.Windows.Forms.TextBox();
            this.lblGuiaRemision = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtGuiaRemision = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.btnVerificarPc = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.txtItemsIngresados = new System.Windows.Forms.TextBox();
            this.lblItemsIngresados = new System.Windows.Forms.Label();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.txtCantidadTotal = new System.Windows.Forms.TextBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.grpItems.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(402, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ORDEN DE INGRESO";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 77);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(22, 16);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Nº";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(164, 77);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(465, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(41, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(222, 76);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(537, 74);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 4;
            // 
            // grpOrigen
            // 
            this.grpOrigen.Controls.Add(this.btnVerificarPc);
            this.grpOrigen.Controls.Add(this.btnBuscarPc);
            this.grpOrigen.Controls.Add(this.lblFactura);
            this.grpOrigen.Controls.Add(this.lblGuiaRemision);
            this.grpOrigen.Controls.Add(this.lblCondicionPago);
            this.grpOrigen.Controls.Add(this.lblProveedor);
            this.grpOrigen.Controls.Add(this.lblNumPc);
            this.grpOrigen.Controls.Add(this.txtFactura);
            this.grpOrigen.Controls.Add(this.txtGuiaRemision);
            this.grpOrigen.Controls.Add(this.txtCondicionPago);
            this.grpOrigen.Controls.Add(this.txtProveedor);
            this.grpOrigen.Controls.Add(this.txtNumPc);
            this.grpOrigen.Location = new System.Drawing.Point(13, 138);
            this.grpOrigen.Name = "grpOrigen";
            this.grpOrigen.Size = new System.Drawing.Size(311, 309);
            this.grpOrigen.TabIndex = 6;
            this.grpOrigen.TabStop = false;
            this.grpOrigen.Text = "Origen: Pedido de Compra";
            // 
            // lblNumPc
            // 
            this.lblNumPc.AutoSize = true;
            this.lblNumPc.Location = new System.Drawing.Point(6, 36);
            this.lblNumPc.Name = "lblNumPc";
            this.lblNumPc.Size = new System.Drawing.Size(22, 16);
            this.lblNumPc.TabIndex = 1;
            this.lblNumPc.Text = "Nº";
            // 
            // txtNumPc
            // 
            this.txtNumPc.Location = new System.Drawing.Point(112, 30);
            this.txtNumPc.Name = "txtNumPc";
            this.txtNumPc.Size = new System.Drawing.Size(100, 22);
            this.txtNumPc.TabIndex = 4;
            // 
            // btnBuscarPc
            // 
            this.btnBuscarPc.Location = new System.Drawing.Point(230, 23);
            this.btnBuscarPc.Name = "btnBuscarPc";
            this.btnBuscarPc.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPc.TabIndex = 5;
            this.btnBuscarPc.Text = "BuscarPc";
            this.btnBuscarPc.UseVisualStyleBackColor = true;
            this.btnBuscarPc.Click += new System.EventHandler(this.btnBuscarPc_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(6, 73);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(71, 16);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(112, 67);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 22);
            this.txtProveedor.TabIndex = 4;
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.AutoSize = true;
            this.lblCondicionPago.Location = new System.Drawing.Point(6, 106);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Size = new System.Drawing.Size(100, 16);
            this.lblCondicionPago.TabIndex = 1;
            this.lblCondicionPago.Text = "CondicionPago";
            // 
            // txtCondicionPago
            // 
            this.txtCondicionPago.Location = new System.Drawing.Point(112, 103);
            this.txtCondicionPago.Name = "txtCondicionPago";
            this.txtCondicionPago.Size = new System.Drawing.Size(100, 22);
            this.txtCondicionPago.TabIndex = 4;
            // 
            // lblGuiaRemision
            // 
            this.lblGuiaRemision.AutoSize = true;
            this.lblGuiaRemision.Location = new System.Drawing.Point(6, 142);
            this.lblGuiaRemision.Name = "lblGuiaRemision";
            this.lblGuiaRemision.Size = new System.Drawing.Size(92, 16);
            this.lblGuiaRemision.TabIndex = 1;
            this.lblGuiaRemision.Text = "GuiaRemision";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(6, 176);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(52, 16);
            this.lblFactura.TabIndex = 1;
            this.lblFactura.Text = "Factura";
            // 
            // txtGuiaRemision
            // 
            this.txtGuiaRemision.Location = new System.Drawing.Point(112, 139);
            this.txtGuiaRemision.Name = "txtGuiaRemision";
            this.txtGuiaRemision.Size = new System.Drawing.Size(100, 22);
            this.txtGuiaRemision.TabIndex = 4;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(112, 170);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 22);
            this.txtFactura.TabIndex = 4;
            // 
            // btnVerificarPc
            // 
            this.btnVerificarPc.Location = new System.Drawing.Point(127, 216);
            this.btnVerificarPc.Name = "btnVerificarPc";
            this.btnVerificarPc.Size = new System.Drawing.Size(85, 26);
            this.btnVerificarPc.TabIndex = 5;
            this.btnVerificarPc.Text = "VerificarPcPc";
            this.btnVerificarPc.UseVisualStyleBackColor = true;
            this.btnVerificarPc.Click += new System.EventHandler(this.btnBuscarPc_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colCodigo,
            this.colUnidad,
            this.colCantidad,
            this.colCantPend,
            this.colCantIng,
            this.colLote});
            this.dgvItems.Location = new System.Drawing.Point(6, 42);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(820, 150);
            this.dgvItems.TabIndex = 5;
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.txtCantidadTotal);
            this.grpItems.Controls.Add(this.txtItemsIngresados);
            this.grpItems.Controls.Add(this.lblCantidadTotal);
            this.grpItems.Controls.Add(this.lblItemsIngresados);
            this.grpItems.Controls.Add(this.dgvItems);
            this.grpItems.Location = new System.Drawing.Point(330, 126);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(896, 321);
            this.grpItems.TabIndex = 10;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            // 
            // txtItemsIngresados
            // 
            this.txtItemsIngresados.Location = new System.Drawing.Point(149, 222);
            this.txtItemsIngresados.Name = "txtItemsIngresados";
            this.txtItemsIngresados.Size = new System.Drawing.Size(100, 22);
            this.txtItemsIngresados.TabIndex = 7;
            // 
            // lblItemsIngresados
            // 
            this.lblItemsIngresados.AutoSize = true;
            this.lblItemsIngresados.Location = new System.Drawing.Point(33, 225);
            this.lblItemsIngresados.Name = "lblItemsIngresados";
            this.lblItemsIngresados.Size = new System.Drawing.Size(110, 16);
            this.lblItemsIngresados.TabIndex = 6;
            this.lblItemsIngresados.Text = "Items Ingresados";
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
            // colCantPend
            // 
            this.colCantPend.HeaderText = "Pendiente";
            this.colCantPend.MinimumWidth = 6;
            this.colCantPend.Name = "colCantPend";
            this.colCantPend.Width = 125;
            // 
            // colCantIng
            // 
            this.colCantIng.HeaderText = "Ingresar";
            this.colCantIng.MinimumWidth = 6;
            this.colCantIng.Name = "colCantIng";
            this.colCantIng.Width = 125;
            // 
            // colLote
            // 
            this.colLote.HeaderText = "Lote";
            this.colLote.MinimumWidth = 6;
            this.colLote.Name = "colLote";
            this.colLote.Width = 125;
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(47, 255);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(98, 16);
            this.lblCantidadTotal.TabIndex = 6;
            this.lblCantidadTotal.Text = "Cantidad Total:";
            // 
            // txtCantidadTotal
            // 
            this.txtCantidadTotal.Location = new System.Drawing.Point(149, 255);
            this.txtCantidadTotal.Name = "txtCantidadTotal";
            this.txtCantidadTotal.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadTotal.TabIndex = 7;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnImprimir);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnEmitir);
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(330, 453);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(826, 100);
            this.pnlAcciones.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 29);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(149, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 36);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(275, 29);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(120, 36);
            this.btnEmitir.TabIndex = 0;
            this.btnEmitir.Text = "Emitir Nota Ing";
            this.btnEmitir.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(401, 29);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(120, 36);
            this.btnAnular.TabIndex = 0;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(527, 29);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 36);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(653, 29);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // OrdenIngresoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 633);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.grpOrigen);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.Name = "OrdenIngresoForm";
            this.Text = "OrdenIngresoForm";
            this.grpOrigen.ResumeLayout(false);
            this.grpOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox grpOrigen;
        private System.Windows.Forms.Button btnBuscarPc;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblGuiaRemision;
        private System.Windows.Forms.Label lblCondicionPago;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblNumPc;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtGuiaRemision;
        private System.Windows.Forms.TextBox txtCondicionPago;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtNumPc;
        private System.Windows.Forms.Button btnVerificarPc;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLote;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.TextBox txtItemsIngresados;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblItemsIngresados;
        private System.Windows.Forms.TextBox txtCantidadTotal;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
    }
}