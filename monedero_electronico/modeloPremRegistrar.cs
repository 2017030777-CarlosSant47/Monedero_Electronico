using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace monedero_electronico
{

    class modeloPremRegistrar
    {
        int idpre = 1;
        public modeloPremRegistrar()
        {
            this.conexion = Program.conexionBD;
        }
        conexion conexion;
        public long agregarPremio(string Descripcion, double Precio, Imagen img)
        {
            long result = 0;
            DBImagen dbimagen = new DBImagen();
            string sql = "INSERT INTO premios SET descripcion=@descripcion,costo=@precio, imagen = @img;";
            try
            {
                long idImagen = dbimagen.insertarImagen(img);///REGRESA EL ID INSERTADO DE LA IMAGEN
                if (idImagen > 0)//SI EL ID ES 0 O -1 NI SIQUIERA AGREGARA EL PREMIO JAJAJA :3
                {
                    this.conexion.cadenaQuery = sql;
                    this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
                    this.conexion.sqlComando.Connection = this.conexion.conexionBD;
                    this.conexion.sqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Descripcion;
                    this.conexion.sqlComando.Parameters.Add("@precio", MySqlDbType.Double).Value = Precio;
                    this.conexion.sqlComando.Parameters.Add("@img", MySqlDbType.Int32).Value = idImagen;
                    this.conexion.abrirConexion();
                    this.conexion.sqlComando.ExecuteNonQuery();
                    long idreturned = this.conexion.sqlComando.LastInsertedId;//CON ESTE TE REGRESA EL ID INSERTADO
                    //this.conexion.sqlComando.Parameters.RemoveAt("@descripcion");
                    //this.conexion.sqlComando.Parameters.RemoveAt("@precio");
                    this.conexion.sqlComando.Parameters.Clear();
                    this.conexion.cerrarConexion(); ;//cerr
                    result = idreturned;
                }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            return result;
                
        }
        public int DevolIdPremio(int conx)
        {
            int bb = 1;
            if (conx == 1)
            {
                this.conexion.abrirConexion();
            }
            this.conexion.cadenaQuery = "SELECT * FROM premios ORDER BY id DESC LIMIT 1";
            this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
            this.conexion.sqlComando.Connection = this.conexion.conexionBD;
            this.conexion.reader = this.conexion.sqlComando.ExecuteReader();
            while (this.conexion.reader.Read())
            {
                bb = this.conexion.reader.GetInt32(0);
            }
            if (conx == 1)
            {
                this.conexion.cerrarConexion();
            }

            return bb;
        }



        public void agregarPremioSucursal(int canti, float b)
        {
            //int b = DevolIdPremio(1);
            //NUNCA VOY A JALAR MUAJAJAJAJJAJA
            Console.WriteLine(b);


            this.conexion.abrirConexion();
            this.conexion.cadenaQuery = "INSERT INTO premiosucursal SET Idsucursal=@sucursal,IdPremio=@idPremio,Cantidad=@cantidad;";
            Console.WriteLine(b); Console.WriteLine(canti);
            this.conexion.sqlComando.Parameters.Add("@sucursal", MySqlDbType.Int32).Value = 1;
            this.conexion.sqlComando.Parameters.Add("@idPremio", MySqlDbType.Int32).Value = b;
            this.conexion.sqlComando.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = canti;
            this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
            this.conexion.sqlComando.Connection = this.conexion.conexionBD;
            this.conexion.sqlComando.ExecuteNonQuery();
            this.conexion.sqlComando.Parameters.RemoveAt("@sucursal");
            this.conexion.sqlComando.Parameters.RemoveAt("@idPremio");
            this.conexion.sqlComando.Parameters.RemoveAt("@cantidad");

            this.conexion.cerrarConexion();//cerr
        }

    }
}