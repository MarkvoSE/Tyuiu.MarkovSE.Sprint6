using Tyuiu.MarkovSE.Sprint6.Task1.V20.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task1.V20
{
    public partial class FormMain_MSE : System.Windows.Forms.Form
    {
        public FormMain_MSE()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonToDo_Click(object sender, EventArgs e)
        {
            int startstep = Convert.ToInt32(textBoxStart_MSE.Text);
            int stopstep = Convert.ToInt32(textBoxSTOP_MSE.Text);

            string strline;

            int len = ds.GetMassFunction(startstep, stopstep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startstep, stopstep);
            textBoxRES_MSE.Text = "";
            textBoxRES_MSE.AppendText("+----------+------------+" + Environment.NewLine);
            textBoxRES_MSE.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
            textBoxRES_MSE.AppendText("+----------+------------+" + Environment.NewLine);

            for (int i = 0; i <= len - 1; i++)
            {
                strline = String.Format("|{0,5:d}     | {1,6:f2}    | ", startstep, valueArray[i]);
                textBoxRES_MSE.AppendText(strline + Environment.NewLine);
                startstep++;
            }
            textBoxRES_MSE.AppendText("+----------+------------+" + Environment.NewLine);


        }

        private void buttonSPRAVKA_MSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТПб-23-1 Марков С. Е.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}