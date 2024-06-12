namespace Evaluacion1_Jenifer.Formularios
{
    partial class Gestion
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
            this.mcbProductos = new MaterialSkin.Controls.MaterialComboBox();
            this.tbCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.tbUnidades = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPrecioU = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Comprar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ListaFacturas = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TotalFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CopiaUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.Mensajes = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcbProductos
            // 
            this.mcbProductos.AutoResize = false;
            this.mcbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbProductos.Depth = 0;
            this.mcbProductos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbProductos.DropDownHeight = 174;
            this.mcbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbProductos.DropDownWidth = 121;
            this.mcbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbProductos.FormattingEnabled = true;
            this.mcbProductos.IntegralHeight = false;
            this.mcbProductos.ItemHeight = 43;
            this.mcbProductos.Location = new System.Drawing.Point(122, 41);
            this.mcbProductos.MaxDropDownItems = 4;
            this.mcbProductos.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbProductos.Name = "mcbProductos";
            this.mcbProductos.Size = new System.Drawing.Size(274, 49);
            this.mcbProductos.StartIndex = 0;
            this.mcbProductos.TabIndex = 0;
            // 
            // tbCliente
            // 
            this.tbCliente.AnimateReadOnly = false;
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCliente.Depth = 0;
            this.tbCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCliente.Hint = "Ingrese el nombre del cliente";
            this.tbCliente.LeadingIcon = null;
            this.tbCliente.Location = new System.Drawing.Point(122, 127);
            this.tbCliente.MaxLength = 50;
            this.tbCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCliente.Multiline = false;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(271, 50);
            this.tbCliente.TabIndex = 1;
            this.tbCliente.Text = "";
            this.tbCliente.TrailingIcon = null;
            // 
            // tbUnidades
            // 
            this.tbUnidades.AnimateReadOnly = false;
            this.tbUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUnidades.Depth = 0;
            this.tbUnidades.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUnidades.Hint = "Unidades a comprar";
            this.tbUnidades.LeadingIcon = null;
            this.tbUnidades.Location = new System.Drawing.Point(122, 211);
            this.tbUnidades.MaxLength = 50;
            this.tbUnidades.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUnidades.Multiline = false;
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.Size = new System.Drawing.Size(271, 50);
            this.tbUnidades.TabIndex = 2;
            this.tbUnidades.Text = "";
            this.tbUnidades.TrailingIcon = null;
            this.tbUnidades.TextChanged += new System.EventHandler(this.tbUnidades_TextChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.AnimateReadOnly = false;
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotal.Depth = 0;
            this.tbTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTotal.Hint = "Total a pagar";
            this.tbTotal.LeadingIcon = null;
            this.tbTotal.Location = new System.Drawing.Point(122, 380);
            this.tbTotal.MaxLength = 50;
            this.tbTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTotal.Multiline = false;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(271, 50);
            this.tbTotal.TabIndex = 3;
            this.tbTotal.Text = "";
            this.tbTotal.TrailingIcon = null;
            // 
            // tbPrecioU
            // 
            this.tbPrecioU.AnimateReadOnly = false;
            this.tbPrecioU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecioU.Depth = 0;
            this.tbPrecioU.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPrecioU.Hint = "Precio de la unidad";
            this.tbPrecioU.LeadingIcon = null;
            this.tbPrecioU.Location = new System.Drawing.Point(122, 294);
            this.tbPrecioU.MaxLength = 50;
            this.tbPrecioU.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPrecioU.Multiline = false;
            this.tbPrecioU.Name = "tbPrecioU";
            this.tbPrecioU.Size = new System.Drawing.Size(271, 50);
            this.tbPrecioU.TabIndex = 4;
            this.tbPrecioU.Text = "";
            this.tbPrecioU.TrailingIcon = null;
            this.tbPrecioU.TextChanged += new System.EventHandler(this.tbPrecioU_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(49, 56);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Producto:";
            // 
            // Comprar
            // 
            this.Comprar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Comprar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Comprar.Depth = 0;
            this.Comprar.HighEmphasis = true;
            this.Comprar.Icon = null;
            this.Comprar.Location = new System.Drawing.Point(152, 453);
            this.Comprar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Comprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Comprar.Name = "Comprar";
            this.Comprar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Comprar.Size = new System.Drawing.Size(160, 36);
            this.Comprar.TabIndex = 10;
            this.Comprar.Text = "Procesar Compra";
            this.Comprar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Comprar.UseAccentColor = false;
            this.Comprar.UseVisualStyleBackColor = true;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(65, 144);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Cliente:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(47, 228);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Unidades:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(76, 399);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Total:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(14, 313);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(103, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Precio Unidad:";
            // 
            // ListaFacturas
            // 
            this.ListaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaFacturas.BackgroundColor = System.Drawing.Color.Plum;
            this.ListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Producto,
            this.Unidades,
            this.Precio,
            this.Total});
            this.ListaFacturas.Location = new System.Drawing.Point(477, 87);
            this.ListaFacturas.Name = "ListaFacturas";
            this.ListaFacturas.Size = new System.Drawing.Size(599, 296);
            this.ListaFacturas.TabIndex = 15;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(909, 442);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(114, 19);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Total Facturado";
            // 
            // TotalFactura
            // 
            this.TotalFactura.AnimateReadOnly = false;
            this.TotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalFactura.Depth = 0;
            this.TotalFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalFactura.LeadingIcon = null;
            this.TotalFactura.Location = new System.Drawing.Point(845, 389);
            this.TotalFactura.MaxLength = 50;
            this.TotalFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.TotalFactura.Multiline = false;
            this.TotalFactura.Name = "TotalFactura";
            this.TotalFactura.ReadOnly = true;
            this.TotalFactura.Size = new System.Drawing.Size(231, 50);
            this.TotalFactura.TabIndex = 16;
            this.TotalFactura.Text = "";
            this.TotalFactura.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Evaluacion1_Jenifer.Properties.Resources.icons8_verificar_50__1_;
            this.panel1.Location = new System.Drawing.Point(791, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 50);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.Mensajes);
            this.panel2.Controls.Add(this.CopiaUsuario);
            this.panel2.Controls.Add(this.mcbProductos);
            this.panel2.Controls.Add(this.tbCliente);
            this.panel2.Controls.Add(this.tbUnidades);
            this.panel2.Controls.Add(this.tbTotal);
            this.panel2.Controls.Add(this.tbPrecioU);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.Comprar);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Location = new System.Drawing.Point(24, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 526);
            this.panel2.TabIndex = 19;
            // 
            // CopiaUsuario
            // 
            this.CopiaUsuario.AutoSize = true;
            this.CopiaUsuario.Depth = 0;
            this.CopiaUsuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CopiaUsuario.Location = new System.Drawing.Point(14, 7);
            this.CopiaUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.CopiaUsuario.Name = "CopiaUsuario";
            this.CopiaUsuario.Size = new System.Drawing.Size(55, 19);
            this.CopiaUsuario.TabIndex = 15;
            this.CopiaUsuario.Text = "Usuario";
            // 
            // Mensajes
            // 
            this.Mensajes.AutoSize = true;
            this.Mensajes.Depth = 0;
            this.Mensajes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mensajes.ForeColor = System.Drawing.Color.Transparent;
            this.Mensajes.Location = new System.Drawing.Point(17, 501);
            this.Mensajes.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mensajes.Name = "Mensajes";
            this.Mensajes.Size = new System.Drawing.Size(61, 19);
            this.Mensajes.TabIndex = 16;
            this.Mensajes.Text = "Mensaje";
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.TotalFactura);
            this.Controls.Add(this.ListaFacturas);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox mcbProductos;
        private MaterialSkin.Controls.MaterialTextBox tbCliente;
        private MaterialSkin.Controls.MaterialTextBox tbUnidades;
        private MaterialSkin.Controls.MaterialTextBox tbTotal;
        private MaterialSkin.Controls.MaterialTextBox tbPrecioU;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton Comprar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView ListaFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox TotalFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel CopiaUsuario;
        private MaterialSkin.Controls.MaterialLabel Mensajes;
    }
}