
namespace pr20
{
    partial class fr1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btright = new System.Windows.Forms.Button();
            this.btleft = new System.Windows.Forms.Button();
            this.bt2left = new System.Windows.Forms.Button();
            this.bt2rigth = new System.Windows.Forms.Button();
            this.lsb1 = new System.Windows.Forms.ListBox();
            this.lsb2 = new System.Windows.Forms.ListBox();
            this.bt1sort = new System.Windows.Forms.Button();
            this.bt1clear = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.bt2clear = new System.Windows.Forms.Button();
            this.bt2sort = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.btsearch = new System.Windows.Forms.Button();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.lsb3 = new System.Windows.Forms.ListBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btsbros = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btstart = new System.Windows.Forms.Button();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lb5 = new System.Windows.Forms.Label();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Алфавиту (по возрастанию) ",
            "Алфавиту (по убыванию) ",
            "Длине слова (по возрастанию) ",
            "Длине слова (по убыванию) "});
            this.comboBox1.Location = new System.Drawing.Point(11, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Сортировка по..";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Алфавиту (по возрастанию) ",
            "Алфавиту (по убыванию) ",
            "Длине слова (по возрастанию) ",
            "Длине слова (по убыванию) "});
            this.comboBox2.Location = new System.Drawing.Point(289, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Сортировка по..";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(8, 12);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 13);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Раздел 1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(286, 12);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 13);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Раздел 2";
            // 
            // btright
            // 
            this.btright.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btright.Location = new System.Drawing.Point(187, 81);
            this.btright.Name = "btright";
            this.btright.Size = new System.Drawing.Size(96, 35);
            this.btright.TabIndex = 4;
            this.btright.Text = ">";
            this.btright.UseVisualStyleBackColor = true;
            this.btright.Click += new System.EventHandler(this.btright_Click);
            // 
            // btleft
            // 
            this.btleft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btleft.Location = new System.Drawing.Point(187, 122);
            this.btleft.Name = "btleft";
            this.btleft.Size = new System.Drawing.Size(96, 35);
            this.btleft.TabIndex = 5;
            this.btleft.Text = "<";
            this.btleft.UseVisualStyleBackColor = true;
            this.btleft.Click += new System.EventHandler(this.btleft_Click);
            // 
            // bt2left
            // 
            this.bt2left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2left.Location = new System.Drawing.Point(187, 204);
            this.bt2left.Name = "bt2left";
            this.bt2left.Size = new System.Drawing.Size(96, 35);
            this.bt2left.TabIndex = 6;
            this.bt2left.Text = "<<";
            this.bt2left.UseVisualStyleBackColor = true;
            this.bt2left.Click += new System.EventHandler(this.bt2left_Click);
            // 
            // bt2rigth
            // 
            this.bt2rigth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2rigth.Location = new System.Drawing.Point(187, 163);
            this.bt2rigth.Name = "bt2rigth";
            this.bt2rigth.Size = new System.Drawing.Size(96, 35);
            this.bt2rigth.TabIndex = 7;
            this.bt2rigth.Text = ">>";
            this.bt2rigth.UseVisualStyleBackColor = true;
            this.bt2rigth.Click += new System.EventHandler(this.bt2rigth_Click);
            // 
            // lsb1
            // 
            this.lsb1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lsb1.Cursor = System.Windows.Forms.Cursors.No;
            this.lsb1.FormattingEnabled = true;
            this.lsb1.Location = new System.Drawing.Point(11, 81);
            this.lsb1.Name = "lsb1";
            this.lsb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsb1.Size = new System.Drawing.Size(170, 251);
            this.lsb1.TabIndex = 8;
            // 
            // lsb2
            // 
            this.lsb2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lsb2.FormattingEnabled = true;
            this.lsb2.Location = new System.Drawing.Point(289, 81);
            this.lsb2.Name = "lsb2";
            this.lsb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsb2.Size = new System.Drawing.Size(170, 251);
            this.lsb2.TabIndex = 9;
            // 
            // bt1sort
            // 
            this.bt1sort.Cursor = System.Windows.Forms.Cursors.No;
            this.bt1sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt1sort.Location = new System.Drawing.Point(36, 338);
            this.bt1sort.Name = "bt1sort";
            this.bt1sort.Size = new System.Drawing.Size(120, 27);
            this.bt1sort.TabIndex = 10;
            this.bt1sort.Text = "Сортировать";
            this.bt1sort.UseVisualStyleBackColor = true;
            this.bt1sort.Click += new System.EventHandler(this.bt1sort_Click);
            // 
            // bt1clear
            // 
            this.bt1clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt1clear.Location = new System.Drawing.Point(36, 371);
            this.bt1clear.Name = "bt1clear";
            this.bt1clear.Size = new System.Drawing.Size(120, 27);
            this.bt1clear.TabIndex = 11;
            this.bt1clear.Text = "Очистить";
            this.bt1clear.UseVisualStyleBackColor = true;
            this.bt1clear.Click += new System.EventHandler(this.bt1clear_Click);
            // 
            // btadd
            // 
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btadd.Location = new System.Drawing.Point(175, 338);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(120, 27);
            this.btadd.TabIndex = 12;
            this.btadd.Text = "Добавить";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btdel
            // 
            this.btdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdel.Location = new System.Drawing.Point(175, 371);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(120, 27);
            this.btdel.TabIndex = 13;
            this.btdel.Text = "Удалить";
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // bt2clear
            // 
            this.bt2clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2clear.Location = new System.Drawing.Point(313, 371);
            this.bt2clear.Name = "bt2clear";
            this.bt2clear.Size = new System.Drawing.Size(120, 27);
            this.bt2clear.TabIndex = 15;
            this.bt2clear.Text = "Очистить";
            this.bt2clear.UseVisualStyleBackColor = true;
            this.bt2clear.Click += new System.EventHandler(this.bt2clear_Click);
            // 
            // bt2sort
            // 
            this.bt2sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2sort.Location = new System.Drawing.Point(313, 338);
            this.bt2sort.Name = "bt2sort";
            this.bt2sort.Size = new System.Drawing.Size(120, 27);
            this.bt2sort.TabIndex = 14;
            this.bt2sort.Text = "Сортировать";
            this.bt2sort.UseVisualStyleBackColor = true;
            this.bt2sort.Click += new System.EventHandler(this.bt2sort_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(483, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(273, 479);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // pn1
            // 
            this.pn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn1.Controls.Add(this.bt2clear);
            this.pn1.Controls.Add(this.bt2sort);
            this.pn1.Controls.Add(this.lsb2);
            this.pn1.Controls.Add(this.btdel);
            this.pn1.Controls.Add(this.btadd);
            this.pn1.Controls.Add(this.bt1clear);
            this.pn1.Controls.Add(this.bt1sort);
            this.pn1.Controls.Add(this.lsb1);
            this.pn1.Controls.Add(this.bt2rigth);
            this.pn1.Controls.Add(this.bt2left);
            this.pn1.Controls.Add(this.btleft);
            this.pn1.Controls.Add(this.btright);
            this.pn1.Controls.Add(this.lb2);
            this.pn1.Controls.Add(this.lb1);
            this.pn1.Controls.Add(this.comboBox2);
            this.pn1.Controls.Add(this.comboBox1);
            this.pn1.Location = new System.Drawing.Point(0, 27);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(477, 410);
            this.pn1.TabIndex = 17;
            // 
            // pn2
            // 
            this.pn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn2.Controls.Add(this.btsearch);
            this.pn2.Controls.Add(this.chb2);
            this.pn2.Controls.Add(this.chb1);
            this.pn2.Controls.Add(this.lsb3);
            this.pn2.Controls.Add(this.tb1);
            this.pn2.Controls.Add(this.lb4);
            this.pn2.Location = new System.Drawing.Point(0, 445);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(313, 210);
            this.pn2.TabIndex = 18;
            this.pn2.Tag = "";
            // 
            // btsearch
            // 
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsearch.Location = new System.Drawing.Point(215, 125);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(80, 70);
            this.btsearch.TabIndex = 20;
            this.btsearch.Text = "Поиск";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(215, 80);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(72, 17);
            this.chb2.TabIndex = 21;
            this.chb2.Text = "Раздел 2";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Checked = true;
            this.chb1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb1.Location = new System.Drawing.Point(215, 57);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(72, 17);
            this.chb1.TabIndex = 20;
            this.chb1.Text = "Раздел 1";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // lsb3
            // 
            this.lsb3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lsb3.FormattingEnabled = true;
            this.lsb3.Location = new System.Drawing.Point(3, 57);
            this.lsb3.Name = "lsb3";
            this.lsb3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsb3.Size = new System.Drawing.Size(193, 147);
            this.lsb3.TabIndex = 20;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(6, 33);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(190, 20);
            this.tb1.TabIndex = 20;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(3, 17);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(129, 13);
            this.lb4.TabIndex = 20;
            this.lb4.Text = "Введите искомое слово";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(9, 440);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(39, 13);
            this.lb3.TabIndex = 19;
            this.lb3.Text = "Поиск";
            // 
            // btsbros
            // 
            this.btsbros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsbros.Location = new System.Drawing.Point(319, 509);
            this.btsbros.Name = "btsbros";
            this.btsbros.Size = new System.Drawing.Size(158, 70);
            this.btsbros.TabIndex = 21;
            this.btsbros.Text = "Сброс";
            this.btsbros.UseVisualStyleBackColor = true;
            this.btsbros.Click += new System.EventHandler(this.btsbros_Click);
            // 
            // btexit
            // 
            this.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btexit.Location = new System.Drawing.Point(319, 585);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(158, 70);
            this.btexit.TabIndex = 22;
            this.btexit.Text = "Выход";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btstart);
            this.panel1.Controls.Add(this.rb3);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Location = new System.Drawing.Point(483, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 138);
            this.panel1.TabIndex = 23;
            this.panel1.Tag = "";
            // 
            // btstart
            // 
            this.btstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btstart.Location = new System.Drawing.Point(186, 35);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(80, 70);
            this.btstart.TabIndex = 21;
            this.btstart.Text = "Начать";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(15, 88);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(125, 17);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "Содежащие \"e-mail\"";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(15, 53);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(128, 17);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Содержащие цифры";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(15, 18);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(44, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Все";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(497, 508);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(67, 13);
            this.lb5.TabIndex = 24;
            this.lb5.Text = "Выбор слов";
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(764, 24);
            this.ms1.TabIndex = 25;
            this.ms1.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeyDisplayString = "Ctl+O";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem2.Text = "Открыть";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeyDisplayString = "Ctrl+S";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem3.Text = "Сохранить";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeyDisplayString = " Alt+X";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem4.Text = "Выход";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(77, 22);
            this.toolStripMenuItem6.Text = " ";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(77, 22);
            this.toolStripMenuItem7.Text = " ";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(79, 22);
            this.toolStripMenuItem8.Text = "?";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // fr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(764, 663);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsbros);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.ms1);
            this.MainMenuStrip = this.ms1;
            this.Name = "fr1";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btright;
        private System.Windows.Forms.Button btleft;
        private System.Windows.Forms.Button bt2left;
        private System.Windows.Forms.Button bt2rigth;
        private System.Windows.Forms.Button bt1sort;
        private System.Windows.Forms.Button bt1clear;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button bt2clear;
        private System.Windows.Forms.Button bt2sort;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.ListBox lsb3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btsbros;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        public System.Windows.Forms.ListBox lsb1;
        public System.Windows.Forms.ListBox lsb2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
    }
}

