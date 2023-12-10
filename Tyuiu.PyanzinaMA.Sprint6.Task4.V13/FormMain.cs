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
        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDo_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_PMA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_PMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PMA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PMA.Text = "";

                chartFunction_PMA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_PMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_PMA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
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
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V13.txt";
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
        
        private void buttonDo_PMA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDo_PMA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonSave_PMA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSave_PMA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonHelp_PMA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_PMA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
