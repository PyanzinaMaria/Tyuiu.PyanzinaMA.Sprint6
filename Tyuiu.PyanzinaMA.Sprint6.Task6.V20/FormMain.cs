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
        
        private void buttonLoadFile_PMA_Click(object sender, EventArgs e)
        {
            textBoxOut_PMA.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonOpenFile_PMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PMA.ShowDialog();
            openFilePath = openFileDialogTask_PMA.FileName;


            textBoxIn_PMA.Text = File.ReadAllText(openFilePath);
            groupBoxInputData_PMA.Text = textBoxOut_PMA.Text + " " + openFileDialogTask_PMA.FileName;
            buttonLoadFile_PMA.Enabled = true;
        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
