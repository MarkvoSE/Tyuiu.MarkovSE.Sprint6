using Tyuiu.MarkovSE.Sprint6.Task4.V9.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task4.V9
{
    public partial class FormMain_MSE : Form
    {
        public FormMain_MSE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_MSE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MSE.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MSE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MSE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MSE.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_MSE.Text = "";

                chartFunction_MSE.Series[0].Points.Clear();

                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_MSE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_MSE.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_MSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСПб-24-1 Марков С. Е.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_MSE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V9.txt";
                File.WriteAllText(path, textBoxResult_MSE.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}