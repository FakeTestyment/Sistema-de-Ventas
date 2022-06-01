namespace Sistema_de_Ventas
{
    partial class frmDetallesCompras
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
            this.dtgProductosComprados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(51, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 152;
            this.label1.Text = "Lista de productos comprados";
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatos.Location = new System.Drawing.Point(51, 87);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(271, 96);
            this.lblDatos.TabIndex = 151;
            this.lblDatos.Text = "Datos de la compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(51, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 150;
            this.label7.Text = "ID de compra";
            // 
            // cbxID
            // 
            this.cbxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.cbxID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxID.ForeColor = System.Drawing.Color.DimGray;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(55, 36);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(267, 29);
            this.cbxID.TabIndex = 149;
            this.cbxID.Text = "Seleccionar compra";
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged_1);
            // 
            // dtgProductosComprados
            // 
            this.dtgProductosComprados.AllowUserToAddRows = false;
            this.dtgProductosComprados.AllowUserToDeleteRows = false;
            this.dtgProductosComprados.AllowUserToResizeColumns = false;
            this.dtgProductosComprados.AllowUserToResizeRows = false;
            this.dtgProductosComprados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductosComprados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductosComprados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgProductosComprados.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductosComprados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProductosComprados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgProductosComprados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosComprados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosComprados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombrea,
            this.PrecioCompraa,
            this.Cantidadd,
            this.Subtoal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductosComprados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductosComprados.EnableHeadersVisualStyles = false;
            this.dtgProductosComprados.GridColor = System.Drawing.Color.White;
            this.dtgProductosComprados.Location = new System.Drawing.Point(55, 213);
            this.dtgProductosComprados.Margin = new System.Windows.Forms.Padding(30);
            this.dtgProductosComprados.MultiSelect = false;
            this.dtgProductosComprados.Name = "dtgProductosComprados";
            this.dtgProductosComprados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosComprados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProductosComprados.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.dtgProductosComprados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProductosComprados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosComprados.ShowCellErrors = false;
            this.dtgProductosComprados.ShowCellToolTips = false;
            this.dtgProductosComprados.ShowEditingIcon = false;
            this.dtgProductosComprados.ShowRowErrors = false;
            this.dtgProductosComprados.Size = new System.Drawing.Size(845, 292);
            this.dtgProductosComprados.TabIndex = 148;
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
            // frmDetallesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.dtgProductosComprados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDetallesCompras";
            this.Text = "DetallesCompras";
            this.Load += new System.EventHandler(this.frmDetallesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosComprados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.DataGridView dtgProductosComprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtoal;
    }
}