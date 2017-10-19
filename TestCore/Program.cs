using RodenCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {

            //OGgD1+Zp4i/VTcNnQoMWye3F+PRl/d+9szL3pBem4oaMaXjLCGMo3OoMUsLuuLMzftrVmbOjl1aWEA0Rw0lO2wdGIDVjUTHWmkA0cdmxWaENnM3uoD80KvnZQYYzL/Ot14yRd7M8hTcqVhnJAWaH3czyrjzp2GfpBMdoE8VI8WQ=
            //p4R+4AghoTd0g2b/xqUHTYtII7upllkfnxww6eGl/mINKGNPNVSesPI/uITIMHyhZZGAs6tzh4pI0h6sdUMcGHzV5KgPrGqde2/lhJGcfAo3ldK6Et/nd8i6mCxDLBiDcytSYpOt78evJrJ31hNGkmKfTuExxj8109WgRnfwne0=
            string encStr = Encryption.RSAEncrypt(Encryption._pubKey, "Roden");
            Console.WriteLine(encStr);
           string encRes = Encryption.RSADecrypt(Encryption._privKey, encStr);
            Console.WriteLine(encRes);
            Console.ReadKey();
        }
    }
}
