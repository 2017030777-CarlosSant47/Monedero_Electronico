using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace monedero_electronico
{
    class Imagen
    {
        private int id;
        private string nameFile;//NOMBRE DEL ARCHIVO
        private string path;///RUTA COMPLETA DE LA IMAGEN
        private byte[] imageData;

        public Imagen()
        {

        }

        public Imagen(string nameFile, string path)
        {
            this.nameFile = nameFile;
            this.path = path;
        }

        public int Id { get => id; set => id = value; }
        public string NameFile { get => nameFile; set => nameFile = value; }
        public string Path { get => path; set => path = value; }
        public byte[] ImageData { get => imageData; set => imageData = value; }

        public void generateImageBinary()///ESTE METODO SIRVE PARA OBTENER EL BINARIO DE LA IMAGEN
        {
            
            FileStream fs = new FileStream(this.path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            this.imageData = br.ReadBytes((int)fs.Length);
            //NO REGRESA NADA POR LO QUE TIENE QUE SER EJECUTADO YA QUE NO TENDRA NINGUN VALOR
        }

        public byte[] getImageDataBinary()
        {
            byte[] data;
            FileStream fs = new FileStream(this.path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            return data = br.ReadBytes((int)fs.Length);
        }

        public Bitmap generateImage()
        {
            MemoryStream memory = new MemoryStream();
            memory.Write(this.imageData, 0, Convert.ToInt32(this.imageData.Length));
            Bitmap bitmap = new Bitmap(memory, false);
            memory.Dispose();
            return bitmap;
        }
    }
}
