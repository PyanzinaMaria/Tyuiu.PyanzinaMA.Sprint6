
namespace Tyuiu.PyanzinaMA.Sprint6.Task3.V10
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
            this.groupBoxCondition_PMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_PMA = new System.Windows.Forms.DataGridView();
            this.labelCondition_PMA = new System.Windows.Forms.Label();
            this.groupBoxOutPut_PMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_PMA = new System.Windows.Forms.DataGridView();
            this.buttonDone_PMA = new System.Windows.Forms.Button();
            this.buttonHelp_PMA = new System.Windows.Forms.Button();
            this.groupBoxCondition_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_PMA)).BeginInit();
            this.groupBoxOutPut_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_PMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            this.groupBoxCondition_PMA.Controls.Add(this.dataGridViewInPut_PMA);
            this.groupBoxCondition_PMA.Controls.Add(this.labelCondition_PMA);
            this.groupBoxCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_PMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            this.groupBoxCondition_PMA.Size = new System.Drawing.Size(485, 356);
            this.groupBoxCondition_PMA.TabIndex = 0;
            this.groupBoxCondition_PMA.TabStop = false;
            this.groupBoxCondition_PMA.Text = "Условие";
            // 
            // dataGridViewInPut_PMA
            // 
            this.dataGridViewInPut_PMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_PMA.ColumnHeadersVisible = false;
            this.dataGridViewInPut_PMA.Location = new System.Drawing.Point(93, 67);
            this.dataGridViewInPut_PMA.Name = "dataGridViewInPut_PMA";
            this.dataGridViewInPut_PMA.RowHeadersVisible = false;
            this.dataGridViewInPut_PMA.Size = new System.Drawing.Size(248, 232);
            this.dataGridViewInPut_PMA.TabIndex = 1;
            // 
            // labelCondition_PMA
            // 
            this.labelCondition_PMA.AutoSize = true;
            this.labelCondition_PMA.Location = new System.Drawing.Point(6, 22);
            this.labelCondition_PMA.Name = "labelCondition_PMA";
            this.labelCondition_PMA.Size = new System.Drawing.Size(469, 40);
            this.labelCondition_PMA.TabIndex = 0;
            this.labelCondition_PMA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в \r\nпятой строке на 0. Резу" +
    "льтат вывести в DataGridView.";
            // 
            // groupBoxOutPut_PMA
            // 
            this.groupBoxOutPut_PMA.Controls.Add(this.dataGridViewOutPut_PMA);
            this.groupBoxOutPut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_PMA.Location = new System.Drawing.Point(513, 12);
            this.groupBoxOutPut_PMA.Name = "groupBoxOutPut_PMA";
            this.groupBoxOutPut_PMA.Size = new System.Drawing.Size(325, 422);
            this.groupBoxOutPut_PMA.TabIndex = 0;
            this.groupBoxOutPut_PMA.TabStop = false;
            this.groupBoxOutPut_PMA.Text = "Результат";
            // 
            // dataGridViewOutPut_PMA
            // 
            this.dataGridViewOutPut_PMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_PMA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_PMA.Location = new System.Drawing.Point(18, 35);
            this.dataGridViewOutPut_PMA.Name = "dataGridViewOutPut_PMA";
            this.dataGridViewOutPut_PMA.RowHeadersVisible = false;
            this.dataGridViewOutPut_PMA.Size = new System.Drawing.Size(289, 264);
            this.dataGridViewOutPut_PMA.TabIndex = 1;
            // 
            // buttonDone_PMA
            // 
            this.buttonDone_PMA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDone_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PMA.Location = new System.Drawing.Point(12, 385);
            this.buttonDone_PMA.Name = "buttonDone_PMA";
            this.buttonDone_PMA.Size = new System.Drawing.Size(368, 48);
            this.buttonDone_PMA.TabIndex = 1;
            this.buttonDone_PMA.Text = "Выполнить";
            this.buttonDone_PMA.UseVisualStyleBackColor = false;
            this.buttonDone_PMA.Click += new System.EventHandler(this.buttonDone_PMA_Click);
            this.buttonDone_PMA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PMA_Down);
            this.buttonDone_PMA.MouseEnter += new System.EventHandler(this.buttonDone_PMA_Enter);
            this.buttonDone_PMA.MouseLeave += new System.EventHandler(this.buttonDone_PMA_Leave);
            // 
            // buttonHelp_PMA
            // 
            this.buttonHelp_PMA.BackColor = System.Drawing.Color.Salmon;
            this.buttonHelp_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PMA.Location = new System.Drawing.Point(397, 385);
            this.buttonHelp_PMA.Name = "buttonHelp_PMA";
            this.buttonHelp_PMA.Size = new System.Drawing.Size(100, 47);
            this.buttonHelp_PMA.TabIndex = 2;
            this.buttonHelp_PMA.Text = "?";
            this.buttonHelp_PMA.UseVisualStyleBackColor = false;
            this.buttonHelp_PMA.Click += new System.EventHandler(this.buttonHelp_PMA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 446);
            this.Controls.Add(this.buttonHelp_PMA);
            this.Controls.Add(this.buttonDone_PMA);
            this.Controls.Add(this.groupBoxOutPut_PMA);
            this.Controls.Add(this.groupBoxCondition_PMA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 10 | Пьянзина М.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_PMA.ResumeLayout(false);
            this.groupBoxCondition_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_PMA)).EndInit();
            this.groupBoxOutPut_PMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_PMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PMA;
        private System.Windows.Forms.Button buttonDone_PMA;
        private System.Windows.Forms.Button buttonHelp_PMA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_PMA;
        private System.Windows.Forms.Label labelCondition_PMA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_PMA;
    }
}

