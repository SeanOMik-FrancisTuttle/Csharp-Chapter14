using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FindcustomerRecords2 {
    class Program {
        static void Main(string[] args) {
            if (File.Exists(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt")) {
                StreamReader reader = new StreamReader(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt");

                Console.Write("Enter balance due: ");
                string id = Console.ReadLine();

                string line = reader.ReadLine();
                while (line != null) {
                    if (Regex.IsMatch(line, id)) {
                        Console.WriteLine("Found customer: {0}", line);
                        break;
                    }
                    line = reader.ReadLine();
                }
            }
            else {
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}
