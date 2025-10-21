using Tyuiu.MarkovSE.Sprint6.Task6.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //buttonDone_MSE.Enabled = false;
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_MSE_Click(object sender, EventArgs e)
        {

            textBoxResult_MSE.Text = ds.CollectTextFromFile(openFilePath);

        }



        private void buttonOpenFile_MSE_Click(object sender, EventArgs e)
        {

            openFileDialogTask_MSE.ShowDialog();
            openFilePath = openFileDialogTask_MSE.FileName;
            textBoxVvod_MSE.Text = File.ReadAllText(openFilePath);
            groupBoxVvod_MSE.Text = groupBoxVvod_MSE.Text + " " + openFileDialogTask_MSE.FileName;
            buttonDone_MSE.Enabled = true;
        }
    }
}