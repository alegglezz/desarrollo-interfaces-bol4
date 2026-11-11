namespace Ejercicio6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.panelImgs = new System.Windows.Forms.FlowLayoutPanel();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.btnAvance = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 74);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(117, 56);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // panelImgs
            // 
            this.panelImgs.Location = new System.Drawing.Point(12, 166);
            this.panelImgs.Name = "panelImgs";
            this.panelImgs.Size = new System.Drawing.Size(562, 272);
            this.panelImgs.TabIndex = 2;
            this.panelImgs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pbImg
            // 
            this.pbImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(593, 166);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(195, 234);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 3;
            this.pbImg.TabStop = false;
            this.pbImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Location = new System.Drawing.Point(593, 415);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(95, 23);
            this.btnRetroceso.TabIndex = 4;
            this.btnRetroceso.Text = "←";
            this.toolTip.SetToolTip(this.btnRetroceso, "Click izquierdo");
            this.btnRetroceso.UseVisualStyleBackColor = true;
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // btnAvance
            // 
            this.btnAvance.Location = new System.Drawing.Point(694, 415);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(94, 23);
            this.btnAvance.TabIndex = 5;
            this.btnAvance.Text = "→";
            this.toolTip.SetToolTip(this.btnAvance, "Click derecho");
            this.btnAvance.UseVisualStyleBackColor = true;
            this.btnAvance.Click += new System.EventHandler(this.btnAvance_Click);
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(163, 117);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(0, 13);
            this.lblDirectorio.TabIndex = 6;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(163, 74);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 13);
            this.lblDatos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.btnAvance);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.panelImgs);
            this.Controls.Add(this.btnAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.FlowLayoutPanel panelImgs;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnRetroceso;
        private System.Windows.Forms.Button btnAvance;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.Label lblDatos;
    }
}

