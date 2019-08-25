namespace monedero_electronico
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelPremios = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnRegistrarClientes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnRegistrarPremio = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPremios = new System.Windows.Forms.Button();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.pbMinimizar);
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 58);
            this.panel1.TabIndex = 0;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1256, 21);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(20, 20);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 1;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1311, 21);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(20, 20);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelPremios);
            this.panelMenu.Controls.Add(this.labelClientes);
            this.panelMenu.Controls.Add(this.btnRegresar);
            this.panelMenu.Controls.Add(this.btnCanjear);
            this.panelMenu.Controls.Add(this.btnAbonar);
            this.panelMenu.Controls.Add(this.btnCuenta);
            this.panelMenu.Controls.Add(this.btnRegistrarClientes);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnRegistrarPremio);
            this.panelMenu.Controls.Add(this.btnHistorial);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnPremios);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 58);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(787, 716);
            this.panelMenu.TabIndex = 1;
            // 
            // labelPremios
            // 
            this.labelPremios.AutoSize = true;
            this.labelPremios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPremios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPremios.Location = new System.Drawing.Point(210, 54);
            this.labelPremios.Name = "labelPremios";
            this.labelPremios.Size = new System.Drawing.Size(117, 33);
            this.labelPremios.TabIndex = 24;
            this.labelPremios.Text = "Premios";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClientes.Location = new System.Drawing.Point(206, 54);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(121, 33);
            this.labelClientes.TabIndex = 23;
            this.labelClientes.Text = "Clientes";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(58, 54);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(92, 33);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCanjear
            // 
            this.btnCanjear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnCanjear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanjear.FlatAppearance.BorderSize = 0;
            this.btnCanjear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanjear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanjear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCanjear.Image = ((System.Drawing.Image)(resources.GetObject("btnCanjear.Image")));
            this.btnCanjear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanjear.Location = new System.Drawing.Point(434, 360);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(350, 198);
            this.btnCanjear.TabIndex = 20;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = false;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAbonar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbonar.FlatAppearance.BorderSize = 0;
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbonar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbonar.Image")));
            this.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbonar.Location = new System.Drawing.Point(58, 360);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(350, 198);
            this.btnAbonar.TabIndex = 19;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click_1);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCuenta.Image")));
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.Location = new System.Drawing.Point(437, 131);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(350, 201);
            this.btnCuenta.TabIndex = 18;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnRegistrarClientes
            // 
            this.btnRegistrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnRegistrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarClientes.FlatAppearance.BorderSize = 0;
            this.btnRegistrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarClientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarClientes.Image")));
            this.btnRegistrarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarClientes.Location = new System.Drawing.Point(58, 131);
            this.btnRegistrarClientes.Name = "btnRegistrarClientes";
            this.btnRegistrarClientes.Size = new System.Drawing.Size(350, 201);
            this.btnRegistrarClientes.TabIndex = 17;
            this.btnRegistrarClientes.Text = "Registrar";
            this.btnRegistrarClientes.UseVisualStyleBackColor = false;
            this.btnRegistrarClientes.Click += new System.EventHandler(this.btnRegistrarClientes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(216, 360);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(416, 198);
            this.btnInventario.TabIndex = 22;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnRegistrarPremio
            // 
            this.btnRegistrarPremio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarPremio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPremio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPremio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPremio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPremio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrarPremio.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPremio.Image")));
            this.btnRegistrarPremio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPremio.Location = new System.Drawing.Point(216, 131);
            this.btnRegistrarPremio.Name = "btnRegistrarPremio";
            this.btnRegistrarPremio.Size = new System.Drawing.Size(416, 201);
            this.btnRegistrarPremio.TabIndex = 21;
            this.btnRegistrarPremio.Text = "Registrar";
            this.btnRegistrarPremio.UseVisualStyleBackColor = false;
            this.btnRegistrarPremio.Click += new System.EventHandler(this.btnRegistrarPremio_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.IndianRed;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(58, 360);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(350, 198);
            this.btnHistorial.TabIndex = 19;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.IndianRed;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(58, 131);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(350, 201);
            this.btnClientes.TabIndex = 17;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(434, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(350, 198);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPremios
            // 
            this.btnPremios.BackColor = System.Drawing.Color.IndianRed;
            this.btnPremios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPremios.FlatAppearance.BorderSize = 0;
            this.btnPremios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPremios.Image = ((System.Drawing.Image)(resources.GetObject("btnPremios.Image")));
            this.btnPremios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPremios.Location = new System.Drawing.Point(434, 131);
            this.btnPremios.Name = "btnPremios";
            this.btnPremios.Size = new System.Drawing.Size(350, 201);
            this.btnPremios.TabIndex = 18;
            this.btnPremios.Text = "Premios";
            this.btnPremios.UseVisualStyleBackColor = false;
            this.btnPremios.Click += new System.EventHandler(this.btnPremios_Click);
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.btnCancelar);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFormulario.Location = new System.Drawing.Point(831, 58);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(538, 716);
            this.panelFormulario.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(226, 626);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1369, 774);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPremios;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnRegistrarPremio;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Button btnRegistrarClientes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label labelPremios;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Button btnCancelar;
    }
}

