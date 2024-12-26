namespace Project.V15
{
    partial class FormDiagram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            textBoxMiddle = new TextBox();
            textBoxData = new TextBox();
            groupBoxSalary = new GroupBox();
            labelMin = new Label();
            labelMax = new Label();
            labelMiddle = new Label();
            groupBoxAdress = new GroupBox();
            labelVish = new Label();
            labelZareka = new Label();
            labelReka = new Label();
            textBoxVish = new TextBox();
            textBoxZareka = new TextBox();
            textBoxReka = new TextBox();
            labelData = new Label();
            labelProf = new Label();
            ((System.ComponentModel.ISupportInitialize)chartData).BeginInit();
            groupBoxSalary.SuspendLayout();
            groupBoxAdress.SuspendLayout();
            SuspendLayout();
            // 
            // chartData
            // 
            chartData.BackColor = Color.DarkCyan;
            chartData.BorderlineColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartData.ChartAreas.Add(chartArea1);
            chartData.Location = new Point(12, 52);
            chartData.Name = "chartData";
            chartData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            chartData.Series.Add(series1);
            chartData.Size = new Size(576, 406);
            chartData.TabIndex = 0;
            chartData.Click += chartData_Click;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(19, 121);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.ReadOnly = true;
            textBoxMax.Size = new Size(100, 23);
            textBoxMax.TabIndex = 1;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(157, 121);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.ReadOnly = true;
            textBoxMin.Size = new Size(100, 23);
            textBoxMin.TabIndex = 2;
            // 
            // textBoxMiddle
            // 
            textBoxMiddle.Location = new Point(19, 58);
            textBoxMiddle.Name = "textBoxMiddle";
            textBoxMiddle.ReadOnly = true;
            textBoxMiddle.Size = new Size(100, 23);
            textBoxMiddle.TabIndex = 3;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(836, 486);
            textBoxData.Name = "textBoxData";
            textBoxData.ReadOnly = true;
            textBoxData.Size = new Size(100, 23);
            textBoxData.TabIndex = 4;
            // 
            // groupBoxSalary
            // 
            groupBoxSalary.BackColor = Color.CornflowerBlue;
            groupBoxSalary.Controls.Add(labelMin);
            groupBoxSalary.Controls.Add(labelMax);
            groupBoxSalary.Controls.Add(labelMiddle);
            groupBoxSalary.Controls.Add(textBoxMiddle);
            groupBoxSalary.Controls.Add(textBoxMax);
            groupBoxSalary.Controls.Add(textBoxMin);
            groupBoxSalary.Location = new Point(653, 23);
            groupBoxSalary.Name = "groupBoxSalary";
            groupBoxSalary.Size = new Size(283, 167);
            groupBoxSalary.TabIndex = 5;
            groupBoxSalary.TabStop = false;
            groupBoxSalary.Text = "Статистика по окладу";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(157, 103);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(93, 15);
            labelMin.TabIndex = 6;
            labelMin.Text = "Минимальный:";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(19, 103);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(97, 15);
            labelMax.TabIndex = 5;
            labelMax.Text = "Максимальный:";
            // 
            // labelMiddle
            // 
            labelMiddle.AutoSize = true;
            labelMiddle.Location = new Point(19, 40);
            labelMiddle.Name = "labelMiddle";
            labelMiddle.Size = new Size(93, 15);
            labelMiddle.TabIndex = 4;
            labelMiddle.Text = "Средний оклад:";
            // 
            // groupBoxAdress
            // 
            groupBoxAdress.BackColor = Color.CornflowerBlue;
            groupBoxAdress.Controls.Add(labelVish);
            groupBoxAdress.Controls.Add(labelZareka);
            groupBoxAdress.Controls.Add(labelReka);
            groupBoxAdress.Controls.Add(textBoxVish);
            groupBoxAdress.Controls.Add(textBoxZareka);
            groupBoxAdress.Controls.Add(textBoxReka);
            groupBoxAdress.Location = new Point(653, 223);
            groupBoxAdress.Name = "groupBoxAdress";
            groupBoxAdress.Size = new Size(283, 206);
            groupBoxAdress.TabIndex = 6;
            groupBoxAdress.TabStop = false;
            groupBoxAdress.Text = "Количество рабочих из разных филиалов организации";
            // 
            // labelVish
            // 
            labelVish.AutoSize = true;
            labelVish.Location = new Point(15, 147);
            labelVish.Name = "labelVish";
            labelVish.Size = new Size(97, 15);
            labelVish.TabIndex = 5;
            labelVish.Text = "ул.Вишневая,11:";
            // 
            // labelZareka
            // 
            labelZareka.AutoSize = true;
            labelZareka.Location = new Point(15, 101);
            labelZareka.Name = "labelZareka";
            labelZareka.Size = new Size(93, 15);
            labelZareka.TabIndex = 4;
            labelZareka.Text = "ул.Заречная,36:";
            // 
            // labelReka
            // 
            labelReka.AutoSize = true;
            labelReka.Location = new Point(15, 56);
            labelReka.Name = "labelReka";
            labelReka.Size = new Size(80, 15);
            labelReka.TabIndex = 3;
            labelReka.Text = "ул.Реченая,4:";
            // 
            // textBoxVish
            // 
            textBoxVish.Location = new Point(118, 144);
            textBoxVish.Name = "textBoxVish";
            textBoxVish.ReadOnly = true;
            textBoxVish.Size = new Size(100, 23);
            textBoxVish.TabIndex = 2;
            // 
            // textBoxZareka
            // 
            textBoxZareka.Location = new Point(118, 93);
            textBoxZareka.Name = "textBoxZareka";
            textBoxZareka.ReadOnly = true;
            textBoxZareka.Size = new Size(100, 23);
            textBoxZareka.TabIndex = 1;
            // 
            // textBoxReka
            // 
            textBoxReka.Location = new Point(118, 53);
            textBoxReka.Name = "textBoxReka";
            textBoxReka.ReadOnly = true;
            textBoxReka.Size = new Size(100, 23);
            textBoxReka.TabIndex = 0;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(602, 489);
            labelData.Name = "labelData";
            labelData.Size = new Size(228, 15);
            labelData.TabIndex = 7;
            labelData.Text = "Наибольший срок работы по договору:";
            // 
            // labelProf
            // 
            labelProf.AutoSize = true;
            labelProf.Location = new Point(12, 34);
            labelProf.Name = "labelProf";
            labelProf.Size = new Size(295, 15);
            labelProf.TabIndex = 8;
            labelProf.Text = "Количество сотрудников определенной должности:";
            // 
            // FormDiagram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(988, 564);
            Controls.Add(labelProf);
            Controls.Add(labelData);
            Controls.Add(groupBoxAdress);
            Controls.Add(groupBoxSalary);
            Controls.Add(textBoxData);
            Controls.Add(chartData);
            Name = "FormDiagram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)chartData).EndInit();
            groupBoxSalary.ResumeLayout(false);
            groupBoxSalary.PerformLayout();
            groupBoxAdress.ResumeLayout(false);
            groupBoxAdress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private TextBox textBoxMiddle;
        private TextBox textBoxData;
        private GroupBox groupBoxSalary;
        private Label labelMin;
        private Label labelMax;
        private Label labelMiddle;
        private GroupBox groupBoxAdress;
        private TextBox textBoxVish;
        private TextBox textBoxZareka;
        private TextBox textBoxReka;
        private Label labelVish;
        private Label labelZareka;
        private Label labelReka;
        private Label labelData;
        private Label labelProf;
    }
}