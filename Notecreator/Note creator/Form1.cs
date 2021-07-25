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

namespace Note_creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox2.Text;
            var Files = File.Create("C://Users/User/Downloads/"+path);
            Files.Close();
            File.WriteAllText("C://Users/User/Downloads/"+path, textBox1.Text);
            MessageBox.Show(path + " is saved in the Downloads file");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            textBox1.Text = OpenFile.ReadToEnd();
        }
    }
}
