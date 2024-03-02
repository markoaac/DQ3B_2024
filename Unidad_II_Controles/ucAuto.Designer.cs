namespace Unidad_II_Controles
{
    partial class ucAuto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbAuto = new PictureBox();
            label1 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            label2 = new Label();
            txtCapacidadMaxima = new TextBox();
            txtLitros = new TextBox();
            pbarGasolina = new ProgressBar();
            btnPrender = new Button();
            btnApagar = new Button();
            btnCargar = new Button();
            tmrGasolina = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbAuto).BeginInit();
            SuspendLayout();
            // 
            // pbAuto
            // 
            pbAuto.BackColor = Color.White;
            pbAuto.BorderStyle = BorderStyle.Fixed3D;
            pbAuto.Location = new Point(3, 3);
            pbAuto.Name = "pbAuto";
            pbAuto.Size = new Size(133, 164);
            pbAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAuto.TabIndex = 0;
            pbAuto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 3);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(142, 26);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(156, 27);
            txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(142, 90);
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = true;
            txtModelo.Size = new Size(156, 27);
            txtModelo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 67);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Modelo";
            // 
            // txtCapacidadMaxima
            // 
            txtCapacidadMaxima.Location = new Point(142, 140);
            txtCapacidadMaxima.Name = "txtCapacidadMaxima";
            txtCapacidadMaxima.ReadOnly = true;
            txtCapacidadMaxima.Size = new Size(75, 27);
            txtCapacidadMaxima.TabIndex = 5;
            txtCapacidadMaxima.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(223, 140);
            txtLitros.Name = "txtLitros";
            txtLitros.ReadOnly = true;
            txtLitros.Size = new Size(75, 27);
            txtLitros.TabIndex = 6;
            txtLitros.TextAlign = HorizontalAlignment.Center;
            // 
            // pbarGasolina
            // 
            pbarGasolina.Location = new Point(3, 173);
            pbarGasolina.Name = "pbarGasolina";
            pbarGasolina.Size = new Size(295, 29);
            pbarGasolina.TabIndex = 7;
            // 
            // btnPrender
            // 
            btnPrender.Location = new Point(3, 208);
            btnPrender.Name = "btnPrender";
            btnPrender.Size = new Size(94, 29);
            btnPrender.TabIndex = 8;
            btnPrender.Text = "Prender";
            btnPrender.UseVisualStyleBackColor = true;
            btnPrender.Click += btnPrender_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(103, 208);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(94, 29);
            btnApagar.TabIndex = 9;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(203, 208);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // tmrGasolina
            // 
            tmrGasolina.Interval = 1000;
            // 
            // ucAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnCargar);
            Controls.Add(btnApagar);
            Controls.Add(btnPrender);
            Controls.Add(pbarGasolina);
            Controls.Add(txtLitros);
            Controls.Add(txtCapacidadMaxima);
            Controls.Add(txtModelo);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(label1);
            Controls.Add(pbAuto);
            Name = "ucAuto";
            Size = new Size(307, 249);
            ((System.ComponentModel.ISupportInitialize)pbAuto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAuto;
        private Label label1;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label label2;
        private TextBox txtCapacidadMaxima;
        private TextBox txtLitros;
        private ProgressBar pbarGasolina;
        private Button btnPrender;
        private Button btnApagar;
        private Button btnCargar;
        private System.Windows.Forms.Timer tmrGasolina;
    }
}
