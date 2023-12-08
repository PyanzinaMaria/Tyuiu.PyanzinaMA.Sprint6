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

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {

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
    }
}
