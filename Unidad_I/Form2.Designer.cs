namespace Unidad_I
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
            contenedor = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // contenedor
            // 
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(144, 74);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(476, 324);
            contenedor.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(336, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(contenedor);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel contenedor;
        private Button button1;
    }
}