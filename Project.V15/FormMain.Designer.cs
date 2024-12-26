namespace Project.V15
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
            components = new System.ComponentModel.Container();
            panelControl = new Panel();
            groupBoxControl = new GroupBox();
            pictureBoxHands = new PictureBox();
            buttonManual = new Button();
            buttonHelp = new Button();
            buttonDiagram = new Button();
            buttonSave = new Button();
            buttonOpen = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panelIn = new Panel();
            groupBoxIn = new GroupBox();
            buttonDel = new Button();
            pictureBoxControl = new PictureBox();
            buttonEdit = new Button();
            textBoxData = new TextBox();
            labelData = new Label();
            textBoxSalary = new TextBox();
            labelSalary = new Label();
            textBoxProf = new TextBox();
            labelProf = new Label();
            textBoxAdress = new TextBox();
            labelAdress = new Label();
            textBoxNumber = new TextBox();
            labelNumber = new Label();
            textBoxFIO = new TextBox();
            labelFIO = new Label();
            splitterIn = new Splitter();
            panelOut = new Panel();
            labelOut = new Label();
            dataGridViewOut = new DataGridView();
            toolTiphelp = new ToolTip(components);
            saveFileDialogSprint = new SaveFileDialog();
            openFileDialogSprint = new OpenFileDialog();
            panelControl.SuspendLayout();
            groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHands).BeginInit();
            panelIn.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxControl).BeginInit();
            panelOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.PaleTurquoise;
            panelControl.Controls.Add(groupBoxControl);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1209, 124);
            panelControl.TabIndex = 0;
            // 
            // groupBoxControl
            // 
            groupBoxControl.Controls.Add(pictureBoxHands);
            groupBoxControl.Controls.Add(buttonManual);
            groupBoxControl.Controls.Add(buttonHelp);
            groupBoxControl.Controls.Add(buttonDiagram);
            groupBoxControl.Controls.Add(buttonSave);
            groupBoxControl.Controls.Add(buttonOpen);
            groupBoxControl.Controls.Add(buttonSearch);
            groupBoxControl.Controls.Add(textBoxSearch);
            groupBoxControl.Dock = DockStyle.Fill;
            groupBoxControl.Location = new Point(0, 0);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(1209, 124);
            groupBoxControl.TabIndex = 0;
            groupBoxControl.TabStop = false;
            // 
            // pictureBoxHands
            // 
            pictureBoxHands.ImageLocation = "C:\\Users\\PC\\source\\repos\\Tyuiu.KomarovaMV.Sprint7\\Project.V15\\Properties\\Снимок экрана 2024-12-24 233318.png";
            pictureBoxHands.Location = new Point(832, 12);
            pictureBoxHands.Name = "pictureBoxHands";
            pictureBoxHands.Size = new Size(163, 70);
            pictureBoxHands.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxHands.TabIndex = 7;
            pictureBoxHands.TabStop = false;
            // 
            // buttonManual
            // 
            buttonManual.BackColor = Color.DarkCyan;
            buttonManual.FlatStyle = FlatStyle.Flat;
            buttonManual.ForeColor = SystemColors.Highlight;
            buttonManual.Image = Properties.Resources.help;
            buttonManual.Location = new Point(1131, 42);
            buttonManual.Name = "buttonManual";
            buttonManual.Size = new Size(64, 57);
            buttonManual.TabIndex = 6;
            toolTiphelp.SetToolTip(buttonManual, "Открыть руководство");
            buttonManual.UseVisualStyleBackColor = false;
            buttonManual.Click += buttonManual_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DarkCyan;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.ForeColor = SystemColors.Highlight;
            buttonHelp.Image = Properties.Resources.information;
            buttonHelp.Location = new Point(1047, 42);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(63, 57);
            buttonHelp.TabIndex = 5;
            toolTiphelp.SetToolTip(buttonHelp, "Посмотреть информацию");
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDiagram
            // 
            buttonDiagram.BackColor = Color.DarkCyan;
            buttonDiagram.Enabled = false;
            buttonDiagram.FlatStyle = FlatStyle.Flat;
            buttonDiagram.ForeColor = SystemColors.Highlight;
            buttonDiagram.Image = Properties.Resources.chart_pie;
            buttonDiagram.Location = new Point(669, 23);
            buttonDiagram.Name = "buttonDiagram";
            buttonDiagram.Size = new Size(105, 64);
            buttonDiagram.TabIndex = 4;
            toolTiphelp.SetToolTip(buttonDiagram, "Посмотреть статистику");
            buttonDiagram.UseVisualStyleBackColor = false;
            buttonDiagram.Click += buttonDiagram_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkCyan;
            buttonSave.Enabled = false;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = SystemColors.Highlight;
            buttonSave.Image = Properties.Resources.table_save;
            buttonSave.Location = new Point(552, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(101, 65);
            buttonSave.TabIndex = 3;
            toolTiphelp.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.DarkCyan;
            buttonOpen.FlatStyle = FlatStyle.Flat;
            buttonOpen.ForeColor = SystemColors.Highlight;
            buttonOpen.Image = Properties.Resources.table_add;
            buttonOpen.Location = new Point(432, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(102, 65);
            buttonOpen.TabIndex = 2;
            toolTiphelp.SetToolTip(buttonOpen, "Открыть файл");
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Aquamarine;
            buttonSearch.Enabled = false;
            buttonSearch.Image = Properties.Resources.zoom;
            buttonSearch.Location = new Point(211, 31);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(44, 43);
            buttonSearch.TabIndex = 1;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Enabled = false;
            textBoxSearch.Location = new Point(34, 42);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(171, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // panelIn
            // 
            panelIn.BackColor = Color.FromArgb(0, 192, 192);
            panelIn.Controls.Add(groupBoxIn);
            panelIn.Dock = DockStyle.Left;
            panelIn.Location = new Point(0, 124);
            panelIn.Name = "panelIn";
            panelIn.Size = new Size(398, 453);
            panelIn.TabIndex = 1;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(buttonDel);
            groupBoxIn.Controls.Add(pictureBoxControl);
            groupBoxIn.Controls.Add(buttonEdit);
            groupBoxIn.Controls.Add(textBoxData);
            groupBoxIn.Controls.Add(labelData);
            groupBoxIn.Controls.Add(textBoxSalary);
            groupBoxIn.Controls.Add(labelSalary);
            groupBoxIn.Controls.Add(textBoxProf);
            groupBoxIn.Controls.Add(labelProf);
            groupBoxIn.Controls.Add(textBoxAdress);
            groupBoxIn.Controls.Add(labelAdress);
            groupBoxIn.Controls.Add(textBoxNumber);
            groupBoxIn.Controls.Add(labelNumber);
            groupBoxIn.Controls.Add(textBoxFIO);
            groupBoxIn.Controls.Add(labelFIO);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(398, 453);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Добавление данных:";
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.DarkRed;
            buttonDel.Enabled = false;
            buttonDel.FlatStyle = FlatStyle.Flat;
            buttonDel.ForeColor = Color.IndianRed;
            buttonDel.Image = Properties.Resources.pencil_delete;
            buttonDel.Location = new Point(261, 368);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(121, 73);
            buttonDel.TabIndex = 13;
            toolTiphelp.SetToolTip(buttonDel, "Удалить запись или выбранную строку");
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // pictureBoxControl
            // 
            pictureBoxControl.ImageLocation = "C:\\Users\\PC\\source\\repos\\Tyuiu.KomarovaMV.Sprint7\\Project.V15\\Properties\\Снимок экрана 2024-12-24 232812.png";
            pictureBoxControl.Location = new Point(156, 22);
            pictureBoxControl.Name = "pictureBoxControl";
            pictureBoxControl.Size = new Size(236, 121);
            pictureBoxControl.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxControl.TabIndex = 7;
            pictureBoxControl.TabStop = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkCyan;
            buttonEdit.Enabled = false;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = SystemColors.Highlight;
            buttonEdit.Image = Properties.Resources.accept;
            buttonEdit.Location = new Point(34, 368);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(115, 73);
            buttonEdit.TabIndex = 12;
            toolTiphelp.SetToolTip(buttonEdit, "Применить изменения");
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxData
            // 
            textBoxData.Enabled = false;
            textBoxData.Location = new Point(34, 311);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(157, 23);
            textBoxData.TabIndex = 11;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(34, 293);
            labelData.Name = "labelData";
            labelData.Size = new Size(157, 15);
            labelData.TabIndex = 10;
            labelData.Text = "Сроки работы по договору";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Enabled = false;
            textBoxSalary.Location = new Point(34, 256);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(157, 23);
            textBoxSalary.TabIndex = 9;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(34, 238);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(41, 15);
            labelSalary.TabIndex = 8;
            labelSalary.Text = "Оклад";
            // 
            // textBoxProf
            // 
            textBoxProf.Enabled = false;
            textBoxProf.Location = new Point(34, 202);
            textBoxProf.Name = "textBoxProf";
            textBoxProf.Size = new Size(157, 23);
            textBoxProf.TabIndex = 7;
            // 
            // labelProf
            // 
            labelProf.AutoSize = true;
            labelProf.Location = new Point(34, 184);
            labelProf.Name = "labelProf";
            labelProf.Size = new Size(69, 15);
            labelProf.TabIndex = 6;
            labelProf.Text = "Должность";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Enabled = false;
            textBoxAdress.Location = new Point(34, 149);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(157, 23);
            textBoxAdress.TabIndex = 5;
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(34, 131);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(40, 15);
            labelAdress.TabIndex = 4;
            labelAdress.Text = "Адрес";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Enabled = false;
            textBoxNumber.Location = new Point(34, 51);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(34, 33);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(45, 15);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "Номер";
            // 
            // textBoxFIO
            // 
            textBoxFIO.Enabled = false;
            textBoxFIO.Location = new Point(34, 104);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new Size(100, 23);
            textBoxFIO.TabIndex = 1;
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Location = new Point(34, 86);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(34, 15);
            labelFIO.TabIndex = 0;
            labelFIO.Text = "ФИО";
            // 
            // splitterIn
            // 
            splitterIn.BackColor = SystemColors.Highlight;
            splitterIn.Location = new Point(398, 124);
            splitterIn.Name = "splitterIn";
            splitterIn.Size = new Size(3, 453);
            splitterIn.TabIndex = 2;
            splitterIn.TabStop = false;
            // 
            // panelOut
            // 
            panelOut.BackColor = Color.PaleTurquoise;
            panelOut.Controls.Add(labelOut);
            panelOut.Controls.Add(dataGridViewOut);
            panelOut.Dock = DockStyle.Fill;
            panelOut.Location = new Point(401, 124);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(808, 453);
            panelOut.TabIndex = 3;
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Dock = DockStyle.Top;
            labelOut.Location = new Point(0, 0);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(53, 15);
            labelOut.TabIndex = 1;
            labelOut.Text = "Данные:";
            labelOut.Click += labelSearch_Click;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.BackgroundColor = Color.Turquoise;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.GridColor = SystemColors.InactiveBorder;
            dataGridViewOut.Location = new Point(0, 0);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(808, 453);
            dataGridViewOut.TabIndex = 0;
            // 
            // toolTiphelp
            // 
            toolTiphelp.IsBalloon = true;
            toolTiphelp.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogSprint
            // 
            openFileDialogSprint.FileName = "openFileDialogSprint";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 577);
            Controls.Add(panelOut);
            Controls.Add(splitterIn);
            Controls.Add(panelIn);
            Controls.Add(panelControl);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Договорная деятельность организации";
            Load += ForMain_Load;
            panelControl.ResumeLayout(false);
            groupBoxControl.ResumeLayout(false);
            groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHands).EndInit();
            panelIn.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxControl).EndInit();
            panelOut.ResumeLayout(false);
            panelOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private Panel panelIn;
        private Splitter splitterIn;
        private Panel panelOut;
        private Label labelOut;
        private DataGridView dataGridViewOut;
        private GroupBox groupBoxControl;
        private GroupBox groupBoxIn;
        private Button buttonManual;
        private Button buttonHelp;
        private Button buttonDiagram;
        private Button buttonSave;
        private Button buttonOpen;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelData;
        private TextBox textBoxSalary;
        private Label labelSalary;
        private TextBox textBoxProf;
        private Label labelProf;
        private TextBox textBoxAdress;
        private Label labelAdress;
        private TextBox textBoxNumber;
        private Label labelNumber;
        private TextBox textBoxFIO;
        private Label labelFIO;
        private Button buttonEdit;
        private TextBox textBoxData;
        private ToolTip toolTiphelp;
        private SaveFileDialog saveFileDialogSprint;
        private OpenFileDialog openFileDialogSprint;
        private PictureBox pictureBoxControl;
        private PictureBox pictureBoxHands;
        private Button buttonDel;
    }
}
