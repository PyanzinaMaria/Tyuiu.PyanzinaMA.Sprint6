
namespace Tyuiu.PyanzinaMA.Sprint6.Task7.V30
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_PMA = new System.Windows.Forms.GroupBox();
            this.labelCondition_PMA = new System.Windows.Forms.Label();
            this.groupBoxOut_PMA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_PMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_PMA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_PMA = new System.Windows.Forms.DataGridView();
            this.buttonDone_PMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_PMA = new System.Windows.Forms.Button();
            this.buttonHelp_PMA = new System.Windows.Forms.Button();
            this.openFileDialogTask_PMA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_PMA = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave_PMA = new System.Windows.Forms.Button();
            this.toolTipOpen_PMA = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDone_PMA = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave_PMA = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHelp_PMA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxCondition_PMA.SuspendLayout();
            this.groupBoxOut_PMA.SuspendLayout();
            this.groupBoxIn_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_PMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            this.groupBoxCondition_PMA.Controls.Add(this.labelCondition_PMA);
            this.groupBoxCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_PMA.Location = new System.Drawing.Point(16, 17);
            this.groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            this.groupBoxCondition_PMA.Size = new System.Drawing.Size(453, 194);
            this.groupBoxCondition_PMA.TabIndex = 1;
            this.groupBoxCondition_PMA.TabStop = false;
            this.groupBoxCondition_PMA.Text = "Условие";
            // 
            // labelCondition_PMA
            // 
            this.labelCondition_PMA.AutoSize = true;
            this.labelCondition_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition_PMA.Location = new System.Drawing.Point(6, 32);
            this.labelCondition_PMA.Name = "labelCondition_PMA";
            this.labelCondition_PMA.Size = new System.Drawing.Size(438, 120);
            this.labelCondition_PMA.TabIndex = 0;
            this.labelCondition_PMA.Text = resources.GetString("labelCondition_PMA.Text");
            // 
            // groupBoxOut_PMA
            // 
            this.groupBoxOut_PMA.Controls.Add(this.dataGridViewOut_PMA);
            this.groupBoxOut_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOut_PMA.Location = new System.Drawing.Point(763, 12);
            this.groupBoxOut_PMA.Name = "groupBoxOut_PMA";
            this.groupBoxOut_PMA.Size = new System.Drawing.Size(282, 255);
            this.groupBoxOut_PMA.TabIndex = 1;
            this.groupBoxOut_PMA.TabStop = false;
            this.groupBoxOut_PMA.Text = "Результат";
            // 
            // groupBoxIn_PMA
            // 
            this.groupBoxIn_PMA.Controls.Add(this.dataGridViewIn_PMA);
            this.groupBoxIn_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIn_PMA.Location = new System.Drawing.Point(475, 17);
            this.groupBoxIn_PMA.Name = "groupBoxIn_PMA";
            this.groupBoxIn_PMA.Size = new System.Drawing.Size(282, 255);
            this.groupBoxIn_PMA.TabIndex = 1;
            this.groupBoxIn_PMA.TabStop = false;
            this.groupBoxIn_PMA.Text = "Ввод данных";
            // 
            // dataGridViewIn_PMA
            // 
            this.dataGridViewIn_PMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_PMA.ColumnHeadersVisible = false;
            this.dataGridViewIn_PMA.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewIn_PMA.Name = "dataGridViewIn_PMA";
            this.dataGridViewIn_PMA.RowHeadersVisible = false;
            this.dataGridViewIn_PMA.Size = new System.Drawing.Size(270, 217);
            this.dataGridViewIn_PMA.TabIndex = 0;
            // 
            // dataGridViewOut_PMA
            // 
            this.dataGridViewOut_PMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_PMA.ColumnHeadersVisible = false;
            this.dataGridViewOut_PMA.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewOut_PMA.Name = "dataGridViewOut_PMA";
            this.dataGridViewOut_PMA.RowHeadersVisible = false;
            this.dataGridViewOut_PMA.Size = new System.Drawing.Size(270, 217);
            this.dataGridViewOut_PMA.TabIndex = 0;
            // 
            // buttonDone_PMA
            // 
            this.buttonDone_PMA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PMA.Image")));
            this.buttonDone_PMA.Location = new System.Drawing.Point(132, 217);
            this.buttonDone_PMA.Name = "buttonDone_PMA";
            this.buttonDone_PMA.Size = new System.Drawing.Size(100, 50);
            this.buttonDone_PMA.TabIndex = 2;
            this.toolTipOpen_PMA.SetToolTip(this.buttonDone_PMA, "Выполнить");
            this.buttonDone_PMA.UseVisualStyleBackColor = false;
            this.buttonDone_PMA.Click += new System.EventHandler(this.buttonDone_PMA_Click);
            // 
            // buttonOpenFile_PMA
            // 
            this.buttonOpenFile_PMA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonOpenFile_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_PMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PMA.Image")));
            this.buttonOpenFile_PMA.Location = new System.Drawing.Point(16, 217);
            this.buttonOpenFile_PMA.Name = "buttonOpenFile_PMA";
            this.buttonOpenFile_PMA.Size = new System.Drawing.Size(100, 50);
            this.buttonOpenFile_PMA.TabIndex = 2;
            this.toolTipOpen_PMA.SetToolTip(this.buttonOpenFile_PMA, "Выберите файл для выполнения задания");
            this.buttonOpenFile_PMA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PMA.Click += new System.EventHandler(this.buttonOpenFile_PMA_Click);
            this.buttonOpenFile_PMA.MouseEnter += new System.EventHandler(this.buttonOpenFile_PMA_MouseEnter);
            // 
            // buttonHelp_PMA
            // 
            this.buttonHelp_PMA.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonHelp_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PMA.Location = new System.Drawing.Point(369, 217);
            this.buttonHelp_PMA.Name = "buttonHelp_PMA";
            this.buttonHelp_PMA.Size = new System.Drawing.Size(100, 50);
            this.buttonHelp_PMA.TabIndex = 2;
            this.buttonHelp_PMA.Text = "?";
            this.toolTipHelp_PMA.SetToolTip(this.buttonHelp_PMA, "Справка");
            this.buttonHelp_PMA.UseVisualStyleBackColor = false;
            this.buttonHelp_PMA.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialogTask_PMA
            // 
            this.openFileDialogTask_PMA.FileName = "openFileDialog1";
            // 
            // buttonSave_PMA
            // 
            this.buttonSave_PMA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_PMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PMA.Image")));
            this.buttonSave_PMA.Location = new System.Drawing.Point(250, 217);
            this.buttonSave_PMA.Name = "buttonSave_PMA";
            this.buttonSave_PMA.Size = new System.Drawing.Size(100, 50);
            this.buttonSave_PMA.TabIndex = 2;
            this.toolTipSave_PMA.SetToolTip(this.buttonSave_PMA, "Сохранить файл с результатом");
            this.buttonSave_PMA.UseVisualStyleBackColor = false;
            this.buttonSave_PMA.Click += new System.EventHandler(this.buttonSave_PMA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 278);
            this.Controls.Add(this.buttonHelp_PMA);
            this.Controls.Add(this.buttonDone_PMA);
            this.Controls.Add(this.buttonOpenFile_PMA);
            this.Controls.Add(this.buttonSave_PMA);
            this.Controls.Add(this.groupBoxIn_PMA);
            this.Controls.Add(this.groupBoxOut_PMA);
            this.Controls.Add(this.groupBoxCondition_PMA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 30 | Пьянзина М.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_PMA.ResumeLayout(false);
            this.groupBoxCondition_PMA.PerformLayout();
            this.groupBoxOut_PMA.ResumeLayout(false);
            this.groupBoxIn_PMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_PMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PMA;
        private System.Windows.Forms.Label labelCondition_PMA;
        private System.Windows.Forms.GroupBox groupBoxOut_PMA;
        private System.Windows.Forms.DataGridView dataGridViewOut_PMA;
        private System.Windows.Forms.GroupBox groupBoxIn_PMA;
        private System.Windows.Forms.DataGridView dataGridViewIn_PMA;
        private System.Windows.Forms.Button buttonDone_PMA;
        private System.Windows.Forms.Button buttonOpenFile_PMA;
        private System.Windows.Forms.Button buttonHelp_PMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PMA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_PMA;
        private System.Windows.Forms.Button buttonSave_PMA;
        private System.Windows.Forms.ToolTip toolTipOpen_PMA;
        private System.Windows.Forms.ToolTip toolTipDone_PMA;
        private System.Windows.Forms.ToolTip toolTipSave_PMA;
        private System.Windows.Forms.ToolTip toolTipHelp_PMA;
    }
}

