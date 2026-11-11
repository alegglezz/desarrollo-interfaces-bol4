namespace Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSalir = new Button();
            txtBoxRojo = new TextBox();
            txtBoxVerde = new TextBox();
            txtBoxAzul = new TextBox();
            btnColor = new Button();
            lblErrorColor = new Label();
            txtBoxPath = new TextBox();
            lblColor = new Label();
            lblPath = new Label();
            picBoxImagen = new PictureBox();
            btnIntroducir = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(185, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += Buttons_MouseEnter;
            btnSalir.MouseLeave += Buttons_MouseLeave;
            // 
            // txtBoxRojo
            // 
            txtBoxRojo.Location = new Point(35, 65);
            txtBoxRojo.Name = "txtBoxRojo";
            txtBoxRojo.Size = new Size(100, 23);
            txtBoxRojo.TabIndex = 1;
            txtBoxRojo.Enter += txtBoxColor_Enter;
            // 
            // txtBoxVerde
            // 
            txtBoxVerde.Location = new Point(185, 65);
            txtBoxVerde.Name = "txtBoxVerde";
            txtBoxVerde.Size = new Size(100, 23);
            txtBoxVerde.TabIndex = 2;
            txtBoxVerde.Enter += txtBoxColor_Enter;
            // 
            // txtBoxAzul
            // 
            txtBoxAzul.Location = new Point(335, 65);
            txtBoxAzul.Name = "txtBoxAzul";
            txtBoxAzul.Size = new Size(100, 23);
            txtBoxAzul.TabIndex = 3;
            txtBoxAzul.Enter += txtBoxColor_Enter;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(485, 65);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 25);
            btnColor.TabIndex = 4;
            btnColor.Text = "COLOR";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            btnColor.MouseEnter += Buttons_MouseEnter;
            btnColor.MouseLeave += Buttons_MouseLeave;
            // 
            // lblErrorColor
            // 
            lblErrorColor.AutoSize = true;
            lblErrorColor.BackColor = Color.White;
            lblErrorColor.ForeColor = Color.Red;
            lblErrorColor.Location = new Point(35, 105);
            lblErrorColor.Name = "lblErrorColor";
            lblErrorColor.Size = new Size(0, 15);
            lblErrorColor.TabIndex = 5;
            // 
            // txtBoxPath
            // 
            txtBoxPath.Location = new Point(35, 185);
            txtBoxPath.Name = "txtBoxPath";
            txtBoxPath.Size = new Size(100, 23);
            txtBoxPath.TabIndex = 6;
            txtBoxPath.Enter += textBoxPath_Enter;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.BackColor = Color.Black;
            lblColor.ForeColor = Color.White;
            lblColor.Location = new Point(35, 25);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(148, 15);
            lblColor.TabIndex = 7;
            lblColor.Text = "Introduce un número RGB:";
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.BackColor = Color.Black;
            lblPath.ForeColor = Color.White;
            lblPath.Location = new Point(35, 145);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(186, 15);
            lblPath.TabIndex = 8;
            lblPath.Text = "Introduce la PATH de una imagen:";
            // 
            // picBoxImagen
            // 
            picBoxImagen.Location = new Point(335, 145);
            picBoxImagen.Name = "picBoxImagen";
            picBoxImagen.Size = new Size(250, 113);
            picBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxImagen.TabIndex = 9;
            picBoxImagen.TabStop = false;
            // 
            // btnIntroducir
            // 
            btnIntroducir.Location = new Point(35, 235);
            btnIntroducir.Name = "btnIntroducir";
            btnIntroducir.Size = new Size(100, 23);
            btnIntroducir.TabIndex = 10;
            btnIntroducir.Text = "INTRODUCIR";
            btnIntroducir.UseVisualStyleBackColor = true;
            btnIntroducir.Click += btnIntroducir_Click;
            btnIntroducir.MouseEnter += Buttons_MouseEnter;
            btnIntroducir.MouseLeave += Buttons_MouseLeave;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(35, 345);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            btnReset.MouseEnter += Buttons_MouseEnter;
            btnReset.MouseLeave += Buttons_MouseLeave;
            // 
            // Form1
            // 
            AcceptButton = btnColor;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnIntroducir);
            Controls.Add(picBoxImagen);
            Controls.Add(lblPath);
            Controls.Add(lblColor);
            Controls.Add(txtBoxPath);
            Controls.Add(lblErrorColor);
            Controls.Add(btnColor);
            Controls.Add(txtBoxAzul);
            Controls.Add(txtBoxVerde);
            Controls.Add(txtBoxRojo);
            Controls.Add(btnSalir);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private TextBox txtBoxRojo;
        private TextBox txtBoxVerde;
        private TextBox txtBoxAzul;
        private Button btnColor;
        private Label lblErrorColor;
        private TextBox txtBoxPath;
        private Label lblColor;
        private Label lblPath;
        private PictureBox picBoxImagen;
        private Button btnIntroducir;
        private Button btnReset;
    }
}
