namespace Unidad_II_Controles
{
    partial class ucProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbProducto = new PictureBox();
            lblNombreProducto = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblId = new Label();
            btnSeleccionar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // pbProducto
            // 
            pbProducto.BorderStyle = BorderStyle.Fixed3D;
            pbProducto.Location = new Point(3, 41);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(84, 99);
            pbProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProducto.TabIndex = 0;
            pbProducto.TabStop = false;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProducto.Location = new Point(93, 41);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(50, 22);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "-----";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(93, 79);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 22);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "-----";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(93, 118);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(50, 22);
            lblStock.TabIndex = 3;
            lblStock.Text = "-----";
            // 
            // lblId
            // 
            lblId.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(3, 7);
            lblId.Name = "lblId";
            lblId.Size = new Size(276, 22);
            lblId.TabIndex = 4;
            lblId.Text = "-----";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(3, 146);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(140, 29);
            btnSeleccionar.TabIndex = 5;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(152, 146);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(127, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ucProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnActualizar);
            Controls.Add(btnSeleccionar);
            Controls.Add(lblId);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombreProducto);
            Controls.Add(pbProducto);
            Name = "ucProducto";
            Size = new Size(282, 184);
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProducto;
        private Label lblNombreProducto;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblId;
        private Button btnSeleccionar;
        private Button btnActualizar;
    }
}
