namespace monedero_electronico
{
    partial class frmReloj
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
            this.components = new System.ComponentModel.Container();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fecha.Location = new System.Drawing.Point(25, 359);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(112, 39);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "label2";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Century Gothic", 95.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hora.Location = new System.Drawing.Point(-8, 207);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(444, 152);
            this.hora.TabIndex = 2;
            this.hora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(538, 716);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reloj";
            this.Text = "reloj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
    }
}