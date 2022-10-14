
namespace WinFormsApp3
{
    partial class ColorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hSB_Red = new System.Windows.Forms.HScrollBar();
            this.hSB_Green = new System.Windows.Forms.HScrollBar();
            this.hSB_Blue = new System.Windows.Forms.HScrollBar();
            this.nUD_Red = new System.Windows.Forms.NumericUpDown();
            this.nUD_Green = new System.Windows.Forms.NumericUpDown();
            this.nUD_Blue = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_Red = new System.Windows.Forms.Label();
            this.l_Green = new System.Windows.Forms.Label();
            this.l_Blue = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OtherColors = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hSB_Red
            // 
            this.hSB_Red.Location = new System.Drawing.Point(91, 47);
            this.hSB_Red.Maximum = 255;
            this.hSB_Red.Name = "hSB_Red";
            this.hSB_Red.Size = new System.Drawing.Size(137, 17);
            this.hSB_Red.TabIndex = 0;
            this.hSB_Red.Value = 1;
            this.hSB_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB_Red_Scroll);
            this.hSB_Red.ValueChanged += new System.EventHandler(this.hSB_Red_ValueChanged);
            // 
            // hSB_Green
            // 
            this.hSB_Green.Location = new System.Drawing.Point(91, 84);
            this.hSB_Green.Maximum = 255;
            this.hSB_Green.Name = "hSB_Green";
            this.hSB_Green.Size = new System.Drawing.Size(137, 17);
            this.hSB_Green.TabIndex = 1;
            this.hSB_Green.Value = 1;
            this.hSB_Green.ValueChanged += new System.EventHandler(this.hSB_Green_ValueChanged);
            // 
            // hSB_Blue
            // 
            this.hSB_Blue.Location = new System.Drawing.Point(91, 129);
            this.hSB_Blue.Maximum = 255;
            this.hSB_Blue.Name = "hSB_Blue";
            this.hSB_Blue.Size = new System.Drawing.Size(137, 17);
            this.hSB_Blue.TabIndex = 2;
            this.hSB_Blue.Value = 1;
            this.hSB_Blue.ValueChanged += new System.EventHandler(this.hSB_Blue_ValueChanged);
            // 
            // nUD_Red
            // 
            this.nUD_Red.Location = new System.Drawing.Point(273, 47);
            this.nUD_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nUD_Red.Name = "nUD_Red";
            this.nUD_Red.Size = new System.Drawing.Size(41, 23);
            this.nUD_Red.TabIndex = 3;
            this.nUD_Red.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Red.ValueChanged += new System.EventHandler(this.nUD_Red_ValueChanged);
            // 
            // nUD_Green
            // 
            this.nUD_Green.Location = new System.Drawing.Point(273, 84);
            this.nUD_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nUD_Green.Name = "nUD_Green";
            this.nUD_Green.Size = new System.Drawing.Size(41, 23);
            this.nUD_Green.TabIndex = 4;
            this.nUD_Green.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Green.ValueChanged += new System.EventHandler(this.nUD_Green_ValueChanged);
            // 
            // nUD_Blue
            // 
            this.nUD_Blue.Location = new System.Drawing.Point(273, 129);
            this.nUD_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nUD_Blue.Name = "nUD_Blue";
            this.nUD_Blue.Size = new System.Drawing.Size(41, 23);
            this.nUD_Blue.TabIndex = 5;
            this.nUD_Blue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Blue.ValueChanged += new System.EventHandler(this.nUD_Blue_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // l_Red
            // 
            this.l_Red.AutoSize = true;
            this.l_Red.Location = new System.Drawing.Point(13, 47);
            this.l_Red.Name = "l_Red";
            this.l_Red.Size = new System.Drawing.Size(27, 15);
            this.l_Red.TabIndex = 7;
            this.l_Red.Text = "Red";
            // 
            // l_Green
            // 
            this.l_Green.AutoSize = true;
            this.l_Green.Location = new System.Drawing.Point(13, 84);
            this.l_Green.Name = "l_Green";
            this.l_Green.Size = new System.Drawing.Size(38, 15);
            this.l_Green.TabIndex = 8;
            this.l_Green.Text = "Green";
            // 
            // l_Blue
            // 
            this.l_Blue.AutoSize = true;
            this.l_Blue.Location = new System.Drawing.Point(12, 129);
            this.l_Blue.Name = "l_Blue";
            this.l_Blue.Size = new System.Drawing.Size(30, 15);
            this.l_Blue.TabIndex = 9;
            this.l_Blue.Text = "Blue";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(52, 183);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(168, 183);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OtherColors
            // 
            this.btn_OtherColors.Location = new System.Drawing.Point(433, 183);
            this.btn_OtherColors.Name = "btn_OtherColors";
            this.btn_OtherColors.Size = new System.Drawing.Size(75, 23);
            this.btn_OtherColors.TabIndex = 12;
            this.btn_OtherColors.Text = "OtherColors";
            this.btn_OtherColors.UseVisualStyleBackColor = true;
            this.btn_OtherColors.Click += new System.EventHandler(this.btn_OtherColors_Click);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 228);
            this.Controls.Add(this.btn_OtherColors);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.l_Blue);
            this.Controls.Add(this.l_Green);
            this.Controls.Add(this.l_Red);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nUD_Blue);
            this.Controls.Add(this.nUD_Green);
            this.Controls.Add(this.nUD_Red);
            this.Controls.Add(this.hSB_Blue);
            this.Controls.Add(this.hSB_Green);
            this.Controls.Add(this.hSB_Red);
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.Load += new System.EventHandler(this.ColorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_Red;
        private System.Windows.Forms.Label l_Green;
        private System.Windows.Forms.Label l_Blue;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OtherColors;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NumericUpDown nUD_Red;
        public System.Windows.Forms.NumericUpDown nUD_Green;
        public System.Windows.Forms.NumericUpDown nUD_Blue;
        public System.Windows.Forms.HScrollBar hSB_Red;
        public System.Windows.Forms.HScrollBar hSB_Green;
        public System.Windows.Forms.HScrollBar hSB_Blue;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}