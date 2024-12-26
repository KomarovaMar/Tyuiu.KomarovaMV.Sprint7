namespace Project.V15
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            groupBoxManual = new GroupBox();
            textBoxManual = new TextBox();
            groupBoxManual.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxManual
            // 
            groupBoxManual.Controls.Add(textBoxManual);
            groupBoxManual.Dock = DockStyle.Fill;
            groupBoxManual.Location = new Point(0, 0);
            groupBoxManual.Name = "groupBoxManual";
            groupBoxManual.Size = new Size(787, 379);
            groupBoxManual.TabIndex = 0;
            groupBoxManual.TabStop = false;
            // 
            // textBoxManual
            // 
            textBoxManual.BackColor = SystemColors.Info;
            textBoxManual.Dock = DockStyle.Fill;
            textBoxManual.Location = new Point(3, 19);
            textBoxManual.Multiline = true;
            textBoxManual.Name = "textBoxManual";
            textBoxManual.ReadOnly = true;
            textBoxManual.Size = new Size(781, 357);
            textBoxManual.TabIndex = 0;
            textBoxManual.Text = resources.GetString("textBoxManual.Text");
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(787, 379);
            Controls.Add(groupBoxManual);
            Name = "FormManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            groupBoxManual.ResumeLayout(false);
            groupBoxManual.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxManual;
        private TextBox textBoxManual;
    }
}