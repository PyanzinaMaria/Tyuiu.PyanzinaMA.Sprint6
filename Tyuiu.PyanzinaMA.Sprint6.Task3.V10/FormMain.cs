using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task3.V10.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.Task3.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                           { -19, 3, 12, -11, 19 },
                                           { -20, 11, 9, 19, -19 },
                                           { -20, 10, -9, 17, 9 },
                                           { -4, 9, -8, 13, -8 } };
        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewOutPut_PMA.ColumnCount = columns;
            dataGridViewOutPut_PMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutPut_PMA.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_PMA.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }
        }

        private void buttonDone_PMA_Leave(object sender, EventArgs e)
        {
            buttonDone_PMA.BackColor = Color.DeepSkyBlue;
        }

        private void buttonDone_PMA_Down(object sender, MouseEventArgs e)
        {
            buttonDone_PMA.BackColor = Color.DeepSkyBlue;
        }

        private void buttonDone_PMA_Enter(object sender, EventArgs e)
        {
            buttonDone_PMA.BackColor = Color.LightGreen;
        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewInPut_PMA.ColumnCount = columns;
            dataGridViewInPut_PMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_PMA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut_PMA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
