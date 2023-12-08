using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task2.V20.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.Task2.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PMA.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_PMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_PMA.Titles.Add("График функции");

                this.chartResult_PMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_PMA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_PMA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult_PMA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Leave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.LightGreen;
        }

        private void buttonDone_Enter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Tomato;
        }

        private void buttonDone_Down(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.LightGreen;
        }
    }
}
