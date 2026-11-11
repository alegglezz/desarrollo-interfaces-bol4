namespace Ejercicio3
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pbxImg = new PictureBox();
            menuImg = new ContextMenuStrip(components);
            ajustarImagenToolStripMenuItem = new ToolStripMenuItem();
            noAjustarImagenToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbxImg).BeginInit();
            menuImg.SuspendLayout();
            SuspendLayout();
            // 
            // pbxImg
            // 
            pbxImg.ContextMenuStrip = menuImg;
            pbxImg.Dock = DockStyle.Fill;
            pbxImg.Location = new Point(0, 0);
            pbxImg.Name = "pbxImg";
            pbxImg.Size = new Size(800, 450);
            pbxImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImg.TabIndex = 0;
            pbxImg.TabStop = false;
            // 
            // menuImg
            // 
            menuImg.Items.AddRange(new ToolStripItem[] { ajustarImagenToolStripMenuItem, noAjustarImagenToolStripMenuItem });
            menuImg.Name = "menuImg";
            menuImg.Size = new Size(172, 48);
            // 
            // ajustarImagenToolStripMenuItem
            // 
            ajustarImagenToolStripMenuItem.Name = "ajustarImagenToolStripMenuItem";
            ajustarImagenToolStripMenuItem.Size = new Size(171, 22);
            ajustarImagenToolStripMenuItem.Text = "Ajustar imagen";
            ajustarImagenToolStripMenuItem.Click += ajustarImagenToolStripMenuItem_Click;
            // 
            // noAjustarImagenToolStripMenuItem
            // 
            noAjustarImagenToolStripMenuItem.Name = "noAjustarImagenToolStripMenuItem";
            noAjustarImagenToolStripMenuItem.Size = new Size(171, 22);
            noAjustarImagenToolStripMenuItem.Text = "No ajustar imagen";
            noAjustarImagenToolStripMenuItem.Click += noAjustarImagenToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbxImg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "IMAGEN";
            ((System.ComponentModel.ISupportInitialize)pbxImg).EndInit();
            menuImg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxImg;
        private ContextMenuStrip menuImg;
        private ToolStripMenuItem ajustarImagenToolStripMenuItem;
        private ToolStripMenuItem noAjustarImagenToolStripMenuItem;
    }
}