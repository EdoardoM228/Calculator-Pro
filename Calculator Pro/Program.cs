using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            FileStream stream = File.Open(@"H:\Новая папка\Account.txt", FileMode.OpenOrCreate);

            Console.Write("Введите логин : ");
            string login = Console.ReadLine();

            Console.Write("Введите пароль : ");
            string password = Console.ReadLine();

            var writer = new StreamWriter(stream);
            
            writer.WriteLine($"Account login : {login}");
            writer.WriteLine($"Account password : {password}");
            writer.Close();

            stream.Close();

            FileStream fileStream = File.OpenRead(@"H:\Новая папка\Account.txt");
            FileStream streamZip = File.Create(@"H:\Новая папка\test.zip");

            GZipStream compressor = new GZipStream(streamZip, CompressionMode.Compress);

            int theByte = fileStream.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
            }

            compressor.Close();

            FileStream zipDecompress = File.OpenRead(@"H:\Новая папка\test.zip");
            FileStream creatFile = File.Create(@"H:\Новая папка\test_zip.txt");

            GZipStream deCompressor = new GZipStream(zipDecompress, CompressionMode.Decompress);

            int theByteDeCompress = creatFile.ReadByte();
            while (theByteDeCompress != -1)
            {
                creatFile.WriteByte((byte)theByte);
                theByteDeCompress = deCompressor.ReadByte();
            }

            deCompressor.Close();


            Console.ReadKey();
        }
    }
}
