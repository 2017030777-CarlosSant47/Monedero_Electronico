using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace monedero_electronico
{
    class modeloClientesCuenta
    {
        public modeloClientesCuenta()
        {
            this.conexion = Program.conexionBD;
        }
        conexion conexion;


        public DataTable consulta(string premio)
        {
            //int id=int.Parse(premio);
            DataTable datos = new DataTable();
            this.conexion.cadenaQuery = "SELECT cuenta.`id`,cuenta.`puntos`,clientes.`nombre` " +
                "FROM cuenta INNER JOIN clientes ON cuenta.`idCliente`= clientes.`id` " +
                "WHERE cuenta.id='" + premio + "%'";
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
            this.conexion.cadenaQuery = "SELECT cuenta.`id`,cuenta.`puntos`,clientes.`nombre` " +
                "FROM cuenta INNER JOIN clientes ON cuenta.`idCliente`= clientes.`id` Order By clientes.`nombre` asc;";
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

