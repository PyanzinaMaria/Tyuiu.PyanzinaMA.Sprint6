using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task5.V28.Lib;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint6.Task5.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.PyanzinaMA.Sprint6\Tyuiu.BelovaEA.Sprint6.Task5.V28\bin\Debug\InPutFileTask5V28.txt";

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_PMA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_PMA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonDo_PMA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDo_PMA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonOpen_PMA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpen_PMA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDo_PMA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_PMA.ColumnCount = 2;
            dataGridViewNums_PMA.Columns[0].Width = 20;
            dataGridViewNums_PMA.Columns[1].Width = 50;

            this.chartDiag_PMA.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartDiag_PMA.ChartAreas[0].AxisY.Title = " Ось Y";

            chartDiag_PMA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_PMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_PMA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_PMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
