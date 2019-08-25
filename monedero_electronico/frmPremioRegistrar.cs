using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace monedero_electronico
{
    public partial class frmPremioRegistrar : Form
    {
        modeloPremRegistrar PRM = new modeloPremRegistrar();
        public frmPremioRegistrar()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen();///NO CAMBIAR LOS NOMBRE DE LOS OBJETOS
            img.Path = txtFilePath.Text;
            img.NameFile = txtFileName.Text;
            Console.WriteLine(img.Path);
            img.generateImageBinary();//NO CAMBIAR EL NOBRE DE LOS METODOS DE IMAGEN TODOS TRABAJAN ESTRE SI
            long result = PRM.agregarPremio(txtDescripcion.Text, double.Parse(txtPrecio.Text), img);
            if(result == 0 || result <= -1)
            {
                MessageBox.Show("No se guardo la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se guardo con exito el premio", "GUardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PRM.agregarPremioSucursal(int.Parse(txtCanti.Text), result);
            }
            //int Idp = PRM.DevolIdPremio(1);
            ///MessageBox.Show("hola", "" + Idp, MessageBoxButtons.OK);
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtCanti_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                float fileSize = new FileInfo(open.FileName).Length / 1024;
                if(fileSize <= 350)//350KB
                {
                    txtFileName.Text = open.SafeFileName;
                    txtFilePath.Text = open.FileName;
                    pbImage.Image = Image.FromFile(open.FileName);
                }
                else
                {
                    MessageBox.Show("El archivo no puede pesar mas de 350 KB",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
