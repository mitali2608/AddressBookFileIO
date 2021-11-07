using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace AddressBookFileIO
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("File IO with Address Book :");
            FileExists();
            ReadAllLines();
            WriteUsingStreamWriter();

        }

        public static void FileExists()
        {
            String path = @"E:\dotnet\DataStructure\AddressBookFileIO\TextFile1.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");


        }

        public static void ReadAllLines()
        {
            String path = @"E:\dotnet\DataStructure\AddressBookFileIO\TextFile1.txt";
            String[] lines;

            lines = File.ReadAllLines(path);

            foreach (var text in lines)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine("Successfully read from Textfile1");

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"E:\dotnet\DataStructure\AddressBookFileIO\TextFile1.txt";

            Console.WriteLine("---------------------------------------");

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("First Name : Chris");
                sr.WriteLine("Last Name  : Musk");
                sr.WriteLine("Address    : LALAland");
                sr.WriteLine("City       : Wonderland");
                sr.WriteLine("State      : Canada");
                sr.WriteLine("Zip        : 7410");
                sr.WriteLine("Phone Number: 1 - 5464880781");
                sr.WriteLine("Email      :  pmcm.am@gmail.com");
                sr.WriteLine("---------------------------------------");




                sr.Close();
                Console.WriteLine("Sucessfully written into Textfile1");
                Console.WriteLine("Content of TextFile1 :");

                Console.WriteLine(File.ReadAllText(path));
            }



        }

    }

}