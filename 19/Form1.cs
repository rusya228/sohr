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


namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string path = @"F:\ПП.txt";
       

        private void btn_view_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Organization organization = new Organization("Данон", 228, "Акакий_Акакьевич", "Молочная_продукция", 1991);
            organization.Print(textBox1);
           
        }

        private void btn_izmenenie_Click(object sender, EventArgs e)
        {
            Organization organization = new Organization("Данон", 228, "Акакий_Акакьевич", "Молочная_продукция", 1991);
            organization.orgName("Руслан_Бардин");
            organization.orgRab(1337);
            organization.orgOrganiz("Apple");
            organization.orgSfera("Электронная техника");
            organization.Print(textBox2);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int kol = Convert.ToInt32(textBox4.Text);
            string sf = textBox5.Text.ToString();
           
            try
            {
                if (kol == 228) { Organization organization = new Organization("Данон", 228, "Акакий_Акакьевич", "Молочная_продукция", 1991); organization.Print(textBox3); }
                if (kol == 1337) { Organization organization = new Organization("Данон", 228, "Акакий_Акакьевич", "Молочная_продукция", 1991); organization.orgName("Руслан_Бардин"); organization.orgRab(1337); organization.orgOrganiz("Apple"); organization.orgSfera("Электронная техника"); organization.Print(textBox3); }
                if (sf='gg') { Organization organization = new Organization("Данон", 228, "Акакий_Акакьевич", "Молочная_продукция", 1991); organization.Print(textBox3); }
            }
            catch (FormatException) { textBox3.Text = "Такой организации не существует"; }
            
                
            
           
           
            

            
        }
    }
}
 