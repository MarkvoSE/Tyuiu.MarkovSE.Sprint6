using Tyuiu.MarkovSE.Sprint6.Task3.V24.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-17, -6, 10, 5, 3},
                                  {-10, -14, 10, -7, -3},
                                  {-19, 9, 8, -17, -9},
                                  {-19, -5, -9, -18, 14},
                                  {17, 12, 11, 12, 2} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_MSE.ColumnCount = mtrx.GetLength(1);
            dataGridViewMatrix_MSE.RowCount = mtrx.GetLength(0);

            for (int i = 0; i < dataGridViewMatrix_MSE.ColumnCount; i++)
            {
                dataGridViewMatrix_MSE.Columns[i].Width = 52;
            }

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix_MSE.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonDone_MSE_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix_MSE.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }
        private void buttonInfo_MSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб-24-1 Марков С. Е.", "Вам пришло новое сообщение", MessageBoxButtons.OK);
        }

        private void dataGridViewMatrix_MSE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}