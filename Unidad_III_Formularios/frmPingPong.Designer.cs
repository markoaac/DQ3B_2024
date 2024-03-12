namespace Unidad_III_Formularios
{
    partial class frmPingPong
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
            bolita = new PictureBox();
            barra = new PictureBox();
            lblPuntos = new Label();
            ((System.ComponentModel.ISupportInitialize)bolita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barra).BeginInit();
            SuspendLayout();
            // 
            // bolita
            // 
            bolita.BackColor = Color.DarkRed;
            bolita.Location = new Point(470, 264);
            bolita.Name = "bolita";
            bolita.Size = new Size(47, 51);
            bolita.TabIndex = 0;
            bolita.TabStop = false;
            // 
            // barra
            // 
            barra.BackColor = Color.Olive;
            barra.Location = new Point(1, 509);
            barra.Name = "barra";
            barra.Size = new Size(228, 37);
            barra.TabIndex = 1;
            barra.TabStop = false;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(12, 9);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(63, 34);
            lblPuntos.TabIndex = 2;
            lblPuntos.Text = "----";
            // 
            // frmPingPong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 547);
            Controls.Add(lblPuntos);
            Controls.Add(barra);
            Controls.Add(bolita);
            Name = "frmPingPong";
            Text = "frmPingPong";
            FormClosing += frmPingPong_FormClosing;
            KeyDown += frmPingPong_KeyDown;
            ((System.ComponentModel.ISupportInitialize)bolita).EndInit();
            ((System.ComponentModel.ISupportInitialize)barra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bolita;
        private PictureBox barra;
        private Label lblPuntos;
    }
}