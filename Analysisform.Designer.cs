namespace CrimelabHelper
{
    partial class Analysisform
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
            analysisList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)analysisList).BeginInit();
            SuspendLayout();
            // 
            // analysisList
            // 
            analysisList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            analysisList.BackgroundColor = SystemColors.ControlLight;
            analysisList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            analysisList.Location = new Point(12, 12);
            analysisList.Name = "analysisList";
            analysisList.ReadOnly = true;
            analysisList.Size = new Size(776, 362);
            analysisList.TabIndex = 1;
            // 
            // Analysisform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 453);
            Controls.Add(analysisList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Analysisform";
            Text = "Analysisformm";
            ((System.ComponentModel.ISupportInitialize)analysisList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView analysisList;
    }
}