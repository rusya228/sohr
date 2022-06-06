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
namespace pr20
{
    public partial class fr1 : Form
    {
        public fr1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < lsb2.Items.Count; i++)
                {
                    Writer.WriteLine((string)lsb2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            lsb1.Items.Clear();
            lsb2.Items.Clear();
            lsb1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (rb1.Checked) lsb1.Items.Add(Str);
                if (rb2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) lsb1.Items.Add(Str);
                }
                if (rb3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) lsb1.Items.Add(Str);
                }
            }
            lsb1.EndUpdate();

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btsbros_Click(object sender, EventArgs e)
        {
            lsb1.Items.Clear();
            lsb2.Items.Clear();
            lsb3.Items.Clear();
            tb1.Text = "";
            richTextBox1.Text = "";
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            chb1.Enabled = true;
            chb2.Enabled = false;

        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            lsb3.Items.Clear();
            string Find = tb1.Text;
            if (chb1.Checked)
            {
                foreach (string String in lsb1.Items)
                {
                    if (String.Contains(Find)) lsb3.Items.Add(String);
                }
            }

          
            if (chb2.Checked)
            {
                foreach (string String in lsb2.Items)
                {
                    if (String.Contains(Find)) lsb3.Items.Add(String);
                }
            }

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            fr2 AddRec = new fr2();
            AddRec.Owner = this;
            AddRec.ShowDialog();

        }
        public void DeleteSelectedStrings(ListBox lsb11)
        {
            for (int i = lsb11.Items.Count - 1; i >= 0; i--)
            {
                if (lsb11.GetSelected(i)) lsb11.Items.RemoveAt(i);
            }
        }
        private void btdel_Click(object sender, EventArgs e)
        {
            DeleteSelectedStrings(lsb1);
            DeleteSelectedStrings(lsb2);
        }
        private void bt2rigth_Click(object sender, EventArgs e)
        {
            lsb2.Items.AddRange(lsb1.Items);
            lsb1.Items.Clear();
        }

        private void bt2left_Click(object sender, EventArgs e)
        {
            lsb1.Items.AddRange(lsb2.Items);
            lsb2.Items.Clear();
        }
        private void btright_Click(object sender, EventArgs e)
        {
            lsb2.BeginUpdate();
            foreach (object Item in lsb1.SelectedItems)
            {
                lsb2.Items.Add(Item);
            }
            lsb1.Items.Remove(lsb1.SelectedItem);
            lsb2.EndUpdate();
        }
        private void btleft_Click(object sender, EventArgs e)
        {
            lsb1.BeginUpdate();
            foreach (object Item in lsb2.SelectedItems)
            {
                lsb1.Items.Add(Item);
            }
            lsb2.Items.Remove(lsb2.SelectedItem);
            lsb1.EndUpdate();
        }

        private void bt1clear_Click(object sender, EventArgs e) { lsb1.Items.Clear(); }
        private void bt2clear_Click(object sender, EventArgs e) { lsb2.Items.Clear(); }
        public void AlphabetSortUp(ComboBox comboBox, ListBox listBox)
        {
          
                List<string> items = new List<string>();
                foreach (string i in listBox.Items)
                {
                    items.Add(i);
                }
                items.Sort();
                listBox.Items.Clear();
                foreach (string i in items)
                {
                    listBox.Items.Add(i);
                }
        }
        public void AlphabetSortDown(ComboBox comboBox, ListBox listBox)
        {
            List<string> items = new List<string>();
            foreach (string i in listBox.Items)
            {
                items.Add(i);
            }
            items.Sort();
            items.Reverse();
            listBox.Items.Clear();
            foreach (string i in items)
            {
                listBox.Items.Add(i);
            }
            
        }
        public void LeinghtSortUp(ComboBox comboBox, ListBox listBox)
        {
            List<string> items = new List<string>();
            foreach (string i in listBox.Items)
            {
                items.Add(i);
            }
            items.Sort((a, b) => a.Length.CompareTo(b.Length));
            listBox.Items.Clear();
            foreach (string i in items)
            {
                listBox.Items.Add(i);
            }
           
        }
        public void LeinghtSortDown(ComboBox comboBox, ListBox listBox)
        {
            List<string> items = new List<string>();
            foreach (string i in listBox.Items)
            {
                items.Add(i);
            }
            items.Sort((a, b) => a.Length.CompareTo(b.Length));
            items.Reverse();
            listBox.Items.Clear();
            foreach (string i in items)
            {
                listBox.Items.Add(i);
            }

        }
        private void bt1sort_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    AlphabetSortUp(comboBox1, lsb1);
                    break;
                case 1:
                    AlphabetSortDown(comboBox1, lsb1);
                    break;
                case 2:
                    LeinghtSortUp(comboBox1, lsb1);
                    break;
                case 3:
                    LeinghtSortDown(comboBox1, lsb1);
                    break;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Опа, чирик");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt2sort_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    AlphabetSortUp(comboBox2, lsb2);
                    break;
                case 1:
                    AlphabetSortDown(comboBox2, lsb2);
                    break;
                case 2:
                    LeinghtSortUp(comboBox2, lsb2);
                    break;
                case 3:
                    LeinghtSortDown(comboBox2, lsb2);
                    break;

            }
        }
    }
}
