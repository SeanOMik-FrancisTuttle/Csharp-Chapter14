using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RetrieveCustomizedForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            var lines = File.ReadLines(@"\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\custom_form.txt");
            BackColor = Color.FromName(lines.ElementAt(0));
            int x = int.Parse(lines.ElementAt(1).Substring(0, lines.ElementAt(1).IndexOf(',')));
            int y = int.Parse(lines.ElementAt(1).Substring(lines.ElementAt(1).IndexOf(',')+1));
            Width = x;
            Height = y;
            Text = lines.ElementAt(2);
        }
    }
}
