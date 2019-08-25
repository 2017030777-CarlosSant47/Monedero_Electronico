using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace monedero_electronico
{
    public class conexion
    {
        private string server;
        private string database;
        private string puerto;
        private string usuario;
        private string pass;
        public String cadenaConexion;
        public String sucursal;
        public MySqlConnection conexionBD;
        public MySqlCommand sqlComando;
        public String cadenaQuery;
        public MySqlDataAdapter adaptador;
        public MySqlDataReader reader;


        public conexion(string server, string sucursal)
        {
            this.server = server;
            this.sucursal = sucursal;
            this.database = "gasolinera";
            this.puerto = "3306";
            this.usuario = "root";
            this.pass = "linux";
            conexionBD = new MySqlConnection();

            cadenaConexion = "Server=" + server + "; Userid=root; Password=" + pass + "; DataBase=gasolinera";
            //cadenaConexion = "Server=" + server + ";port=" + puerto + ";username=" +
            //     usuario + ";Password=" + pass + ";database=" + database + ";";
            Console.WriteLine(cadenaConexion);
            conexionBD.ConnectionString = cadenaConexion;
            sqlComando = new MySqlCommand();
            adaptador = new MySqlDataAdapter();

        }

        public bool abrirConexion()
        {
            Boolean exito = false;
            if (conexionBD.State == ConnectionState.Closed)
            {
                conexionBD.Open();
                exito = true;
            }
            return exito;
            /*try
            {
                this.conexionBD.Open();
                Console.WriteLine("SE CONECTÓ");
                return true;

            } catch (MySqlException e){
                return false;
            }*/
        }

        public bool cerrarConexion()
        {
            
            try{
                this.conexionBD.Close();
                return true;
            } catch (MySqlException e){
                return false;
            }
        }

      
        


        //Getters
        public string getServer() { return this.server; }
        public string getUsuario() { return this.usuario; }
        public string getPass() { return this.pass; }
        public MySqlConnection getConexionBD() { return this.conexionBD; }
        public string getSucursal() { return this.sucursal; }

        //Setters
        public void setServer(string server) { this.server = server; }
        public void setUsuario(string usuario) { this.usuario = usuario; }
        public void setPass(string pass) { this.pass = pass; }
        public void setConexionBD(MySqlConnection conexionBD) { this.conexionBD = conexionBD; }
        public void setSucursal(String sucursal) { this.sucursal = sucursal; }


    }
}

