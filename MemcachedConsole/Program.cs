using MemcachedConsole.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Madison;
using System.Security.Cryptography;

namespace MemcachedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.TestDBNull
            // TestDBNull();
            //2.
            //TestUU();
            //var keys=GenerateKeys();

            //RSACreateKey rsaCreate = new RSACreateKey();
            //rsaCreate.CreateRsaKeys();
            //string privateKeyContent = OpensslRSAPrivatekey();
            //string publicKeyContent = OpensslRSAPublickey();
            ////publicKeyContent = publicKeyContent.Replace("-----BEGIN PUBLIC KEY-----", "");
            ////privateKeyContent = privateKeyContent.Replace("-----BEGIN PUBLIC KEY-----", "");

            //string decrypterCode = string.Format("vone{0}{1}", new DateTime(2016, 4, 19, 17, 37, 46).ToString("yyyyMMddHHmmss"), 13612345678);
            //string encryptCode = Madison.Core.SecurityFormat.RSA.RSA_PEM_EncryptByPublicKey(publicKeyContent, decrypterCode);

            //string decrypterCodes = Madison.Core.SecurityFormat.RSA.RSA_PEM_DecrypterByPrivateKey(privateKeyContent, encryptCode);
            //new MemcachedConsole.Email.Email().SendEmail();

            new Memcached.Memcached().MemcachedHelp();
        }

        public static void TestDBNull() {
            object val = DBNull.Value;
            int ff = 0;
            object result = Convert.IsDBNull(val);
            if (result.Equals(true))
            {
                Console.WriteLine("     OK   " + ff);
            }
            object tt = "" + DBNull.Value;//DBNull是一个特别的类型
            Console.WriteLine("KKKKKKKOOOOO");
        }

        public static void TestUU()
        {
            string saleTypes = "15";
            var saleType = saleTypes.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (saleTypes.Contains("5"))
            {
                Console.WriteLine("进来了");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("没有进来");
                Console.ReadKey();
            }
        }

        public static string[] GenerateKeys() {
            string[] sKeys = new String[2];
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            sKeys[0] = rsa.ToXmlString(true);
            sKeys[1] = rsa.ToXmlString(false);
            return sKeys;
        }


        public static string OpensslRSAPrivatekey()
        {
            string key = @"-----BEGIN RSA PRIVATE KEY-----
MIIEowIBAAKCAQEAo7DpaCzL9B+THezgcBu9ZMbGitUwqVw2cHF2ghCrPfZNdNMw
NY1D6y5pRPnXawkVEsopL/fwuwfiTo60YJVUsSSLmzLaahtvmEDqPJBJvvvJTBq6
oz6UricjQtik2vTuXLL+4wrxki0ov5gQ36/Iw+s46tuCl1odoRXFiL9Phmv6XTQR
IwLDz4jW2VBtk0Ck7O7W8Q88LfEe2ycw+Z4QSbC+vTEhuBoBr+xhs66veBOmzXUD
cRtKpMORBrk1h2v9aOsb3rzdjLjkJRkp37a/I4gi/JqlY4P84vt7jKxc1IK+OuS9
MFEPqiDgFzlMGBKsD35fXg9vb+fm7nKESW1nEwIDAQABAoIBACAhWa9ZG6+PgxEc
rfFTgJmHavFVZ3fW4diwbNKa8wH2lr2Xtp7MW8iOE5u2btJTtg86H1uLD3Wm1oUU
/dL3fOhIhB6ynKy3NfBszY2VxOP4CEsn8/qXDhghForIe5N/AEqx19Y5D7Hhq13w
O1+s4XuTcFipPbj3t1knLN7qrnFz8BAoz6c76J6Uc85y9MNvbTe9+8NwysA1c2qF
UMw3dBdHIu2xzxCqD65u1MwjOF5tyLJLgffdb7Gud+2bA6q1iyUgu0EiXk0VSoz9
PesXPr3mpUDpN2XdZkyPcDzpUjo+itatgocuVJw0eq7FSQ9iAIufUHcE8wjVoJir
yfbRBAECgYEA0JokopB8bhTenZbgY5lsxHgHIqvxZOC0LD2BAuOyOUoYHb/x4z5d
yvssN7TUZS8g9uV/5hCusWVoom10px70kLwkmCa1NrW0gB9a6BwK+9WRdCOmePFU
Kn6FMtSoAGOEMJ3hFVwIPQunFZH8hstkucqmDlFlSxMocPU6/AacJJsCgYEAyOJn
8/wBj8oBvQXOOUqesI2EnArqnQNdCOeqGBXBzcoy2oZi+GBmPJY2jCpQpfQhCGwD
W7euCkzD0L8Zi781ZcamB4CsmSjGyTsUpZQgGsOq1tEGKFM0rJ9A2vDSY2AaeNAc
oGmZyDhngTjR8r0s/hjoUJrinltNSHmbdb3SoukCgYBQrBwY5mnIpLeHGG9E9XOz
83tG9FoRmjjzlwGKnYYyU65J6w5fxKG/Oy3ZiUxOqVBFS3IQBkmY/0/c6Rmg+/62
7pv0X5vbQaBBoF6mvxmcVPbAhHz/7syO9okKpGUoaVQY/SWr/gCNozEFzYRsmMIm
e/GGPgI/a3RLYvthtiiymwKBgQCrIvacjNxnuxiwB/ogJMn8bxPCPCqTiQIBTBtE
WYS55MBeGo7GOpnek7n0vzflqY1at2pFAL5sV+maNLN2snazNgDL83sXH/36ATMd
vIt9QaSRTZGJWRlO1n1SCEe0EXN76Q/6OPyh7it/kwCJY1CpSF7iDJFzhyTX0YH3
VLfVwQKBgEpQ2ZrTDcEx/ppAws36RSMxp9TS5WCyk0YQIF/GMlGqWIi6bh7Nxa/Z
b2pl+MctKFLBkvYPNda8WML5RQbARrw+tI3yugm1aoQ7kQm7231GL4giIc6pdMUu
gNcdg9u2yL9CGvRNmdHx5fso/ie2MPuRzLhCxWALopNEHzNJB/jV
-----END RSA PRIVATE KEY-----";
            return key;
        }

        public static string OpensslRSAPublickey()
        {
            string key = @"-----BEGIN PUBLIC KEY-----
MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAo7DpaCzL9B+THezgcBu9
ZMbGitUwqVw2cHF2ghCrPfZNdNMwNY1D6y5pRPnXawkVEsopL/fwuwfiTo60YJVU
sSSLmzLaahtvmEDqPJBJvvvJTBq6oz6UricjQtik2vTuXLL+4wrxki0ov5gQ36/I
w+s46tuCl1odoRXFiL9Phmv6XTQRIwLDz4jW2VBtk0Ck7O7W8Q88LfEe2ycw+Z4Q
SbC+vTEhuBoBr+xhs66veBOmzXUDcRtKpMORBrk1h2v9aOsb3rzdjLjkJRkp37a/
I4gi/JqlY4P84vt7jKxc1IK+OuS9MFEPqiDgFzlMGBKsD35fXg9vb+fm7nKESW1n
EwIDAQAB
-----END PUBLIC KEY-----
";
            return key;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string RSAPrivateKeyDotNet2Java()
        {
            string rsaKey = @"<RSAKeyValue><Modulus>vVgLGgbYjU8rnroay9vO/GsKbaJpPmLkb7sYlKSdrpZ1KnjsRD0Va02C25jhh5YXKPuDPGMl/N7CmTGgmv3CQJhBNdQ+e9bw4jVC/18QPRBE3AUzF2DC+kGhVSsl3SjbF1n7xhzXmw1oX6txX8hOBNbC6XA67Aawjz0k+A2/3j0=</Modulus><Exponent>AQAB</Exponent><P>xhRFjGC37wrK7tvqKpoD9xbFTyajFgTOFAdF2pISjOI4uP63HJHUs8Pwv/YpFmhGgOBg6Pm34DBfCh7gsZy66w==</P><Q>9LXe6osF37C0H9BtZqeG9Ovy3S3RLVU25Ssqv8wcxm5gXhSkBo5urYtJxj7/RiVmbGc26wi+BAO/mDj1dtoxdw==</Q><DP>gjbTXaw7Xoa+z3V8pBLppmauwRDKR3BTNTFux3gdf8Y7ucmhAMQRize1LcyaSCO2rYRT0PRQ362M3O9dkQVSjw==</DP><DQ>Kzs+KH1rCjuzdrNhwHL0Oqy8eSqw+6tESXQ41y1+H+g8CiLnX2kmUG59GBLlEkVlNN1/LEKdHyRyYrgdVWPyvQ==</DQ><InverseQ>vV5TdI/DU8RBOmM6fPNjyNfBN3sa3J0w51PiDmCjyE9tn3WL9b0SEZNo91uyR5pbOLat6u8RRFUxqKSjC+NNZQ==</InverseQ><D>GfC9/0rWJZtQdpE4qpqVY6+mi26ndzdFOf7VV0gA8l0FSv8AyjiJfrHtLk4RApUQMeUuDaU9HG/IaVngjwYaXqfTcDrrjcLCIwYJDeRRtRuSlCavby7QT7UkvDEO/5nfPNJzKnTGfD8aaCRkeOiiPr5reWWAYW7ywtqdJU+sYWE=</D></RSAKeyValue>";
            return RSAKeyConvert.RSAPrivateKeyDotNet2Java(rsaKey);
        }

        public static string RSAPublicKeyDotNet2Java()
        {
            string rsaKey = @"<RSAKeyValue><Modulus>vVgLGgbYjU8rnroay9vO/GsKbaJpPmLkb7sYlKSdrpZ1KnjsRD0Va02C25jhh5YXKPuDPGMl/N7CmTGgmv3CQJhBNdQ+e9bw4jVC/18QPRBE3AUzF2DC+kGhVSsl3SjbF1n7xhzXmw1oX6txX8hOBNbC6XA67Aawjz0k+A2/3j0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            return RSAKeyConvert.RSAPublicKeyDotNet2Java(rsaKey);
        }
    }
}
