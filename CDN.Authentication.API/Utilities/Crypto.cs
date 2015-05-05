using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace CDN.Authentication.API.Utilities
{
    public class Crypto
    {

        /*Generate Cryptographically Random Keys
        To generate cryptographically random keys:
        Use the RNGCryptoServiceProvider class to generate a cryptographically strong random number.
        Choose an appropriate key size. The recommended key lengths are as follows:
        For SHA1, set the validationKey to 64 bytes (128 hexadecimal characters).
        For AES, set the decryptionKey to 32 bytes (64 hexadecimal characters).
        For 3DES, set the decryptionKey to 24 bytes (48 hexadecimal characters).*/

        /*public class KeyCreatorq
        {
            // .exe 24 64
            public static void Main(String[] args)
            {
                String[] commandLineArgs = System.Environment.GetCommandLineArgs();
                string decryptionKey = CreateKey(System.Convert.ToInt32(commandLineArgs[1]));
                string validationKey = CreateKey(System.Convert.ToInt32(commandLineArgs[2]));

                Console.WriteLine("<machineKey validationKey=\"{0}\" decryptionKey=\"{1}\" validation=\"SHA1\"/>", validationKey, decryptionKey);
            }

            // .exe 128
            public static void Main(string[] argv)
            {
                int len = 128;
                if (argv.Length > 0)
                    len = int.Parse(argv[0]);
                byte[] buff = new byte[len / 2];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetBytes(buff);
                StringBuilder sb = new StringBuilder(len);
                for (int i = 0; i < buff.Length; i++)
                    sb.Append(string.Format("{0:X2}", buff[i]));
                Console.WriteLine(sb);
            }
        }*/

        // KeyCreator(32, 64);
        public string KeyCreator(int numberDecryption, int numberValidation)
        {
            var decryptionKey = CreateKey(numberDecryption);
            var validationKey = CreateKey(numberValidation);

            return string.Format("<machineKey validationKey=\"{0}\" decryptionKey=\"{1}\" validation=\"SHA1\" decryption=\"AES\"/> ", validationKey, decryptionKey);
        }

        static String CreateKey(int numBytes)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[numBytes];

            rng.GetBytes(buff);
            return BytesToHexString(buff);
        }

        static String BytesToHexString(byte[] bytes)
        {
            StringBuilder hexString = new StringBuilder(64);

            for (int counter = 0; counter < bytes.Length; counter++)
            {
                hexString.Append(String.Format("{0:X2}", counter));
            }
            return hexString.ToString();
        }
    }
}