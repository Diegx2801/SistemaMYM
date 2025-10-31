namespace SistemaVentas
{
    partial class MantenedorDistribuidor
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
            this.Observaciones = new System.Windows.Forms.GroupBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.dtFechaderegistro = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFechaderegistro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRazonsocial = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.cbkEstadoDistribuidor = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDistribuidor = new System.Windows.Forms.DataGridView();
            this.Observaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribuidor)).BeginInit();
            this.SuspendLayout();
            // 
            // Observaciones
            // 
            this.Observaciones.Controls.Add(this.btnInicio);
            this.Observaciones.Controls.Add(this.dtFechaderegistro);
            this.Observaciones.Controls.Add(this.txtEmail);
            this.Observaciones.Controls.Add(this.lblFechaderegistro);
            this.Observaciones.Controls.Add(this.lblEmail);
            this.Observaciones.Controls.Add(this.lblTelefono);
            this.Observaciones.Controls.Add(this.lblDireccion);
            this.Observaciones.Controls.Add(this.lblRazonsocial);
            this.Observaciones.Controls.Add(this.lblRuc);
            this.Observaciones.Controls.Add(this.txtTelefono);
            this.Observaciones.Controls.Add(this.txtRazonSocial);
            this.Observaciones.Controls.Add(this.txtDireccion);
            this.Observaciones.Controls.Add(this.txtRuc);
            this.Observaciones.Controls.Add(this.cbkEstadoDistribuidor);
            this.Observaciones.Controls.Add(this.btnCancelar);
            this.Observaciones.Controls.Add(this.btnModificar);
            this.Observaciones.Controls.Add(this.btnAgregar);
            this.Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Observaciones.Location = new System.Drawing.Point(13, 313);
            this.Observaciones.Margin = new System.Windows.Forms.Padding(4);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Padding = new System.Windows.Forms.Padding(4);
            this.Observaciones.Size = new System.Drawing.Size(1020, 244);
            this.Observaciones.TabIndex = 11;
            this.Observaciones.TabStop = false;
            this.Observaciones.Text = "Datos del Distribuidor";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(918, 211);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(94, 36);
            this.btnInicio.TabIndex = 17;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // dtFechaderegistro
            // 
            this.dtFechaderegistro.Location = new System.Drawing.Point(476, 194);
            this.dtFechaderegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaderegistro.Name = "dtFechaderegistro";
            this.dtFechaderegistro.Size = new System.Drawing.Size(265, 23);
            this.dtFechaderegistro.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 205);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 23);
            this.txtEmail.TabIndex = 30;
            // 
            // lblFechaderegistro
            // 
            this.lblFechaderegistro.AutoSize = true;
            this.lblFechaderegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaderegistro.Location = new System.Drawing.Point(320, 194);
            this.lblFechaderegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaderegistro.Name = "lblFechaderegistro";
            this.lblFechaderegistro.Size = new System.Drawing.Size(141, 17);
            this.lblFechaderegistro.TabIndex = 28;
            this.lblFechaderegistro.Text = "Fecha de Registro";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(8, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(8, 155);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 17);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(8, 110);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(76, 17);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblRazonsocial
            // 
            this.lblRazonsocial.AutoSize = true;
            this.lblRazonsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRazonsocial.Location = new System.Drawing.Point(8, 75);
            this.lblRazonsocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonsocial.Name = "lblRazonsocial";
            this.lblRazonsocial.Size = new System.Drawing.Size(101, 17);
            this.lblRazonsocial.TabIndex = 21;
            this.lblRazonsocial.Text = "Razón social";
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRuc.Location = new System.Drawing.Point(8, 41);
            this.lblRuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(40, 17);
            this.lblRuc.TabIndex = 20;
            this.lblRuc.Text = "RUC";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(124, 159);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 23);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(123, 70);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(180, 23);
            this.txtRazonSocial.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 106);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 23);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(123, 34);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(180, 23);
            this.txtRuc.TabIndex = 15;
            // 
            // cbkEstadoDistribuidor
            // 
            this.cbkEstadoDistribuidor.AutoSize = true;
            this.cbkEstadoDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbkEstadoDistribuidor.Location = new System.Drawing.Point(350, 37);
            this.cbkEstadoDistribuidor.Margin = new System.Windows.Forms.Padding(4);
            this.cbkEstadoDistribuidor.Name = "cbkEstadoDistribuidor";
            this.cbkEstadoDistribuidor.Size = new System.Drawing.Size(190, 21);
            this.cbkEstadoDistribuidor.TabIndex = 14;
            this.cbkEstadoDistribuidor.Text = "Estado de distribuidor";
            this.cbkEstadoDistribuidor.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(877, 124);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(877, 74);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 38);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(877, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 38);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(890, 232);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 41);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(890, 164);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(143, 41);
            this.btnDeshabilitar.TabIndex = 9;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(890, 101);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 41);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(890, 34);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(143, 41);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvDistribuidor
            // 
            this.dgvDistribuidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistribuidor.Location = new System.Drawing.Point(13, 34);
            this.dgvDistribuidor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDistribuidor.Name = "dgvDistribuidor";
            this.dgvDistribuidor.RowHeadersWidth = 51;
            this.dgvDistribuidor.Size = new System.Drawing.Size(821, 239);
            this.dgvDistribuidor.TabIndex = 6;
            // 
            // MantenedorDistribuidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 588);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDistribuidor);
            this.Name = "MantenedorDistribuidor";
            this.Text = "MantenedorDistribuidor";
            this.Observaciones.ResumeLayout(false);
            this.Observaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribuidor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Observaciones;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.DateTimePicker dtFechaderegistro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFechaderegistro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRazonsocial;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.CheckBox cbkEstadoDistribuidor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDistribuidor;
    }
}