namespace Unidad_II_Formularios
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
            ucMascota2 = new Unidad_II_Controles.ucMascota();
            button1 = new Button();
            ofdBuscar = new OpenFileDialog();
            SuspendLayout();
            // 
            // ucMascota2
            // 
            ucMascota2.Location = new Point(450, 12);
            ucMascota2.mascota = null;
            ucMascota2.Name = "ucMascota2";
            ucMascota2.Size = new Size(338, 209);
            ucMascota2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(496, 192);
            button1.Name = "button1";
            button1.Size = new Size(176, 43);
            button1.TabIndex = 2;
            button1.Text = "Llenar Información";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ofdBuscar
            // 
            ofdBuscar.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ucMascota2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Unidad_II_Controles.ucMascota ucMascota2;
        private Button button1;
        private OpenFileDialog ofdBuscar;
    }
}
