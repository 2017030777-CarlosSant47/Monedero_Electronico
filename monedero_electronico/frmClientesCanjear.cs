using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monedero_electronico
{
    public partial class frmClientesCanjear : Form
    {
        modeloClientesCanjear canjear;

       // conexion con = new conexion(); 


        public frmClientesCanjear()
        {
            InitializeComponent();
            this.txtFecha.CustomFormat = "yyyy-MM-dd";
            canjear = new modeloClientesCanjear();


        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            
            canjear.setPremio(this.txtPremio.Text);
            canjear.setCuenta(int.Parse(this.txtCuenta.Text));
            canjear.setFecha(this.txtFecha.Text.ToString());
            // if (canjear.agregarMovimiento() == true && canjear.canjeo()==true)
           
            canjear.consultarDisponibilidad();
            if (canjear.getDispPremio()>0)
            {
                if (canjear.canjeo())
                {

                    MessageBox.Show("Se ha canjeado con éxito");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
                MessageBox.Show("No se encuentra disponible");
        }
    }
}
