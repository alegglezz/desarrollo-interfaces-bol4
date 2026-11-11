namespace Ejercicio5
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.textBoxAgenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAgenda
            // 
            this.textBoxAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAgenda.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgenda.Location = new System.Drawing.Point(0, 0);
            this.textBoxAgenda.Multiline = true;
            this.textBoxAgenda.Name = "textBoxAgenda";
            this.textBoxAgenda.ReadOnly = true;
            this.textBoxAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAgenda.Size = new System.Drawing.Size(484, 450);
            this.textBoxAgenda.TabIndex = 0;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.textBoxAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "AGENDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAgenda;
    }
}