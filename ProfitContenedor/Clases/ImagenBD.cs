using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Presentacion
{
    public static class ImagenBD
    {
        public static byte[] ImagenToByte(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];

            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public static Image BytesToImage(byte[] bytes)
        {
            if (bytes == null) return null;
            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;

            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }
    }
}
