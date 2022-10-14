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
    public partial class Task : Form
    {
        Point f = new Point();
       
        public Task()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show();
        }
        string path = @"C:\Users\Руслан\Desktop\1.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string d = dateTimePicker1.Value.Day.ToString()+ "." + dateTimePicker1.Value.Month.ToString()+"."+dateTimePicker1.Value.Year.ToString();
            string s= textBox2.Text;
            FileStream fs = new FileStream(path, FileMode.Append);
            fs.Close();
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine(s+" "+d);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] str = File.ReadAllLines(path);
            string p = textBox1.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains(p))
                {
                    listBox1.Items.Add(str[i]);

                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
