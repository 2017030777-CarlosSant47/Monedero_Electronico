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
    public partial class frmMenu : Form
    {
        
        
        public frmMenu()
        {
            InitializeComponent();
            AbrirFormulario<frmReloj>();
         //   AbrirMenu<menu>();
            menu();
          //  Program.conexionBD = new conexion();
           // Program.conexionBD.abrirConexion();
            


        }

        private void menu()
        { 
            // deshabilitar menu clientes
            btnAbonar.Visible = false;
            btnCanjear.Visible = false;
            btnCuenta.Visible = false;
            btnRegistrarClientes.Visible = false;

            //deshabilitar menu premios
            btnRegistrarPremio.Visible = false;
            btnInventario.Visible = false;

            //habilitar menu principal
            btnClientes.Visible = true;
            btnPremios.Visible = true;
            btnHistorial.Visible = true;
            btnSalir.Visible = true;

            //boton atras
            btnRegresar.Visible = false;

            labelClientes.Visible = false;
            labelPremios.Visible = false;
        }



        private void menuClientes()
        {
            //deshabilitar menu premios
            btnRegistrarPremio.Visible = false;
            btnInventario.Visible = false;

            //deshabilitar menu principal
            btnClientes.Visible = false;
            btnPremios.Visible = false;
            btnHistorial.Visible = false;
            btnSalir.Visible = false;

            //habilitar menu clientes
            btnRegistrarClientes.Visible = true;
            btnCuenta.Visible = true;
            btnAbonar.Visible = true;
            btnCanjear.Visible = true;

            //habilitar boton de regreso
            btnRegresar.Visible = true;

            labelClientes.Visible = true;
        }



        private void menuPremios()
        {
            //deshabilitar menu principal
            btnClientes.Visible = false;
            btnPremios.Visible = false;
            btnHistorial.Visible = false;
            btnSalir.Visible = false;

            //deshabilitar menu clientes
            btnAbonar.Visible = false;
            btnCanjear.Visible = false;
            btnCuenta.Visible = false;
            btnRegistrarClientes.Visible = false;

            //habilitar premios
            btnRegistrarPremio.Visible = true;
            btnInventario.Visible = true;

            //botón regresar
            btnRegresar.Visible = true;

            labelPremios.Visible = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show("¿Seguro que quieres salir?", "", buttons, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AbrirMenu<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelMenu.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Left;
                panelMenu.Controls.Add(formulario);
                panelMenu.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        public Form AbrirFormulario<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
            return formulario;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            menuClientes();
            labelClientes.Visible = true;
            labelPremios.Visible = false;
        }

        private void btnRegistrarPremio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPremioRegistrar>();
        }

        private void btnPremios_Click(object sender, EventArgs e)
        {
            menuPremios();
            labelClientes.Visible = false;
            labelPremios.Visible = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPremiosInventario>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientesCuenta>();
        }

        private void btnAbonar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            // clientesCanjearModelo canje = new clientesCanjearModelo(conexion, AbrirFormulario<clientesCanjear>());
            AbrirFormulario<frmClientesCanjear>();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu();
            labelClientes.Visible = false;
            labelPremios.Visible = false;
        }
    }
}
