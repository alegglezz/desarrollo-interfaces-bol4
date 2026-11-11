namespace Ejercicio7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxOp1 = new System.Windows.Forms.TextBox();
            this.textBoxOp2 = new System.Windows.Forms.TextBox();
            this.groupBoxOperacion = new System.Windows.Forms.GroupBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBoxOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOp1
            // 
            this.textBoxOp1.Location = new System.Drawing.Point(12, 60);
            this.textBoxOp1.Name = "textBoxOp1";
            this.textBoxOp1.Size = new System.Drawing.Size(122, 20);
            this.textBoxOp1.TabIndex = 0;
            this.textBoxOp1.TextChanged += new System.EventHandler(this.ValidarTextBox);
            // 
            // textBoxOp2
            // 
            this.textBoxOp2.Location = new System.Drawing.Point(175, 60);
            this.textBoxOp2.Name = "textBoxOp2";
            this.textBoxOp2.Size = new System.Drawing.Size(122, 20);
            this.textBoxOp2.TabIndex = 1;
            this.textBoxOp2.TextChanged += new System.EventHandler(this.ValidarTextBox);
            // 
            // groupBoxOperacion
            // 
            this.groupBoxOperacion.Controls.Add(this.rbDivision);
            this.groupBoxOperacion.Controls.Add(this.rbMultiplicacion);
            this.groupBoxOperacion.Controls.Add(this.rbResta);
            this.groupBoxOperacion.Controls.Add(this.rbSuma);
            this.groupBoxOperacion.Location = new System.Drawing.Point(12, 100);
            this.groupBoxOperacion.Name = "groupBoxOperacion";
            this.groupBoxOperacion.Size = new System.Drawing.Size(285, 100);
            this.groupBoxOperacion.TabIndex = 2;
            this.groupBoxOperacion.TabStop = false;
            this.groupBoxOperacion.Text = "Elige una operación";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(6, 28);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(31, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "+";
            this.rbSuma.UseVisualStyleBackColor = true;
            this.rbSuma.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(6, 65);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(28, 17);
            this.rbResta.TabIndex = 1;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "-";
            this.rbResta.UseVisualStyleBackColor = true;
            this.rbResta.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(163, 28);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(29, 17);
            this.rbMultiplicacion.TabIndex = 2;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Text = "*";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            this.rbMultiplicacion.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(163, 65);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(30, 17);
            this.rbDivision.TabIndex = 3;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "/";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(150, 63);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(0, 13);
            this.lblOperacion.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(285, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.groupBoxOperacion);
            this.Controls.Add(this.textBoxOp2);
            this.Controls.Add(this.textBoxOp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EJERCICIO 7";
            this.groupBoxOperacion.ResumeLayout(false);
            this.groupBoxOperacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOp1;
        private System.Windows.Forms.TextBox textBoxOp2;
        private System.Windows.Forms.GroupBox groupBoxOperacion;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnCalcular;
    }
}

