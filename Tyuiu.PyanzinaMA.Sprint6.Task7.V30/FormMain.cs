using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PMA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PMA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(openFilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_PMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PMA.ShowDialog();
            openFilePath = openFileDialogTask_PMA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_PMA.ColumnCount = columns;
            dataGridViewIn_PMA.RowCount = rows;
            dataGridViewOut_PMA.ColumnCount = columns;
            dataGridViewOut_PMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_PMA.Columns[i].Width = 25;
                dataGridViewOut_PMA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_PMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_PMA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_PMA.ColumnCount = 50;
            dataGridViewOut_PMA.ColumnCount = 50;

            dataGridViewOut_PMA.RowCount = 50;
            dataGridViewIn_PMA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_PMA.Columns[i].Width = 25;
                dataGridViewOut_PMA.Columns[i].Width = 25;
            }
        }

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_PMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_PMA.Enabled = true;
        }

        private void buttonSave_PMA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PMA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PMA.ShowDialog();

            string path = saveFileDialogMatrix_PMA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_PMA.RowCount;
            int columns = dataGridViewOut_PMA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_PMA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_PMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_PMA_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void toolTip_PMA(object sender, PopupEventArgs e)
        {

        }
    }
}
