
namespace Tyuiu.PyanzinaMA.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_PMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_PMA = new System.Windows.Forms.Button();
            this.chartFunction_PMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_PMA = new System.Windows.Forms.Button();
            this.labelCondition_PMA = new System.Windows.Forms.Label();
            this.pictureBoxCondition_PMA = new System.Windows.Forms.PictureBox();
            this.textBoxStart_PMA = new System.Windows.Forms.TextBox();
            this.textBoxStop_PMA = new System.Windows.Forms.TextBox();
            this.labelStart_PMA = new System.Windows.Forms.Label();
            this.labelStop_PMA = new System.Windows.Forms.Label();
            this.buttonSave_PMA = new System.Windows.Forms.Button();
            this.textBoxResult_PMA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_PMA.SuspendLayout();
            this.groupBoxInPut_PMA.SuspendLayout();
            this.groupBoxOutPut_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_PMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            this.groupBoxCondition_PMA.Controls.Add(this.pictureBoxCondition_PMA);
            this.groupBoxCondition_PMA.Controls.Add(this.labelCondition_PMA);
            this.groupBoxCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_PMA.Location = new System.Drawing.Point(14, 18);
            this.groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            this.groupBoxCondition_PMA.Size = new System.Drawing.Size(392, 148);
            this.groupBoxCondition_PMA.TabIndex = 0;
            this.groupBoxCondition_PMA.TabStop = false;
            this.groupBoxCondition_PMA.Text = "Условие";
            // 
            // groupBoxInPut_PMA
            // 
            this.groupBoxInPut_PMA.Controls.Add(this.labelStop_PMA);
            this.groupBoxInPut_PMA.Controls.Add(this.labelStart_PMA);
            this.groupBoxInPut_PMA.Controls.Add(this.textBoxStop_PMA);
            this.groupBoxInPut_PMA.Controls.Add(this.textBoxStart_PMA);
            this.groupBoxInPut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_PMA.Location = new System.Drawing.Point(14, 172);
            this.groupBoxInPut_PMA.Name = "groupBoxInPut_PMA";
            this.groupBoxInPut_PMA.Size = new System.Drawing.Size(392, 129);
            this.groupBoxInPut_PMA.TabIndex = 0;
            this.groupBoxInPut_PMA.TabStop = false;
            this.groupBoxInPut_PMA.Text = "Ввод данных";
            // 
            // groupBoxOutPut_PMA
            // 
            this.groupBoxOutPut_PMA.Controls.Add(this.textBoxResult_PMA);
            this.groupBoxOutPut_PMA.Controls.Add(this.chartFunction_PMA);
            this.groupBoxOutPut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_PMA.Location = new System.Drawing.Point(425, 18);
            this.groupBoxOutPut_PMA.Name = "groupBoxOutPut_PMA";
            this.groupBoxOutPut_PMA.Size = new System.Drawing.Size(475, 332);
            this.groupBoxOutPut_PMA.TabIndex = 0;
            this.groupBoxOutPut_PMA.TabStop = false;
            this.groupBoxOutPut_PMA.Text = "Результат";
            // 
            // buttonDone_PMA
            // 
            this.buttonDone_PMA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PMA.Location = new System.Drawing.Point(14, 307);
            this.buttonDone_PMA.Name = "buttonDone_PMA";
            this.buttonDone_PMA.Size = new System.Drawing.Size(152, 43);
            this.buttonDone_PMA.TabIndex = 1;
            this.buttonDone_PMA.Text = "Выполнить";
            this.buttonDone_PMA.UseVisualStyleBackColor = false;
            this.buttonDone_PMA.Click += new System.EventHandler(this.buttonDone_PMA_Click);
            // 
            // chartFunction_PMA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PMA.Legends.Add(legend1);
            this.chartFunction_PMA.Location = new System.Drawing.Point(146, 25);
            this.chartFunction_PMA.Name = "chartFunction_PMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PMA.Series.Add(series1);
            this.chartFunction_PMA.Size = new System.Drawing.Size(323, 288);
            this.chartFunction_PMA.TabIndex = 2;
            this.chartFunction_PMA.Text = "chart1";
            // 
            // buttonHelp_PMA
            // 
            this.buttonHelp_PMA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonHelp_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PMA.Location = new System.Drawing.Point(326, 307);
            this.buttonHelp_PMA.Name = "buttonHelp_PMA";
            this.buttonHelp_PMA.Size = new System.Drawing.Size(80, 43);
            this.buttonHelp_PMA.TabIndex = 1;
            this.buttonHelp_PMA.Text = "?";
            this.buttonHelp_PMA.UseVisualStyleBackColor = false;
            this.buttonHelp_PMA.Click += new System.EventHandler(this.buttonHelp_PMA_Click);
            // 
            // labelCondition_PMA
            // 
            this.labelCondition_PMA.AutoSize = true;
            this.labelCondition_PMA.Location = new System.Drawing.Point(6, 22);
            this.labelCondition_PMA.Name = "labelCondition_PMA";
            this.labelCondition_PMA.Size = new System.Drawing.Size(379, 60);
            this.labelCondition_PMA.TabIndex = 0;
            this.labelCondition_PMA.Text = "Написать программу, которая выводит таблицу \r\nзначений функции f(x) с шагом 1 на " +
    "заданном \r\nпромежутке.";
            // 
            // pictureBoxCondition_PMA
            // 
            this.pictureBoxCondition_PMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_PMA.Image")));
            this.pictureBoxCondition_PMA.Location = new System.Drawing.Point(10, 85);
            this.pictureBoxCondition_PMA.Name = "pictureBoxCondition_PMA";
            this.pictureBoxCondition_PMA.Size = new System.Drawing.Size(243, 42);
            this.pictureBoxCondition_PMA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCondition_PMA.TabIndex = 1;
            this.pictureBoxCondition_PMA.TabStop = false;
            // 
            // textBoxStart_PMA
            // 
            this.textBoxStart_PMA.Location = new System.Drawing.Point(125, 37);
            this.textBoxStart_PMA.Name = "textBoxStart_PMA";
            this.textBoxStart_PMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_PMA.TabIndex = 0;
            // 
            // textBoxStop_PMA
            // 
            this.textBoxStop_PMA.Location = new System.Drawing.Point(125, 73);
            this.textBoxStop_PMA.Name = "textBoxStop_PMA";
            this.textBoxStop_PMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop_PMA.TabIndex = 0;
            // 
            // labelStart_PMA
            // 
            this.labelStart_PMA.AutoSize = true;
            this.labelStart_PMA.Location = new System.Drawing.Point(6, 40);
            this.labelStart_PMA.Name = "labelStart_PMA";
            this.labelStart_PMA.Size = new System.Drawing.Size(113, 20);
            this.labelStart_PMA.TabIndex = 1;
            this.labelStart_PMA.Text = "Начало шага:";
            // 
            // labelStop_PMA
            // 
            this.labelStop_PMA.AutoSize = true;
            this.labelStop_PMA.Location = new System.Drawing.Point(6, 76);
            this.labelStop_PMA.Name = "labelStop_PMA";
            this.labelStop_PMA.Size = new System.Drawing.Size(101, 20);
            this.labelStop_PMA.TabIndex = 1;
            this.labelStop_PMA.Text = "Конец шага:";
            // 
            // buttonSave_PMA
            // 
            this.buttonSave_PMA.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSave_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_PMA.Location = new System.Drawing.Point(172, 307);
            this.buttonSave_PMA.Name = "buttonSave_PMA";
            this.buttonSave_PMA.Size = new System.Drawing.Size(148, 43);
            this.buttonSave_PMA.TabIndex = 1;
            this.buttonSave_PMA.Text = "Сохранить";
            this.buttonSave_PMA.UseVisualStyleBackColor = false;
            this.buttonSave_PMA.Click += new System.EventHandler(this.buttonSave_PMA_Click);
            // 
            // textBoxResult_PMA
            // 
            this.textBoxResult_PMA.Location = new System.Drawing.Point(16, 25);
            this.textBoxResult_PMA.Multiline = true;
            this.textBoxResult_PMA.Name = "textBoxResult_PMA";
            this.textBoxResult_PMA.Size = new System.Drawing.Size(100, 288);
            this.textBoxResult_PMA.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 361);
            this.Controls.Add(this.buttonHelp_PMA);
            this.Controls.Add(this.buttonSave_PMA);
            this.Controls.Add(this.buttonDone_PMA);
            this.Controls.Add(this.groupBoxOutPut_PMA);
            this.Controls.Add(this.groupBoxInPut_PMA);
            this.Controls.Add(this.groupBoxCondition_PMA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 13 | Пьянзина М.А.";
            this.groupBoxCondition_PMA.ResumeLayout(false);
            this.groupBoxCondition_PMA.PerformLayout();
            this.groupBoxInPut_PMA.ResumeLayout(false);
            this.groupBoxInPut_PMA.PerformLayout();
            this.groupBoxOutPut_PMA.ResumeLayout(false);
            this.groupBoxOutPut_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_PMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PMA;
        private System.Windows.Forms.PictureBox pictureBoxCondition_PMA;
        private System.Windows.Forms.Label labelCondition_PMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_PMA;
        private System.Windows.Forms.Label labelStop_PMA;
        private System.Windows.Forms.Label labelStart_PMA;
        private System.Windows.Forms.TextBox textBoxStop_PMA;
        private System.Windows.Forms.TextBox textBoxStart_PMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PMA;
        private System.Windows.Forms.TextBox textBoxResult_PMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PMA;
        private System.Windows.Forms.Button buttonDone_PMA;
        private System.Windows.Forms.Button buttonHelp_PMA;
        private System.Windows.Forms.Button buttonSave_PMA;
    }
}

