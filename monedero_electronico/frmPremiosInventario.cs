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
    public partial class frmPremiosInventario : Form
    {
        public frmPremiosInventario()
        {
            InitializeComponent();
            actualizatabla();
        }
        modelPremiosInventario midb = new modelPremiosInventario();

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String nombrep;
            nombrep = txtBuscar.Text;
            if (txtBuscar.Text != "")
            {

                TBPremios.DataSource = null;
                DataTable datos = midb.consulta(nombrep);
                TBPremios.DataSource = datos;
            }
            else
            {
                txtBuscar.Text = ""; actualizatabla();
            }
        }

        private void actualizatabla()
        {

            TBPremios.DataSource = null;
            DataTable datos = midb.ConsultarTodos();
            TBPremios.DataSource = datos;
        }

        private void FrmPremiosInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
