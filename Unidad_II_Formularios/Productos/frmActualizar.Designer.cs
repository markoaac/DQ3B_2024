namespace Unidad_II_Formularios.Productos
{
    partial class frmActualizar
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
            txtNombreProducto = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txtStock = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            chkCambio = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtNombreProducto.Location = new Point(10, 38);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(280, 28);
            txtNombreProducto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.edit_add;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(86, 164);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 11;
            button1.Text = "Actualizar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtStock.Location = new Point(169, 94);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 28);
            txtStock.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label3.Location = new Point(169, 74);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 9;
            label3.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtPrecio.Location = new Point(10, 94);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(122, 28);
            txtPrecio.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 7;
            label2.Text = "Precio";
            // 
            // chkCambio
            // 
            chkCambio.AutoSize = true;
            chkCambio.Location = new Point(54, 133);
            chkCambio.Margin = new Padding(3, 2, 3, 2);
            chkCambio.Name = "chkCambio";
            chkCambio.Size = new Size(192, 19);
            chkCambio.TabIndex = 12;
            chkCambio.Text = "¿Cambiar imagen de producto?";
            chkCambio.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 226);
            Controls.Add(chkCambio);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private Label label1;
        private Button button1;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtPrecio;
        private Label label2;
        private CheckBox chkCambio;
        private OpenFileDialog openFileDialog1;
    }
}