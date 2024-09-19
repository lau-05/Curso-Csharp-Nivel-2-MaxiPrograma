namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.labelResultado);
            this.panel2.Controls.Add(this.tbApellido);
            this.panel2.Controls.Add(this.labelApellido);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.tbResultado);
            this.panel2.Controls.Add(this.labelDireccion);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.tbDireccion);
            this.panel2.Controls.Add(this.labelEdad);
            this.panel2.Controls.Add(this.tbEdad);
            this.panel2.Controls.Add(this.labelNombre);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Location = new System.Drawing.Point(3, -19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 451);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(123, 62);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.MaxLength = 10000;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(363, 27);
            this.tbNombre.TabIndex = 5;
            // 
            // tbApellido
            // 
            this.tbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellido.Location = new System.Drawing.Point(123, 27);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApellido.MaxLength = 10000;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(363, 27);
            this.tbApellido.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(26, 65);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(21, 30);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(75, 20);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "APELLIDO";
            // 
            // tbEdad
            // 
            this.tbEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEdad.Location = new System.Drawing.Point(123, 94);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEdad.MaxLength = 10000;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(68, 27);
            this.tbEdad.TabIndex = 6;
            this.tbEdad.TextChanged += new System.EventHandler(this.tbEdad_TextChanged);
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(21, 100);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(49, 20);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "EDAD";
            // 
            // tbDireccion
            // 
            this.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccion.Location = new System.Drawing.Point(123, 129);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDireccion.MaxLength = 10000;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(363, 27);
            this.tbDireccion.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(123, 337);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 41);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(20, 132);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(85, 20);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "DIRECCIÓN";
            // 
            // tbResultado
            // 
            this.tbResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbResultado.Location = new System.Drawing.Point(24, 194);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResultado.MaxLength = 10000;
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(462, 135);
            this.tbResultado.TabIndex = 8;
            this.tbResultado.TextChanged += new System.EventHandler(this.tbResultado_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(306, 337);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 41);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(21, 170);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(89, 20);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "RESULTADO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 435);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(518, 432);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Panel panel1;
    }
}

