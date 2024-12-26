using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V15.Lib;

namespace Project.V15
{
    public partial class FormDiagram : Form
    {
        DataService ds=new DataService();
        public FormDiagram()
        {
            InitializeComponent();
            string[,] data = ds.GetMatrix(FormMain.openFilePath);
            int rows = data.GetUpperBound(0)+1;
            int cols = data.Length/rows;
            int countMan = 0;
            int countSec = 0;
            int countB = 0;
            int countA = 0;
            int countD = 0;
            int countReka = 0;
            int countZareka = 0;
            int countVish = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3)
                    {
                        if (data[i, j] == "менеджер") { countMan++; }
                        if (data[i, j] == "секретарь") { countSec++; }
                        if (data[i, j] == "бухгалтер") { countB++; }
                        if (data[i, j] == "архивариус") { countA++; }
                        if (data[i, j] == "документовед") { countD++; }
                    }
                    if (j == 2)
                    {
                        if (data[i, j] == "ул.Речная, 4") { countReka++; }
                        if (data[i, j] == "ул.Заречная, 36") { countZareka++; }
                        if (data[i, j] == "ул.Вишневая,11") { countVish++; }
                    }
                }
            }
            chartData.Series[0].Points.AddXY($"менеджер({countMan})", countMan);
            chartData.Series[0].Points.AddXY($"секретарь({countSec})", countSec);
            chartData.Series[0].Points.AddXY($"бухгалтер({countB})", countB);
            chartData.Series[0].Points.AddXY($"архивариус({countA})", countA);
            chartData.Series[0].Points.AddXY($"документовед({countD})", countD);
            textBoxReka.Text=Convert.ToString(countReka);
            textBoxZareka.Text=Convert.ToString(countZareka);
            textBoxVish.Text=Convert.ToString(countVish);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j==4) { sum += Convert.ToInt32(data[i, j]); }
                }
            }
            textBoxMiddle.Text=Convert.ToString((sum/rows));
            int max = 0;
            int mini = 1000000;
            int maxData = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 4)
                    {
                        if (Convert.ToInt32(data[i, j]) < mini) { mini = Convert.ToInt32(data[i, j]); }
                        if (Convert.ToInt32(data[i, j]) > max) { max = Convert.ToInt32(data[i, j]); }
                    }
                    if (j == 5)
                    {
                        if (Convert.ToInt32(data[i, j]) > maxData) { maxData = Convert.ToInt32(data[i, j]); }
                    }
                }
            }
            textBoxMax.Text=Convert.ToString(max);
            textBoxMin.Text= Convert.ToString(mini);
            textBoxData.Text=Convert.ToString(maxData);
        }

        private void chartData_Click(object sender, EventArgs e)
        {

        }
    }
}
