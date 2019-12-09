using System;
using System.IO;

namespace ReadCustomerRecords {
    class Program {
        static void Main(string[] args) {
            if (File.Exists(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt")) {
                StreamReader reader = new StreamReader(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt");
                string line = reader.ReadLine();
                while (line != null) {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            } else {
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}
