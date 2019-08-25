using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;


/*
 _____________________
< El pepi es joto uwu >
 ---------------------
 \     ____________
  \    |__________|
      /           /\
     /           /  \
    /___________/___/|
    |          |     |
    |  ==\ /== |     |
    |   O O  | \ \ |
    |     <    |  \ \|
   /|          |   \ \
  / |  \_____/ |   / /
 / /|          |  / /|
/||\|          | /||\/
    -------------|
        | |    | |
       <__/    \__>
       */
namespace monedero_electronico
{
    class DBImagen
    {
        MySqlCommand command;
        conexion db;
        public DBImagen()
        {
            this.db = Program.conexionBD;
            command = new MySqlCommand();
        }


        public int registrarPremio(Imagen img)
        {
            int result = 0;
            string sqlRegistrarPremio = "Insert into premios set descripcion = 'Premio1', costo = 35, imagen = ?imgid";
            try
            {
                MySqlCommand com = new MySqlCommand(sqlRegistrarPremio,
                    this.db.getConexionBD());
                long idImagen = this.insertarImagen(img);
                if (idImagen > 0)
                {
                    com.Parameters.Add("?imgid", MySqlDbType.Int64).Value =
                    db.abrirConexion();
                    result = com.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            db.cerrarConexion();
            return result;


        }
        public long insertarImagen(Imagen img)
        {
            long result = 0;
            string sql = "insert into imagen set filename = ?filen, file = ?img;";
            try
            {
                command.Parameters.Clear();
                command.CommandText = sql;
                command.Connection = db.getConexionBD();
                command.Parameters.Add("?filen", MySqlDbType.VarChar).Value = img.NameFile;
                command.Parameters.Add("?img", MySqlDbType.Blob).Value = img.getImageDataBinary();
                db.abrirConexion();
                command.ExecuteNonQuery();
                result = command.LastInsertedId;

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            db.cerrarConexion();
            return result;
        }

        public Imagen consultarImagen()
        {
            Imagen img = new Imagen();
            string sql = "select id as IDImagen, imagenfile as imgbinary from imagen where id = 1 /n;";

            try
            {
                db.abrirConexion();
                command.CommandText = sql;
                command.Connection = db.getConexionBD();
                //Console.WriteLine(db.GetConnection().ConnectionString);

                MySqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    img.Id = data.GetInt32(0);
                    img.ImageData = (byte[])data["imgbinary"];
                    //Console.WriteLine(data.GetString(1));
                    break;
                }

                db.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
                img = null;
            }
            return img;
        }
    }
}
