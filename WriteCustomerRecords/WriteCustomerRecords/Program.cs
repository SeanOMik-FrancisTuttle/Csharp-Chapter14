using System;
using System.IO;

namespace WriteCustomerRecords {
    class Customer {
        public Customer(int id, string name, double balance_owed) {
            this.id = id;
            this.name = name;
            this.balance_owed = balance_owed;
        }

        public int id { get; set; }
        public string name { get; set; }
        public double balance_owed { get; set; }
        public override string ToString() {
            return string.Format("(ID: {0}) {1} - Balance Owed: {2}", id, name, balance_owed);
        }
    }
    class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Enter customer name: ");
                string customer_name = Console.ReadLine();

                Console.Write("Enter customer id: ");
                int customer_id = int.Parse(Console.ReadLine());

                Console.Write("Balance owed: ");
                double customer_owed = double.Parse(Console.ReadLine());

                Customer customer = new Customer(customer_id, customer_name, customer_owed);
                bool exists = File.Exists(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt");
                if (exists) {
                    StreamReader file_read = new StreamReader(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt");
                    string lines = file_read.ReadToEnd();
                    file_read.Close();
                    StreamWriter file = new StreamWriter(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt");
                    file.WriteLine(lines);
                    file.Write(customer.ToString());
                    file.Close();
                } else {
                    StreamWriter file = new StreamWriter(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\customer_records.txt");
                    file.Write(customer.ToString());
                    file.Close();
                }
            }
        }
    }
}
