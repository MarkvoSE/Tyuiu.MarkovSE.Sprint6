using Tyuiu.MarkovSE.Sprint6.Task2.V29.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_MSE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MSE.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MSE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MSE.Titles.Add("График функции");

                this.chartFunction_MSE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MSE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MSE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_MSE.Series[0].Points.AddXY(startStep, valueArray[i]);

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
            MessageBox.Show("Таск 2 выполнил студент группы ИСПб-24-1 Марков С. Е.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_MSE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MSE.BackColor = Color.Red;
        }

        private void buttonDone_MSE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MSE.BackColor = Color.Green;
        }
        private void buttonDone_MSE_MouseDown(object sender, EventArgs e)
        {
            buttonDone_MSE.BackColor = Color.Blue;
        }
    }
}