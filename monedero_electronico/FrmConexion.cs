using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monedero_electronico
{
    public partial class FrmConexion : Form
    {
        conexion[] db = new conexion[3] {new conexion("localhost", "Gasalinera 1"),
                new conexion("192.168.1.25", "Gasalinera 2"),
                new conexion("1.1.12.2", "Gasalinera 3") };

        int conex = 1;
        public FrmConexion()
        {
            InitializeComponent();
            insertConections();
            
        }
        

        private void FrmConexion_Load(object sender, EventArgs e)
        {

        }

        public void testConection()
        {
            try
            {
                lbEstado.Visible = true;
                lbEstado.Text = "Conectando con el servidor...";
                Console.WriteLine("Index" + cmbConexiones.SelectedIndex);
                if (db[cmbConexiones.SelectedIndex].abrirConexion())
                {
                    conex = 1;
                    lbEstado.Text = "Conexión existosa con el servidor";
                    lbEstado.BackColor = Color.Green;
                    db[cmbConexiones.SelectedIndex].cerrarConexion();
                }
                else
                {
                    conex = 0;
                    lbEstado.Text = "Error de Conexión";
                    lbEstado.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            if (cmbConexiones.InvokeRequired)
            {
                
                cmbConexiones.Invoke(new Action(() =>
                {
                    
                }));
                return;
            }
            */

        }

        private void CmbConexiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            testConection();
            
            //Console.WriteLine();
        }

        private void insertConections()
        {
            for (int x = 0; x < db.Length; x++)
            {
                cmbConexiones.Items.Add(db[x].getSucursal() + " : " + db[x].getServer());
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (conex == 1)
            {
                Program.conexionBD = db[cmbConexiones.SelectedIndex];
                //Program.sucursal = db[cmbConexiones.SelectedIndex].getServer();
                frmMenu menu = new frmMenu();
                menu.Show();
            }

        }
    }
}
