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

namespace WindowsFormsApp1
{
    public partial class Point : Form
    {
        public Point()
        {
            InitializeComponent();
        }
        string path =  @"C:\Users\Руслан\Desktop\2.txt"; 
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string cb1=comboBox1.Text;
            string cb2 = comboBox2.Text;
            FileStream fs = new FileStream(path, FileMode.Append);
            fs.Close();
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine("Метка: {0}, Категория: {1}, Заметка: {2}",cb2, cb1, s);
            sw.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = textBox2.Text;
            string[] str = File.ReadAllLines(path);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains(s))
                {
                    listBox2.Items.Add(str[i]);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cb2 = comboBox2.Text;
            string[] str = File.ReadAllLines(path);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains(cb2))
                {
                    listBox1.Items.Add(str[i]);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string dob = textBox3.Text;
            comboBox2.Items.Add(dob);
        }
    }
}
