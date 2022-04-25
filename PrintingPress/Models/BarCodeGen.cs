using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using  System.IO;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using Zen.Barcode;

namespace WindowsFormsApplication1
    {
        class BarCodeGen
        { 
            public void Barcode(PictureBox picture)
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picture.Image = barcode.Draw(codeGen(), 40);
            }

            public void QRcode(PictureBox picture)
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picture.Image = qrcode.Draw(codeGen(), 2);
            }
        /// <summary>
        /// Generate Barcoce
        /// </summary>
        /// <returns>Barcode file path</returns>
            public static string Barcode()
            {
                MemoryStream ms = new MemoryStream();
            PictureBox picture=new PictureBox();
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
               picture.Image = barcode.Draw(codeGen(), 40); 
               picture.Image.Save("barcode.png", picture.Image.RawFormat);
            FileInfo info = new FileInfo("barcode.png");
            return info.Name;
        }
        /// <summary>
        /// Generate QRCode (barcode)
        /// </summary>
        /// <returns>Barcode file Path</returns>
            public static string QRcode(string barCodeInfor)
            {
                
                MemoryStream ms = new MemoryStream();
                PictureBox picture = new PictureBox();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picture.Image = qrcode.Draw(barCodeInfor, 2); 
           picture.Image.Save("barqcode.png", picture.Image.RawFormat); 
           FileInfo info = new FileInfo("barqcode.png");
                return  info.FullName;
        }
         private static string codeGen()
            {
                //Encrypted text
                return "R4xD9MvZffJqvjOzWWbhMA==";
                 
            }
         
        }
    }
