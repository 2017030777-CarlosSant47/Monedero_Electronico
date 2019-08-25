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
    public partial class frmClientesCuenta : Form
    {
        modeloClientesCuenta cc = new modeloClientesCuenta();
        public frmClientesCuenta()
        {
            InitializeComponent();
            actualizatabla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Equals("")) { MessageBox.Show("Ingrese un valor primero"); actualizatabla(); }
            else
            {
               tablacuenta.DataSource = null;
                DataTable datos = cc.consulta(txtBuscar.Text);
                tablacuenta.DataSource = datos;
            }
        }

        private void FrmClientesCuenta_Load(object sender, EventArgs e)
        {
            
            
        }

        private void actualizatabla()
        {

            tablacuenta.DataSource = null;
            DataTable datos = cc.ConsultarTodos();
            tablacuenta.DataSource = datos;
        }
    }
}
