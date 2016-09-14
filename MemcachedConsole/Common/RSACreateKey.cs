using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedConsole.Common
{
    public class RSACreateKey
    {
        public void CreateRsaKeys() {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter writer = new StreamWriter("PrivateKey.xml"))  //这个文件要保密...
            {

                writer.WriteLine(rsa.ToXmlString(true));

            }
            using (StreamWriter writer = new StreamWriter("PublicKey.xml"))
            {

                writer.WriteLine(rsa.ToXmlString(false));
            }
        }
    }
}
