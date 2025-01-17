namespace Discos_DB
{
    partial class frmAltaDiscos
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
            this.pbDiscos = new System.Windows.Forms.PictureBox();
            this.txtUrlmagenTapa = new System.Windows.Forms.TextBox();
            this.lblUrlImagenTapa = new System.Windows.Forms.Label();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFechaLanzamiento = new System.Windows.Forms.TextBox();
            this.txtCantidadCanciones = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDiscos
            // 
            this.pbDiscos.Location = new System.Drawing.Point(458, 72);
            this.pbDiscos.Name = "pbDiscos";
            this.pbDiscos.Size = new System.Drawing.Size(222, 222);
            this.pbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscos.TabIndex = 29;
            this.pbDiscos.TabStop = false;
            // 
            // txtUrlmagenTapa
            // 
            this.txtUrlmagenTapa.Location = new System.Drawing.Point(296, 189);
            this.txtUrlmagenTapa.Name = "txtUrlmagenTapa";
            this.txtUrlmagenTapa.Size = new System.Drawing.Size(121, 22);
            this.txtUrlmagenTapa.TabIndex = 21;
            this.txtUrlmagenTapa.Leave += new System.EventHandler(this.txtUrlmagenTapa_Leave);
            // 
            // lblUrlImagenTapa
            // 
            this.lblUrlImagenTapa.AutoSize = true;
            this.lblUrlImagenTapa.Location = new System.Drawing.Point(45, 195);
            this.lblUrlImagenTapa.Name = "lblUrlImagenTapa";
            this.lblUrlImagenTapa.Size = new System.Drawing.Size(72, 16);
            this.lblUrlImagenTapa.TabIndex = 22;
            this.lblUrlImagenTapa.Text = "Url Imagen";
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(296, 270);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(121, 24);
            this.cboTipoEdicion.TabIndex = 25;
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(296, 231);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(121, 24);
            this.cboEstilo.TabIndex = 23;
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(45, 278);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(83, 16);
            this.lblTipoEdicion.TabIndex = 26;
            this.lblTipoEdicion.Text = "Tipo Edicion";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(45, 239);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(40, 16);
            this.lblEstilo.TabIndex = 24;
            this.lblEstilo.Text = "Estilo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 33);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(48, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 33);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFechaLanzamiento
            // 
            this.txtFechaLanzamiento.Location = new System.Drawing.Point(296, 111);
            this.txtFechaLanzamiento.Name = "txtFechaLanzamiento";
            this.txtFechaLanzamiento.Size = new System.Drawing.Size(121, 22);
            this.txtFechaLanzamiento.TabIndex = 17;
            // 
            // txtCantidadCanciones
            // 
            this.txtCantidadCanciones.Location = new System.Drawing.Point(296, 151);
            this.txtCantidadCanciones.Name = "txtCantidadCanciones";
            this.txtCantidadCanciones.Size = new System.Drawing.Size(121, 22);
            this.txtCantidadCanciones.TabIndex = 19;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(296, 72);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 22);
            this.txtTitulo.TabIndex = 15;
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(45, 157);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(128, 16);
            this.lblCantidadCanciones.TabIndex = 20;
            this.lblCantidadCanciones.Text = "Cantidad Canciones";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(45, 111);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(221, 32);
            this.lblFechaLanzamiento.TabIndex = 18;
            this.lblFechaLanzamiento.Text = "Fecha Lanzamiento [YYYY-MM-DD]\r\n\r\n";
            this.lblFechaLanzamiento.Click += new System.EventHandler(this.lblFechaLanzamiento_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(45, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAltaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 410);
            this.Controls.Add(this.pbDiscos);
            this.Controls.Add(this.txtUrlmagenTapa);
            this.Controls.Add(this.lblUrlImagenTapa);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtFechaLanzamiento);
            this.Controls.Add(this.txtCantidadCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDiscos;
        private System.Windows.Forms.TextBox txtUrlmagenTapa;
        private System.Windows.Forms.Label lblUrlImagenTapa;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtFechaLanzamiento;
        private System.Windows.Forms.TextBox txtCantidadCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblTitulo;
    }
}