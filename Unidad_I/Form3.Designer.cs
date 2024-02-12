namespace Unidad_I
{
    partial class Form3
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
            txtNombre = new TextBox();
            button1 = new Button();
            contenedor = new FlowLayoutPanel();
            txtContinente = new TextBox();
            label2 = new Label();
            txtIdioma = new TextBox();
            label3 = new Label();
            txtPoblacion = new TextBox();
            label4 = new Label();
            txtCalor = new TextBox();
            label5 = new Label();
            txtPaises = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(39, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(39, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contenedor
            // 
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(487, 72);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(372, 268);
            contenedor.TabIndex = 4;
            // 
            // txtContinente
            // 
            txtContinente.Location = new Point(39, 117);
            txtContinente.Name = "txtContinente";
            txtContinente.Size = new Size(125, 27);
            txtContinente.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "Continente";
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(39, 182);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(125, 27);
            txtIdioma.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 159);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "Idioma";
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(39, 261);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(125, 27);
            txtPoblacion.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 238);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Poblacion";
            // 
            // txtCalor
            // 
            txtCalor.Location = new Point(39, 332);
            txtCalor.Name = "txtCalor";
            txtCalor.Size = new Size(125, 27);
            txtCalor.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 309);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 11;
            label5.Text = "¿Calor?";
            // 
            // txtPaises
            // 
            txtPaises.Location = new Point(251, 33);
            txtPaises.Multiline = true;
            txtPaises.Name = "txtPaises";
            txtPaises.Size = new Size(169, 146);
            txtPaises.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 584);
            Controls.Add(txtCalor);
            Controls.Add(label5);
            Controls.Add(txtPoblacion);
            Controls.Add(label4);
            Controls.Add(txtIdioma);
            Controls.Add(label3);
            Controls.Add(txtContinente);
            Controls.Add(label2);
            Controls.Add(contenedor);
            Controls.Add(txtPaises);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button button1;
        private FlowLayoutPanel contenedor;
        private TextBox txtContinente;
        private Label label2;
        private TextBox txtIdioma;
        private Label label3;
        private TextBox txtPoblacion;
        private Label label4;
        private TextBox txtCalor;
        private Label label5;
        private TextBox txtPaises;
    }
}