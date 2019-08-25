namespace monedero_electronico
{
    partial class FrmConexion
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
            this.lbEstado = new System.Windows.Forms.Label();
            this.cmbConexiones = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(32, 104);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(142, 18);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "Estado de Conexion";
            // 
            // cmbConexiones
            // 
            this.cmbConexiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConexiones.FormattingEnabled = true;
            this.cmbConexiones.Location = new System.Drawing.Point(32, 76);
            this.cmbConexiones.Name = "cmbConexiones";
            this.cmbConexiones.Size = new System.Drawing.Size(221, 26);
            this.cmbConexiones.TabIndex = 4;
            this.cmbConexiones.SelectedIndexChanged += new System.EventHandler(this.CmbConexiones_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(140, 149);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(113, 35);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectarse";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.cmbConexiones);
            this.Controls.Add(this.btnConectar);
            this.Name = "FrmConexion";
            this.Text = "FrmConexion";
            this.Load += new System.EventHandler(this.FrmConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cmbConexiones;
        private System.Windows.Forms.Button btnConectar;
    }
}