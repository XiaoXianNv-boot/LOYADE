using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using ThoughtWorks;
using ThoughtWorks.QRCode.Codec;

namespace LOYADE
{
    public class ActionQR
    {
        public static void GenerateQRFile(string str, string file)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方法
            encoder.QRCodeScale = 8;//大小
            encoder.QRCodeVersion = 8;//版本 
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            System.Drawing.Bitmap bp = encoder.Encode(str, Encoding.GetEncoding("GB2312"));
            bp.Save(file);
            bp = null;
            encoder = null;
        }

        public static void GenerateQRFile(string str, string file, string colorname)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方法
            encoder.QRCodeScale = 8;//大小
            encoder.QRCodeVersion = 8;//版本
            encoder.QRCodeForegroundColor = Color.FromName(colorname);
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M; 
            System.Drawing.Bitmap bp = encoder.Encode(str, Encoding.GetEncoding("GB2312")); 
            bp.Save(file);
            bp = null;
            encoder = null;
        }
    }
}
