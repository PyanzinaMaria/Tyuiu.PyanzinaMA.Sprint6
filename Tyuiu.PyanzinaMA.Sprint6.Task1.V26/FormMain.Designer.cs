
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
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
            this.groupBoxInPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut.Location = new System.Drawing.Point(14, 254);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(451, 117);
            this.groupBoxInPut.TabIndex = 0;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone.Location = new System.Drawing.Point(12, 389);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(354, 49);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 26 | Пьянзина М.А.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button button1;
    }
}

