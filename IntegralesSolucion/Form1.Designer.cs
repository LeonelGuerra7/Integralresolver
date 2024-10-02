namespace IntegralesSolucion
{
    partial class FormIntegral
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
            this.textBoxIntegral = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIngresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIntegral
            // 
            this.textBoxIntegral.Location = new System.Drawing.Point(253, 103);
            this.textBoxIntegral.Name = "textBoxIntegral";
            this.textBoxIntegral.Size = new System.Drawing.Size(285, 20);
            this.textBoxIntegral.TabIndex = 0;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(185, 167);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(143, 42);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(429, 167);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(142, 41);
            this.buttonBorrar.TabIndex = 2;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelResultado.ForeColor = System.Drawing.Color.Black;
            this.labelResultado.Location = new System.Drawing.Point(258, 285);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(455, 29);
            this.labelResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // labelIngresa
            // 
            this.labelIngresa.AutoSize = true;
            this.labelIngresa.Location = new System.Drawing.Point(325, 70);
            this.labelIngresa.Name = "labelIngresa";
            this.labelIngresa.Size = new System.Drawing.Size(142, 13);
            this.labelIngresa.TabIndex = 5;
            this.labelIngresa.Text = "Ingresa la integral a resolver:";
            // 
            // FormIntegral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIngresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxIntegral);
            this.Name = "FormIntegral";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIntegral;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIngresa;
    }
}

