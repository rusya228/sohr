using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int god = int.Parse(textBox3.Text);
            int day = int.Parse(textBox1.Text);
            DateTime date = new DateTime();
            date = date.AddYears(god - 1);
            date = date.AddDays(day - 1);
            try
            {
                if (god%4!=0)
                {
                    if (day > 365 || day < 1)
                    {
                        throw new InvalidArgument("Dayouttofrange");
                    }
                }
                MessageBox.Show("Ошибок не найдено");
            }
            catch (InvalidArgument)
            {
                MessageBox.Show("Возникла ошибка!");
            }
            finally
            {
                Console.WriteLine();
            }
            Console.WriteLine("Конец программы");
        }
           
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }

    [Serializable]
    internal class InvalidArgument : Exception
    {
        public InvalidArgument()
        {
        }

        public InvalidArgument(string message) : base(message)
        {
        }

        public InvalidArgument(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidArgument(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
