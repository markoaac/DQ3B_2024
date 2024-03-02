namespace Unidad_II_Formularios.Productos
{
    partial class frmPrincipalProductos
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
            txtNombreProducto = new TextBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            button1 = new Button();
            contenedor = new FlowLayoutPanel();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtNombreProducto.Location = new Point(10, 28);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(170, 28);
            txtNombreProducto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtPrecio.Location = new Point(10, 87);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(170, 28);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label2.Location = new Point(10, 66);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtStock.Location = new Point(10, 154);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(170, 28);
            txtStock.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label3.Location = new Point(10, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 4;
            label3.Text = "Stock";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.edit_add;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(40, 183);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contenedor
            // 
            contenedor.AutoScroll = true;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(186, 7);
            contenedor.Margin = new Padding(3, 2, 3, 2);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(517, 364);
            contenedor.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.edit_add;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(40, 225);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 8;
            button2.Text = "Carrito";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmPrincipalProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 379);
            Controls.Add(button2);
            Controls.Add(contenedor);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipalProductos";
            Text = "frmPrincipalProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreProducto;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private Button button1;
        private FlowLayoutPanel contenedor;
        private OpenFileDialog openFileDialog1;
        private Button button2;
    }
}