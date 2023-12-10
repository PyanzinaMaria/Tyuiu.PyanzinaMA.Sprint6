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
            openFileDialogTask_PMA.Filter = "Значения, разделённые запятыми(*.csv)|*.scv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PMA.Filter = "Значения, разделённые запятыми(*.csv)|*.scv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

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


        private void buttonOpenFile_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_PMA.ShowDialog();
                openFilePath = openFileDialogTask_PMA.FileName;

                int[,] arrayValues = new int[rows, columns];

                arrayValues = LoadFromFileData(openFilePath);

                dataGridViewInMatrix_PMA.ColumnCount = columns;
                dataGridViewInMatrix_PMA.RowCount = rows;
                dataGridViewOutMatrix_PMA.ColumnCount = columns;
                dataGridViewOutMatrix_PMA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInMatrix_PMA.Columns[i].Width = 40;
                    dataGridViewOutMatrix_PMA.Columns[i].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInMatrix_PMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                arrayValues = ds.GetMatrix(openFilePath);
                buttonDone_PMA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dataGridViewOutMatrix_PMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_PMA.Enabled = true;
        }

        private void buttonSaveFile_PMA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PMA.FileName = "OutPutFileTask7V30.csv";
            saveFileDialogMatrix_PMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PMA.ShowDialog();

            string path = saveFileDialogMatrix_PMA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_PMA.RowCount;
            int columns = dataGridViewOutMatrix_PMA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutMatrix_PMA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutMatrix_PMA.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_PMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMA.ToolTipTitle = "Выполнить";
        }

        private void buttonDone_PMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMA.ToolTipTitle = "Выполнить";
        }
        
        private void buttonSaveFile_PMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_PMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMA.ToolTipTitle = "Справка";
        }
    }
}
