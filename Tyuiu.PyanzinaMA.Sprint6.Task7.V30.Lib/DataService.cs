using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int xCol = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if (arrayValues[r, c] != 4)
                    {
                        arrayValues[r, c] = 8;
                    }
                }
            }
            return arrayValues;
        }
    }
}
