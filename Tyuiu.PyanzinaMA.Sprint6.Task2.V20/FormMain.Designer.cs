
namespace Tyuiu.PyanzinaMA.Sprint6.Task2.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_PMA = new System.Windows.Forms.GroupBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp_PMA = new System.Windows.Forms.Button();
            this.labelCondition_PMA = new System.Windows.Forms.Label();
            this.pictureBoxCondition = new System.Windows.Forms.PictureBox();
            this.textBoxStart_PMA = new System.Windows.Forms.TextBox();
            this.textBoxEnd_PMA = new System.Windows.Forms.TextBox();
            this.labelStart_PMA = new System.Windows.Forms.Label();
            this.labelEnd_PMA = new System.Windows.Forms.Label();
            this.dataGridViewResult_PMA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult_PMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_PMA.SuspendLayout();
            this.groupBoxOutPut_PMA.SuspendLayout();
            this.groupBoxInPut_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            this.groupBoxCondition_PMA.Controls.Add(this.pictureBoxCondition);
            this.groupBoxCondition_PMA.Controls.Add(this.labelCondition_PMA);
            this.groupBoxCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_PMA.Location = new System.Drawing.Point(15, 19);
            this.groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            this.groupBoxCondition_PMA.Size = new System.Drawing.Size(450, 262);
            this.groupBoxCondition_PMA.TabIndex = 0;
            this.groupBoxCondition_PMA.TabStop = false;
            this.groupBoxCondition_PMA.Text = "Условие";
            // 
            // groupBoxOutPut_PMA
            // 
            this.groupBoxOutPut_PMA.Controls.Add(this.chartResult_PMA);
            this.groupBoxOutPut_PMA.Controls.Add(this.dataGridViewResult_PMA);
            this.groupBoxOutPut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_PMA.Location = new System.Drawing.Point(486, 19);
            this.groupBoxOutPut_PMA.Name = "groupBoxOutPut_PMA";
            this.groupBoxOutPut_PMA.Size = new System.Drawing.Size(649, 419);
            this.groupBoxOutPut_PMA.TabIndex = 0;
            this.groupBoxOutPut_PMA.TabStop = false;
            this.groupBoxOutPut_PMA.Text = "Результат";
            // 
            // groupBoxInPut_PMA
            // 
            this.groupBoxInPut_PMA.Controls.Add(this.labelEnd_PMA);
            this.groupBoxInPut_PMA.Controls.Add(this.labelStart_PMA);
            this.groupBoxInPut_PMA.Controls.Add(this.textBoxEnd_PMA);
            this.groupBoxInPut_PMA.Controls.Add(this.textBoxStart_PMA);
            this.groupBoxInPut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_PMA.Location = new System.Drawing.Point(15, 287);
            this.groupBoxInPut_PMA.Name = "groupBoxInPut_PMA";
            this.groupBoxInPut_PMA.Size = new System.Drawing.Size(450, 95);
            this.groupBoxInPut_PMA.TabIndex = 0;
            this.groupBoxInPut_PMA.TabStop = false;
            this.groupBoxInPut_PMA.Text = "Ввод данных";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.Location = new System.Drawing.Point(15, 398);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(335, 40);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_Down);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_Enter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_Leave);
            // 
            // buttonHelp_PMA
            // 
            this.buttonHelp_PMA.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonHelp_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PMA.Location = new System.Drawing.Point(366, 398);
            this.buttonHelp_PMA.Name = "buttonHelp_PMA";
            this.buttonHelp_PMA.Size = new System.Drawing.Size(99, 40);
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
            this.labelCondition_PMA.Size = new System.Drawing.Size(443, 80);
            this.labelCondition_PMA.TabIndex = 0;
            this.labelCondition_PMA.Text = resources.GetString("labelCondition_PMA.Text");
            this.labelCondition_PMA.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxCondition
            // 
            this.pictureBoxCondition.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition.Image")));
            this.pictureBoxCondition.Location = new System.Drawing.Point(10, 114);
            this.pictureBoxCondition.Name = "pictureBoxCondition";
            this.pictureBoxCondition.Size = new System.Drawing.Size(303, 38);
            this.pictureBoxCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCondition.TabIndex = 1;
            this.pictureBoxCondition.TabStop = false;
            // 
            // textBoxStart_PMA
            // 
            this.textBoxStart_PMA.Location = new System.Drawing.Point(114, 28);
            this.textBoxStart_PMA.Name = "textBoxStart_PMA";
            this.textBoxStart_PMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_PMA.TabIndex = 0;
            // 
            // textBoxEnd_PMA
            // 
            this.textBoxEnd_PMA.Location = new System.Drawing.Point(114, 57);
            this.textBoxEnd_PMA.Name = "textBoxEnd_PMA";
            this.textBoxEnd_PMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxEnd_PMA.TabIndex = 0;
            // 
            // labelStart_PMA
            // 
            this.labelStart_PMA.AutoSize = true;
            this.labelStart_PMA.Location = new System.Drawing.Point(6, 31);
            this.labelStart_PMA.Name = "labelStart_PMA";
            this.labelStart_PMA.Size = new System.Drawing.Size(102, 20);
            this.labelStart_PMA.TabIndex = 1;
            this.labelStart_PMA.Text = "Старт шага:";
            // 
            // labelEnd_PMA
            // 
            this.labelEnd_PMA.AutoSize = true;
            this.labelEnd_PMA.Location = new System.Drawing.Point(6, 60);
            this.labelEnd_PMA.Name = "labelEnd_PMA";
            this.labelEnd_PMA.Size = new System.Drawing.Size(101, 20);
            this.labelEnd_PMA.TabIndex = 1;
            this.labelEnd_PMA.Text = "Конец шага:";
            // 
            // dataGridViewResult_PMA
            // 
            this.dataGridViewResult_PMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResult_PMA.Location = new System.Drawing.Point(19, 25);
            this.dataGridViewResult_PMA.Name = "dataGridViewResult_PMA";
            this.dataGridViewResult_PMA.RowHeadersVisible = false;
            this.dataGridViewResult_PMA.Size = new System.Drawing.Size(128, 388);
            this.dataGridViewResult_PMA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 70;
            // 
            // chartResult_PMA
            // 
            chartArea8.Name = "ChartArea1";
            this.chartResult_PMA.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartResult_PMA.Legends.Add(legend8);
            this.chartResult_PMA.Location = new System.Drawing.Point(163, 25);
            this.chartResult_PMA.Name = "chartResult_PMA";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartResult_PMA.Series.Add(series8);
            this.chartResult_PMA.Size = new System.Drawing.Size(470, 388);
            this.chartResult_PMA.TabIndex = 1;
            this.chartResult_PMA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.buttonHelp_PMA);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPut_PMA);
            this.Controls.Add(this.groupBoxInPut_PMA);
            this.Controls.Add(this.groupBoxCondition_PMA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 20 | Пьянзина М.А.";
            this.groupBoxCondition_PMA.ResumeLayout(false);
            this.groupBoxCondition_PMA.PerformLayout();
            this.groupBoxOutPut_PMA.ResumeLayout(false);
            this.groupBoxInPut_PMA.ResumeLayout(false);
            this.groupBoxInPut_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PMA;
        private System.Windows.Forms.Label labelCondition_PMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_PMA;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp_PMA;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_PMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_PMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label labelEnd_PMA;
        private System.Windows.Forms.Label labelStart_PMA;
        private System.Windows.Forms.TextBox textBoxEnd_PMA;
        private System.Windows.Forms.TextBox textBoxStart_PMA;
    }
}

