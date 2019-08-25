using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monedero_electronico
{
    class modeloClientesCanjear
    {
        conexion conexion;
        conexion conexion2;
        conexion conexion3;
        String sucursal;
        private int cuenta;
        private String premio;
        private int idPremio;
        private int idTipo;
        private string fecha;
        private int dispPremio;

        public modeloClientesCanjear()
        {

            this.conexion = Program.conexionBD;
            this.conexion2 = Program.conexionBD;
            this.conexion3 = Program.conexionBD;
            this.sucursal = Program.sucursal;
            // this.conexion = conexion;
          //  conexion.abrirConexion();
        }
         

        public Boolean devolverIdPremio()
        {
            try
            {
                MessageBox.Show("Si entra a devolver id premio");
                
                this.conexion2.cadenaQuery = "SELECT id FROM premios WHERE descripcion='"+this.getPremio()+"'";
                this.conexion2.abrirConexion();
                this.conexion2.sqlComando.CommandText = this.conexion2.cadenaQuery;
                this.conexion2.sqlComando.Connection = this.conexion2.getConexionBD();
                this.conexion2.reader = this.conexion2.sqlComando.ExecuteReader();
                while (this.conexion2.reader.Read())
                {
                    this.setIdPremio(this.conexion2.reader.GetInt32(0));
                    this.conexion2.cerrarConexion();
                    return true;
                }
                this.conexion2.cerrarConexion();
                return false;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }

        public Boolean capturarCanjeo()
        {
            try
            {

                if (this.devolverIdPremio())
                {
                    this.conexion3.cadenaQuery = "INSERT INTO canjeos(idPremio) VALUES (@premio)";
                    this.conexion3.sqlComando.Parameters.AddWithValue("@premio", this.getIdPremio());
                    this.conexion3.abrirConexion();
                    this.conexion3.sqlComando.CommandText = this.conexion3.cadenaQuery;
                    this.conexion3.sqlComando.Connection = this.conexion3.getConexionBD();
                    this.conexion3.sqlComando.ExecuteNonQuery();

                    this.conexion3.sqlComando.Parameters.RemoveAt("@premio");
                    this.conexion3.cerrarConexion();
                    return true;
                }
                else
                    return false;
            }
            catch(MySqlException e)
            {
                //MessageBox.Show(e.ToString());
                return false;
            }
        }

        public Boolean devolverUltimoCanjeo()
        {
            try
            {
                this.conexion2.abrirConexion();
                this.conexion2.cadenaQuery = "SELECT id FROM canjeos ORDER BY id DESC LIMIT 1";
                this.conexion2.sqlComando.CommandText = this.conexion2.cadenaQuery;
                this.conexion2.sqlComando.Connection = this.conexion2.getConexionBD();
                this.conexion2.reader = this.conexion2.sqlComando.ExecuteReader();
                while (this.conexion2.reader.Read())
                {
                    this.setIdTipo(this.conexion2.reader.GetInt32(0));
                    this.conexion2.cerrarConexion();
                    return true;
                }
                this.conexion2.cerrarConexion();
                return false;
            }
            catch(MySqlException e)
            {
              //  MessageBox.Show(e.ToString());
                return false;
            }
        }

        public Boolean agregarMovimiento()
        {
            try
            {
                
                if (this.capturarCanjeo() == true)
                {

                    if (this.devolverUltimoCanjeo())
                    {
                        this.conexion.cadenaQuery = "INSERT INTO movimientos(tipo,idTipo,idCuenta,fecha) VALUES" +
                        "(@tipo,@idTipo,@idCuenta,@fecha)";
                        this.conexion.sqlComando.Parameters.AddWithValue("@tipo", 2);
                        this.conexion.sqlComando.Parameters.AddWithValue("@idTipo", this.getIdTipo());
                        this.conexion.sqlComando.Parameters.AddWithValue("@idCuenta", this.getCuenta());
                        this.conexion.sqlComando.Parameters.AddWithValue("@fecha", this.getFecha());

                        this.conexion.abrirConexion();
                        this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
                        this.conexion.sqlComando.Connection = this.conexion.getConexionBD();
                        this.conexion.sqlComando.ExecuteNonQuery();

                        this.conexion.sqlComando.Parameters.RemoveAt("@tipo");
                        this.conexion.sqlComando.Parameters.RemoveAt("@idTipo");
                        this.conexion.sqlComando.Parameters.RemoveAt("@idCuenta");
                        this.conexion.sqlComando.Parameters.RemoveAt("@fecha");

                        this.conexion.cerrarConexion();
                        return true;
                    }
                    else
                        return false;
             
                    
                }
               
                return false;
            }
            catch(MySqlException e)
            {
                //MessageBox.Show(e.ToString());
                return false;
            }
        }


        public Boolean consultarDisponibilidad()
        {
            string whereQuery;
            if (this.sucursal.Equals("localhost"))
                whereQuery = "idsucursal= 1";
            else if (this.sucursal.Equals("10.10.10.10"))
                whereQuery = "idsucursal= 2";
            else
                whereQuery = "idsucursal= 3";
            try
            {
                this.devolverIdPremio();
                this.conexion.abrirConexion();
                this.conexion.cadenaQuery = "SELECT cantidad FROM premiosucursal WHERE " + whereQuery + " AND idpremio=" + this.getIdPremio();
                this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
                this.conexion.sqlComando.Connection = this.conexion.getConexionBD();
                this.conexion.reader = this.conexion.sqlComando.ExecuteReader();
                while (this.conexion.reader.Read())
                {
                    this.setDispPremio(this.conexion.reader.GetInt32(0));
                    this.conexion.cerrarConexion();
                    return true;
                }
                this.conexion.cerrarConexion();
                return false;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }

        public Boolean canjeo()
        {
            try
            {

                String whereQuery;
                
                if (this.sucursal.Equals("localhost"))
                    whereQuery = "idsucursal= 1";
                else if (this.sucursal.Equals("10.10.10.10"))
                    whereQuery = "idsucursal= 2";
                else
                    whereQuery = "idsucursal= 3";
                if (agregarMovimiento())
                {
                    this.conexion.abrirConexion();
                    this.conexion.cadenaQuery = "UPDATE premioSucursal SET cantidad=IF(cantidad > 0, cantidad - 1, cantidad) WHERE " + whereQuery + " AND idpremio=" + this.getIdPremio();
                    this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
                    this.conexion.sqlComando.Connection = this.conexion.getConexionBD();
                    this.conexion.sqlComando.ExecuteNonQuery();
                    this.conexion.cerrarConexion();

                    return true;
                }
                return false;
            }catch(MySqlException e)
            {
               // MessageBox.Show(e.ToString());
                return false;
            }
        }

        //getters & setters

        public void setCuenta(int cuenta){this.cuenta = cuenta;}
        public void setPremio(String premio){this.premio = premio;}
        public int getCuenta(){return this.cuenta;}
        public String getPremio(){ return this.premio;}
        public void setIdTipo(int idTipo) { this.idTipo = idTipo; }
        public int getIdTipo() { return this.idTipo; }
        public string getFecha() { return this.fecha; }
        public void setFecha(string fecha) { this.fecha = fecha; }
        public void setIdPremio(int idPremio) { this.idPremio = idPremio; }
        public int getIdPremio() { return this.idPremio; }
        public void setDispPremio(int dispPremio) { this.dispPremio =dispPremio; }
        public int getDispPremio() { return this.dispPremio; }

    }
}
