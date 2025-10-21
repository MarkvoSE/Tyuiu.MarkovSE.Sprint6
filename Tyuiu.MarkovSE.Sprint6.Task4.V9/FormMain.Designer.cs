namespace Tyuiu.MarkovSE.Sprint6.Task4.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOne_MSE = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo_MSE = new System.Windows.Forms.GroupBox();
            this.groupBoxTri_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.textBoxResult_MSE = new System.Windows.Forms.TextBox();
            this.textBoxStart_MSE = new System.Windows.Forms.TextBox();
            this.textBoxStop_MSE = new System.Windows.Forms.TextBox();
            this.labelStart_MSE = new System.Windows.Forms.Label();
            this.labelStop_MSE = new System.Windows.Forms.Label();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.buttonSave_MSE = new System.Windows.Forms.Button();
            this.buttonHelp_MSE = new System.Windows.Forms.Button();
            this.chartFunction_MSE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOne_MSE.SuspendLayout();
            this.groupBoxTwo_MSE.SuspendLayout();
            this.groupBoxTri_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_MSE
            // 
            this.groupBoxOne_MSE.Controls.Add(this.textBoxTask_MSE);
            this.groupBoxOne_MSE.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_MSE.Name = "groupBoxOne_MSE";
            this.groupBoxOne_MSE.Size = new System.Drawing.Size(546, 112);
            this.groupBoxOne_MSE.TabIndex = 0;
            this.groupBoxOne_MSE.TabStop = false;
            this.groupBoxOne_MSE.Text = "Условие :";
            // 
            // groupBoxTwo_MSE
            // 
            this.groupBoxTwo_MSE.Controls.Add(this.labelStop_MSE);
            this.groupBoxTwo_MSE.Controls.Add(this.labelStart_MSE);
            this.groupBoxTwo_MSE.Controls.Add(this.textBoxStop_MSE);
            this.groupBoxTwo_MSE.Controls.Add(this.textBoxStart_MSE);
            this.groupBoxTwo_MSE.Location = new System.Drawing.Point(578, 13);
            this.groupBoxTwo_MSE.Name = "groupBoxTwo_MSE";
            this.groupBoxTwo_MSE.Size = new System.Drawing.Size(269, 112);
            this.groupBoxTwo_MSE.TabIndex = 1;
            this.groupBoxTwo_MSE.TabStop = false;
            this.groupBoxTwo_MSE.Text = "Ввод данных ";
            // 
            // groupBoxTri_MSE
            // 
            this.groupBoxTri_MSE.Controls.Add(this.textBoxResult_MSE);
            this.groupBoxTri_MSE.Location = new System.Drawing.Point(13, 132);
            this.groupBoxTri_MSE.Name = "groupBoxTri_MSE";
            this.groupBoxTri_MSE.Size = new System.Drawing.Size(332, 379);
            this.groupBoxTri_MSE.TabIndex = 2;
            this.groupBoxTri_MSE.TabStop = false;
            this.groupBoxTri_MSE.Text = "Вывод:";
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.ReadOnly = true;
            this.textBoxTask_MSE.Size = new System.Drawing.Size(533, 77);
            this.textBoxTask_MSE.TabIndex = 0;
            this.textBoxTask_MSE.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5 \r\nРезультат вывести в te" +
            "xtBox . Построить график функции и сохранить в файл \r\nOutPutFileTask.txt по нажа" +
            "тию кнопки ";
            // 
            // textBoxResult_MSE
            // 
            this.textBoxResult_MSE.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_MSE.Multiline = true;
            this.textBoxResult_MSE.Name = "textBoxResult_MSE";
            this.textBoxResult_MSE.Size = new System.Drawing.Size(319, 353);
            this.textBoxResult_MSE.TabIndex = 0;
            // 
            // textBoxStart_MSE
            // 
            this.textBoxStart_MSE.Location = new System.Drawing.Point(7, 63);
            this.textBoxStart_MSE.Name = "textBoxStart_MSE";
            this.textBoxStart_MSE.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_MSE.TabIndex = 0;
            // 
            // textBoxStop_MSE
            // 
            this.textBoxStop_MSE.Location = new System.Drawing.Point(152, 62);
            this.textBoxStop_MSE.Name = "textBoxStop_MSE";
            this.textBoxStop_MSE.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_MSE.TabIndex = 1;
            // 
            // labelStart_MSE
            // 
            this.labelStart_MSE.AutoSize = true;
            this.labelStart_MSE.Location = new System.Drawing.Point(6, 38);
            this.labelStart_MSE.Name = "labelStart_MSE";
            this.labelStart_MSE.Size = new System.Drawing.Size(70, 13);
            this.labelStart_MSE.TabIndex = 2;
            this.labelStart_MSE.Text = "Старт шага :";
            // 
            // labelStop_MSE
            // 
            this.labelStop_MSE.AutoSize = true;
            this.labelStop_MSE.Location = new System.Drawing.Point(152, 38);
            this.labelStop_MSE.Name = "labelStop_MSE";
            this.labelStop_MSE.Size = new System.Drawing.Size(72, 13);
            this.labelStop_MSE.TabIndex = 3;
            this.labelStop_MSE.Text = "Конец шага :";
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MSE.Location = new System.Drawing.Point(874, 33);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(101, 63);
            this.buttonDone_MSE.TabIndex = 3;
            this.buttonDone_MSE.Text = "Выполнить ";
            this.buttonDone_MSE.UseVisualStyleBackColor = false;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_MSE_Click);
            // 
            // buttonSave_MSE
            // 
            this.buttonSave_MSE.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave_MSE.Location = new System.Drawing.Point(981, 34);
            this.buttonSave_MSE.Name = "buttonSave_MSE";
            this.buttonSave_MSE.Size = new System.Drawing.Size(97, 62);
            this.buttonSave_MSE.TabIndex = 4;
            this.buttonSave_MSE.Text = "Сохранить ";
            this.buttonSave_MSE.UseVisualStyleBackColor = false;
            this.buttonSave_MSE.Click += new System.EventHandler(this.buttonSave_MSE_Click);
            // 
            // buttonHelp_MSE
            // 
            this.buttonHelp_MSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MSE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MSE.Location = new System.Drawing.Point(1084, 34);
            this.buttonHelp_MSE.Name = "buttonHelp_MSE";
            this.buttonHelp_MSE.Size = new System.Drawing.Size(89, 61);
            this.buttonHelp_MSE.TabIndex = 5;
            this.buttonHelp_MSE.Text = "Справка ";
            this.buttonHelp_MSE.UseVisualStyleBackColor = false;
            this.buttonHelp_MSE.Click += new System.EventHandler(this.buttonHelp_MSE_Click);
            // 
            // chartFunction_MSE
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_MSE.ChartAreas.Add(chartArea2);
            this.chartFunction_MSE.Location = new System.Drawing.Point(375, 132);
            this.chartFunction_MSE.Name = "chartFunction_MSE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.chartFunction_MSE.Series.Add(series2);
            this.chartFunction_MSE.Size = new System.Drawing.Size(765, 379);
            this.chartFunction_MSE.TabIndex = 6;
            this.chartFunction_MSE.Text = "chart1";
            // 
            // FormMain_MSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 523);
            this.Controls.Add(this.chartFunction_MSE);
            this.Controls.Add(this.buttonHelp_MSE);
            this.Controls.Add(this.buttonSave_MSE);
            this.Controls.Add(this.buttonDone_MSE);
            this.Controls.Add(this.groupBoxTri_MSE);
            this.Controls.Add(this.groupBoxTwo_MSE);
            this.Controls.Add(this.groupBoxOne_MSE);
            this.Name = "FormMain_MSE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Марков С.Е.";
            this.groupBoxOne_MSE.ResumeLayout(false);
            this.groupBoxOne_MSE.PerformLayout();
            this.groupBoxTwo_MSE.ResumeLayout(false);
            this.groupBoxTwo_MSE.PerformLayout();
            this.groupBoxTri_MSE.ResumeLayout(false);
            this.groupBoxTri_MSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.GroupBox groupBoxTwo_MSE;
        private System.Windows.Forms.GroupBox groupBoxTri_MSE;
        private System.Windows.Forms.Label labelStop_MSE;
        private System.Windows.Forms.Label labelStart_MSE;
        private System.Windows.Forms.TextBox textBoxStop_MSE;
        private System.Windows.Forms.TextBox textBoxStart_MSE;
        private System.Windows.Forms.TextBox textBoxResult_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
        private System.Windows.Forms.Button buttonSave_MSE;
        private System.Windows.Forms.Button buttonHelp_MSE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MSE;
    }
}