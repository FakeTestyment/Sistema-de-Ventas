namespace Sistema_de_Ventas
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuAñadirCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuVerCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentasDisplay = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVerVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.container1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenuSeleccionado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductos,
            this.menuCompras,
            this.menuVentasDisplay,
            this.menuClientes,
            this.menuUsuarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(180, 558);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProductos
            // 
            this.menuProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.menuProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductos.IconSize = 30;
            this.menuProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProductos.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuProductos.Size = new System.Drawing.Size(155, 34);
            this.menuProductos.Text = "Inventario";
            this.menuProductos.Click += new System.EventHandler(this.menuProductos_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAñadirCompra,
            this.menuVerCompras});
            this.menuCompras.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.menuCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 30;
            this.menuCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuCompras.Size = new System.Drawing.Size(155, 34);
            this.menuCompras.Text = "Compras";
            // 
            // menuAñadirCompra
            // 
            this.menuAñadirCompra.AccessibleName = "menuCompras";
            this.menuAñadirCompra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAñadirCompra.ForeColor = System.Drawing.Color.Gray;
            this.menuAñadirCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuAñadirCompra.IconColor = System.Drawing.Color.Black;
            this.menuAñadirCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAñadirCompra.Name = "menuAñadirCompra";
            this.menuAñadirCompra.Size = new System.Drawing.Size(217, 30);
            this.menuAñadirCompra.Text = "Añadir compras";
            this.menuAñadirCompra.Click += new System.EventHandler(this.menuAñadirCompra_Click_1);
            // 
            // menuVerCompras
            // 
            this.menuVerCompras.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVerCompras.ForeColor = System.Drawing.Color.Gray;
            this.menuVerCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuVerCompras.IconColor = System.Drawing.Color.Black;
            this.menuVerCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVerCompras.Name = "menuVerCompras";
            this.menuVerCompras.Size = new System.Drawing.Size(217, 30);
            this.menuVerCompras.Text = "Ver compras";
            this.menuVerCompras.Click += new System.EventHandler(this.menuVerCompras_Click_1);
            // 
            // menuVentasDisplay
            // 
            this.menuVentasDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVentas,
            this.MenuVerVentas});
            this.menuVentasDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentasDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuVentasDisplay.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentasDisplay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuVentasDisplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentasDisplay.IconSize = 30;
            this.menuVentasDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuVentasDisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentasDisplay.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.menuVentasDisplay.Name = "menuVentasDisplay";
            this.menuVentasDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuVentasDisplay.Size = new System.Drawing.Size(155, 34);
            this.menuVentasDisplay.Text = "Ventas";
            // 
            // menuVentas
            // 
            this.menuVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.Color.Gray;
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(193, 30);
            this.menuVentas.Text = "Añadir Venta";
            this.menuVentas.Click += new System.EventHandler(this.menuVentas_Click);
            // 
            // MenuVerVentas
            // 
            this.MenuVerVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVerVentas.ForeColor = System.Drawing.Color.Gray;
            this.MenuVerVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuVerVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVerVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVerVentas.Name = "MenuVerVentas";
            this.MenuVerVentas.Size = new System.Drawing.Size(193, 30);
            this.MenuVerVentas.Text = "Ver Ventas";
            this.MenuVerVentas.Click += new System.EventHandler(this.MenuVerVentas_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 30;
            this.menuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuClientes.Size = new System.Drawing.Size(155, 34);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.menuUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(209)))));
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuUsuarios.IconSize = 30;
            this.menuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuUsuarios.Size = new System.Drawing.Size(155, 34);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click_1);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(1040, 17);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 70;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.container);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1290, 627);
            this.panel.TabIndex = 71;
            // 
            // container
            // 
            this.container.Controls.Add(this.container1);
            this.container.Controls.Add(this.panel4);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(185, 69);
            this.container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1105, 558);
            this.container.TabIndex = 2;
            // 
            // container1
            // 
            this.container1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container1.Location = new System.Drawing.Point(0, 27);
            this.container1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(1105, 531);
            this.container1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 27);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 558);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.lblMenuSeleccionado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblMenuSeleccionado
            // 
            this.lblMenuSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenuSeleccionado.AutoSize = true;
            this.lblMenuSeleccionado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblMenuSeleccionado.Location = new System.Drawing.Point(529, 9);
            this.lblMenuSeleccionado.Name = "lblMenuSeleccionado";
            this.lblMenuSeleccionado.Size = new System.Drawing.Size(299, 45);
            this.lblMenuSeleccionado.TabIndex = 72;
            this.lblMenuSeleccionado.Text = "Menu Seleccionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 71;
            this.label1.Text = "DressyAvenue";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(1083, 9);
            this.lblUser.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(186, 50);
            this.lblUser.TabIndex = 69;
            this.lblUser.Text = "Usuario Default";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 627);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(822, 479);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de ventas";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuVentasDisplay;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProductos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel container1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMenuSeleccionado;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuVerVentas;
        private FontAwesome.Sharp.IconMenuItem menuAñadirCompra;
        private FontAwesome.Sharp.IconMenuItem menuVerCompras;
    }
}

