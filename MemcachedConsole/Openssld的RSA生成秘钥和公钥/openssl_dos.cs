using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedConsole.Openssld的RSA生成秘钥和公钥
{
    /// <summary>
    /// 直接运行exe的命令语句
    /// </summary>
    public class openssl_dos
    {
        /*
         * 1. 生成原始 RSA私钥文件 private_key.pem

            genrsa -out private_key.pem 1024
        2. 将原始 RSA私钥转换为 pkcs8格式 （有的语言不支持这个）

            pkcs8 -topk8 -inform PEM -in private_key.pem -outform PEM -nocrypt -out rsa_private_key.pem
        3. 生成 RSA公钥 rsa_public_key.pem

            rsa -in private_key.pem -pubout -out rsa_public_key.crt
        4. 从公钥 rsa_public_key.pem 获取十六进制的公钥（第一段16进制字符串）

            asn1parse -out temp.ans -i -inform PEM<private_key.pem
        最终获取文件列表:

        rsa_private_key.pem

        rsa_public_key.crt

        16进制公钥字符串用于js端加密
         * 
         * 
         * 
         * 
         */
    }
}
