
namespace Tyuiu.PyanzinaMA.Sprint6.Task6.V20
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_PMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_PMA = new System.Windows.Forms.Button();
            this.buttonLoad_PMA = new System.Windows.Forms.Button();
            this.buttonHelp_PMA = new System.Windows.Forms.Button();
            this.textBoxOut_PMA = new System.Windows.Forms.TextBox();
            this.labelCondition_PMA = new System.Windows.Forms.Label();
            this.groupBoxInPut_PMA = new System.Windows.Forms.GroupBox();
            this.textBoxIn_PMA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_PMA = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCondition_PMA.SuspendLayout();
            this.groupBoxResult_PMA.SuspendLayout();
            this.groupBoxInPut_PMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            this.groupBoxCondition_PMA.Controls.Add(this.labelCondition_PMA);
            this.groupBoxCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_PMA.Location = new System.Drawing.Point(16, 19);
            this.groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            this.groupBoxCondition_PMA.Size = new System.Drawing.Size(399, 253);
            this.groupBoxCondition_PMA.TabIndex = 0;
            this.groupBoxCondition_PMA.TabStop = false;
            this.groupBoxCondition_PMA.Text = "Условие";
            // 
            // groupBoxResult_PMA
            // 
            this.groupBoxResult_PMA.Controls.Add(this.textBoxOut_PMA);
            this.groupBoxResult_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_PMA.Location = new System.Drawing.Point(433, 179);
            this.groupBoxResult_PMA.Name = "groupBoxResult_PMA";
            this.groupBoxResult_PMA.Size = new System.Drawing.Size(355, 143);
            this.groupBoxResult_PMA.TabIndex = 0;
            this.groupBoxResult_PMA.TabStop = false;
            this.groupBoxResult_PMA.Text = "Результат";
            // 
            // buttonDone_PMA
            // 
            this.buttonDone_PMA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PMA.Location = new System.Drawing.Point(16, 278);
            this.buttonDone_PMA.Name = "buttonDone_PMA";
            this.buttonDone_PMA.Size = new System.Drawing.Size(157, 44);
            this.buttonDone_PMA.TabIndex = 1;
            this.buttonDone_PMA.Text = "Выполнить";
            this.buttonDone_PMA.UseVisualStyleBackColor = false;
            this.buttonDone_PMA.Click += new System.EventHandler(this.buttonDone_PMA_Click);
            // 
            // buttonLoad_PMA
            // 
            this.buttonLoad_PMA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLoad_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad_PMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad_PMA.Image")));
            this.buttonLoad_PMA.Location = new System.Drawing.Point(179, 278);
            this.buttonLoad_PMA.Name = "buttonLoad_PMA";
            this.buttonLoad_PMA.Size = new System.Drawing.Size(144, 44);
            this.buttonLoad_PMA.TabIndex = 1;
            this.buttonLoad_PMA.UseVisualStyleBackColor = false;
            this.buttonLoad_PMA.Click += new System.EventHandler(this.buttonLoad_PMA_Click);
            // 
            // buttonHelp_PMA
            // 
            this.buttonHelp_PMA.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonHelp_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PMA.Location = new System.Drawing.Point(329, 278);
            this.buttonHelp_PMA.Name = "buttonHelp_PMA";
            this.buttonHelp_PMA.Size = new System.Drawing.Size(86, 44);
            this.buttonHelp_PMA.TabIndex = 1;
            this.buttonHelp_PMA.Text = "?";
            this.buttonHelp_PMA.UseVisualStyleBackColor = false;
            this.buttonHelp_PMA.Click += new System.EventHandler(this.buttonHelp_PMA_Click);
            // 
            // textBoxOut_PMA
            // 
            this.textBoxOut_PMA.Location = new System.Drawing.Point(6, 25);
            this.textBoxOut_PMA.Multiline = true;
            this.textBoxOut_PMA.Name = "textBoxOut_PMA";
            this.textBoxOut_PMA.Size = new System.Drawing.Size(343, 103);
            this.textBoxOut_PMA.TabIndex = 0;
            // 
            // labelCondition_PMA
            // 
            this.labelCondition_PMA.AutoSize = true;
            this.labelCondition_PMA.Location = new System.Drawing.Point(6, 25);
            this.labelCondition_PMA.Name = "labelCondition_PMA";
            this.labelCondition_PMA.Size = new System.Drawing.Size(376, 100);
            this.labelCondition_PMA.TabIndex = 0;
            this.labelCondition_PMA.Text = "Дан файл, который может находиться в любом \r\nместе на диске. Загрузить файл в Tex" +
    "tBoxIn\r\nчерез openFileDialog. Вывести второе слово \r\nкаждой строки в результирую" +
    "щую строку и \r\nвывести её в textBoxOut.";
            // 
            // groupBoxInPut_PMA
            // 
            this.groupBoxInPut_PMA.Controls.Add(this.textBoxIn_PMA);
            this.groupBoxInPut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_PMA.Location = new System.Drawing.Point(433, 19);
            this.groupBoxInPut_PMA.Name = "groupBoxInPut_PMA";
            this.groupBoxInPut_PMA.Size = new System.Drawing.Size(355, 154);
            this.groupBoxInPut_PMA.TabIndex = 0;
            this.groupBoxInPut_PMA.TabStop = false;
            this.groupBoxInPut_PMA.Text = "Ввод данных";
            // 
            // textBoxIn_PMA
            // 
            this.textBoxIn_PMA.Location = new System.Drawing.Point(6, 25);
            this.textBoxIn_PMA.Multiline = true;
            this.textBoxIn_PMA.Name = "textBoxIn_PMA";
            this.textBoxIn_PMA.Size = new System.Drawing.Size(343, 123);
            this.textBoxIn_PMA.TabIndex = 0;
            // 
            // openFileDialogTask_PMA
            // 
            this.openFileDialogTask_PMA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.buttonHelp_PMA);
            this.Controls.Add(this.buttonLoad_PMA);
            this.Controls.Add(this.buttonDone_PMA);
            this.Controls.Add(this.groupBoxInPut_PMA);
            this.Controls.Add(this.groupBoxResult_PMA);
            this.Controls.Add(this.groupBoxCondition_PMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Пьянзина М.А.";
            this.groupBoxCondition_PMA.ResumeLayout(false);
            this.groupBoxCondition_PMA.PerformLayout();
            this.groupBoxResult_PMA.ResumeLayout(false);
            this.groupBoxResult_PMA.PerformLayout();
            this.groupBoxInPut_PMA.ResumeLayout(false);
            this.groupBoxInPut_PMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PMA;
        private System.Windows.Forms.Label labelCondition_PMA;
        private System.Windows.Forms.GroupBox groupBoxResult_PMA;
        private System.Windows.Forms.TextBox textBoxOut_PMA;
        private System.Windows.Forms.Button buttonDone_PMA;
        private System.Windows.Forms.Button buttonLoad_PMA;
        private System.Windows.Forms.Button buttonHelp_PMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_PMA;
        private System.Windows.Forms.TextBox textBoxIn_PMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PMA;
    }
}

