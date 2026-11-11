namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNuevaImg = new Button();
            ofdImg = new OpenFileDialog();
            ckbModal = new CheckBox();
            timerTitulo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnNuevaImg
            // 
            btnNuevaImg.Location = new Point(38, 36);
            btnNuevaImg.Name = "btnNuevaImg";
            btnNuevaImg.Size = new Size(148, 23);
            btnNuevaImg.TabIndex = 0;
            btnNuevaImg.Text = "Nueva Imagen";
            btnNuevaImg.UseVisualStyleBackColor = true;
            btnNuevaImg.Click += btnNuevaImg_Click;
            // 
            // ofdImg
            // 
            ofdImg.FileName = "openFileDialog1";
            // 
            // ckbModal
            // 
            ckbModal.AutoSize = true;
            ckbModal.Location = new Point(38, 84);
            ckbModal.Name = "ckbModal";
            ckbModal.Size = new Size(60, 19);
            ckbModal.TabIndex = 1;
            ckbModal.Text = "Modal";
            ckbModal.UseVisualStyleBackColor = true;
            ckbModal.CheckedChanged += ckbModal_CheckedChanged;
            // 
            // timerTitulo
            // 
            timerTitulo.Enabled = true;
            timerTitulo.Interval = 1000;
            timerTitulo.Tick += timerTitulo_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ckbModal);
            Controls.Add(btnNuevaImg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Visor de imágenes 00:00";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevaImg;
        private OpenFileDialog ofdImg;
        private CheckBox ckbModal;
        private System.Windows.Forms.Timer timerTitulo;
    }
}
