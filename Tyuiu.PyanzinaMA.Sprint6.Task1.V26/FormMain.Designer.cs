
namespace Tyuiu.PyanzinaMA.Sprint6.Task1.V26
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.buttonDone_PMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCondition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxResult_PMA = new System.Windows.Forms.TextBox();
            this.textBoxStart_PMA = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBoxEnd_PMA = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBox1);
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition.Location = new System.Drawing.Point(14, 19);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(451, 229);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.labelResult);
            this.groupBoxOutPut.Controls.Add(this.textBoxResult_PMA);
            this.groupBoxOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut.Location = new System.Drawing.Point(483, 19);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(305, 419);
            this.groupBoxOutPut.TabIndex = 0;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.labelEnd);
            this.groupBoxInPut.Controls.Add(this.labelStart);
            this.groupBoxInPut.Controls.Add(this.textBoxEnd_PMA);
            this.groupBoxInPut.Controls.Add(this.textBoxStart_PMA);
            this.groupBoxInPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut.Location = new System.Drawing.Point(14, 254);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(451, 117);
            this.groupBoxInPut.TabIndex = 0;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных";
            // 
            // buttonDone_PMA
            // 
            this.buttonDone_PMA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDone_PMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PMA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_PMA.Location = new System.Drawing.Point(12, 389);
            this.buttonDone_PMA.Name = "buttonDone_PMA";
            this.buttonDone_PMA.Size = new System.Drawing.Size(354, 49);
            this.buttonDone_PMA.TabIndex = 1;
            this.buttonDone_PMA.Text = "Выполнить";
            this.buttonDone_PMA.UseVisualStyleBackColor = false;
            this.buttonDone_PMA.Click += new System.EventHandler(this.buttonDone_PMA_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(383, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(6, 22);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(443, 80);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = resources.GetString("labelCondition.Text");
            this.labelCondition.Click += new System.EventHandler(this.labelCondition_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxResult_PMA
            // 
            this.textBoxResult_PMA.Location = new System.Drawing.Point(10, 54);
            this.textBoxResult_PMA.Multiline = true;
            this.textBoxResult_PMA.Name = "textBoxResult_PMA";
            this.textBoxResult_PMA.Size = new System.Drawing.Size(220, 346);
            this.textBoxResult_PMA.TabIndex = 0;
            // 
            // textBoxStart_PMA
            // 
            this.textBoxStart_PMA.Location = new System.Drawing.Point(114, 32);
            this.textBoxStart_PMA.Name = "textBoxStart_PMA";
            this.textBoxStart_PMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_PMA.TabIndex = 0;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(6, 32);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(102, 20);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Старт шага:";
            // 
            // textBoxEnd_PMA
            // 
            this.textBoxEnd_PMA.Location = new System.Drawing.Point(114, 64);
            this.textBoxEnd_PMA.Name = "textBoxEnd_PMA";
            this.textBoxEnd_PMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxEnd_PMA.TabIndex = 0;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(7, 67);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(101, 20);
            this.labelEnd.TabIndex = 1;
            this.labelEnd.Text = "Конец шага:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 31);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(93, 20);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDone_PMA);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxCondition);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 26 | Пьянзина М.А.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Button buttonDone_PMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxResult_PMA;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxEnd_PMA;
        private System.Windows.Forms.TextBox textBoxStart_PMA;
        private System.Windows.Forms.Label labelResult;
    }
}

