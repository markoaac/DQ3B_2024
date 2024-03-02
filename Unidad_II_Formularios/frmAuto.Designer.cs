namespace Unidad_II_Formularios
{
    partial class frmAuto
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
            label1 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            label2 = new Label();
            txtCapacidad = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ofdBuscar = new OpenFileDialog();
            contenedor = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 58);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(155, 27);
            txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(12, 136);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(155, 27);
            txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Modelo";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(12, 220);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(155, 27);
            txtCapacidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 4;
            label3.Text = "Capacidad  Máxima";
            // 
            // button1
            // 
            button1.Location = new Point(36, 273);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ofdBuscar
            // 
            ofdBuscar.FileName = "openFileDialog1";
            // 
            // contenedor
            // 
            contenedor.AutoScroll = true;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(217, 12);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(571, 426);
            contenedor.TabIndex = 7;
            // 
            // frmAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contenedor);
            Controls.Add(button1);
            Controls.Add(txtCapacidad);
            Controls.Add(label3);
            Controls.Add(txtModelo);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(label1);
            Name = "frmAuto";
            Text = "frmAuto";
            FormClosing += frmAuto_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label label2;
        private TextBox txtCapacidad;
        private Label label3;
        private Button button1;
        private OpenFileDialog ofdBuscar;
        private FlowLayoutPanel contenedor;
    }
}