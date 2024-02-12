namespace Unidad_II_Controles
{
    partial class ucMascota
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbMascota = new PictureBox();
            lblNombre = new Label();
            label1 = new Label();
            txtTipo = new TextBox();
            txtEdad = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMascota).BeginInit();
            SuspendLayout();
            // 
            // pbMascota
            // 
            pbMascota.BorderStyle = BorderStyle.Fixed3D;
            pbMascota.Location = new Point(13, 50);
            pbMascota.Name = "pbMascota";
            pbMascota.Size = new Size(89, 103);
            pbMascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMascota.TabIndex = 0;
            pbMascota.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Monotype Corsiva", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(13, 11);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(245, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label1";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(108, 73);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(150, 27);
            txtTipo.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(108, 126);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(150, 27);
            txtEdad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 103);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "Edad";
            // 
            // ucMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtTipo);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(pbMascota);
            Name = "ucMascota";
            Size = new Size(270, 167);
            ((System.ComponentModel.ISupportInitialize)pbMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMascota;
        private Label lblNombre;
        private Label label1;
        private TextBox txtTipo;
        private TextBox txtEdad;
        private Label label2;
    }
}
