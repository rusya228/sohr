using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr20
{
    public partial class fr2 : Form
    {
        public fr2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr1 Main = this.Owner as fr1;
            if (textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true)
                    Main.lsb1.Items.Add(this.textBox1.Text);
                else
                    Main.lsb2.Items.Add(this.textBox1.Text);
                this.Close();

            }
        }
    }
}
