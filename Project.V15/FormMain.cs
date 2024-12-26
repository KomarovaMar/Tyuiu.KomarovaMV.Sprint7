using Project.V15.Lib;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static string openFilePath;
        DataService ds = new DataService();
        private void ForMain_Load(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.ShowDialog();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogSprint.ShowDialog();
            openFilePath = openFileDialogSprint.FileName;


            string[,] Matrix = ds.GetMatrix(openFilePath);

            int rows = Matrix.GetUpperBound(0) + 1;
            int cols = Matrix.Length / rows;

            dataGridViewOut.RowCount = rows;
            dataGridViewOut.ColumnCount = cols;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewOut.Columns[i].Width = 200;
                    dataGridViewOut.Rows[j].Height = 30;
                }
            }

            dataGridViewOut.Columns[0].HeaderText = "Номер";
            dataGridViewOut.Columns[1].HeaderText = "ФИО";
            dataGridViewOut.Columns[2].HeaderText = "Адрес";
            dataGridViewOut.Columns[3].HeaderText = "Должность";
            dataGridViewOut.Columns[4].HeaderText = "Оклад";
            dataGridViewOut.Columns[5].HeaderText = "Срок работы по договору(в мес)";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++) { dataGridViewOut.Rows[r].Cells[c].Value = Matrix[r, c]; }
            }
            Matrix = ds.GetMatrix(openFilePath);
            buttonDiagram.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDel.Enabled = true;
            textBoxSearch.Enabled = true;
            textBoxFIO.Enabled = true;
            textBoxNumber.Enabled = true;
            textBoxAdress.Enabled = true;
            textBoxProf.Enabled = true;
            textBoxSalary.Enabled = true;
            textBoxData.Enabled = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text)) { buttonSearch.Enabled = false; }
            else { buttonSearch.Enabled = true; }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogSprint.FileName = "NewDataBase.cvs";
            saveFileDialogSprint.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogSprint.ShowDialog();


            string path = saveFileDialogSprint.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists == true) { File.Delete(path); }
            int rows = dataGridViewOut.RowCount;
            int cols = dataGridViewOut.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1) { str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";"; }
                    else { str = str + dataGridViewOut.Rows[i].Cells[j].Value; }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string FIO = textBoxFIO.Text;
            string Number = textBoxNumber.Text;
            string Adress = textBoxAdress.Text;
            string Prof = textBoxProf.Text;
            string Salary = textBoxSalary.Text;
            string Data = textBoxData.Text;
            if (string.IsNullOrEmpty(FIO) || string.IsNullOrEmpty(Number) || string.IsNullOrEmpty(Prof) || string.IsNullOrEmpty(Adress) || string.IsNullOrEmpty(Salary) || string.IsNullOrEmpty(Data))
            {
                MessageBox.Show("Данные не добавлены, недостаточно значений", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int AddRow = dataGridViewOut.Rows.Add();
                dataGridViewOut.Rows[AddRow].Cells[0].Value = Number;
                dataGridViewOut.Rows[AddRow].Cells[1].Value = FIO;
                dataGridViewOut.Rows[AddRow].Cells[2].Value = Adress;
                dataGridViewOut.Rows[AddRow].Cells[3].Value = Prof;
                dataGridViewOut.Rows[AddRow].Cells[4].Value = Salary;
                dataGridViewOut.Rows[AddRow].Cells[5].Value = Data;
                buttonSave.Enabled = true;
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var data = ds.GetMatrix(openFilePath);
            var st = textBoxSearch.Text.ToLower();
            var filter = new List<string[]>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(st) || data[i, 1].ToLower().Contains(st) ||
                    data[i, 2].ToLower().Contains(st) || data[i, 3].ToLower().Contains(st) ||
                    data[i, 4].ToLower().Contains(st))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = data[i, j];
                    }
                    filter.Add(row);
                }
            }
            var filtered = filter.ToArray();
            dataGridViewOut.RowCount = filtered.Length;
            dataGridViewOut.ColumnCount = filtered.Length == 0 ? 0 : filtered[0].Length;
            for (int r = 0; r < filtered.Length; r++)
            {
                for (int c = 0; c < filtered[0].Length; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = filtered[r][c];
                }
            }
        }

        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            FormDiagram formD = new FormDiagram();
            formD.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int indx = dataGridViewOut.SelectedCells[0].RowIndex;
            dataGridViewOut.Rows.RemoveAt(indx);
        }
    }
}
