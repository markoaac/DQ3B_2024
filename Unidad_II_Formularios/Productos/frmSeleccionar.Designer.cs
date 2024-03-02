namespace Unidad_II_Formularios.Productos
{
    partial class frmSeleccionar
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
            lblNombreProducto = new Label();
            lblStock = new Label();
            txtCantidad = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProducto.Location = new Point(12, 9);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(530, 37);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "label1";
            lblNombreProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(12, 63);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(530, 37);
            lblStock.TabIndex = 1;
            lblStock.Text = "label1";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(172, 114);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(216, 35);
            txtCantidad.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.agt_action_success;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(79, 170);
            button1.Name = "button1";
            button1.Size = new Size(222, 39);
            button1.TabIndex = 12;
            button1.Text = "Agregar al Carrito";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.cancel;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(336, 170);
            button2.Name = "button2";
            button2.Size = new Size(117, 39);
            button2.TabIndex = 13;
            button2.Text = "Cerrar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 252);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCantidad);
            Controls.Add(lblStock);
            Controls.Add(lblNombreProducto);
            Name = "frmSeleccionar";
            Text = "frmSeleccionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private Label lblStock;
        private TextBox txtCantidad;
        private Button button1;
        private Button button2;
    }
}