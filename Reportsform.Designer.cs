namespace CrimelabHelper
{
    partial class Reportsform
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
            reportsList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)reportsList).BeginInit();
            SuspendLayout();
            // 
            // reportsList
            // 
            reportsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportsList.BackgroundColor = SystemColors.ControlLight;
            reportsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportsList.Location = new Point(12, 12);
            reportsList.Name = "reportsList";
            reportsList.ReadOnly = true;
            reportsList.Size = new Size(776, 362);
            reportsList.TabIndex = 2;
            // 
            // Reportsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(reportsList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportsform";
            Text = "Reportsform";
            ((System.ComponentModel.ISupportInitialize)reportsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView reportsList;
    }
}