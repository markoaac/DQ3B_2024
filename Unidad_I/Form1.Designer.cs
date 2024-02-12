namespace Unidad_I
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            button1 = new Button();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(133, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese un nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(31, 103);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Presióname";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(31, 172);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(94, 29);
            btnPrueba.TabIndex = 3;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrueba);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button button1;
        private Button btnPrueba;
    }
}
