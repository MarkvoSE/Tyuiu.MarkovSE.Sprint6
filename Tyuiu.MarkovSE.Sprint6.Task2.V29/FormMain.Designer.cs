namespace Tyuiu.MarkovSE.Sprint6.Task2.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_MSE = new GroupBox();
            pictureBoxTask_MSE = new PictureBox();
            groupBoxValue_MSE = new GroupBox();
            textBoxStopStep_MSE = new TextBox();
            textBoxStartStep_MSE = new TextBox();
            labelStopStep_MSE = new Label();
            labelStartStep_MSE = new Label();
            groupBoxResult_MSE = new GroupBox();
            chartFunction_MSE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_MSE = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_MSE = new Label();
            buttonHelp_MSE = new Button();
            buttonDone_MSE = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_MSE).BeginInit();
            groupBoxValue_MSE.SuspendLayout();
            groupBoxResult_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MSE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MSE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MSE
            // 
            groupBoxTask_MSE.Controls.Add(pictureBoxTask_MSE);
            groupBoxTask_MSE.Location = new Point(12, 12);
            groupBoxTask_MSE.Name = "groupBoxTask_MSE";
            groupBoxTask_MSE.Size = new Size(518, 345);
            groupBoxTask_MSE.TabIndex = 0;
            groupBoxTask_MSE.TabStop = false;
            groupBoxTask_MSE.Text = "Условие";
            // 
            // pictureBoxTask_MSE
            // 
            pictureBoxTask_MSE.Image = (Image)resources.GetObject("pictureBoxTask_MSE.Image");
            pictureBoxTask_MSE.Location = new Point(6, 22);
            pictureBoxTask_MSE.Name = "pictureBoxTask_MSE";
            pictureBoxTask_MSE.Size = new Size(506, 168);
            pictureBoxTask_MSE.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_MSE.TabIndex = 0;
            pictureBoxTask_MSE.TabStop = false;
            // 
            // groupBoxValue_MSE
            // 
            groupBoxValue_MSE.Controls.Add(textBoxStopStep_MSE);
            groupBoxValue_MSE.Controls.Add(textBoxStartStep_MSE);
            groupBoxValue_MSE.Controls.Add(labelStopStep_MSE);
            groupBoxValue_MSE.Controls.Add(labelStartStep_MSE);
            groupBoxValue_MSE.Location = new Point(12, 363);
            groupBoxValue_MSE.Name = "groupBoxValue_MSE";
            groupBoxValue_MSE.Size = new Size(269, 75);
            groupBoxValue_MSE.TabIndex = 0;
            groupBoxValue_MSE.TabStop = false;
            groupBoxValue_MSE.Text = "Ввод данных";
            // 
            // textBoxStopStep_MSE
            // 
            textBoxStopStep_MSE.Location = new Point(141, 37);
            textBoxStopStep_MSE.Name = "textBoxStopStep_MSE";
            textBoxStopStep_MSE.Size = new Size(122, 23);
            textBoxStopStep_MSE.TabIndex = 2;
            // 
            // textBoxStartStep_MSE
            // 
            textBoxStartStep_MSE.Location = new Point(6, 37);
            textBoxStartStep_MSE.Name = "textBoxStartStep_MSE";
            textBoxStartStep_MSE.Size = new Size(122, 23);
            textBoxStartStep_MSE.TabIndex = 1;
            // 
            // labelStopStep_MSE
            // 
            labelStopStep_MSE.AutoSize = true;
            labelStopStep_MSE.Location = new Point(141, 19);
            labelStopStep_MSE.Name = "labelStopStep_MSE";
            labelStopStep_MSE.Size = new Size(75, 15);
            labelStopStep_MSE.TabIndex = 1;
            labelStopStep_MSE.Text = "Конец шага:";
            // 
            // labelStartStep_MSE
            // 
            labelStartStep_MSE.AutoSize = true;
            labelStartStep_MSE.Location = new Point(6, 19);
            labelStartStep_MSE.Name = "labelStartStep_MSE";
            labelStartStep_MSE.Size = new Size(72, 15);
            labelStartStep_MSE.TabIndex = 0;
            labelStartStep_MSE.Text = "Старт шага:";
            // 
            // groupBoxResult_MSE
            // 
            groupBoxResult_MSE.Controls.Add(chartFunction_MSE);
            groupBoxResult_MSE.Controls.Add(dataGridViewFunction_MSE);
            groupBoxResult_MSE.Controls.Add(labelResult_MSE);
            groupBoxResult_MSE.Location = new Point(536, 12);
            groupBoxResult_MSE.Name = "groupBoxResult_MSE";
            groupBoxResult_MSE.Size = new Size(507, 426);
            groupBoxResult_MSE.TabIndex = 0;
            groupBoxResult_MSE.TabStop = false;
            groupBoxResult_MSE.Text = "Вывод данных";
            // 
            // chartFunction_MSE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MSE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_MSE.Legends.Add(legend1);
            chartFunction_MSE.Location = new Point(138, 40);
            chartFunction_MSE.Name = "chartFunction_MSE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MSE.Series.Add(series1);
            chartFunction_MSE.Size = new Size(363, 371);
            chartFunction_MSE.TabIndex = 3;
            chartFunction_MSE.Text = "chart1";
            // 
            // dataGridViewFunction_MSE
            // 
            dataGridViewFunction_MSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_MSE.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_MSE.Location = new Point(6, 40);
            dataGridViewFunction_MSE.Name = "dataGridViewFunction_MSE";
            dataGridViewFunction_MSE.RowHeadersVisible = false;
            dataGridViewFunction_MSE.ScrollBars = ScrollBars.Vertical;
            dataGridViewFunction_MSE.Size = new Size(126, 371);
            dataGridViewFunction_MSE.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // labelResult_MSE
            // 
            labelResult_MSE.AutoSize = true;
            labelResult_MSE.Location = new Point(6, 19);
            labelResult_MSE.Name = "labelResult_MSE";
            labelResult_MSE.Size = new Size(63, 15);
            labelResult_MSE.TabIndex = 2;
            labelResult_MSE.Text = "Результат:";
            // 
            // buttonHelp_MSE
            // 
            buttonHelp_MSE.BackColor = SystemColors.Highlight;
            buttonHelp_MSE.Location = new Point(287, 363);
            buttonHelp_MSE.Name = "buttonHelp_MSE";
            buttonHelp_MSE.Size = new Size(99, 75);
            buttonHelp_MSE.TabIndex = 1;
            buttonHelp_MSE.Text = "Справка";
            buttonHelp_MSE.UseVisualStyleBackColor = false;
            buttonHelp_MSE.Click += buttonHelp_MSE_Click;
            // 
            // buttonDone_MSE
            // 
            buttonDone_MSE.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_MSE.ForeColor = SystemColors.ControlText;
            buttonDone_MSE.Location = new Point(392, 363);
            buttonDone_MSE.Name = "buttonDone_MSE";
            buttonDone_MSE.Size = new Size(138, 75);
            buttonDone_MSE.TabIndex = 2;
            buttonDone_MSE.Text = "Выполнить";
            buttonDone_MSE.UseVisualStyleBackColor = false;
            buttonDone_MSE.Click += buttonDone_MSE_Click;
            buttonDone_MSE.MouseEnter += buttonDone_MSE_MouseEnter;
            buttonDone_MSE.MouseLeave += buttonDone_MSE_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 450);
            Controls.Add(buttonDone_MSE);
            Controls.Add(buttonHelp_MSE);
            Controls.Add(groupBoxResult_MSE);
            Controls.Add(groupBoxValue_MSE);
            Controls.Add(groupBoxTask_MSE);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 29 | Марков С. Е.";
            groupBoxTask_MSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_MSE).EndInit();
            groupBoxValue_MSE.ResumeLayout(false);
            groupBoxValue_MSE.PerformLayout();
            groupBoxResult_MSE.ResumeLayout(false);
            groupBoxResult_MSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MSE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MSE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSE;
        private PictureBox pictureBoxTask_MSE;
        private GroupBox groupBoxValue_MSE;
        private TextBox textBoxStartStep_MSE;
        private Label labelStopStep_MSE;
        private Label labelStartStep_MSE;
        private GroupBox groupBoxResult_MSE;
        private Label labelResult_MSE;
        private TextBox textBoxStopStep_MSE;
        private Button buttonHelp_MSE;
        private Button buttonDone_MSE;
        private DataGridView dataGridViewFunction_MSE;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MSE;
    }
}