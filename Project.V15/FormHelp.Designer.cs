namespace Project.V15
{
    partial class FormHelp
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
            groupBoxHelp = new GroupBox();
            textBoxHelp = new TextBox();
            groupBoxHelp.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxHelp
            // 
            groupBoxHelp.BackColor = Color.LightSteelBlue;
            groupBoxHelp.Controls.Add(textBoxHelp);
            groupBoxHelp.Dock = DockStyle.Fill;
            groupBoxHelp.Location = new Point(0, 0);
            groupBoxHelp.Name = "groupBoxHelp";
            groupBoxHelp.Size = new Size(562, 272);
            groupBoxHelp.TabIndex = 0;
            groupBoxHelp.TabStop = false;
            groupBoxHelp.Text = "Создатель";
            // 
            // textBoxHelp
            // 
            textBoxHelp.BackColor = SystemColors.Info;
            textBoxHelp.Dock = DockStyle.Fill;
            textBoxHelp.Location = new Point(3, 19);
            textBoxHelp.Multiline = true;
            textBoxHelp.Name = "textBoxHelp";
            textBoxHelp.ReadOnly = true;
            textBoxHelp.Size = new Size(556, 250);
            textBoxHelp.TabIndex = 0;
            textBoxHelp.Text = "Спринт 7 выполнил  студент группы АСОиУБ-24-1 Комарова Маргарита Васильевна\r\nПроект: приложения Desktop по области \"Договорная деятельность компании\"\r\n\r\n\r\n";
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(562, 272);
            Controls.Add(groupBoxHelp);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            groupBoxHelp.ResumeLayout(false);
            groupBoxHelp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHelp;
        private TextBox textBoxHelp;
    }
}