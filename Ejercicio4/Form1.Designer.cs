namespace Ejercicio4
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
            lsMulti = new ListBox();
            lsUnica = new ListBox();
            btnAñadir = new Button();
            btnQuitar = new Button();
            btnTraspasar = new Button();
            lblIndicesLista1 = new Label();
            lblElementosLista1 = new Label();
            txtBox = new TextBox();
            rbLista1 = new RadioButton();
            rbLista2 = new RadioButton();
            rbTraspaso12 = new RadioButton();
            rbTraspaso21 = new RadioButton();
            groupBoxQuitar = new GroupBox();
            groupBoxTraspasar = new GroupBox();
            timerTitulo = new System.Windows.Forms.Timer(components);
            toolTipLista = new ToolTip(components);
            groupBoxQuitar.SuspendLayout();
            groupBoxTraspasar.SuspendLayout();
            SuspendLayout();
            // 
            // lsMulti
            // 
            lsMulti.FormattingEnabled = true;
            lsMulti.Location = new Point(12, 12);
            lsMulti.Name = "lsMulti";
            lsMulti.SelectionMode = SelectionMode.MultiExtended;
            lsMulti.Size = new Size(120, 94);
            lsMulti.TabIndex = 0;
            lsMulti.SelectedIndexChanged += lsMulti_SelectedIndexChanged;
            // 
            // lsUnica
            // 
            lsUnica.FormattingEnabled = true;
            lsUnica.Location = new Point(12, 119);
            lsUnica.Name = "lsUnica";
            lsUnica.Size = new Size(119, 94);
            lsUnica.TabIndex = 1;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(12, 266);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(109, 38);
            btnAñadir.TabIndex = 2;
            btnAñadir.Text = "Añadir";
            toolTipLista.SetToolTip(btnAñadir, "Añade el texto escrito en la lista1");
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(130, 266);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(109, 38);
            btnQuitar.TabIndex = 3;
            btnQuitar.Text = "Quitar";
            toolTipLista.SetToolTip(btnQuitar, "Elimina los elementos seleccionados de la lista indicada por los botones de opción");
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnTraspasar
            // 
            btnTraspasar.Location = new Point(249, 266);
            btnTraspasar.Name = "btnTraspasar";
            btnTraspasar.Size = new Size(109, 38);
            btnTraspasar.TabIndex = 4;
            btnTraspasar.Text = "Traspasar";
            toolTipLista.SetToolTip(btnTraspasar, "Mueve los elementos seleccionados de una lista a otra según la dirección indicada");
            btnTraspasar.UseVisualStyleBackColor = true;
            btnTraspasar.Click += btnTraspasar_Click;
            // 
            // lblIndicesLista1
            // 
            lblIndicesLista1.AutoSize = true;
            lblIndicesLista1.Location = new Point(147, 66);
            lblIndicesLista1.Name = "lblIndicesLista1";
            lblIndicesLista1.Size = new Size(203, 15);
            lblIndicesLista1.TabIndex = 5;
            lblIndicesLista1.Text = "ÍNDICES SELECCIONADOS LISTA 1:   0";
            // 
            // lblElementosLista1
            // 
            lblElementosLista1.AutoSize = true;
            lblElementosLista1.Location = new Point(147, 33);
            lblElementosLista1.Name = "lblElementosLista1";
            lblElementosLista1.Size = new Size(129, 15);
            lblElementosLista1.TabIndex = 6;
            lblElementosLista1.Text = "ELEMENTOS LISTA 1:   0";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(12, 228);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(346, 23);
            txtBox.TabIndex = 7;
            // 
            // rbLista1
            // 
            rbLista1.AutoSize = true;
            rbLista1.Location = new Point(0, 27);
            rbLista1.Name = "rbLista1";
            rbLista1.Size = new Size(62, 19);
            rbLista1.TabIndex = 8;
            rbLista1.TabStop = true;
            rbLista1.Text = "LISTA 1";
            toolTipLista.SetToolTip(rbLista1, "Seleccionar para quitar de la lista 1");
            rbLista1.UseVisualStyleBackColor = true;
            rbLista1.CheckedChanged += rbLista1_CheckedChanged;
            // 
            // rbLista2
            // 
            rbLista2.AutoSize = true;
            rbLista2.Location = new Point(0, 52);
            rbLista2.Name = "rbLista2";
            rbLista2.Size = new Size(62, 19);
            rbLista2.TabIndex = 9;
            rbLista2.TabStop = true;
            rbLista2.Text = "LISTA 2";
            toolTipLista.SetToolTip(rbLista2, "Seleccionar para quitar de la lista 2");
            rbLista2.UseVisualStyleBackColor = true;
            rbLista2.CheckedChanged += rbLista2_CheckedChanged;
            // 
            // rbTraspaso12
            // 
            rbTraspaso12.AutoSize = true;
            rbTraspaso12.Location = new Point(0, 27);
            rbTraspaso12.Name = "rbTraspaso12";
            rbTraspaso12.Size = new Size(101, 19);
            rbTraspaso12.TabIndex = 10;
            rbTraspaso12.TabStop = true;
            rbTraspaso12.Text = "TRASPASO 1-2";
            toolTipLista.SetToolTip(rbTraspaso12, "Seleccionar para traspasar de 1 a 2");
            rbTraspaso12.UseVisualStyleBackColor = true;
            rbTraspaso12.CheckedChanged += rbTraspaso12_CheckedChanged;
            // 
            // rbTraspaso21
            // 
            rbTraspaso21.AutoSize = true;
            rbTraspaso21.Location = new Point(0, 52);
            rbTraspaso21.Name = "rbTraspaso21";
            rbTraspaso21.Size = new Size(101, 19);
            rbTraspaso21.TabIndex = 11;
            rbTraspaso21.TabStop = true;
            rbTraspaso21.Text = "TRASPASO 2-1";
            toolTipLista.SetToolTip(rbTraspaso21, "Seleccionar para traspasar de 2 a 1");
            rbTraspaso21.UseVisualStyleBackColor = true;
            rbTraspaso21.CheckedChanged += rbTraspaso21_CheckedChanged;
            // 
            // groupBoxQuitar
            // 
            groupBoxQuitar.Controls.Add(rbLista1);
            groupBoxQuitar.Controls.Add(rbLista2);
            groupBoxQuitar.Location = new Point(130, 332);
            groupBoxQuitar.Name = "groupBoxQuitar";
            groupBoxQuitar.Size = new Size(109, 88);
            groupBoxQuitar.TabIndex = 12;
            groupBoxQuitar.TabStop = false;
            groupBoxQuitar.Text = "QUITAR";
            // 
            // groupBoxTraspasar
            // 
            groupBoxTraspasar.Controls.Add(rbTraspaso12);
            groupBoxTraspasar.Controls.Add(rbTraspaso21);
            groupBoxTraspasar.Location = new Point(249, 332);
            groupBoxTraspasar.Name = "groupBoxTraspasar";
            groupBoxTraspasar.Size = new Size(109, 88);
            groupBoxTraspasar.TabIndex = 13;
            groupBoxTraspasar.TabStop = false;
            groupBoxTraspasar.Text = "TRASPASAR";
            // 
            // timerTitulo
            // 
            timerTitulo.Enabled = true;
            timerTitulo.Interval = 200;
            timerTitulo.Tick += timer1_Tick;
            // 
            // toolTipLista
            // 
            toolTipLista.ShowAlways = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTraspasar);
            Controls.Add(groupBoxQuitar);
            Controls.Add(txtBox);
            Controls.Add(lblElementosLista1);
            Controls.Add(lblIndicesLista1);
            Controls.Add(btnTraspasar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAñadir);
            Controls.Add(lsUnica);
            Controls.Add(lsMulti);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EJERCICIO 4";
            groupBoxQuitar.ResumeLayout(false);
            groupBoxQuitar.PerformLayout();
            groupBoxTraspasar.ResumeLayout(false);
            groupBoxTraspasar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsMulti;
        private ListBox lsUnica;
        private Button btnAñadir;
        private Button btnQuitar;
        private Button btnTraspasar;
        private Label lblIndicesLista1;
        private Label lblElementosLista1;
        private TextBox txtBox;
        private RadioButton rbLista1;
        private RadioButton rbLista2;
        private RadioButton rbTraspaso12;
        private RadioButton rbTraspaso21;
        private GroupBox groupBoxQuitar;
        private GroupBox groupBoxTraspasar;
        private System.Windows.Forms.Timer timerTitulo;
        private ToolTip toolTipLista;
    }
}
