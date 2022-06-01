namespace Sistema_de_Ventas
{
    partial class frmDetallesVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.dtgProductosVendidos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(81, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 147;
            this.label1.Text = "Lista de productos vendidos";
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatos.Location = new System.Drawing.Point(81, 88);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(271, 96);
            this.lblDatos.TabIndex = 146;
            this.lblDatos.Text = "Datos de la venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(81, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 145;
            this.label7.Text = "ID de venta";
            // 
            // cbxID
            // 
            this.cbxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.cbxID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxID.ForeColor = System.Drawing.Color.DimGray;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(85, 37);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(267, 29);
            this.cbxID.TabIndex = 144;
            this.cbxID.Text = "Seleccionar venta";
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged_1);
            // 
            // dtgProductosVendidos
            // 
            this.dtgProductosVendidos.AllowUserToAddRows = false;
            this.dtgProductosVendidos.AllowUserToDeleteRows = false;
            this.dtgProductosVendidos.AllowUserToResizeColumns = false;
            this.dtgProductosVendidos.AllowUserToResizeRows = false;
            this.dtgProductosVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductosVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductosVendidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgProductosVendidos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductosVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProductosVendidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgProductosVendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombrea,
            this.PrecioCompraa,
            this.PrecioVentaa,
            this.Cantidadd,
            this.Subtoal,
            this.Ganancia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductosVendidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductosVendidos.EnableHeadersVisualStyles = false;
            this.dtgProductosVendidos.GridColor = System.Drawing.Color.White;
            this.dtgProductosVendidos.Location = new System.Drawing.Point(85, 214);
            this.dtgProductosVendidos.Margin = new System.Windows.Forms.Padding(30);
            this.dtgProductosVendidos.MultiSelect = false;
            this.dtgProductosVendidos.Name = "dtgProductosVendidos";
            this.dtgProductosVendidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosVendidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProductosVendidos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.dtgProductosVendidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProductosVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosVendidos.ShowCellErrors = false;
            this.dtgProductosVendidos.ShowCellToolTips = false;
            this.dtgProductosVendidos.ShowEditingIcon = false;
            this.dtgProductosVendidos.ShowRowErrors = false;
            this.dtgProductosVendidos.Size = new System.Drawing.Size(778, 320);
            this.dtgProductosVendidos.TabIndex = 143;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombrea
            // 
            this.Nombrea.HeaderText = "Producto";
            this.Nombrea.Name = "Nombrea";
            this.Nombrea.ReadOnly = true;
            this.Nombrea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioCompraa
            // 
            this.PrecioCompraa.HeaderText = "Precio de compra";
            this.PrecioCompraa.Name = "PrecioCompraa";
            this.PrecioCompraa.ReadOnly = true;
            this.PrecioCompraa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVentaa
            // 
            this.PrecioVentaa.HeaderText = "Precio de venta";
            this.PrecioVentaa.Name = "PrecioVentaa";
            this.PrecioVentaa.ReadOnly = true;
            this.PrecioVentaa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidadd
            // 
            this.Cantidadd.HeaderText = "Cantidad";
            this.Cantidadd.Name = "Cantidadd";
            this.Cantidadd.ReadOnly = true;
            this.Cantidadd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Subtoal
            // 
            this.Subtoal.HeaderText = "Subtotal";
            this.Subtoal.Name = "Subtoal";
            this.Subtoal.ReadOnly = true;
            this.Subtoal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ganancia
            // 
            this.Ganancia.HeaderText = "Ganancia";
            this.Ganancia.Name = "Ganancia";
            this.Ganancia.ReadOnly = true;
            this.Ganancia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmDetallesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.dtgProductosVendidos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDetallesVentas";
            this.Text = "DetallesCompras";
            this.Load += new System.EventHandler(this.frmDetallesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.DataGridView dtgProductosVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganancia;
    }
}