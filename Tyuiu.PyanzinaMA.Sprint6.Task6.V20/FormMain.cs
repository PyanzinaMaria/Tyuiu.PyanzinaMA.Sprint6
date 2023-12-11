using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLoad_PMA_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask_PMA.ShowDialog();
            openFilePath = openFileDialogTask_PMA.FileName;

            textBoxIn_PMA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_PMA.Text = textBoxOut_PMA.Text + " " + openFileDialogTask_PMA.FileName;
            buttonLoad_PMA.Enabled = true;
        }

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            textBoxOut_PMA.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
