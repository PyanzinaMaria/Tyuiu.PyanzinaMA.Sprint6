
namespace Tyuiu.PyanzinaMA.Sprint6.Task5.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_PMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_PMA = new System.Windows.Forms.Button();
            this.buttonHelp_PMA = new System.Windows.Forms.Button();
            this.dataGridViewResult_PMA = new System.Windows.Forms.DataGridView();
            this.buttonOpen_PMA = new System.Windows.Forms.Button();
            this.chartResult_PMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCondition_PMA = new System.Windows.Forms.Label();
            this.groupBoxCondition_PMA.SuspendLayout();
            this.groupBoxResult_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            this.groupBoxCondition_PMA.Controls.Add(this.labelCondition_PMA);
            this.groupBoxCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_PMA.Location = new System.Drawing.Point(16, 18);
            this.groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            this.groupBoxCondition_PMA.Size = new System.Drawing.Size(362, 289);
            this.groupBoxCondition_PMA.TabIndex = 0;
            this.groupBoxCondition_PMA.TabStop = false;
            this.groupBoxCondition_PMA.Text = "Условие";
            // 
            // groupBoxResult_PMA
            // 
            this.groupBoxResult_PMA.Controls.Add(this.chartResult_PMA);
            this.groupBoxResult_PMA.Controls.Add(this.dataGridViewResult_PMA);
            this.groupBoxResult_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_PMA.Location = new System.Drawing.Point(395, 18);
            this.groupBoxResult_PMA.Name = "groupBoxResult_PMA";
            this.groupBoxResult_PMA.Size = new System.Drawing.Size(563, 344);
            this.groupBoxResult_PMA.TabIndex = 0;
            this.groupBoxResult_PMA.TabStop = false;
            this.groupBoxResult_PMA.Text = "Результат";
            // 
            // buttonDone_PMA
            // 
            this.buttonDone_PMA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PMA.Location = new System.Drawing.Point(16, 313);
            this.buttonDone_PMA.Name = "buttonDone_PMA";
            this.buttonDone_PMA.Size = new System.Drawing.Size(159, 49);
            this.buttonDone_PMA.TabIndex = 1;
            this.buttonDone_PMA.Text = "Выполнить";
            this.buttonDone_PMA.UseVisualStyleBackColor = false;
            this.buttonDone_PMA.Click += new System.EventHandler(this.buttonDone_PMA_Click);
            // 
            // buttonHelp_PMA
            // 
            this.buttonHelp_PMA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonHelp_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PMA.Location = new System.Drawing.Point(304, 313);
            this.buttonHelp_PMA.Name = "buttonHelp_PMA";
            this.buttonHelp_PMA.Size = new System.Drawing.Size(74, 49);
            this.buttonHelp_PMA.TabIndex = 1;
            this.buttonHelp_PMA.Text = "?";
            this.buttonHelp_PMA.UseVisualStyleBackColor = false;
            this.buttonHelp_PMA.Click += new System.EventHandler(this.buttonHelp_PMA_Click);
            // 
            // dataGridViewResult_PMA
            // 
            this.dataGridViewResult_PMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PMA.ColumnHeadersVisible = false;
            this.dataGridViewResult_PMA.Location = new System.Drawing.Point(25, 25);
            this.dataGridViewResult_PMA.Name = "dataGridViewResult_PMA";
            this.dataGridViewResult_PMA.RowHeadersVisible = false;
            this.dataGridViewResult_PMA.Size = new System.Drawing.Size(145, 300);
            this.dataGridViewResult_PMA.TabIndex = 0;
            // 
            // buttonOpen_PMA
            // 
            this.buttonOpen_PMA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonOpen_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_PMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_PMA.Image")));
            this.buttonOpen_PMA.Location = new System.Drawing.Point(181, 313);
            this.buttonOpen_PMA.Name = "buttonOpen_PMA";
            this.buttonOpen_PMA.Size = new System.Drawing.Size(117, 49);
            this.buttonOpen_PMA.TabIndex = 1;
            this.buttonOpen_PMA.UseVisualStyleBackColor = false;
            this.buttonOpen_PMA.Click += new System.EventHandler(this.buttonOpen_PMA_Click);
            // 
            // chartResult_PMA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_PMA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_PMA.Legends.Add(legend2);
            this.chartResult_PMA.Location = new System.Drawing.Point(199, 25);
            this.chartResult_PMA.Name = "chartResult_PMA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_PMA.Series.Add(series2);
            this.chartResult_PMA.Size = new System.Drawing.Size(344, 300);
            this.chartResult_PMA.TabIndex = 1;
            this.chartResult_PMA.Text = "chart1";
            // 
            // labelCondition_PMA
            // 
            this.labelCondition_PMA.AutoSize = true;
            this.labelCondition_PMA.Location = new System.Drawing.Point(9, 40);
            this.labelCondition_PMA.Name = "labelCondition_PMA";
            this.labelCondition_PMA.Size = new System.Drawing.Size(273, 100);
            this.labelCondition_PMA.TabIndex = 0;
            this.labelCondition_PMA.Text = "Прочитать данные из файла \r\nInPutFileTask5V28.txt. Вывести в \r\nDataGridView. Выве" +
    "сти все числа, \r\nменьше 10. Построить диаграмму \r\nпо эти значениям.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 374);
            this.Controls.Add(this.buttonOpen_PMA);
            this.Controls.Add(this.buttonHelp_PMA);
            this.Controls.Add(this.buttonDone_PMA);
            this.Controls.Add(this.groupBoxResult_PMA);
            this.Controls.Add(this.groupBoxCondition_PMA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 28 | Пьянзина М.А.";
            this.groupBoxCondition_PMA.ResumeLayout(false);
            this.groupBoxCondition_PMA.PerformLayout();
            this.groupBoxResult_PMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PMA;
        private System.Windows.Forms.Label labelCondition_PMA;
        private System.Windows.Forms.GroupBox groupBoxResult_PMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_PMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_PMA;
        private System.Windows.Forms.Button buttonDone_PMA;
        private System.Windows.Forms.Button buttonHelp_PMA;
        private System.Windows.Forms.Button buttonOpen_PMA;
    }
}

