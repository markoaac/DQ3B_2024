namespace Unidad_III_Formularios
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
            button1 = new Button();
            button2 = new Button();
            txtMensaje = new TextBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Saludar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Ciclo For";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(268, 12);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(125, 27);
            txtMensaje.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(59, 74);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(668, 86);
            progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.Location = new Point(46, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 171);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(86, 355);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Mover";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(txtMensaje);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtMensaje;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button button3;
    }
}
