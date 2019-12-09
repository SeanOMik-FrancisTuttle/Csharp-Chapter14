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

namespace TestFileAndDirectory2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent(); // Note this foreach loop takes a very long time, due to it searching every directory inside my documents.

            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in Directory.GetFiles(filepath, "*.txt", SearchOption.AllDirectories)) {
                fileCheckLists.Items.Add(file, false);
            }
        }

        private void fileCheckLists_SelectedIndexChanged(object sender, EventArgs e) {
            string file_path = fileCheckLists.SelectedItem.ToString();

            FileInfo file_info = new FileInfo(file_path);
            lblCreationInfo.Text = file_path + " was created " + file_info.CreationTime.ToString();
        }
    }
}
