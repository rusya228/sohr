using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBox = System.Windows.Forms.TextBox;
using System.IO;

namespace _19
{
    public class Organization
    {
        public string path = @"F:\ПП.txt";
        public string organiz = "None";
        public int rab = 0;
        public string name = "None";
        public string sfera = "None";
        public int year = 0;
        public  Organization(string organiz, int rab, string name, string sfera, int year)
        {
            this.organiz = organiz;
            this.rab = rab;
            this.name = name;
            this.sfera = sfera;
            this.year = year;
        }
        public void Print(TextBox textBox1)
        {
            try
            {

                textBox1.Text += organiz + " " + name + " " + rab + " " + sfera +" " + year + Environment.NewLine;
                using (FileStream fs = File.Create(path))//запись в документ
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(textBox1.Text);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка в создании или заполнении файла";
            }

        }
        public void Deconstruct(out string organiz, out string rab, out string name, out string sfera, out string year)
        {
            organiz = this.organiz;
            rab = this.rab.ToString();
            name = this.name;
            sfera = this.sfera;
            year = this.year.ToString();
        }
        public void orgName(string newName)
        {
            name = newName;
        }
        public void orgRab(int newRab)
        {
            rab=newRab;
        }
        public void orgOrganiz(string newOrganiz)
        {
            organiz = newOrganiz;
        }
        public void orgSfera(string newSfera)
        {
            sfera = newSfera;
        }
    }
}
