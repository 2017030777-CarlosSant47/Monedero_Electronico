using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace monedero_electronico
{
    public class modelPremiosInventario
    {
        public modelPremiosInventario()
        {
            this.conexion = Program.conexionBD;
        }
        conexion conexion;

        public DataTable consulta(string premio)
        {
            DataTable datos = new DataTable();
            this.conexion.cadenaQuery = "SELECT premios.`descripcion`,premios.`costo`,premiosucursal.`idsucursal`,premiosucursal.`cantidad` " +
                "FROM premios INNER JOIN premiosucursal ON premios.`id`= premiosucursal.`idpremio`" +
                "WHERE premios.descripcion LIKE '" + premio + "%'";
            this.conexion.abrirConexion();//abrir conexion
            this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
            this.conexion.sqlComando.Connection = this.conexion.conexionBD;

            this.conexion.adaptador.SelectCommand = this.conexion.sqlComando;
            this.conexion.adaptador.Fill(datos);
            this.conexion.cerrarConexion();//cerrar conexion
            return datos;
        }
        public DataTable ConsultarTodos()
        {
            DataTable Datos = new DataTable();
            this.conexion.cadenaQuery = "SELECT premios.`descripcion`,premios.`costo`,premiosucursal.`idsucursal`,premiosucursal.`cantidad` " +
                "FROM premios INNER JOIN premiosucursal ON premios.`id`= premiosucursal.`idpremio` Order By premios.`descripcion` asc;";
            this.conexion.abrirConexion();
            this.conexion.sqlComando.CommandText = this.conexion.cadenaQuery;
            this.conexion.sqlComando.Connection = this.conexion.conexionBD;
            this.conexion.adaptador.SelectCommand = this.conexion.sqlComando;
            this.conexion.adaptador.Fill(Datos);
            this.conexion.cerrarConexion();
            return Datos;
        }

    }
}
