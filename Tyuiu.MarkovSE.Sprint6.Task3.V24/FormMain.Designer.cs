namespace Tyuiu.MarkovSE.Sprint6.Task3.V24
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTask_MSE = new System.Windows.Forms.GroupBox();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_MSE = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_MSE = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MSE)).BeginInit();
            this.groupBoxResult_MSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MSE
            // 
            this.groupBoxTask_MSE.Controls.Add(this.buttonDone_MSE);
            this.groupBoxTask_MSE.Controls.Add(this.textBox1);
            this.groupBoxTask_MSE.Controls.Add(this.buttonInfo_MSE);
            this.groupBoxTask_MSE.Location = new System.Drawing.Point(13, 35);
            this.groupBoxTask_MSE.Name = "groupBoxTask_MSE";
            this.groupBoxTask_MSE.Size = new System.Drawing.Size(321, 335);
            this.groupBoxTask_MSE.TabIndex = 0;
            this.groupBoxTask_MSE.TabStop = false;
            this.groupBoxTask_MSE.Text = "Условие";
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.Location = new System.Drawing.Point(51, 196);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(116, 34);
            this.buttonDone_MSE.TabIndex = 4;
            this.buttonDone_MSE.Text = "Выполнить";
            this.buttonDone_MSE.UseVisualStyleBackColor = true;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_MSE_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(310, 168);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дана матрица 5 на 5\r\n-17  -6  10   5   3\r\n -10 -14  10  -7  -3\r\n -19   9   8 -17 " +
            " -9\r\n -19  -5  -9 -18  14\r\n  17  12  11  12   2\r\nзаменить четные значения во вто" +
            "рой строке на 0";
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.Location = new System.Drawing.Point(7, 196);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(38, 34);
            this.buttonInfo_MSE.TabIndex = 3;
            this.buttonInfo_MSE.Text = "?";
            this.buttonInfo_MSE.UseVisualStyleBackColor = true;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_MSE_Click);
            // 
            // dataGridViewMatrix_MSE
            // 
            this.dataGridViewMatrix_MSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_MSE.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewMatrix_MSE.Name = "dataGridViewMatrix_MSE";
            this.dataGridViewMatrix_MSE.ReadOnly = true;
            this.dataGridViewMatrix_MSE.RowHeadersVisible = false;
            this.dataGridViewMatrix_MSE.RowHeadersWidth = 51;
            this.dataGridViewMatrix_MSE.RowTemplate.Height = 24;
            this.dataGridViewMatrix_MSE.Size = new System.Drawing.Size(354, 190);
            this.dataGridViewMatrix_MSE.TabIndex = 1;
            this.dataGridViewMatrix_MSE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_MSE_CellContentClick);
            // 
            // groupBoxResult_MSE
            // 
            this.groupBoxResult_MSE.Controls.Add(this.dataGridViewMatrix_MSE);
            this.groupBoxResult_MSE.Location = new System.Drawing.Point(336, 35);
            this.groupBoxResult_MSE.Name = "groupBoxResult_MSE";
            this.groupBoxResult_MSE.Size = new System.Drawing.Size(374, 223);
            this.groupBoxResult_MSE.TabIndex = 2;
            this.groupBoxResult_MSE.TabStop = false;
            this.groupBoxResult_MSE.Text = "Вывод данных";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 270);
            this.Controls.Add(this.groupBoxResult_MSE);
            this.Controls.Add(this.groupBoxTask_MSE);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 3|Вариант 24|Марков С.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_MSE.ResumeLayout(false);
            this.groupBoxTask_MSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MSE)).EndInit();
            this.groupBoxResult_MSE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MSE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_MSE;
        private System.Windows.Forms.GroupBox groupBoxResult_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
    }
}