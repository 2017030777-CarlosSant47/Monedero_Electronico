
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monedero_electronico
{
    static class Program
    {
        public static conexion conexionBD;
        public static string sucursal;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConexion());
         //   conexionBD = new conexion();

            
        }
        
    }
}
