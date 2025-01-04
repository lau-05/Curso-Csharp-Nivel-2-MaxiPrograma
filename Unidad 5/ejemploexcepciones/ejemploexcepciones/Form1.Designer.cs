namespace ejemploexcepciones
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
            this.textBoxnum1 = new System.Windows.Forms.TextBox();
            this.textBoxnum2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonMAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxnum1
            // 
            this.textBoxnum1.Location = new System.Drawing.Point(230, 75);
            this.textBoxnum1.Name = "textBoxnum1";
            this.textBoxnum1.Size = new System.Drawing.Size(70, 22);
            this.textBoxnum1.TabIndex = 0;
            // 
            // textBoxnum2
            // 
            this.textBoxnum2.Location = new System.Drawing.Point(230, 140);
            this.textBoxnum2.Name = "textBoxnum2";
            this.textBoxnum2.Size = new System.Drawing.Size(70, 22);
            this.textBoxnum2.TabIndex = 1;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(255, 297);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 16);
            this.labelResultado.TabIndex = 4;
            // 
            // buttonMAS
            // 
            this.buttonMAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMAS.Location = new System.Drawing.Point(241, 200);
            this.buttonMAS.Name = "buttonMAS";
            this.buttonMAS.Size = new System.Drawing.Size(42, 34);
            this.buttonMAS.TabIndex = 6;
            this.buttonMAS.Text = "+";
            this.buttonMAS.UseVisualStyleBackColor = true;
            this.buttonMAS.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.buttonMAS);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxnum2);
            this.Controls.Add(this.textBoxnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnum1;
        private System.Windows.Forms.TextBox textBoxnum2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonMAS;
    }
}

