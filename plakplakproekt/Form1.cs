using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Xceed.Words.NET;

namespace plakplakproekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 form2;

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (!double.TryParse(XTextBox.Text, out x))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле X!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XTextBox.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double y;
            if (!double.TryParse(YTextBox.Text, out y))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле Y!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YTextBox.Clear();
            }
        }

        private void ZTextBox_TextChanged(object sender, EventArgs e)
        {
            double z;
            if (!double.TryParse(ZTextBox.Text, out z))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле Z!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZTextBox.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(ATextBox.Text, out a))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле A!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ATextBox.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            double b;
            if (!double.TryParse(BTextBox.Text, out b))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле B!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BTextBox.Clear();
            }
        }

        private void CTextBox_TextChanged(object sender, EventArgs e)
        {
            double c;
            if (!double.TryParse(CTextBox.Text, out c))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле C!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CTextBox.Clear();
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DTextBox_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (!double.TryParse(DTextBox.Text, out d))
            {
                MessageBox.Show("Вы ввели некорректное значение в поле D!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTextBox.Clear();
            }
        }
        private void CalculateDistanceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XTextBox.Text) ||
                string.IsNullOrEmpty(YTextBox.Text) ||
                string.IsNullOrEmpty(ZTextBox.Text) ||
                string.IsNullOrEmpty(ATextBox.Text) ||
                string.IsNullOrEmpty(BTextBox.Text) ||
                string.IsNullOrEmpty(CTextBox.Text) ||
                string.IsNullOrEmpty(DTextBox.Text))
            {
                MessageBox.Show("Вы не ввели все данные!", "Ошибка 01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CalculateDistanceButton.BackColor = Color.Yellow;

            double x = double.Parse(XTextBox.Text);
            double y = double.Parse(YTextBox.Text);
            double z = double.Parse(ZTextBox.Text);

            double A = double.Parse(ATextBox.Text);
            double B = double.Parse(BTextBox.Text);
            double C = double.Parse(CTextBox.Text);
            double D = double.Parse(DTextBox.Text);

            double distance = Math.Abs(A * x + B * y + C * z + D) / Math.Sqrt(A * A + B * B + C * C);

            resultTextBox.Text = distance.ToString();

            double roundedDistance = Math.Round(distance, 7);
        }

        private void resultTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Предотвращает ввод цифр пользователем
                MessageBox.Show("В данное поле нельзя вводить данные!", "Ошибка 03", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultTextBox.Clear(); // Очищает поле ввода
            }
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resultTextBox.Text))
            {
                resultTextBox.BackColor = SystemColors.Control; // Установка фона на цвет по умолчанию
            }
            else
            {
                resultTextBox.BackColor = Color.Green; // Установка зеленого фона
            }

            if (string.IsNullOrEmpty(resultTextBox.Text))
            {
                PodrobnoButton.BackColor = Color.Yellow; // Установка желтого цвета кнопки
            }
            else
            {
                PodrobnoButton.BackColor = Color.Green; // Установка зеленого цвета кнопки
            }
        }

        private void InitializeResultTextBox()
        {
            resultTextBox.KeyPress += resultTextBox_KeyPress;
            resultTextBox.TextChanged += resultTextBox_TextChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(resultTextBox.Text);

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var excelWorkbook = excelApp.Workbooks.Add();
            var excelWorksheet = excelWorkbook.ActiveSheet as Worksheet;
            excelWorksheet.Range["A1"].Value = distance;
            excelApp.Visible = true;
        }

        private void WordButton_Click(object sender, EventArgs e)
        {
            string textToExport = resultTextBox.Text;

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();
            wordDoc.Content.Text = textToExport;
            wordDoc.Content.Text = DataBase.firstStep1;
            object filePath = @"C:\Users\Student\Desktop\Приктическая Никитенко";
            wordDoc.SaveAs2(ref filePath);
            wordDoc.Close();
            wordApp.Quit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PodrobnoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XTextBox.Text) ||
                string.IsNullOrEmpty(YTextBox.Text) ||
                string.IsNullOrEmpty(ZTextBox.Text) ||
                string.IsNullOrEmpty(ATextBox.Text) ||
                string.IsNullOrEmpty(BTextBox.Text) ||
                string.IsNullOrEmpty(CTextBox.Text) ||
                string.IsNullOrEmpty(DTextBox.Text) ||
                string.IsNullOrEmpty(resultTextBox.Text))
            {
                MessageBox.Show("Данные введены некорректно или информация не допускается правилами.", "Ошибка 02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x = double.Parse(XTextBox.Text);
            double y = double.Parse(YTextBox.Text);
            double z = double.Parse(ZTextBox.Text);

            double A = double.Parse(ATextBox.Text);
            double B = double.Parse(BTextBox.Text);
            double C = double.Parse(CTextBox.Text);
            double D = double.Parse(DTextBox.Text);

            double distance = Math.Abs(A * x + B * y + C * z + D) / Math.Sqrt(A * A + B * B + C * C);

            resultTextBox.Text = " " + distance.ToString();

            double roundedDistance = Math.Round(distance, 7);

            Form2 form2 = new Form2(x, y, z, distance, A, B, C, D);
            form2.DistanceFormula = "Формула: " + ATextBox.Text + " * x + " + BTextBox.Text + " * y + " + CTextBox.Text + " * z + " + DTextBox.Text;
            form2.ResultText = "Подставим в формулу данные: " + resultTextBox.Text;
            form2.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            Workbook excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\Student\Documents\Книга2");
            Worksheet excelWorksheet = excelWorkbook.ActiveSheet as Worksheet;

            double distance = excelWorksheet.Range["A1"].Value;
            resultTextBox.Text = distance.ToString();

            MessageBox.Show("Экспорт успешно выполнен");

            excelWorkbook.Close();
            excelApp.Quit();
        }

        private void ImportToWord_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;

            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Open(@"C:\Users\Student\Desktop\Приктическая Никитенко");
            string textFromDocument = wordDoc.Content.Text;

            double distance;
            if (double.TryParse(textFromDocument, out distance))
            {
                resultTextBox.Text = distance.ToString();
            }
            else
            {
                MessageBox.Show("Не удалось прочитать данные из документа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            wordDoc.Close();
            wordApp.Quit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (form2 != null) {
                XTextBox.Text = form2.XValue;
                YTextBox.Text = form2.YValue;
                ZTextBox.Text = form2.ZValue;
                ATextBox.Text = form2.AValue;
                BTextBox.Text = form2.BValue;
                CTextBox.Text = form2.CValue;
                DTextBox.Text = form2.DValue;
       
            }
        }

        public void click(object sender, EventArgs e)
        {
            try
            {
                XSSFWorkbook hssfwb;
                openFileDialog1.Filter = "Excel files(*.xlsx)|*.xlsx";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string path = openFileDialog1.FileName;

                using (FileStream xlsxFile = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new XSSFWorkbook(xlsxFile);
                }
                ISheet matrixExcel = hssfwb.GetSheet("Лист1");

                XTextBox.Text = Convert.ToString(matrixExcel.GetRow(0).GetCell(0));
                YTextBox.Text = Convert.ToString(matrixExcel.GetRow(0).GetCell(1));
                ZTextBox.Text = Convert.ToString(matrixExcel.GetRow(0).GetCell(2));
                ATextBox.Text = Convert.ToString(matrixExcel.GetRow(1).GetCell(0));
                BTextBox.Text = Convert.ToString(matrixExcel.GetRow(1).GetCell(1));
                CTextBox.Text = Convert.ToString(matrixExcel.GetRow(1).GetCell(2));
                DTextBox.Text = Convert.ToString(matrixExcel.GetRow(1).GetCell(3));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Что-то не так!" + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickclick(object sender, EventArgs e) 
        {
            try
            {
                openFileDialog1.Filter = "Word files(*.docx)|*.docx";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string path = openFileDialog1.FileName;

                DocX document = DocX.Load(path);
                string text = document.Text;
                string[] array = text.Split(new char[] { ' ' });

                XTextBox.Text = array[0];
                YTextBox.Text = array[1];
                ZTextBox.Text = array[2];
                ATextBox.Text = array[3];
                BTextBox.Text = array[4];
                CTextBox.Text = array[5];
                DTextBox.Text = array[6];

            }
            catch(Exception ex)
            {
                MessageBox.Show("Что-то не так!" + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}

