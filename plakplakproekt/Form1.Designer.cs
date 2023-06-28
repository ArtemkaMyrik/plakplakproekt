namespace plakplakproekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateDistanceButton = new System.Windows.Forms.Button();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PodrobnoButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(512, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1147, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти расстояние от точки до плоскости";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(816, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "X+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1096, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1384, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 56);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z+";
            // 
            // CalculateDistanceButton
            // 
            this.CalculateDistanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CalculateDistanceButton.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateDistanceButton.Location = new System.Drawing.Point(493, 749);
            this.CalculateDistanceButton.Name = "CalculateDistanceButton";
            this.CalculateDistanceButton.Size = new System.Drawing.Size(434, 75);
            this.CalculateDistanceButton.TabIndex = 8;
            this.CalculateDistanceButton.Text = "Рассчитать расстояние";
            this.CalculateDistanceButton.UseVisualStyleBackColor = false;
            this.CalculateDistanceButton.Click += new System.EventHandler(this.CalculateDistanceButton_Click);
            // 
            // XTextBox
            // 
            this.XTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.XTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XTextBox.Location = new System.Drawing.Point(611, 546);
            this.XTextBox.MaxLength = 5;
            this.XTextBox.Multiline = true;
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(199, 50);
            this.XTextBox.TabIndex = 9;
            // 
            // YTextBox
            // 
            this.YTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.YTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YTextBox.Location = new System.Drawing.Point(887, 546);
            this.YTextBox.MaxLength = 5;
            this.YTextBox.Multiline = true;
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(203, 50);
            this.YTextBox.TabIndex = 10;
            // 
            // ZTextBox
            // 
            this.ZTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ZTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZTextBox.Location = new System.Drawing.Point(1165, 540);
            this.ZTextBox.MaxLength = 5;
            this.ZTextBox.Multiline = true;
            this.ZTextBox.Name = "ZTextBox";
            this.ZTextBox.Size = new System.Drawing.Size(213, 56);
            this.ZTextBox.TabIndex = 11;
            // 
            // BTextBox
            // 
            this.BTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTextBox.Location = new System.Drawing.Point(806, 667);
            this.BTextBox.MaxLength = 5;
            this.BTextBox.Multiline = true;
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(181, 57);
            this.BTextBox.TabIndex = 13;
            // 
            // CTextBox
            // 
            this.CTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTextBox.Location = new System.Drawing.Point(1064, 672);
            this.CTextBox.MaxLength = 5;
            this.CTextBox.Multiline = true;
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(168, 57);
            this.CTextBox.TabIndex = 5;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.Red;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(1214, 791);
            this.resultTextBox.MaxLength = 8;
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(173, 56);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1457, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 56);
            this.label9.TabIndex = 17;
            this.label9.Text = "=0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1045, 799);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 48);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ответ:";
            // 
            // DTextBox
            // 
            this.DTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTextBox.Location = new System.Drawing.Point(1301, 673);
            this.DTextBox.MaxLength = 5;
            this.DTextBox.Multiline = true;
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.Size = new System.Drawing.Size(168, 57);
            this.DTextBox.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 876);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.clickclick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(735, 670);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 56);
            this.label11.TabIndex = 22;
            this.label11.Text = "А ,";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(986, 674);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 56);
            this.label12.TabIndex = 23;
            this.label12.Text = "B ,";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1225, 674);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 56);
            this.label13.TabIndex = 24;
            this.label13.Text = "C ,";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1475, 673);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 56);
            this.label14.TabIndex = 25;
            this.label14.Text = "D";
            // 
            // PodrobnoButton
            // 
            this.PodrobnoButton.BackColor = System.Drawing.Color.Yellow;
            this.PodrobnoButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PodrobnoButton.Location = new System.Drawing.Point(792, 886);
            this.PodrobnoButton.Name = "PodrobnoButton";
            this.PodrobnoButton.Size = new System.Drawing.Size(585, 103);
            this.PodrobnoButton.TabIndex = 28;
            this.PodrobnoButton.Text = "Посмотреть более подробное решение...";
            this.PodrobnoButton.UseVisualStyleBackColor = false;
            this.PodrobnoButton.Click += new System.EventHandler(this.PodrobnoButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(193, 876);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(113, 113);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(636, 876);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.WordButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(493, 876);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(126, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(535, 831);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 47);
            this.label15.TabIndex = 33;
            this.label15.Text = "ЭКСПОРТ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(230, 821);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 57);
            this.label16.TabIndex = 34;
            this.label16.Text = "ИМПОРТ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(933, 749);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(91, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1403, 470);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(492, 489);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 39;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(179, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 47);
            this.label6.TabIndex = 41;
            this.label6.Text = "Уравнение плоскости:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 47);
            this.label2.TabIndex = 42;
            this.label2.Text = "Координаты плоскости:";
            // 
            // ATextBox
            // 
            this.ATextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ATextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ATextBox.Location = new System.Drawing.Point(557, 667);
            this.ATextBox.MaxLength = 5;
            this.ATextBox.Multiline = true;
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(181, 57);
            this.ATextBox.TabIndex = 43;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1001);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.PodrobnoButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ZTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.CalculateDistanceButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Name = "Form1";
            this.Text = "Основная панель";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button CalculateDistanceButton;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private TextBox ZTextBox;
        private TextBox BTextBox;
        private TextBox CTextBox;
        private TextBox resultTextBox;
        private Label label9;
        private Label label10;
        private TextBox DTextBox;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button PodrobnoButton;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label15;
        private Label label16;
        private Button InfoButton;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label6;
        private TextBox ATextBox;
        private OpenFileDialog openFileDialog1;
    }
}