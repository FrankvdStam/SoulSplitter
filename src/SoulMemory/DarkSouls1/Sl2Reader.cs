using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1
{
    //Imported from CapitaineToinon. Thanks!

    /*
    Encryption

    DS1:
       Files are not encrypted
    DSR:
       Each USERDATA file is individually AES-128-CBC encrypted. 
       Key:  01 23 45 67 89 AB CD EF FE DC BA 98 76 54 32 10 
       IV: First 16 bytes of each file
    */
    internal static class Sl2Reader
    {
        private static readonly byte[] AesKey = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };

        /// <summary>
        /// Read the IGT from an SL2 file
        /// </summary>
        /// <param name="path">path to the SL2 file</param>
        /// <param name="slot">the slot to read the IGT from</param>
        /// <param name="version">The game version</param>
        /// <returns>IGT or -1 if sometimes failed</returns>
        public static int? GetSaveFileIgt(string path, int slot, bool ptde)
        {
            int? igt = null;

            // Path may be null if this function is called before
            // the game was hooked
            if (path == null)
            {
                return igt;
            }

            try
            {
                if (IsReadable(path))
                {
                    if (ptde)
                    {
                        byte[] file = File.ReadAllBytes(path);
                        int saveSlotSize = 0x60020;

                        // Seems like GFWL files have a different slot size
                        if (file.Length != 4326432)
                            saveSlotSize = 0x60190;

                        int igtOffset = 0x2dc + (saveSlotSize * slot);
                        igt = BitConverter.ToInt32(file, igtOffset);
                    }
                    else
                    {
                        // Each USERDATA file is individually AES - 128 - CBC encrypted.
                        byte[] file = File.ReadAllBytes(path);
                        file = DecryptSl2(file);
                        int saveSlotSize = 0x60030;
                        int igtOffset = 0x2EC + (saveSlotSize * slot);
                        igt = BitConverter.ToInt32(file, igtOffset);
                    }
                }
            }
            catch
            {
                igt = null;
            }
            return igt;
        }

        /// <summary>
        /// Tests if the path to an SL2 file should be read or not
        /// </summary>
        private static bool IsReadable(string path)
        {
            try
            {
                return File.Exists(path) && !(new FileInfo(path).IsReadOnly);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Each USERDATA file is individually AES-128-CBC encrypted. 
        /// </summary>
        /// <param name="cipherBytes">encrypted bytes</param>
        /// <param name="key">key</param>
        /// <param name="iv">iv</param>
        /// <returns>decrypted bytes</returns>
        private static byte[] DecryptSl2(byte[] cipherBytes)
        {
            var encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;

            // Set key and IV
            var aesKey = new byte[16];
            Array.Copy(AesKey, 0, aesKey, 0, 16);
            encryptor.Key = aesKey;
            encryptor.IV = cipherBytes.Take(16).ToArray();

            var memoryStream = new MemoryStream();
            var aesDecryptor = encryptor.CreateDecryptor();
            var cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);
            byte[] plainBytes;

            try
            {
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
                cryptoStream.FlushFinalBlock();
                plainBytes = memoryStream.ToArray();
            }
            finally
            {
                memoryStream.Close();
                cryptoStream.Close();
            }

            return plainBytes;
        }
    }
}

