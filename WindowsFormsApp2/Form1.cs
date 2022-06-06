using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string f = textBox1.Text;
                int c1 = Convert.ToInt32(textBox2.Text);
                dateTimePicker2.MaxDate = DateTime.Now;
                DateTime dt1 = dateTimePicker2.Value;
                DateTime dt2 = DateTime.Now;
                int d = (dt2.Year - dt1.Year) * 365;
                string s = "Вы " + f;
                listBox1.Items.Add(s);
                s = Convert.ToString(d);
                s = "Вы прожили " + s + " дней";
                listBox1.Items.Add(s);
                s = Convert.ToString(c1);
                s = "Вы хотите учиться еще " + s + " дней";
                listBox1.Items.Add(s);
                dt2 = dt2.AddDays(c1);
                s = "Вы станете очень умным " + dt2;
                listBox1.Items.Add(s);
                s = Convert.ToString(dt2.DayOfWeek);
                s = "Это будет в " + s;
                listBox1.Items.Add(s);
                s = "Если не все поняли, подучите английский";
                listBox1.Items.Add(s);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);//День
            int b = int.Parse(textBox5.Text);//Год
            DateTime date = new DateTime();
            date = date.AddYears(b-1);
            date = date.AddDays(a-1); 
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            string v = date.ToString("f");
            string[] m = v.Split();
            MessageBox.Show(m[0] +" "+ m[1]);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
