using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task4.V13.Lib;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_PMA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_PMA.Text);
                int l = ds.GetMassFunction(startValue, stopValue).Length;
                double[] num = new double[l];
                num = ds.GetMassFunction(startValue, stopValue);
                //this.chartFunction_URI.Titles.Add("График функции F(x)");
                this.chartFunction_PMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PMA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_PMA.Text = "";
                chartFunction_PMA.Series[0].Points.Clear();
                for (int i = 0; i <= l - 1; i++)
                {
                    this.chartFunction_PMA.Series[0].Points.AddXY(startValue, num[i]);
                    textBoxResult_PMA.AppendText(num[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\User\source\repos\Tyuiu.PyanzinaMA.Sprint6\Tyuiu.PyanzinaMA.Sprint6.Task4.V13\bin\Debug\OutPutFileTask4V13.txt";
                File.WriteAllText(path, textBoxResult_PMA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
