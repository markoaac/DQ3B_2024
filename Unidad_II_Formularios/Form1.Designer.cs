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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ucMascota1 = new Unidad_II_Controles.ucMascota();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucMascota2
            // 
            ucMascota2.Location = new Point(12, 26);
            ucMascota2.mascota = null;
            ucMascota2.Name = "ucMascota2";
            ucMascota2.Size = new Size(327, 198);
            ucMascota2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(32, 280);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ucMascota1);
            flowLayoutPanel1.Location = new Point(345, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(443, 394);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // ucMascota1
            // 
            ucMascota1.Location = new Point(3, 3);
            ucMascota1.mascota = null;
            ucMascota1.Name = "ucMascota1";
            ucMascota1.Size = new Size(338, 209);
            ucMascota1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(ucMascota2);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Unidad_II_Controles.ucMascota ucMascota2;
        private Button button1;
        private OpenFileDialog ofdBuscar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Unidad_II_Controles.ucMascota ucMascota1;
    }
}
