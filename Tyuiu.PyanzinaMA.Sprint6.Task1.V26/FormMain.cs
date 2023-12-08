using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task1.V26.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void labelCondition_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PMA.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_PMA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_PMA.Text = "";
                textBoxResult_PMA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PMA.AppendText("|    X       |    f(x)     |" + Environment.NewLine);
                textBoxResult_PMA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}       |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_PMA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_PMA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
        
    
