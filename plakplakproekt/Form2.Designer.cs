namespace plakplakproekt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Formula = new System.Windows.Forms.Label();
            this.PodrobnoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Решение :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1684, 248);
            this.label2.TabIndex = 1;
            this.label2.Text = "Для вычисления расстояния от точки M(Mx; My; Mz) до плоскости Ax + By + Cz + D = " +
    "0\r\nиспользуем формулу:  \r\nd = |A·Mx + B·My + C·Mz + D| \r\n√A2 + B2 + C2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(78, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Формула :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подставим в формулу данные:";
            // 
            // Formula
            // 
            this.Formula.AutoSize = true;
            this.Formula.BackColor = System.Drawing.Color.Transparent;
            this.Formula.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Formula.Location = new System.Drawing.Point(42, 498);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(195, 170);
            this.Formula.TabIndex = 4;
            this.Formula.Text = "d=";
            // 
            // PodrobnoTextBox
            // 
            this.PodrobnoTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PodrobnoTextBox.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PodrobnoTextBox.Location = new System.Drawing.Point(243, 446);
            this.PodrobnoTextBox.MaxLength = 130;
            this.PodrobnoTextBox.Multiline = true;
            this.PodrobnoTextBox.Name = "PodrobnoTextBox";
            this.PodrobnoTextBox.Size = new System.Drawing.Size(794, 260);
            this.PodrobnoTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(706, 808);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(603, 134);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PodrobnoTextBox);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Formula;
        private TextBox PodrobnoTextBox;
        private Button button1;
    }
}