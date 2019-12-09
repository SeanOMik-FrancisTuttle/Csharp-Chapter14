using System;
using System.IO;

namespace TestFileAndDirectory {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter directory (Type \"end\" to stop) >> ");
            string text = Console.ReadLine();

            while (text != "end") {
                Console.WriteLine("Directory {0}", Directory.Exists(text) ? "Exists" : "Doesn't Exist" );

                Console.Write("Enter directory >> ");
                text = Console.ReadLine();
            }
        }
    }
}
