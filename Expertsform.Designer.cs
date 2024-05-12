namespace CrimelabHelper
{
    partial class Expertsform
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
            expertsList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)expertsList).BeginInit();
            SuspendLayout();
            // 
            // expertsList
            // 
            expertsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            expertsList.BackgroundColor = SystemColors.ControlLight;
            expertsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expertsList.Location = new Point(12, 12);
            expertsList.Name = "expertsList";
            expertsList.ReadOnly = true;
            expertsList.Size = new Size(776, 362);
            expertsList.TabIndex = 1;
            // 
            // Expertsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(expertsList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expertsform";
            Text = "Expertsform";
            ((System.ComponentModel.ISupportInitialize)expertsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView expertsList;
    }
}