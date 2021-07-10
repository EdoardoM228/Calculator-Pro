using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            //FileStream stream = new FileStream(@"H:\Новая папка\Новый текстовый документ.xml", FileMode.Open);

            var xmlFileWriter = new XmlTextWriter(@"H:\Новая папка\Новый текстовый документ.xml", null);
            xmlFileWriter.Formatting = Formatting.Indented;
            xmlFileWriter.Indentation = 1;
            xmlFileWriter.IndentChar = ' ';
            xmlFileWriter.QuoteChar = '\"';  

            xmlFileWriter.WriteStartDocument();
            xmlFileWriter.WriteStartElement("ListOfBook");
            xmlFileWriter.WriteStartElement("Book");
            xmlFileWriter.WriteStartElement("Title");
            xmlFileWriter.WriteString(" Dubrovskii");
            xmlFileWriter.WriteComment("навзание книги");
            xmlFileWriter.WriteEndElement();
            xmlFileWriter.WriteStartElement("Author");
            xmlFileWriter.WriteString(" A.S.Puskin");
            xmlFileWriter.WriteComment("Автор книги");
            xmlFileWriter.WriteEndElement();
            xmlFileWriter.WriteStartElement("Year");
            xmlFileWriter.WriteString(" 1841");
            xmlFileWriter.WriteComment("Год первого выпуска");
            xmlFileWriter.WriteEndElement();
            xmlFileWriter.WriteStartElement("theMainCharacter");
            xmlFileWriter.WriteString(@"Троекуров Кирила Петрович
Дубровский - старший
Владимир Дубровский
Маша Троекурова
Князь Верейский
Антон Спицын");
            xmlFileWriter.WriteEndElement();
            xmlFileWriter.WriteEndElement();
            xmlFileWriter.WriteEndElement();

            xmlFileWriter.Close();

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(@"H:\Новая папка\Новый текстовый документ.xml");

            XmlNode root = xmlDocument.DocumentElement;

            Console.WriteLine($"Имя документа : {xmlDocument.LocalName}");

            foreach(XmlNode book in root.ChildNodes)
            {
                Console.WriteLine("Найденная книга : ");
                foreach(XmlNode species in book.ChildNodes)
                {
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                }
            }

            Console.ReadKey();
        }
    }
}
