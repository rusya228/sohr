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
using System.Text.RegularExpressions;



namespace ПЗ21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();

        }

        private void сохранитьCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Герман Аршанов aka germanium");
        }


        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            richTextBox1.Clear();
            textBox1.Clear();
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }

            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();

        }
        private void DeleteSelectedStrings(ListBox listbox)
        {
            for (int i = listbox.Items.Count - 1; i >= 0; i--)
            {
                if (listbox.GetSelected(i)) listbox.Items.RemoveAt(i);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteSelectedStrings(listBox1);
            DeleteSelectedStrings(listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox2.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            listBox2.EndUpdate();
            DeleteSelectedStrings(listBox1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            listBox1.EndUpdate();
            DeleteSelectedStrings(listBox2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.BeginUpdate();
                listBox1.Sorted = true;
                listBox1.Sorted = false;
                listBox1.EndUpdate();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.BeginUpdate();
                
                List<string> list = new List<string>();
                foreach(string i in listBox1.Items)
                {
                    list.Add(i);
                }
                list.Sort();
                list.Reverse();
                listBox1.Items.Clear();
                foreach(string i in list)
                {
                    listBox1.Items.Add(i);
                }

                listBox1.EndUpdate();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.BeginUpdate();
                List<string> list = new List<string>();
                foreach (string i in listBox1.Items)
                {
                    list.Add(i);
                }
                listBox1.Items.Clear();
                foreach (string i in list.OrderBy(item => item.Length))
                {
                    listBox1.Items.Add(i);
                }
                listBox1.EndUpdate();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.BeginUpdate();
                List<string> list = new List<string>();
                foreach (string i in listBox1.Items)
                {
                    list.Add(i);
                }
                listBox1.Items.Clear();
                foreach (string i in list.OrderByDescending(item => item.Length))
                {
                    listBox1.Items.Add(i);
                }
                listBox1.EndUpdate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                listBox2.BeginUpdate();
                listBox2.Sorted = true;
                listBox2.Sorted = false;
                listBox2.EndUpdate();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                listBox2.BeginUpdate();

                List<string> list = new List<string>();
                foreach (string i in listBox2.Items)
                {
                    list.Add(i);
                }
                list.Sort();
                list.Reverse();
                listBox2.Items.Clear();
                foreach (string i in list)
                {
                    listBox2.Items.Add(i);
                }

                listBox2.EndUpdate();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                listBox2.BeginUpdate();
                List<string> list = new List<string>();
                foreach (string i in listBox2.Items)
                {
                    list.Add(i);
                }
                listBox2.Items.Clear();
                foreach (string i in list.OrderBy(item => item.Length))
                {
                    listBox2.Items.Add(i);
                }
                    
                listBox2.EndUpdate();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                listBox2.BeginUpdate();
                List<string> list = new List<string>();
                foreach (string i in listBox2.Items)
                {
                    list.Add(i);
                }
                listBox2.Items.Clear();
                foreach (string i in list.OrderByDescending(item => item.Length))
                {
                    listBox2.Items.Add(i);
                }
                    
                listBox2.EndUpdate();
            }
        }
    }
}

