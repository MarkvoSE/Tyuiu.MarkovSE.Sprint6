namespace Tyuiu.MarkovSE.Sprint6.Task6.V2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelOne_MSE = new System.Windows.Forms.Panel();
            this.buttonHelp_MSE = new System.Windows.Forms.Button();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.buttonOpenFile_MSE = new System.Windows.Forms.Button();
            this.panelTwo_MSE = new System.Windows.Forms.Panel();
            this.groupBoxDano_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_MSE = new System.Windows.Forms.TextBox();
            this.panelThree_MSE = new System.Windows.Forms.Panel();
            this.groupBoxVvod_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxVvod_MSE = new System.Windows.Forms.TextBox();
            this.panelFour_MSE = new System.Windows.Forms.Panel();
            this.groupBoxResult_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MSE = new System.Windows.Forms.TextBox();
            this.splitterSplit_MSE = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_MSE = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_MSE = new System.Windows.Forms.ToolTip(this.components);
            this.panelOne_MSE.SuspendLayout();
            this.panelTwo_MSE.SuspendLayout();
            this.groupBoxDano_MSE.SuspendLayout();
            this.panelThree_MSE.SuspendLayout();
            this.groupBoxVvod_MSE.SuspendLayout();
            this.panelFour_MSE.SuspendLayout();
            this.groupBoxResult_MSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne_MSE
            // 
            this.panelOne_MSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOne_MSE.Controls.Add(this.buttonHelp_MSE);
            this.panelOne_MSE.Controls.Add(this.buttonDone_MSE);
            this.panelOne_MSE.Controls.Add(this.buttonOpenFile_MSE);
            this.panelOne_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_MSE.Location = new System.Drawing.Point(0, 0);
            this.panelOne_MSE.Name = "panelOne_MSE";
            this.panelOne_MSE.Size = new System.Drawing.Size(800, 88);
            this.panelOne_MSE.TabIndex = 0;
            // 
            // buttonHelp_MSE
            // 
           
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_MSE.Enabled = false;
            this.buttonDone_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MSE.ForeColor = System.Drawing.Color.Silver;
            this.buttonDone_MSE.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MSE.Image")));
            this.buttonDone_MSE.Location = new System.Drawing.Point(118, 6);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(105, 75);
            this.buttonDone_MSE.TabIndex = 1;
            this.toolTipTask_MSE.SetToolTip(this.buttonDone_MSE, "Подсчитывает количество слов в строке, и если их больше 2, \r\nто выводит каждое вт" +
                "орое слово из строки в результатирующую строку\r\n\r\n");
            this.buttonDone_MSE.UseVisualStyleBackColor = false;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_MSE_Click);
            // 
            // buttonOpenFile_MSE
            // 
            this.buttonOpenFile_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_MSE.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_MSE.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MSE.Image")));
            this.buttonOpenFile_MSE.Location = new System.Drawing.Point(9, 6);
            this.buttonOpenFile_MSE.Name = "buttonOpenFile_MSE";
            this.buttonOpenFile_MSE.Size = new System.Drawing.Size(103, 75);
            this.buttonOpenFile_MSE.TabIndex = 0;
            this.toolTipTask_MSE.SetToolTip(this.buttonOpenFile_MSE, "Открыть файл \r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_MSE.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MSE.Click += new System.EventHandler(this.buttonOpenFile_MSE_Click);
            // 
            // panelTwo_MSE
            // 
            this.panelTwo_MSE.Controls.Add(this.groupBoxDano_MSE);
            this.panelTwo_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_MSE.Location = new System.Drawing.Point(0, 88);
            this.panelTwo_MSE.Name = "panelTwo_MSE";
            this.panelTwo_MSE.Size = new System.Drawing.Size(800, 100);
            this.panelTwo_MSE.TabIndex = 0;
            // 
            // groupBoxDano_MSE
            // 
            this.groupBoxDano_MSE.Controls.Add(this.textBoxUslovie_MSE);
            this.groupBoxDano_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDano_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDano_MSE.Name = "groupBoxDano_MSE";
            this.groupBoxDano_MSE.Size = new System.Drawing.Size(800, 94);
            this.groupBoxDano_MSE.TabIndex = 0;
            this.groupBoxDano_MSE.TabStop = false;
            this.groupBoxDano_MSE.Text = "Условие:";
            // 
            // textBoxUslovie_MSE
            // 
            this.textBoxUslovie_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_MSE.Location = new System.Drawing.Point(3, 18);
            this.textBoxUslovie_MSE.Multiline = true;
            this.textBoxUslovie_MSE.Name = "textBoxUslovie_MSE";
            this.textBoxUslovie_MSE.ReadOnly = true;
            this.textBoxUslovie_MSE.Size = new System.Drawing.Size(794, 73);
            this.textBoxUslovie_MSE.TabIndex = 0;
            this.textBoxUslovie_MSE.Text = resources.GetString("textBoxUslovie_MSE.Text");
            // 
            // panelThree_MSE
            // 
            this.panelThree_MSE.Controls.Add(this.groupBoxVvod_MSE);
            this.panelThree_MSE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_MSE.Location = new System.Drawing.Point(0, 188);
            this.panelThree_MSE.Name = "panelThree_MSE";
            this.panelThree_MSE.Size = new System.Drawing.Size(386, 262);
            this.panelThree_MSE.TabIndex = 0;
            // 
            // groupBoxVvod_MSE
            // 
            this.groupBoxVvod_MSE.Controls.Add(this.textBoxVvod_MSE);
            this.groupBoxVvod_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvod_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvod_MSE.Name = "groupBoxVvod_MSE";
            this.groupBoxVvod_MSE.Size = new System.Drawing.Size(386, 262);
            this.groupBoxVvod_MSE.TabIndex = 0;
            this.groupBoxVvod_MSE.TabStop = false;
            this.groupBoxVvod_MSE.Text = "Ввод:";
            // 
            // textBoxVvod_MSE
            // 
            this.textBoxVvod_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVvod_MSE.Location = new System.Drawing.Point(3, 18);
            this.textBoxVvod_MSE.Multiline = true;
            this.textBoxVvod_MSE.Name = "textBoxVvod_MSE";
            this.textBoxVvod_MSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxVvod_MSE.Size = new System.Drawing.Size(380, 241);
            this.textBoxVvod_MSE.TabIndex = 0;
            // 
            // panelFour_MSE
            // 
            this.panelFour_MSE.Controls.Add(this.groupBoxResult_MSE);
            this.panelFour_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_MSE.Location = new System.Drawing.Point(386, 188);
            this.panelFour_MSE.Name = "panelFour_MSE";
            this.panelFour_MSE.Size = new System.Drawing.Size(414, 262);
            this.panelFour_MSE.TabIndex = 0;
            // 
            // groupBoxResult_MSE
            // 
            this.groupBoxResult_MSE.Controls.Add(this.textBoxResult_MSE);
            this.groupBoxResult_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_MSE.Name = "groupBoxResult_MSE";
            this.groupBoxResult_MSE.Size = new System.Drawing.Size(414, 262);
            this.groupBoxResult_MSE.TabIndex = 0;
            this.groupBoxResult_MSE.TabStop = false;
            this.groupBoxResult_MSE.Text = "Вывод:";
            // 
            // textBoxResult_MSE
            // 
            this.textBoxResult_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_MSE.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_MSE.Multiline = true;
            this.textBoxResult_MSE.Name = "textBoxResult_MSE";
            this.textBoxResult_MSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MSE.Size = new System.Drawing.Size(408, 241);
            this.textBoxResult_MSE.TabIndex = 0;
            // 
            // splitterSplit_MSE
            // 
            this.splitterSplit_MSE.Location = new System.Drawing.Point(386, 188);
            this.splitterSplit_MSE.Name = "splitterSplit_MSE";
            this.splitterSplit_MSE.Size = new System.Drawing.Size(3, 262);
            this.splitterSplit_MSE.TabIndex = 1;
            this.splitterSplit_MSE.TabStop = false;
            // 
            // openFileDialogTask_MSE
            // 
            this.openFileDialogTask_MSE.FileName = "InPutFileTask6V2.txt";
            // 
            // toolTipTask_MSE
            // 
            this.toolTipTask_MSE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_MSE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitterSplit_MSE);
            this.Controls.Add(this.panelFour_MSE);
            this.Controls.Add(this.panelThree_MSE);
            this.Controls.Add(this.panelTwo_MSE);
            this.Controls.Add(this.panelOne_MSE);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 2 | Марков С.Е.";
            this.panelOne_MSE.ResumeLayout(false);
            this.panelTwo_MSE.ResumeLayout(false);
            this.groupBoxDano_MSE.ResumeLayout(false);
            this.groupBoxDano_MSE.PerformLayout();
            this.panelThree_MSE.ResumeLayout(false);
            this.groupBoxVvod_MSE.ResumeLayout(false);
            this.groupBoxVvod_MSE.PerformLayout();
            this.panelFour_MSE.ResumeLayout(false);
            this.groupBoxResult_MSE.ResumeLayout(false);
            this.groupBoxResult_MSE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_MSE;
        private System.Windows.Forms.Panel panelTwo_MSE;
        private System.Windows.Forms.GroupBox groupBoxDano_MSE;
        private System.Windows.Forms.TextBox textBoxUslovie_MSE;
        private System.Windows.Forms.Panel panelThree_MSE;
        private System.Windows.Forms.GroupBox groupBoxVvod_MSE;
        private System.Windows.Forms.TextBox textBoxVvod_MSE;
        private System.Windows.Forms.Panel panelFour_MSE;
        private System.Windows.Forms.GroupBox groupBoxResult_MSE;
        private System.Windows.Forms.TextBox textBoxResult_MSE;
        private System.Windows.Forms.Splitter splitterSplit_MSE;
        private System.Windows.Forms.Button buttonHelp_MSE;
        private System.Windows.Forms.ToolTip toolTipTask_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
        private System.Windows.Forms.Button buttonOpenFile_MSE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MSE;
    }
}