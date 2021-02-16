using System;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> bookName = new MyDictionary<string, string>();

            bookName.Add("Stefan Zweig", "Satranç");
            bookName.Add("Amin Maalouf", "Semerkant");
            bookName.Add("Dan Brown", "Dijital Kale");



            Console.WriteLine(bookName.Lenght);


            foreach (var writer in bookName.itemkey)
            {
                Console.WriteLine(writer);
            }

            foreach (var bookname in bookName.itemvalue)
            {
                Console.WriteLine(bookname);
            }
        }
    }
}
